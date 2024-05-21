CREATE TABLE Animais (
	id INT PRIMARY KEY,
	nome VARCHAR(80) NOT NULL,
	tipo VARCHAR(35) NOT NULL,
	raca VARCHAR(50) NOT NULL,
	Detalhes TEXT,
	data_nasc DATE NOT NULL
);

CREATE TABLE Medicos (
	NIC INT PRIMARY KEY CHECK(LEN(CONVERT(VARCHAR, NIC)) = 8),
	nome VARCHAR(80) NOT NULL,
	email VARCHAR(50) NOT NULL,
	telefone VARCHAR(15) NOT NULL CHECK (
        ((telefone LIKE '+3519%' AND LEN(CONVERT(VARCHAR, telefone)) = 13) OR
		(telefone LIKE '+351 9%' AND LEN(CONVERT(VARCHAR, telefone)) = 14)) OR
        (telefone LIKE '9%' AND LEN(CONVERT(VARCHAR, telefone)) = 9)
    ),
	DataNasc DATE NOT NULL,
);

CREATE TABLE Consultas ( 
	id INT PRIMARY KEY IDENTITY,
	dataHora DATETIME NOT NULL,
	relatorio TEXT NOT NULL,
	Animal INT,
	FOREIGN KEY (Animal) REFERENCES Animais(id),
	Medico INT,
	FOREIGN KEY (Medico) REFERENCES Medicos(NIC)
);

CREATE INDEX idConsulta
ON Consultas(id);

CREATE INDEX nomeAnimal
ON Animais(nome);

CREATE INDEX nomeMedico
ON Medicos(nome);