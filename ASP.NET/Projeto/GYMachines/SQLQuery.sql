﻿--CREATE TABLE Utilizadores (
--	Username VARCHAR(50) PRIMARY KEY NOT NULL,
--	pass VARCHAR(200) NOT NULL,
--	nome VARCHAR(100),
--	perfil VARCHAR(100) CHECK(perfil LIKE 'cliente' OR perfil LIKE 'admin'),
--  email VARCHAR(255) NOT NULL
--);

--CREATE TABLE Compras (
--	ID INT PRIMARY KEY IDENTITY,
--	Data DATE DEFAULT (getdate()),
--	Total FLOAT NOT NULL,
--	id_cliente VARCHAR(50) FOREIGN KEY REFERENCES Utilizadores(Username),
--	finalizada BIT DEFAULT 0,
--	estado VARCHAR(30) DEFAULT 'Espera confirmação' NOT NULL,
--);

--CREATE TABLE Maquinas (
--	ID INT PRIMARY KEY IDENTITY,
--	Marca VARCHAR(30) NOT NULL,
--	Modelo VARCHAR(100) NOT NULL,
--	GrpMuscular VARCHAR(150) NOT NULL CHECK(GrpMuscular IN ('pernas', 'costas', 'peito', 'braços')),
--	preco FLOAT NOT NULL,
--	Descricao TEXT NOT NULL
--);

--CREATE TABLE Favoritos (
--	ID INT PRIMARY KEY IDENTITY,
--	Username VARCHAR(50) NOT NULL,
--	id_Produto INT NOT NULL FOREIGN KEY REFERENCES Maquinas(ID)
--);