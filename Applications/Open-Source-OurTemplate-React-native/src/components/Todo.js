import React, { Component } from 'react';
import PropTypes from 'prop-types';
import { Container, Header, Left, Body, Title, Right, Content, InputGroup, Input, List, Button, Icon, Spinner } from 'native-base';
import { View, Text, Dimensions, Alert } from 'react-native';

import InputBox from './InputBox';
import TodoList from './TodoList';
import Filters from './Filters';

const { width } = Dimensions.get('window');

class Todo extends Component {

  constructor(props) {
    super(props);
    this.state = {
      filter: 'all',
    };
  }

  setFilter = (type) => {
    this.setState({
      filter: type
    })
  }

  async componentWillMount() {
    await Expo.Font.loadAsync({
      'Roboto': require('native-base/Fonts/Roboto.ttf'),
      'Roboto_medium': require('native-base/Fonts/Roboto_medium.ttf'),
      'Ionicons': require('native-base/Fonts/Ionicons.ttf')
    });
  }

  render() {
    return (
      <Container>
        <Header>
          <Left />
          <Body>
            <Title>Your Todos</Title>
          </Body>
          <Right />
        </Header>
        <InputBox filter={this.state.filter}/>
        <Content contentContainerStyle={{ justifyContent: 'space-between' }} >
          <View >
            <Filters filter={this.state.filter} setFilter={this.setFilter}/>
            <List>
              <TodoList filter={this.state.filter}/>
            </List>
          </View>
        </Content>
      </Container>
    );
  }
}

export default Todo;
