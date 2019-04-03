// Dependencies
import * as dotenv from 'dotenv';
import { Telegraf, ContextMessageUpdate } from 'telegraf';

import telegraf from 'telegraf'

// Configure dotenv
dotenv.config({ path: `${__dirname}/../.env` });

const bot = new telegraf(process.env.TOKEN);
const chats = {} as {
    [index: number]: { id: number; time: number }[]
};

const SECOND = 1000
const MINUTE = 60 * SECOND

const BLOCK_TIMEOUT = MINUTE

function addCandidate(chatId: number, candidateId: number): void {
    const candidate = {
        id: candidateId,
        time: new Date().getTime()
    }

    let candidates = chats[chatId];
    if (candidates) {
        candidates.push(candidate);
    } else {
        candidates = [candidate];
    }

    chats[chatId] = candidates;
}

function removeCandidate(chatId: string | number, candidateId: number): void {
    let candidates = chats[chatId];
    if (!candidates)
        return;
    chats[chatId] = candidates.filter((candidate: { id: number; }) => candidate.id !== candidateId);
}


bot.on('new_chat_members', ctx => {
    for (const member of ctx.message.new_chat_members) {
        addCandidate(ctx.chat.id, member.id);
        ctx.reply(`Please, send any message to this chat in ${BLOCK_TIMEOUT.toString()} seconds or you will be banned.`);
    }
});

bot.on('message', ctx => {
    removeCandidate(ctx.chat.id, ctx.from.id);
});


bot.startPolling();

setInterval(() => {
    for (const chatId in chats) {
        const candidates = chats[chatId];
        if (!candidates.length)
            continue;
        const now = new Date().getTime();
        for (const candidate of candidates) {
            if (candidate.time < now - BLOCK_TIMEOUT) {
                const telegram = bot.telegram as any;
                telegram.kickChatMember(chatId, candidate.id);
                removeCandidate(chatId, candidate.id);
            }
        }
    }
}, 1000);
