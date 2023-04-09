import React, { Component } from 'react';
import {StyleSheet, View,Text,Alert,TouchableOpacity} from 'react-native';

class  LoginComponent extends Component {

  constructor(props) {
    super(props);
    this.state = {
      content: '',
    }
  }
      render() {
        const content = this.props.name;
        return (     
          <Text>This is Login Page</Text>       
        )
      }
}

const styles = StyleSheet.create({
  container:
  {
    width: '100%',
    height: 30,
    backgroundColor: '#ccc',
    textAlign: 'center',
    marginBottom:20
  },
  text:{
    textAlign:'center',
  }
});

export default LoginComponent;