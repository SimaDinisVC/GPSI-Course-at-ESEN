import { useEffect, useState } from 'react';
import { StyleSheet, View, Text, Image} from 'react-native';
//import { View } from 'react-native-safe-area-context';
import { Button, Searchbar } from 'react-native-paper';
import PagerView from 'react-native-pager-view';
import axios from 'axios';
import { useSelector } from 'react-redux';
// Componentes
import ServerConnectionInfo from '../ServerConnectionInfo';
import PageIndicator from '../PageIndicator';
import Imagem from '../Image';

export default function Home({ navigation }) {
    const [searchQuery, setSearchQuery] = useState('');
    const [currentPage, setCurrentPage] = useState(0);
    const [images, setImages] = useState([]);
    const globalVars = useSelector((state) => state.globalVARS);

    const getImages = async () => {
      const imgs = await axios.get(`http://${globalVars.apiUrl}/images-uris?appToken=${globalVars.apiToken}`);

      setImages(imgs.data.map(file => `http://${globalVars.apiUrl}/images/${file}?appToken=${globalVars.apiToken}`));
    }

    useEffect(() => {
      getImages();
    }, [])

    return (
      <View style={styles.container}>
        <View style={{flex:0.1, marginTop: 45,}}>
        <Searchbar
          placeholder="Pesquise Locais"
          onChangeText={setSearchQuery}
          value={searchQuery}
          mode="bar"
          iconColor='white'
          placeholderTextColor='white'
          selectionColor='white'
          inputStyle={{color:'white', fontFamily:'PoppinsMedium', fontSize:18, paddingTop:3}}
          style={{marginHorizontal:20, backgroundColor:'#305e96', marginTop:-15}}
        />
        </View>
        <View style={{flex:0.9}}>
          <PagerView style={{flex:0.6, marginTop:50, }} initialPage={0} onPageSelected={(event) => setCurrentPage(event.nativeEvent.position)}>
            {images.map((url, index) => (
              <Imagem source={{uri: url}} key={index} />
            ))}
          </PagerView>
          <PageIndicator pageCount={images.length} currentPage={currentPage} />
          <View style={{marginBottom:-5}}>
            <Button icon="ticket-confirmation" onPress={() => navigation.navigate('selectCompany')} mode="elevated" labelStyle={{fontFamily:'PoppinsMedium', paddingTop:1}} style={{alignSelf:'center', width:250, height:45, justifyContent:'center', marginBottom:10, marginTop:50}} buttonColor='#305e96' textColor='white'>
              Tirar Senha
            </Button>
            <Button icon="calendar" onPress={() => navigation.navigate('agendarTicket')} mode="elevated" labelStyle={{fontFamily:'PoppinsMedium', paddingTop:1}} style={{alignSelf:'center', width:250, height:45, justifyContent:'center', marginHorizontal:20}} buttonColor='#305e96' textColor='white'>
              Agendar uma senha
            </Button>
          </View>
        </View>
        <ServerConnectionInfo/>
      </View>
    )
}

const styles = StyleSheet.create({
    container: {
      flex: 1,
    },
    text: {
      fontSize: 25,
      fontWeight: '500',
    },
    page: {
      justifyContent: 'center',
      alignItems: 'center',
      borderWidth: 0, 
      borderColor: 'black',
      borderRadius: 40,
      marginHorizontal: 20,
    },
    image: {
      width: '100%',
      height: '100%',
      borderRadius: 37,
      resizeMode: 'cover',
    },
})