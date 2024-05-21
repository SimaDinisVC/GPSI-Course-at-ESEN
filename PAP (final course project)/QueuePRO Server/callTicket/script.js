var url = new URL(window.location.href);


var params = new URLSearchParams(url.search);


var queryParamsList = {};


params.forEach(function(value, key) {
    queryParamsList[key]= value;
});


var websocket = new WebSocket('ws://localhost:5000');


websocket.onopen = function() {
    console.log('Conexão estabelecida com o servidor WebSocket.');
    if (queryParamsList.id_setor) {
        websocket.send(JSON.stringify({reason:'openTickets', NIF_Empresa: queryParamsList.NIF_Empresa, id_loja: queryParamsList.id_loja, id_setor: queryParamsList.id_setor }))
    } else {
        websocket.send(JSON.stringify({reason:'openTickets', NIF_Empresa: queryParamsList.NIF_Empresa, id_loja: queryParamsList.id_loja }))
    }
};


websocket.onmessage = function(event) {
    const data = JSON.parse(event.data)
    
    if (data.reason === 'socketSetted') {
        if (data.letraIndicativa) {
            var letraindicativa = document.getElementById('letraIndicativa')
            letraindicativa.innerText = data.letraIndicativa;
        }
    } else if (data.reason === 'nextSenha') {
        var numeroSenha = document.getElementById('numeroSenha')
        numeroSenha.innerText = data.numero;
    }
};


websocket.onclose = function() {
    window.location.href = 'about:blank';
};

document.addEventListener('DOMContentLoaded', function () {
    var cardBox = document.getElementById('cardBox');
    
    cardBox.addEventListener('click', function () {
        if (queryParamsList.id_setor) {
            websocket.send(JSON.stringify({reason:'nextTicket', NIF_Empresa: queryParamsList.NIF_Empresa, id_loja: queryParamsList.id_loja, id_setor: queryParamsList.id_setor }))
        } else {
            websocket.send(JSON.stringify({reason:'nextTicket', NIF_Empresa: queryParamsList.NIF_Empresa, id_loja: queryParamsList.id_loja }))
        }
    });
});
