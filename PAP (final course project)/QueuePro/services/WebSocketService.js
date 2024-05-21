import { sincronizeDataCompanys } from '../global/stateSlices/companySlice'
import { sincronizeDataEstablishments } from '../global/stateSlices/establishmentSlice'
import { sincronizeDataSections } from '../global/stateSlices/sectionSlice'
import { sincronizeDataTickets, sincronizeTakedTicket } from '../global/stateSlices/ticketsSlice'
import { sincronizeQueues } from '../global/stateSlices/availableQueues'

class WebSocketService {
    constructor() {
        this.listeners = {};
    }

    connect() {
        if (this.socket === undefined || this.socket.readyState === WebSocket.CLOSED) {
            this.socket = new WebSocket('ws://10.1.21.32:5000');
            this.socket.onopen = this.handleOpen.bind(this);
            this.socket.onmessage = this.handleMessage.bind(this);
            this.socket.onclose = this.handleClose.bind(this);
        }
    }

    disconnect() { // To when the app closes
        if (this.socket.readyState === WebSocket.OPEN) {
            this.socket.close();
        }
    }

    setDispatch(dispatch) {
        this.dispatch = dispatch;
    }

    sincronizeData() {
        this.socket.send('sincronizeData');
    }

    sendMessage(message) { // Send a message to the server
        this.socket.send(message);
    }

    handleMessage(event) { // Recieving data from the server
        const data = JSON.parse(event.data)

        if (data.reason === 'sincronizeData' && this.dispatch !== undefined) {
            this.dispatch(sincronizeDataCompanys(data.companyData))
            this.dispatch(sincronizeDataEstablishments(data.estabelecimentoData))
            this.dispatch(sincronizeDataSections(data.sectionData))
        } else if (data.reason === 'sincronizeDataCompanys' && this.dispatch !== undefined) {
            this.dispatch(sincronizeDataCompanys(data.companyData))
        } else if (data.reason === 'sincronizeDataEstablishments' && this.dispatch !== undefined) {
            this.dispatch(sincronizeDataEstablishments(data.estabelecimentoData))
        } else if (data.reason === 'sincronizeDataSections' && this.dispatch !== undefined) {
            this.dispatch(sincronizeDataSections(data.sectionData))
        } else if (data.reason === 'sincronizeDataTickets' && this.dispatch !== undefined) {
            console.log(data.ticketsData);
            this.dispatch(sincronizeDataTickets(data.ticketsData))
        } else if (data.reason === 'availableQueues' && this.dispatch !== undefined) {
            this.dispatch(sincronizeQueues(data.data));
        } else if (data.reason === 'getTicketSucc' && this.dispatch !== undefined) {
            this.dispatch(sincronizeTakedTicket(data.ticket))
            console.log(data.ticket);
            this.emit('getTicketSucc');
        } else if (data.reason === 'alreadyHaveTicket') {
            this.emit('alreadyHaveTicket')
        }
    }

    handleOpen() {
        console.log('Server connection established');
        this.emit('connectionOpened');
        if (this.dispatch !== undefined) { 
            this.sincronizeData();
        }
    }

    handleClose() {
        console.log('Server connection closed unexpectedly');
        this.emit('connectionClosed'); // Emite a informação para a UI
        console.log('Trying to reconnect...');
        this.connect();
    }

    addListener(eventName, listener) {
        if (!this.listeners[eventName]) {
            this.listeners[eventName] = [];
        }
        this.listeners[eventName].push(listener);
    }

    removeListener(eventName, listener) {
        if (this.listeners[eventName]) {
            this.listeners[eventName] = this.listeners[eventName].filter(item => item !== listener);
        }
    }

    emit(eventName, ...args) {
        if (this.listeners[eventName]) {
            this.listeners[eventName].forEach(listener => {
                listener(...args);
            });
        }
    }
}

export default new WebSocketService();