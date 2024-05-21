import React, { useEffect, useState } from 'react';
import { StyleSheet, FlatList, View, Text, RefreshControl } from 'react-native';
import { Modal, Portal, Card, Menu, Divider, Avatar, IconButton, Icon } from 'react-native-paper';
// Redux
import { useSelector } from 'react-redux'
// Services
import WebSocketService from '../../services/WebSocketService';
import axios from 'axios';
// Components
import ServerConnectionInfo from '../ServerConnectionInfo';

export default function Senhas({ navigation }) {
    const [ModalVisible, setModalVisible] = useState(false);
    const [ticketID, setTicketID] = useState(-1);
    const [isRefreshing, setIsRefreshing] = useState(false);
    const company = useSelector((state) => state.companys.DATA);
    const establishment = useSelector((state) => state.establishments.DATA);
    const section = useSelector((state) => state.sections.DATA);
    const data = useSelector((state) => state.tickets.DATA);
    const globalVars = useSelector((state) => state.globalVARS);

    const senha = data && data[ticketID];
    
    const onRefresh = async () => {
        setIsRefreshing(true);
        WebSocketService.sendMessage('sincronizeDataTickets');
        setIsRefreshing(false);
    };

    if (!data || data.length === 0) {
        return (
            <View style={styles.container}>
                <View>
                    <Text style={styles.text}>Minhas Senhas</Text>
                </View>
                <View style={{ flex: 1, alignItems:'center', justifyContent:'center' }}>
                    <Icon source='ticket-confirmation' color='#305e96' size={70}/>
                    <Text style={{ fontFamily: 'PoppinsRegular', fontSize: 16, textAlign:'center', paddingHorizontal:30 }}>
                        Não tem senhas adquiridas no momento
                    </Text>                    
                    <ServerConnectionInfo/>
                </View>
            </View>
        )
    }

    return (
        <View style={styles.container}>
            <Portal>
                <Modal visible={ModalVisible} onDismiss={() => {setModalVisible(false); setTicketID(-1) }} contentContainerStyle={{backgroundColor: '#305e96', color:'white', borderRadius:20, paddingBottom:20, marginHorizontal:20}}>
                    <IconButton icon='close' iconColor='white' size={35} style={{marginTop:20}}  onPress={() => {setModalVisible(false); setTicketID(-1) }}/>
                    <Text style={{color:'white', alignSelf:'center', fontFamily:'PoppinsSemiBold', marginTop:-53, marginBottom: 20, fontSize:30 }}>Senha</Text>
                    <View style={{backgroundColor:'white', marginHorizontal:50, paddingVertical:30, width:'auto', borderRadius:30}}>
                        <Text style={{fontFamily:'PoppinsBold', marginTop:10, fontSize:100, alignSelf:'center'}}>{senha ? `${senha.letraIndicativo?senha.letraIndicativo:''}${senha.numero}` : ''}</Text>
                    </View>
                    <View style={{alignItems:'center', marginVertical:15 }}>
                        <Text style={senha && senha.expired === true ? {fontFamily:'PoppinsItalic', color:'#e63737', fontSize:20} : {display:'none'}}>Expirada</Text>
                    </View>
                    <View style={{flexDirection:'row'}}>
                        <View style={senha && senha.secção ? {flex:0.5, alignItems:'center', justifyContent:'center', gap:5}: {flex:1, alignItems:'center', justifyContent:'center', gap:5}}>
                            <Text style={{color:'white', fontFamily:'PoppinsRegular', fontSize:20}}>Empresa:</Text>
                            <View style={{marginLeft:7, borderRadius:10, backgroundColor:'white', width:'90%', alignItems:'center'}}>
                                <Text style={{color:'black', fontFamily:'PoppinsSemiBold', fontSize:25}}>{senha && senha.NIF_empresa ? `${company.find(emp => emp.NIF == senha.NIF_empresa).Nome}` : ''}</Text>
                            </View>
                        </View>
                        <View style={senha && senha.secção ? {flex:0.5, alignItems:'center', justifyContent:'center', gap:5} : {display:'none'}}>
                            <Text style={{color:'white', fontFamily:'PoppinsRegular', fontSize:20}}>Setor:</Text>
                            <View style={{marginRight:7, borderRadius:10, backgroundColor:'white', width:'90%', alignItems:'center'}}>
                                <Text style={{color:'black', fontFamily:'PoppinsSemiBold', fontSize:25}}>{senha && senha.secção ? `${section.find(sec => sec.id_setor == senha.secção).Nome}` : ''}</Text>
                            </View>
                        </View>
                    </View>
                </Modal>
            </Portal>
            <View>
                <Text style={styles.text}>Minhas Senhas</Text>
            </View>
            <View style={{ flex: 1 }}>
                <FlatList
                    scrollEnabled={true}
                    data={data}
                    keyExtractor={(item, index) => index.toString()} // Use o id único do item
                    refreshing={isRefreshing}
                    onRefresh={onRefresh}
                    renderItem={({ item, index }) => (
                        <Card mode='outlined' style={{ marginHorizontal: 10, marginVertical: 5, backgroundColor:'#305e96' }} onPress={() => {setModalVisible(true); setTicketID(index);}}>
                            <Card.Title
                                title={item.secção ? `${section.find(sec => sec.id_setor == item.secção).Nome}` : `${establishment.find(sec => sec.id_loja == item.estabelecimento).Nome}`}
                                titleVariant='headlineSmall'
                                titleStyle={{ fontFamily: 'PoppinsMedium', color:'white' }}
                                subtitle={item.NIF_empresa ? `${company.find(emp => emp.NIF == item.NIF_empresa).Nome}` : ''}
                                subtitleStyle={{ fontFamily: 'PoppinsRegular', color:'white' }}
                                left={(props) => <Avatar.Text {...props} label={(item.letraIndicativo? item.letraIndicativo:'') + item.numero} style={{ marginTop: 3, marginLeft: -7, backgroundColor: 'white' }} size={55} labelStyle={{ fontFamily: 'PoppinsRegular', marginTop: 2, fontSize: 25 , color:'#305e96'}} />}
                                right={(props) => {
                                    const [visible, setVisible] = useState(false);
                                    return (
                                        <Menu
                                            visible={visible}
                                            onDismiss={() => setVisible(false)}
                                            anchorPosition='left'
                                            contentStyle={{paddingVertical:2}}
                                            anchor={<IconButton icon="dots-vertical" iconColor='white' onPress={() => setVisible(true)} />}
                                        >
                                            <Menu.Item leadingIcon="eye" title="Mostrar" titleStyle={{fontFamily:'PoppinsSemiBold', color:'white'}} onPress={() => {setModalVisible(true); setTicketID(item.id); setVisible(false);}} />
                                            <Divider style={{height:1}} />
                                            <Menu.Item leadingIcon="delete" style={{paddingTop:2}} titleStyle={{fontFamily:'PoppinsSemiBold', marginTop:1, color: '#ff4545' }} onPress={async () => {setVisible(false); await axios.post(url, { query: `DELETE FROM senhas WHERE id = ${item.id}` }); onRefresh()}} title="Excluir" />
                                        </Menu>
                                    )
                                }}
                            />
                            <Card.Content>
                                <View style={{ flex: 1, flexDirection: 'row', justifyContent: 'space-evenly' }}>
                                    <Text style={{ color: 'white', fontFamily: 'PoppinsLight' }}>5 pessoas à frente</Text>
                                    <Text style={{ color: 'white', fontFamily: 'PoppinsLight' }}>cerca de 10 min.</Text>
                                </View>
                            </Card.Content>
                        </Card>
                    )}
                />
                <ServerConnectionInfo/>
            </View>
        </View>
    );
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
    },
    text: {
        fontFamily: 'PoppinsSemiBold',
        fontSize: 30,
        marginTop: 20,
        marginBottom: 5,
        alignSelf: 'center',
    },
});