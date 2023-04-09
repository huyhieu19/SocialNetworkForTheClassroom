import React, { Component } from 'react';
import { ScrollView,View, Text, TextInput, TouchableOpacity, StyleSheet, Alert ,Image} from 'react-native';

class  LoginComponent extends Component {

  constructor(props) {
    super(props);
    this.state = {
      email: 'abc',
      password: 'a'
    }
  } handleEmailChange = (email) => {
    this.setState({email})
  }

  handlePasswordChange = (password) => {
    this.setState({password})
  }

  handleLogin = () => {
    Alert.alert("value of email",this.state.email)
    // Call API to authenticate user
    // ...
    // Redirect to home screen if login successful
    // ...
  }

  render() {
    return (
      
      <View style={styles.container}>
        <View style={{width: '100%', height: 187, overflow: 'hidden'}}>
        <View style={styles.radious1}></View>
        <View style={styles.radious2}></View>
        <Text style={styles.title}>Welcome</Text>
        </View>
        
        <Image
          source={require('../../assets/620.12-login-icon-iconbunny.jpg')}
          style={{ width: 150, height: 150 }}
        />
        <TextInput 
          style={styles.input} 
          placeholder="Enter your email"
          onChangeText={(value)=> this.handleEmailChange(value)}
        />
        <TextInput 
          style={styles.input} 
          placeholder="Enter your password" 
          secureTextEntry={true}
          onChangeText={(value)=> this.handlePasswordChange(value)}
        />
        <TouchableOpacity style={styles.button} onPress={this.handleLogin}>
          <Text style={styles.buttonText}>Sign in</Text>
        </TouchableOpacity>
      

      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: 'center',
    justifyContent: 'center',
    backgroundColor: '#F3FBFB',
    width:'100%',
  },
  title: {
    fontSize: 24,
    fontWeight: 'bold',
    marginBottom: 24,
    position:'absolute',
    bottom:0,
    left:120
  },
  input: {
    width: 300,
    height: 48,
    borderWidth: 1,
    borderColor: 'black',
    borderRadius: 8,
    paddingHorizontal: 16,
    marginVertical: 8
  },
  button: {
    backgroundColor: '#29CCC3',
    borderRadius: 8,
    padding: 16,
    marginTop: 24,
    width:276,
    height:53,
  
  },
  buttonText: {
    color: 'white',
    fontSize: 16,
    fontWeight: 'bold',
    textAlign: 'center',
    height:53
  },
  radious1:{
    width: 200,
    height: 200,
    borderRadius: 100,
    backgroundColor: 'rgba(163,234,239,0.8)',
    position: 'absolute',
    top:-13,
    left: -80
    
  },
  radious2:{
    width: 200,
    height: 200,
    borderRadius: 100,
    backgroundColor: 'rgba(163,234,239,0.8)',
    position: 'absolute',
    top:-80,
    left: 0
  }
});


export default LoginComponent;