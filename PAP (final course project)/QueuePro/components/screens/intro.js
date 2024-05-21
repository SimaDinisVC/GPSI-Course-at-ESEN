import { Button, Text } from 'react-native-paper';
import React, { useEffect } from 'react';
import { StyleSheet, View, Image } from 'react-native';
import { SafeAreaView } from 'react-native-safe-area-context';
import AsyncStorage from '@react-native-async-storage/async-storage';

export default function Intro({ navigation }) {
    useEffect(() => {
        const checkWelcomeStatus = async () => {
          try {
            const welcomeStatus = await AsyncStorage.getItem('welcomeStatus');
            if (welcomeStatus !== null && welcomeStatus === 'opened') {
              navigation.reset({ index: 0, routes: [{ name: 'main' }] });
            }
          } catch (error) {
            console.error('Erro ao verificar o status de boas-vindas:', error);
          }
        };
    
        checkWelcomeStatus();
    }, [navigation]);

    
    return (
        <SafeAreaView style={{ flex: 1 }}>
          <View style={{flex:0.9, justifyContent:'center', alignItems:'center'}}>
            <Image source={require('../../assets/logo.png')} style={styles.image}/>
            <Text style={styles.title}>QueuePro</Text>
            <Text style={styles.text}>Bem-vindo(a) à mais inovadora experiência de filas de espera.</Text>
            <Text style={styles.p}>A QueuePro acredita que até as coisas mais simples podem ser modernizadas. E foi por isso que desenvolvemos um sistema prático de filas de espera que visa ajudar o ambiente.</Text>
          </View>
          <View style={{flex:0.1, justifyContent:'flex-start'}}>
            <Button 
              mode='contained'
              textColor='white'
              uppercase={true}
              style={ styles.button }
              onPress={ async () => { 
                await AsyncStorage.setItem('welcomeStatus', 'opened');
                navigation.navigate('main', { screen: 'Home'}) 
              } }>
              Começar agora
            </Button>
          </View>
        </SafeAreaView>
    )
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
  },
  title: {
    color: '#305e96',
    fontSize: 60,
    fontFamily:'PoppinsSemiBold',
  },
  text: {
    color: 'black',
    fontSize: 26,
    paddingHorizontal: 40,
    textAlign: "center",
    fontFamily:'PoppinsMedium'
  },
  p: {
    color:'black',
    fontSize: 20,
    marginTop: 50,
    paddingHorizontal: 30,
    textAlign: "center",
    fontFamily:'PoppinsItalic',
    marginBottom: 40
  },
  button: {
    paddingVertical: 8,
    marginHorizontal: 20,
    alignSelf: 'stretch',
    backgroundColor: '#305e96',
  },
  image: {
    width:200,
    height:200,
    margin:-30,
  }
})