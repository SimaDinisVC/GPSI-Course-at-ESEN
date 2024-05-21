import { Text, View } from 'react-native'
import React, { useState, useEffect } from 'react';
import { Snackbar} from 'react-native-paper';
import WebSocketService from '../services/WebSocketService';

export default function AlertTicketTaken() {
    const [isConnectionClosed, setConnectionClosed] = useState(false);

    useEffect(() => {

        WebSocketService.addListener('alreadyHaveTicket', ()=>setConnectionClosed(true));

        return () => {
            // Clean when unmounted
            WebSocketService.removeListener('alreadyHaveTicket', () => {});
        };
    }, []);


    return (
        <Snackbar
            style={{backgroundColor:"white", borderRadius:10}}
            visible={isConnectionClosed}
            duration={2000}
            onDismiss={()=> {setConnectionClosed(false)}}
            >
            <Text>Você já possui uma senha.</Text>
        </Snackbar>
    );
}