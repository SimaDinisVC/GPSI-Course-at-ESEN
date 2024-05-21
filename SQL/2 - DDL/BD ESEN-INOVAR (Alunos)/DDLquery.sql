CREATE TABLE Aluno (
	N_Processo VARCHAR(40) PRIMARY KEY CHECK(N_Processo LIKE 'a%'),
	Nome VARCHAR(50) NOT NULL,
	Sexo VARCHAR(10) NOT NULL,
	DataNasc DATETIME NOT NULL,
	Validade DATETIME NOT NULL,
	TipoID VARCHAR(10) NOT NULL CHECK(TipoID LIKE 'BI' OR TipoID LIKE 'NIF'),
	NIF INT NOT NULL UNIQUE CHECK(NIF > 100000000 AND NIF < 999999999),
	IBAN VARCHAR(25) NOT NULL UNIQUE CHECK(IBAN LIKE 'PT50%'),
	NIB INT NOT NULL UNIQUE CHECK(NIB > 100000000000000000000 AND NIB < 999999999999999999999),
	BIC VARCHAR(11) NOT NULL UNIQUE CHECK(LEN(BIC) = 8 OR LEN(BIC) = 11),
	N_AbonoFamilia INT NOT NULL CHECK(LEN(N_AbonoFamilia) = 9),
	Naturalidade VARCHAR(30) NOT NULL,
	Nacionalidade VARCHAR(20) NOT NULL,
	Distrito VARCHAR(30) NOT NULL,
	Concelho VARCHAR(30) NOT NULL,
	Freguesia VARCHAR(30) NOT NULL,
	N_AgregadoFamiliar INT NOT NULL,
	Transporte VARCHAR(20) NOT NULL CHECK(Transporte IN ('A pé', 'Carro', 'Autocarro', 'Comboio')),
	Percurso FLOAT NOT NULL,
	SistemaSaude VARCHAR(30) NOT NULL,
	N_Beneficiario INT NOT NULL CHECK(LEN(N_Beneficiario) = 9)
);

CREATE TABLE Contacto (
	id_contacto INT PRIMARY KEY IDENTITY,
	Residencia VARCHAR(50) NOT NULL,
	Distrito VARCHAR(30) NOT NULL,
	Concelho VARCHAR(30) NOT NULL,
	Freguesia VARCHAR(30) NOT NULL,
	CodigoPostal VARCHAR(8) NOT NULL CHECK(CodigoPostal LIKE '####-###'),
	Telefone INT NOT NULL CHECK(LEN(Telefone) = 9),
	Telemovel INT NOT NULL CHECK(LEN(Telemovel) = 9),
	Fax INT NOT NULL CHECK(LEN(Fax) = 9),
	CorreioEletronico VARCHAR(40) NOT NULL CHECK(CorreioEletronico LIKE '%@%.%'),
	Aluno VARCHAR(40) NOT NULL,
	FOREIGN KEY (Aluno) REFERENCES Aluno(N_Processo)
);

CREATE TABLE Progenitores (
	NIF INT PRIMARY KEY CHECK(LEN(NIF) = 9),
	NivelParentesco VARCHAR(3) NOT NULL CHECK(NivelParentesco IN ('Mãe', 'Pai')),
	Nome VARCHAR(50) NOT NULL,
	Telefone INT NOT NULL CHECK(LEN(Telefone) = 9),
	Telemovel INT NOT NULL CHECK(LEN(Telemovel) = 9),
	Naturalidade VARCHAR(30) NOT NULL,
	Nacionalidade VARCHAR(20) NOT NULL,
	FormacaoAcademica VARCHAR(15) NOT NULL CHECK(FormacaoAcademica IN ('9ºano', 'Licenciatura', 'Mestrado', 'Doutoramento')),
	Profissao VARCHAR(40) NOT NULL,
	LocalTrabalho VARCHAR(50) NOT NULL,
	CorreioEletronico VARCHAR(40) NOT NULL CHECK(CorreioEletronico LIKE '%@%.%'),
	Aluno VARCHAR(40) NOT NULL,
	FOREIGN KEY (Aluno) REFERENCES Aluno(N_Processo)
);

CREATE TABLE Curso (
	id_curso INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) NOT NULL UNIQUE,
	TemposTotais INT NOT NULL
);

CREATE TABLE Matricula (
	id_matricula INT PRIMARY KEY IDENTITY,
	AnoTurma VARCHAR(4) NOT NULL CHECK(AnoTurma LIKE '%º_'),
	DataMatricula DATETIME NOT NULL,
	AnoLetivo VARCHAR(9) NOT NULL CHECK(AnoLetivo LIKE '####/####'),
	Aluno VARCHAR(40) NOT NULL,
	Curso INT NOT NULL,
	FOREIGN KEY (Aluno) REFERENCES Aluno(N_Processo),
	FOREIGN KEY (Curso) REFERENCES Curso(id_curso)
);

CREATE TABLE Disciplina (
	id_disciplina INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(20) NOT NULL UNIQUE,
	Turnos BIT NOT NULL
);

CREATE TABLE Módulos (
	id_modulo INT PRIMARY KEY IDENTITY,
	n_modulo INT NOT NULL UNIQUE,
	disciplina INT NOT NULL,
	FOREIGN KEY (disciplina) REFERENCES Disciplina(id_disciplina)
);