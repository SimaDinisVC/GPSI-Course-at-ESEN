CREATE DATABASE QueuePRO -- a base de dados é criada em C:/Users/user usando sql server
GO
USE QueuePRO

CREATE TABLE Admin (
    Email VARCHAR(50) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(255) NOT NULL
);

CREATE TABLE Empresa (
    NIF INT PRIMARY KEY,
    Nome VARCHAR(20) NOT NULL,
    Slogan VARCHAR(40),
    AreaEmpresarial VARCHAR(40) NOT NULL,
    emailAdmin VARCHAR(20),
    FOREIGN KEY (emailAdmin) REFERENCES Admin(Email)
);

CREATE TABLE Morada (
    idMorada INT PRIMARY KEY IDENTITY,
    Rua VARCHAR(40) NOT NULL,
    codigoPostal VARCHAR(8) NOT NULL,
    Localidade VARCHAR(40) NOT NULL,
);

CREATE TABLE Estabelecimento (
    id_loja INT PRIMARY KEY IDENTITY,
    Nome VARCHAR(20) NOT NULL,
    HorarioAbertura DATETIME,
    HorarioEncerramento DATETIME,
    Telefone VARCHAR(20),
    AgendarSenhas BIT NOT NULL DEFAULT 0,
    RetirarSenhasApp BIT NOT NULL DEFAULT 0,
    RetirarSenhasApenasLoja BIT NOT NULL DEFAULT 0,
    idMorada INT,
    FOREIGN KEY (idMorada) REFERENCES Morada(idMorada),
    NIF_empresa INT,
    FOREIGN KEY (NIF_empresa) REFERENCES Empresa(NIF)
);

CREATE TABLE Gestor (
    Email VARCHAR(20) PRIMARY KEY CHECK(Email LIKE '%@%.%'),
    Nome VARCHAR(20) NOT NULL,
    Password VARCHAR(20) NOT NULL,
    Email_admin VARCHAR(20),
    FOREIGN KEY (Email_admin) REFERENCES Admin(Email)
);

CREATE TABLE GestorEstabelecimento (
    id_loja INT,
    Email_gestor VARCHAR(20),
    PRIMARY KEY (id_loja, Email_gestor),
    FOREIGN KEY (id_loja) REFERENCES Estabelecimento(id_loja),
    FOREIGN KEY (Email_gestor) REFERENCES Gestor(Email)
);

CREATE TABLE Seccao (
    letra_indicativa CHAR PRIMARY KEY,
    Nome VARCHAR(30) NOT NULL,
    id_loja INT,
    FOREIGN KEY (id_loja) REFERENCES Estabelecimento(id_loja)
);

CREATE TABLE SeccaoSubseccao (
    letra_indicativa_seccao CHAR,
    letra_indicativa_subseccao CHAR,
    PRIMARY KEY (letra_indicativa_seccao, letra_indicativa_subseccao),
    FOREIGN KEY (letra_indicativa) REFERENCES Seccao(letra_indicativa),
    FOREIGN KEY (letra_indicativa_subseccao) REFERENCES Seccao(letra_indicativa)
);

CREATE TABLE Utilizador (
    DeviceID VARCHAR(50) PRIMARY KEY,
    SessionID VARCHAR(50)
);

CREATE TABLE Senha (
    letra_indicativa CHAR,
    DeviceID VARCHAR(50),
    PRIMARY KEY (letra_indicativa, DeviceID),
    FOREIGN KEY (letra_indicativa) REFERENCES Seccao(letra_indicativa),
    FOREIGN KEY (DeviceID) REFERENCES Utilizador(DeviceID)
);

CREATE TABLE AnaliseDados (
    id_analise INT PRIMARY KEY IDENTITY,
    PeriodoMaisMovimentado VARCHAR(5) CHECK(PeriodoMaisMovimentado IN ('Manhã', 'Tarde', 'Noite')),
    diaMaisMovimentado VARCHAR(20) CHECK(diaMaisMovimentado IN ('Segunda-Feira', 'Terça-Feira', 'Quarta-Feira', 'Quinta-Feira', 'Sexta-Feira', 'Sábado', 'Domingo')),
    TempoEsperaMédioDiario INT DEFAULT 0,
    EficienciaFuncionario INT DEFAULT 0 CHECK(EficienciaFuncionario >= 0 AND EficienciaFuncionario <= 100),
    AvaliacaoMediaFuncionarios INT DEFAULT 0 CHECK(AvaliacaoMediaFuncionarios >= 0 AND AvaliacaoMediaFuncionarios <= 100),
    letra_indicativa CHAR,
    FOREIGN KEY (letra_indicativa) REFERENCES Seccao(letra_indicativa)
);