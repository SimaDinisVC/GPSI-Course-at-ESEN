import react, { useEffect, useState } from 'react';
import { StyleSheet, View, Text, FlatList  } from 'react-native';
import { Portal, Modal, Card, IconButton, Icon, Button, Avatar } from 'react-native-paper';
// Redux
import { useSelector } from 'react-redux'
// Services
import WebSocketService from '../../services/WebSocketService';
// Componentes
import ServerConnectionInfo from '../ServerConnectionInfo';
import AlertTicketTaken from '../AlertTicketTaken';


export default function SelectSection({ navigation }) {
    const [ModalVisible, setModalVisible] = useState(false);
    const [isRefreshing, setIsRefreshing] = useState(false);
    const globalVars = useSelector((state) => state.globalVARS);
    const availableQueues = useSelector((state) => state.availableQueues.DATA);
    const company = useSelector((state) => state.companys.DATA);
    const section = useSelector((state) => state.sections.DATA);
    const senha = useSelector((state) => state.tickets.takedTicket);
    let data = useSelector((state) => state.sections.DATA);
    data = data.filter(section => section.id_loja === globalVars.SelectedEstablishment);

    useEffect(() => {
        WebSocketService.addListener('getTicketSucc', () => setModalVisible(true));

        if (WebSocketService.socket.readyState === WebSocketService.socket.OPEN) {
            WebSocketService.sendMessage('sincronizeDataSections');
            WebSocketService.sendMessage('getAvailableQueues');
        }
    }, [])

    const handleRefresh = () => {
        setIsRefreshing(true);
        if (WebSocketService.socket.readyState === WebSocketService.socket.OPEN) {
            WebSocketService.sendMessage('sincronizeDataSections');
            WebSocketService.sendMessage('getAvailableQueues');
        }
        setIsRefreshing(false);
    };

    if (data.length === 0){
        return (
            <View style={styles.container}>
                <View>
                    <IconButton icon='formated-list-numbered' iconColor='#305e96' size={35} style={{marginTop:10}}  onPress={() => navigation.goBack() }/>
                    <Text style={styles.text}>Tire a sua senha</Text>
                </View>
                <View style={{ flex: 1, alignItems:'center', justifyContent:'center' }}>
                    <Icon source='store' color='#305e96' size={70}/>
                    <Text style={{ fontFamily: 'PoppinsRegular', fontSize: 16, textAlign:'center', paddingHorizontal:30 }}>
                        Ainda não existem setores na base de dados
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
                        <Text style={{fontFamily:'PoppinsBold', marginTop:10, fontSize:100, alignSelf:'center'}}>{senha ? `${senha.letraIndicativo}${senha.numero}` : ''}</Text>
                    </View>
                    <View style={{flexDirection:'row'}}>
                        <View style={{flex:0.5, alignItems:'center', justifyContent:'center', gap:5}}>
                            <Text style={{color:'white', fontFamily:'PoppinsRegular', fontSize:20}}>Empresa:</Text>
                            <View style={{marginLeft:7, borderRadius:10, backgroundColor:'white', width:'90%', alignItems:'center'}}>
                                <Text style={{color:'black', fontFamily:'PoppinsSemiBold', fontSize:25}}>{senha.NIF_empresa ? `${company.find(emp => emp.NIF == senha.NIF_empresa).Nome}` : ''}</Text>
                            </View>
                        </View>
                        <View style={{flex:0.5, alignItems:'center', justifyContent:'center', gap:5}}>
                            <Text style={{color:'white', fontFamily:'PoppinsRegular', fontSize:20}}>Setor:</Text>
                            <View style={{marginRight:7, borderRadius:10, backgroundColor:'white', width:'90%', alignItems:'center'}}>
                                <Text style={{color:'black', fontFamily:'PoppinsSemiBold', fontSize:25}}>{senha.secção ? `${section.find(sec => sec.id_setor == senha.secção).Nome}` : ''}</Text>
                            </View>
                        </View>
                    </View>
                </Modal>
            </Portal>
            <View>
                <IconButton icon='arrow-left' iconColor='#305e96' size={35} style={{marginTop:10}} onPress={() => navigation.goBack() }/>
                <Text style={styles.text}>Tire a sua senha</Text>
            </View>
            <FlatList
                scrollEnabled={true}
                data={data}
                keyExtractor={(item, index) => index.toString()} // Use o id único do item
                refreshing={isRefreshing}
                onRefresh={handleRefresh}
                renderItem={({ item }) => {
                    const a = availableQueues.some(element => {
                        let parts = element.split('-');
                        let lastPart = parts[parts.length - 1]; // O último segmento será o id_setor ou 'independente'
                        return lastPart == item.id_setor; // Compara com a variável idSetorVar
                    });

                    return (
                    <Card mode='elevated' style={{ marginHorizontal: 15, paddingVertical:7, paddingHorizontal:2, marginVertical: 5, backgroundColor:'#305e96' }}>
                        <Card.Title
                            title={item.Nome}
                            titleVariant='headlineSmall'
                            titleStyle={{ fontFamily: 'PoppinsMedium', color:'white' }}
                            left={(props) => {
                                return (
                                    <Avatar.Text {...props} label={item.letra_indicativa} style={{ marginLeft: -7, backgroundColor: 'white' }} size={55} labelStyle={{ fontFamily: 'PoppinsRegular', marginTop: 2, fontSize: 25 , color:'#305e96'}} />
                                )
                            }}
                        />
                        <Card.Actions>
                            <View style={ a ? {display:'none'} : {flex:1}}><Text style={{fontFamily:'PoppinsItalic', fontSize:14.5, paddingTop:5}}>Indisponível no momento</Text></View> 
                            <Button mode='elevated' disabled={a ? false:true} icon='ticket' buttonColor='white' textColor='#305e96' onPress={() => {WebSocketService.sendMessage(JSON.stringify({reason: 'getTicket', queueKey:`${globalVars.SelectedCompany}-${globalVars.SelectedEstablishment}-${item.id_setor}`}));WebSocketService.sendMessage('sincronizeDataTickets');}}>Tirar Senha</Button>
                        </Card.Actions>
                    </Card>
                    )
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
        fontSize: 28,
        marginTop: -15,
        marginBottom: 10,
        alignSelf: 'center',
    },
});