require('dotenv').config(); // Configure the Environment Variables
const bodyParser = require('body-parser');
const fs = require('fs');
const path = require('path');
const mysql = require('mysql');
const express = require('express');
const WebSocket = require('ws');
const app = express();
const wss = new WebSocket.Server({ port: process.env.wssPORT || 5000 });
const PORT = process.env.httpPORT || 4000; // port to run our API

let queues = new Map(); // com setores

const database = mysql.createConnection({ // Configs to establish the DB <-> Server connection
    host: process.env.DB_HOST,
    user: process.env.DB_USER,
    password: process.env.DB_PASSWORD,
    database: process.env.DB_DATABASE
});

database.connect((err) => {
    if (err) {
        console.error('Erro ao conectar ao banco de dados:', err);
        return;
    }
    console.log('Connection to MySQL established');
});

wss.on('connection', (ws) => {
    console.log('WS Connection established');
    
    ws.on('message', (message) => { // tirar Senha
        let data;
        try {
            data = JSON.parse(message);
        } catch (e) {
            data = message.toString();
        }

        console.log(data);

        // APP REQUESTs
        if (data === 'sincronizeData' && ws.readyState === WebSocket.OPEN) {
            sincronizeData(database, ws);
        } else if (data === 'sincronizeDataCompanys' && ws.readyState === WebSocket.OPEN) {
            database.query('SELECT * FROM empresa ORDER BY Nome', (err, results) => {
                if (err) {
                    return;
                } else {
                    ws.send(JSON.stringify({reason: 'sincronizeDataCompanys', companyData: results}));
                }
            });
        } else if (data === 'sincronizeDataEstablishments' && ws.readyState === WebSocket.OPEN) {
            database.query('SELECT Estabelecimento.*, Morada.Rua, Morada.codigoPostal, Morada.Localidade FROM Estabelecimento INNER JOIN Morada ON Estabelecimento.idMorada = Morada.idMorada;', (err, results) => {
                if (err) {
                    return;
                } else {
                    ws.send(JSON.stringify({reason: 'sincronizeDataEstablishments', estabelecimentoData: results}));
                }
            });
        } else if (data === 'sincronizeDataSections' && ws.readyState === WebSocket.OPEN) {
            database.query('SELECT * FROM setor', (err, results) => {
                if (err) {
                    return;
                } else {
                    ws.send(JSON.stringify({reason: 'sincronizeDataSections', sectionData: results}));
                }
            });
        } else if (data === 'sincronizeDataTickets' && ws.readyState === WebSocket.OPEN) {
            let ticketsData = [];

            queues.forEach((valor, chave) => {
                if (valor.fila.includes(ws)) {
                    ticketsData.push({letraIndicativo:valor.letra_indicativa, numero:valor.fila.indexOf(ws)+1, expired: valor.number > valor.fila.indexOf(ws)+1, NIF_empresa: valor.empresa, estabelecimento: valor.estabelecimento, secção:valor.setor });
                }
            })
            ws.send(JSON.stringify({reason: 'sincronizeDataTickets', ticketsData:ticketsData}))

        } else if (data.reason === 'getTicket') {
            const { queueKey } = data;

            if (queues.has(queueKey)) {
                const queue = queues.get(queueKey);
                if (!queue.fila.includes(ws)) {
                    queue.fila.push(ws);
                    console.log(queue.fila);
                    ws.send(JSON.stringify({reason:'getTicketSucc', ticket:{letraIndicativo:queue.letra_indicativa, numero:queue.fila.indexOf(ws)+1, NIF_empresa: queue.empresa, secção:queue.setor}}))
                } else {
                    ws.send(JSON.stringify({reason:'alreadyHaveTicket'}))
                }
                
            }
        } else if (data === 'getAvailableQueues' && ws.readyState === WebSocket.OPEN) {
            const a = Array.from(queues.keys());
            ws.send(JSON.stringify({reason:'availableQueues', data:a}));
            
        // CALLER REQUESTs
        } else if (data.reason === 'openTickets' && ws.readyState === WebSocket.OPEN) {
            const { NIF_Empresa, id_loja, id_setor } = data;
            const queueKey = `${NIF_Empresa}-${id_loja}-${id_setor || 'independente'}`;

            if (!queues.has(queueKey)) {
                queues.set(queueKey, {
                    empresa: NIF_Empresa,
                    estabelecimento: id_loja,
                    caller: ws,
                    number: 0,
                    fila: []
                });
            }
            else {
                
                const queue1 = queues.get(queueKey);
                queue1.caller.close();
                queue1.caller = ws;

            }

            
            const queue = queues.get(queueKey);
            let response = { reason: 'socketSetted' }
            if (id_setor) {
                queue.setor = id_setor;
                database.query(`SELECT letra_indicativa FROM setor WHERE id_setor = ${id_setor}`, (err, results) => {
                    if (err) {
                        return;
                    } else {
                        const a = JSON.stringify(results)
                        response.letraIndicativa = JSON.parse(a)[0].letra_indicativa;
                        queue.letra_indicativa = response.letraIndicativa;
                        ws.send(JSON.stringify(response));
                    }
                });
            } else {
                ws.send(JSON.stringify(response));
            }

            ws.on('close', (code, reason) => {
                console.log('WS Connection closed');
                queues.delete(queueKey);
            })
            
        } else if (data.reason === 'nextTicket' && ws.readyState === WebSocket.OPEN) {
            const { NIF_Empresa, id_loja, id_setor } = data;
            const queueKey = `${NIF_Empresa}-${id_loja}-${id_setor || 'independente'}`;
            
            if (queues.has(queueKey)) {
                const queue = queues.get(queueKey);
                if (queue.fila.length > queue.number) {
                    console.log('entrei');
                    queue.number += 1;
                    queue.fila[queue.number-1].send(JSON.stringify({reason:'yourTicket'}));
                    console.log(queue.fila);
                    ws.send(JSON.stringify({reason:'nextSenha', numero:queue.number}));
                }
            }
        }
    });
  
    ws.on('close', (code, reason) => {
        console.log('WS Connection closed');
    })
  
});

