import react, { useEffect, useState } from 'react';
import { StyleSheet, View, Text, FlatList, Linking  } from 'react-native';
import { Portal, Modal, Card, IconButton, Icon, Button } from 'react-native-paper';
// Redux
import { useDispatch, useSelector } from 'react-redux';
import { selectEstablishment } from '../../global/stateSlices/globalVariables';
// Services
import WebSocketService from '../../services/WebSocketService';
// Componentes
import ServerConnectionInfo from '../ServerConnectionInfo';
import AlertTicketTaken from '../AlertTicketTaken';


export default function SelectEstablishment({ navigation }) {
    const [ModalVisible, setModalVisible] = useState(false);
    const [isRefreshing, setIsRefreshing] = useState(false);
    const globalVars = useSelector((state) => state.globalVARS);
    const dispatch = useDispatch();
    const availableQueues = useSelector((state) => state.availableQueues.DATA);
    const company = useSelector((state) => state.companys.DATA);
    const senha = useSelector((state) => state.tickets.takedTicket);
    let data = useSelector((state) => state.establishments.DATA);
    data = data.filter(estab => estab.NIF_empresa === globalVars.SelectedCompany);

    useEffect(() => {
        
        WebSocketService.addListener('getTicketSucc', () => setModalVisible(true));

        if (WebSocketService.socket.readyState === WebSocketService.socket.OPEN) {
            WebSocketService.sendMessage('sincronizeDataEstablishments');
            WebSocketService.sendMessage('getAvailableQueues');
        }
    }, [])

    const handleRefresh = () => {
        setIsRefreshing(true);
        if (WebSocketService.socket.readyState === WebSocketService.socket.OPEN) {
            WebSocketService.sendMessage('sincronizeDataEstablishments');
            WebSocketService.sendMessage('getAvailableQueues');
        }
        setIsRefreshing(false);
    };

    if (data.length === 0){
        return (
            <View style={styles.container}>
                <View>
                    <IconButton icon='arrow-left' iconColor='#305e96' size={35} style={{marginTop:10}}  onPress={() => navigation.goBack() }/>
                    <Text style={styles.text}>Escolha o estabelecimento</Text>
                </View>
                <View style={{ flex: 1, alignItems:'center', justifyContent:'center' }}>
                    <Icon source='store' color='#305e96' size={70}/>
                    <Text style={{ fontFamily: 'PoppinsRegular', fontSize: 16, textAlign:'center', paddingHorizontal:30 }}>
                        Ainda não existem estabelecimentos na base de dados
                    </Text>
                </View>
            </View>
        )
    }

    return (
        <View style={styles.container}>
            <Portal>
                <Modal visible={ModalVisible} onDismiss={() => {setModalVisible(false) }} contentContainerStyle={{backgroundColor: '#305e96', color:'white', borderRadius:20, paddingBottom:20, marginHorizontal:20}}>
                    <IconButton icon='close' iconColor='white' size={35} style={{marginTop:20}}  onPress={() => {setModalVisible(false)}}/>
                    <Text style={{color:'white', alignSelf:'center', fontFamily:'PoppinsSemiBold', marginTop:-53, marginBottom: 20, fontSize:30 }}>Senha</Text>
                    <View style={{backgroundColor:'white', marginHorizontal:50, paddingVertical:30, width:'auto', borderRadius:30}}>
                        <Text style={{fontFamily:'PoppinsBold', marginTop:10, fontSize:100, alignSelf:'center'}}>{senha ? `${senha.numero}` : ''}</Text>
                    </View>
                    <View style={{flexDirection:'row', marginTop:10}}>
                        <View style={{flex:1, alignItems:'center', justifyContent:'center', gap:5}}>
                            <Text style={{color:'white', fontFamily:'PoppinsRegular', fontSize:20}}>Empresa:</Text>
                            <View style={{marginHorizontal:7, borderRadius:10, backgroundColor:'white', width:'90%', alignItems:'center'}}>
                                <Text style={{color:'black', fontFamily:'PoppinsSemiBold', fontSize:25}}>{senha.NIF_empresa ? `${company.find(emp => emp.NIF == senha.NIF_empresa).Nome}` : ''}</Text>
                            </View>
                        </View>
                    </View>
                </Modal>
            </Portal>
            <View>
                <IconButton icon='arrow-left' iconColor='#305e96' size={35} style={{marginTop:10}} onPress={() => navigation.goBack() }/>
                <Text style={styles.text}>Escolha o estabelecimento</Text>
            </View>
            <FlatList
                scrollEnabled={true}
                data={data}
                keyExtractor={(item, index) => index.toString()} // Use o id único do item
                refreshing={isRefreshing}
                onRefresh={handleRefresh}
                renderItem={({ item }) => {
                    if (item.semSetores) {
                        const a = availableQueues.some(element => {
                            let parts = element.split('-');
                            let lastPart = parts[parts.length - 1];
                            let middlePart = parts[parts.length - 2]; // O último segmento será o id_setor ou 'independente'
                            return middlePart+'-'+lastPart == item.id_loja+'-'+'independente'; // Compara com a variável idSetorVar
                        });

                        return (
                            <Card mode='elevated' style={{ marginHorizontal: 15, paddingVertical:7, paddingHorizontal:2, marginVertical: 5, backgroundColor:'#305e96' }}>
                                <Card.Title
                                    title={item.Nome}
                                    titleVariant='headlineSmall'
                                    titleStyle={{ fontFamily: 'PoppinsMedium', color:'white' }}
                                />
                                <Card.Content>
                                    <Text style={{ fontFamily: 'PoppinsRegular', color:'white' }} onPress={() => Linking.openURL(`https://www.google.com/maps/search/?api=1&query=${encodeURI(item.Rua+', '+item.codigoPostal+' '+item.Localidade)}`)}>{item.Rua+', '+item.codigoPostal+' '+item.Localidade}</Text>
                                    <Text style={{ fontFamily: 'PoppinsRegular', color:'white'}} onPress={() => Linking.openURL(`tel:${item.Telefone}`)}>{item.Telefone}</Text>
                                </Card.Content>
                                <Card.Actions>
                                    <View style={ a ? {display:'none'}: {flex:1}}><Text style={{fontFamily:'PoppinsItalic', fontSize:14.5, paddingTop:5}}>Indisponível no momento</Text></View> 
                                    <Button mode='elevated' disabled={a ? false:true} icon='ticket' buttonColor='white' textColor='#305e96' onPress={() => {WebSocketService.sendMessage(JSON.stringify({reason: 'getTicket', queueKey:`${globalVars.SelectedCompany}-${item.id_loja}-${'independente'}`}));WebSocketService.sendMessage('sincronizeDataTickets');}}>Tirar Senha</Button>
                                </Card.Actions>
                            </Card>
                        )
                    } else {
                        return (
                            <Card mode='elevated' style={{ marginHorizontal: 15, paddingVertical:7, paddingHorizontal:2, marginVertical: 5, backgroundColor:'#305e96' }} onPress={() => {navigation.navigate('selectSection'); dispatch(selectEstablishment(item.id_loja)); }}>
                                <Card.Title
                                    title={item.Nome}
                                    titleVariant='headlineSmall'
                                    titleStyle={{ fontFamily: 'PoppinsMedium', color:'white' }}
                                    right={(props) => {
                                        return (
                                            <View {...props} style={{ marginRight:10 }}>
                                                <Icon source='arrow-right-drop-circle-outline' color='white' size={30}/>
                                            </View>
                                        )
                                    }}
                                />
                                <Card.Content>
                                    <Text style={{ fontFamily: 'PoppinsRegular', color:'white' }} onPress={() => Linking.openURL(`https://www.google.com/maps/search/?api=1&query=${encodeURI(item.Rua+', '+item.codigoPostal+' '+item.Localidade)}`)}>{item.Rua+', '+item.codigoPostal+' '+item.Localidade}</Text>
                                    <Text style={{ fontFamily: 'PoppinsRegular', color:'white'}} onPress={() => Linking.openURL(`tel:${item.Telefone}`)}>{item.Telefone}</Text>
                                </Card.Content>
                            </Card>
                        )
                    }                 
                }}
            />
            <ServerConnectionInfo/>
            
            <AlertTicketTaken/>
        </View>
    );
}


const styles = StyleSheet.create({
    container: {
        flex: 1,
    },
    text: {
        fontFamily: 'PoppinsMedium',
        fontSize: 25,
        marginTop: -15,
        marginBottom: 10,
        alignSelf: 'center',
    },
});