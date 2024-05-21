import { Text, View } from 'react-native'
import React, { useState, useEffect } from 'react';
import { Snackbar} from 'react-native-paper';
import WebSocketService from '../services/WebSocketService';

export default function ServerConnectionInfo() {
    const [isConnectionClosed, setConnectionClosed] = useState(false);

    useEffect(() => {
        const connectionClosedListener = () => {
            setConnectionClosed(true);
        };

        const connectionOpenedListener = () => {
            setConnectionClosed(false);
        };

        WebSocketService.addListener('connectionClosed', connectionClosedListener);
        WebSocketService.addListener('connectionOpened', connectionOpenedListener);

        return () => {
            // Clean when unmounted
            WebSocketService.removeListener('connectionClosed', connectionClosedListener);
            WebSocketService.removeListener('connectionClosed', connectionClosedListener);
        };
    }, []);


    return (
        <Snackbar
            style={{backgroundColor:"white", borderRadius:10}}
            visible={isConnectionClosed}
            onDismiss={()=> {return;}}
            action={{
                label: 'Tentar Conectar',
                onPress: () => WebSocketService.connect(),
                textColor: '#305e96',
                dark: true,
                rippleColor:'#305e96'
            }}>
            <Text>Conexão Perdida.{'\n'}Verifique a sua ligação à Internet.</Text>
        </Snackbar>
    );
}