// API ----------------------------------------------------------------------------------------------------

app.use(express.static('./callTicket'));

app.get('/callTicket', (req, res) => {
    res.sendFile(__dirname + '/callTicket/callTicket.html')
});

app.use(bodyParser.urlencoded({ limit: '50mb', extended: true }));
app.use(bodyParser.json({ limit: '50mb' }));

app.post('/upload', (req, res) => {
    const imagemBase64 = req.body.imagem;

    const imagemBuffer = Buffer.from(imagemBase64, 'base64');

    const diretorio = './public/images/company/';

    const caminhoArquivo = diretorio + req.body.nome_ficheiro;

    // Escreve a imagem no sistema de arquivos
    fs.writeFile(caminhoArquivo, imagemBuffer, (err) => {
        if (err) {
            res.status(500).send('Erro ao salvar a imagem.');
        } else {
            res.send('Imagem salva com sucesso.');
        }
    });
});


app.use((req, res, next) => {
    if (req.query.appToken == process.env.APP_TOKEN) {
        next();
    } else {
        res.status(403).send('403 - Only App Usage is Acceptable')
    }
});

app.use(express.static('./public'));

app.get('/images-uris', (req, res) => {
    const imagesDir = path.join(__dirname, '/public/images');
    fs.readdir(imagesDir, (err, files) => {
        if (err) {
            console.error('Erro ao ler diretório de imagens:', err);
            return res.status(500).json({ error: 'Erro ao ler diretório de imagens' });
        }

        const imageFiles = files.filter(file => {
            const ext = path.extname(file).toLowerCase();
            return ext === '.jpg' || ext === '.jpeg' || ext === '.png' || ext === '.gif';
        });

        res.json(imageFiles);
    });
});

app.listen(PORT, () => {
    console.log(`Server running on port: ${PORT}`);
});
  

async function sincronizeData(db, ws) {
    let data = { reason: 'sincronizeData' };

    try {
        const estabelecimentoPromise = new Promise((resolve, reject) => {
            db.query('SELECT Estabelecimento.*, Morada.Rua, Morada.codigoPostal, Morada.Localidade FROM Estabelecimento INNER JOIN Morada ON Estabelecimento.idMorada = Morada.idMorada;', (err, results) => {
                if (err) {
                    reject(err);
                } else {
                    resolve(results);
                }
            });
        });

        const setorPromise = new Promise((resolve, reject) => {
            db.query('SELECT * FROM setor', (err, results) => {
                if (err) {
                    reject(err);
                } else {
                    resolve(results);
                }
            });
        });

        const empresaPromise = new Promise((resolve, reject) => {
            db.query('SELECT * FROM empresa ORDER BY Nome', (err, results) => {
                if (err) {
                    reject(err);
                } else {
                    resolve(results);
                }
            });
        });

        
        data.estabelecimentoData = await estabelecimentoPromise;
        data.sectionData = await setorPromise;
        data.companyData = await empresaPromise;

        ws.send(JSON.stringify(data));
    } catch (err) {
        console.error('Erro ao sincronizar dados:', err);
    }
}