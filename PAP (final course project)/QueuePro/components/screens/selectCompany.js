import react, { useEffect, useState } from 'react';
import { StyleSheet, View, Text, FlatList, ViewBase } from 'react-native';
import { Avatar, Card, IconButton, Icon } from 'react-native-paper';
// Redux
import { useDispatch, useSelector } from 'react-redux';
import { selectCompany } from '../../global/stateSlices/globalVariables';
// Services
import WebSocketService from '../../services/WebSocketService';
// Componentes
import ServerConnectionInfo from '../ServerConnectionInfo';


export default function SelectCompany({ navigation }) {
    const [isRefreshing, setIsRefreshing] = useState(false);
    const data = useSelector((state) => state.companys.DATA);
    const globalVars = useSelector((state) => state.globalVARS)
    const dispatch = useDispatch();

    useEffect(() => {
        if (WebSocketService.socket.readyState === WebSocketService.socket.OPEN) {
            WebSocketService.sendMessage('sincronizeDataCompanys');
        }
    }, [])

    const handleRefresh = () => {
        setIsRefreshing(true);
        if (WebSocketService.socket.readyState === WebSocketService.socket.OPEN) {
            WebSocketService.sendMessage('sincronizeDataCompanys');
        }
        setIsRefreshing(false);
    };

    if (data.length === 0){
        return (
            <View style={styles.container}>
                <View>
                    <IconButton icon='arrow-left' iconColor='#305e96' size={35} style={{marginTop:10}}  onPress={() => navigation.goBack() }/>
                    <Text style={styles.text}>Escolha a empresa</Text>
                </View>
                <View style={{ flex: 1, alignItems:'center', justifyContent:'center' }}>
                    <Icon source='domain' color='#305e96' size={70}/>
                    <Text style={{ fontFamily: 'PoppinsRegular', fontSize: 16, textAlign:'center', paddingHorizontal:30 }}>
                        Ainda não existem empresas na base de dados
                    </Text>
                </View>
            </View>
        )
    }

    return (
        <View style={styles.container}>
            <View>
                <IconButton icon='arrow-left' iconColor='#305e96' size={35} style={{marginTop:10}}  onPress={() => navigation.goBack() }/>
                <Text style={styles.text}>Escolha a empresa</Text>
            </View>
            <FlatList
                scrollEnabled={true}
                data={data}
                keyExtractor={(item, index) => index.toString()} // Use o id único do item
                refreshing={isRefreshing}
                onRefresh={handleRefresh}
                renderItem={({ item }) => (
                    <Card mode='elevated' style={{ marginHorizontal: 15, paddingVertical:7, paddingHorizontal:2, marginVertical: 5, backgroundColor:'#305e96' }} onPress={() => { navigation.navigate('selectEstablishment'); dispatch(selectCompany(item.NIF));}}>
                        <Card.Title
                                title={item.Nome}
                                titleVariant='headlineSmall'
                                titleStyle={{ fontFamily: 'PoppinsMedium', color:'white' }}
                                subtitle={item.AreaEmpresarial}
                                subtitleStyle={{ fontFamily: 'PoppinsRegular', color:'white' }}
                                left={(props) => {
                                    if (item.logoPath != null) {
                                        return (
                                            <Avatar.Image {...props} source={{uri:`http://${globalVars.apiUrl}/images/company/${item.logoPath}?appToken=${globalVars.apiToken}`}} style={{ marginTop: 3, marginLeft: -7, backgroundColor: 'white' }} size={55}/>
                                        )
                                    }
                                    else {
                                        return (
                                            <Avatar.Icon {...props} icon='domain' style={{ marginTop: 3, marginLeft: -7, backgroundColor: 'white' }} size={55}/>
                                        )
                                    }
                                }}
                                right={(props) => {
                                    return (
                                        <View {...props} style={{marginRight:10}}>
                                            <Icon source='arrow-right-drop-circle-outline' color='white' size={30}/>
                                        </View>
                                    )
                                }}
                            />
                    </Card>
                )}
            />
            <ServerConnectionInfo/>
        </View>
    );
}


const styles = StyleSheet.create({
    container: {
        flex: 1,
    },
    text: {
        fontFamily: 'PoppinsMedium',
        fontSize: 30,
        marginTop: -15,
        marginBottom: 10,
        alignSelf: 'center',
    },
});