import { Text, View } from 'react-native';
import React from 'react';
// Redux
import { useSelector } from 'react-redux'

export default function Details({ navigation }) {
    return (
      <View style={{paddingTop: 60, justifyContent:'center', flex:1, alignItems:'center'}}>
        <Text style={{fontFamily:'PoppinsMedium', fontSize:23}}>Em desenvolvimento</Text>
      </View>
    )
}