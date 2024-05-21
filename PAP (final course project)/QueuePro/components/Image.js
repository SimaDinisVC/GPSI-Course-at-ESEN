import { useState } from 'react';
import { View, Image, StyleSheet } from 'react-native';
import { ActivityIndicator }from 'react-native-paper'

export default function Imagem({source, key}) {
    const [loading, setLoading] = useState(true);
    
    return (
      <View style={[styles.page, loading && { justifyContent:'center', alignItems: 'center'}]} key={key}>
          {loading && <ActivityIndicator size="large" color="#305e96" />}
          <View style={{ display: loading ? 'none' : 'flex' }}>
              <Image
                  source={source}
                  style={styles.image}
                  onLoadEnd={() => setLoading(false)}
              />
          </View>
      </View> 
    );
}

const styles = StyleSheet.create({
    page: {
      flex:1,
      borderRadius: 40,
      marginHorizontal: 20,
    },
    image: {
      width: '100%',
      height: '100%',
      borderRadius: 33,
      resizeMode: 'cover', // ou 'contain', dependendo do comportamento desejado da imagem
    },
  });