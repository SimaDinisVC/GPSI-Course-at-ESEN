/*create table Livros(
id int identity (1000,1) primary key,
ISBN char(17) check(ISBN like '___-_-____-____-_'),
Titulo varchar(100) not null,
Autor varchar(50),
Sinopese varchar(max),
Idioma varchar(20) default 'Português',
Genero varchar(30),
Editora varchar(30),
Cota varchar(4),
KeyWords varchar(max),
Disponivel bit default 1,
Ano_edicao smallint,
Data_aquisicao date default getdate(),
Capa image,
Braille bit,
)

Create table Leitores(
N_processo char(6) check (N_processo like 'a_____') primary key,
Nome varchar(100),
CC char(8),
Email varchar(100) check (Email like '%@%.%') unique,
Telemovel char(9) check (len(telemovel)=9 and telemovel like '9[1236]_______'),
Data_nascimento date,
Ativo bit default 1,
Nome_foto varchar(50),
Morada varchar(100),
Cod_Postal char(8) check (Cod_Postal like '____-___' and isnumeric(right(Cod_Postal,3))=1 and isnumeric(left(Cod_Postal,4))=1),
)

Create table Movimentos(
Numero int identity (1,1) primary key,
nprocesso char(6) references Leitores(N_processo),
id_livro int references Livros(id),
Data_levantamento date default getdate(),
Data_entrega date,
OBS varchar(max) default 'Nada a registar',
)*/