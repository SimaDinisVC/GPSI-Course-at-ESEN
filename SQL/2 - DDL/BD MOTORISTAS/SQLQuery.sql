--CREATE DATABASE BD_Motoristas;
--GO

--USE BD_Motoristas;

--CREATE TABLE Clientes (
--	Cod_Cliente VARCHAR(10) PRIMARY KEY CHECK(Cod_Cliente LIKE 'C%'),
--	CAE INT CHECK(CAE >= 10000 AND CAE <= 99999),
--	Tipo VARCHAR(20) DEFAULT 'PME' CHECK(Tipo IN ('PME', 'Grande Empresa')),
--	Nome VARCHAR(60) NOT NULL,
--	Empresa VARCHAR(50) UNIQUE,
--	NIF INT UNIQUE CHECK(NIF LIKE '5%' AND NIF >= 100000000 AND NIF <= 999999999),
--	Email VARCHAR(30) CHECK(Email LIKE '%@%.%'),
--	Morada VARCHAR(50),
--	CoordenadaLatitude VARCHAR(30) CHECK(CoordenadaLatitude LIKE '##� [NSEO]'),
--    CoordenandaLongitude VARCHAR(30) CHECK(CoordenandaLongitude LIKE '##� [NSEO]'),
--    CONSTRAINT GPS UNIQUE (CoordenadaLatitude, CoordenandaLongitude)
--);

--CREATE TABLE Veiculos (
--	ID_Viatura INT PRIMARY KEY IDENTITY,
--	Matricula VARCHAR(6) NOT NULL UNIQUE,
--	Marca VARCHAR(30),
--	Tipo VARCHAR(15) CHECK(Tipo NOT LIKE 'Ligeiro'),
--	Tara FLOAT,
--	Lotacao INT,
--	DataInspecao DATETIME,
--	Kms INT,
--	RelatorioTecnico TEXT
--);

--CREATE TABLE Motoristas (
--	N_Func INT PRIMARY KEY IDENTITY CHECK(N_Func > 99),
--	Nome VARCHAR(40) NOT NULL,
--	Sobrenome VARCHAR(40),
--	NIF INT UNIQUE CHECK(NIF >= 100000000 AND NIF <= 999999999),
--	N_cartaConducao VARCHAR(10) NOT NULL CHECK(N_cartaConducao LIKE 'VS%'),
--	CategoriaCarta CHAR CHECK(CategoriaCarta IN ('C','D')),
--	AnoCaducaCarta INT CHECK(AnoCaducaCarta > 1000 AND AnoCaducaCarta < 9999),
--	Vencimento INT CHECK(Vencimento >= 420),
--	RelatorioMedico VARCHAR(100) DEFAULT 'Nada a registar',
--	DataIngresso DATE DEFAULT GETDATE(),
--	Morada VARCHAR(40),
--	CodigoPostal VARCHAR(8) CHECK(CodigoPostal LIKE '####-###'),
--	HoraEntrada VARCHAR(5) CHECK(HoraEntrada LIKE '##:##'),
--	TempoDiario INT CHECK(TempoDiario > 4 AND TempoDiario < 8),
--	Casado BIT,
--	Contato INT CHECK(Contato LIKE '96#######'),
--	Altura FLOAT,
--	DataNasc DATETIME,
--	Idade INT CHECK(Idade >= 18),
--	ID_Viatura INT,
--	FOREIGN KEY (ID_Viatura) REFERENCES Veiculos(ID_Viatura)
--);

--CREATE TABLE Transportes (
--	N_Frete INT PRIMARY KEY IDENTITY,
--	N_Funcionario INT,
--	tipoCarga VARCHAR(50) CHECK(tipoCarga IN ('S�lidos', 'L�quido', ' Materiais perigosos', 'Animais')),
--	localDescarga VARCHAR(50) NOT NULL,
--	GPS VARCHAR(30) NOT NULL CHECK(GPS LIKE '%.%, %.%'),
--	DataTransporte DATE DEFAULT GETDATE(),
--	Combustivel INT,
--	Kms INT,
--	Despesas FLOAT CHECK(Despesas <=200),
--	ID_Viatura INT,
--	FOREIGN KEY (ID_Viatura) REFERENCES Veiculos(ID_Viatura),
--	Cod_Cliente VARCHAR(10) CHECK(Cod_Cliente LIKE 'C%'),
--	FOREIGN KEY (Cod_Cliente) REFERENCES Clientes(Cod_Cliente)
--);

--Contabilidade:

--CREATE VIEW Salario AS 
--SELECT NIF, Vencimento, ((Vencimento * 23) / 100) AS Desconto
--FROM Motorista--

--CREATE VIEW Despesa_Total AS
--SELECT NFuncionario, ID_Viatura, Despesas
--FROM Transportes

--CREATE VIEW Frete AS
--SELECT CodCliente, NFrete, Despesas, Kms * 0.8 AS Valor_Servico
--FROM Transportes
--ORDER BY CodCliente;

--Recursos Humanos:

--CREATE VIEW Pre_Reforma AS
--SELECT Nome, Idade
--FROM Motorista
--WHERE Idade > 60;

--CREATE VIEW Aniversariante AS
--SELECT Nome, Morada
--FROM Motorista
--WHERE DataNascimento = CURRENT_TIMESTAMP;

--CREATE VIEW Carta_Caduca AS
--SELECT Nome, Contato
--FROM Motorista
--WHERE AnoCaducaCarta = YEAR(GETDATE());

--Departamento médico:

--CREATE VIEW Relatorio_medico AS
--SELECT RelatorioMedico 
--FROM Motorista
--WHERE RelatorioMedico != 'Nada a observar';

--CREATE VIEW Problema_Visao AS
--SELECT Nome
--FROM Motorista
--WHERE RelatorioMedico LIKE '%visão%';

--Base Logística de Viseu:

--CREATE VIEW Funcionario_Viseu AS
--SELECT Nome, HoraEntrada, TempoDiario 
--FROM Motorista
--WHERE CodigoPostal LIKE '3500%';

--Oficina:

--CREATE VIEW Veiculos_Inspecionados AS
--SELECT Matricula, Marca, Kms, DataInspecao
--FROM Veiculos
--WHERE YEAR(DataInspecao) = YEAR(GETDATE());

--Para o Seguro:

--CREATE VIEW Veiculos_Circulacao AS
--SELECT A.ID_Viatura, B.Nome, B.NCartaoConducao, B.Idade
--FROM Veiculos AS A, Motorista AS B

--Departamento Comercial:

--CREATE VIEW Listagem_Veiculo AS
--SELECT ID_Viatura, Tara, TamanhoReboque
--FROM Veiculos

--CREATE VIEW Saldo_Clientes AS
--SELECT NOME, EMPRESA, SALDO
--FROM Clientes
--WHERE SALDO > 5000

--Administração

--CREATE VIEW Motorista_Solteiros AS
--SELECT Nome, Sobrenome, Contato
--FROM Motorista
--WHERE Casado = 0;

--CREATE VIEW Quantidade_KM AS
--SELECT Motorista.Nome, Transportes.Kms
--FROM Motorista, Transportes 
--WHERE Motorista.NumeroFuncionario = Transportes.NFuncionario

--CREATE VIEW Total_Capital_Divida AS 
--SELECT EMPRESA, SUM(SALDO) AS Saldo_Total
--FROM Clientes
--GROUP BY EMPRESA;

-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

-- CREATE INDEX Ver_IDViatura
-- ON Veiculos(ID_Viatura);

-- SELECT Ver_IDViatura
-- FROM Veiculos
-- ORDER BY Kms;