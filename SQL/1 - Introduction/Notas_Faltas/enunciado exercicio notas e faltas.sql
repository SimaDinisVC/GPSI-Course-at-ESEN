/*inserir os alunos(nome,datanascimento)
7, 2000/10/10
8, 1999/1/5
9, 2001/2/20*/

/*inserir as disciplinas(nome,nrmodulos,limitefaltas)
4, 19, 12
5, 6, 6
6, 8, 4*/

/*inserir os professores(nome,data_nascimento,genero,grupo)
4,1970/1/10,m,informática
5,1968/2/5,f,5
professor3,1971/3/1,m,6*/

/*inserir as notas(nprocesso_aluno,codigo_disciplina,data,modulo,valor,n_professor) atenção às FK que podem ser diferentes
7, 4, 2017/9/15, 14, 10, 4
8, 4, 2017/9/15, 14, 14, 4
9, 4, 2017/9/15, 14, 13, 4
7, 5, 2017/9/15, 3, 12, 5
8, 5, 2017/9/15, 3, 12, 5
9, 5, 2017/9/15, 3, 12, 5
7, 5, 2017/11/15, 4, 10, 5
8, 5, 2017/11/15, 4, 12, 5
9, 5, 2017/11/15, 4, 11, 5
7, 6, 2017/11/15, 4, 18, 5
8, 6, 2017/11/15, 4, 17, 5
9, 6, 2017/11/15, 4, 16, 5
9, 6, 2017/11/15, 5, 16, 5
*/


/*inserir as seguintes faltas(nprocesso_aluno,codigo_disciplina,data,tipo) atenção às FK que podem ser diferentes
7,4,2017/10/23,J
7,5,2017/10/23,J
8,4,2017/9/25,I
*/


/*listar todos os alunos que nasceram no ano 2000*/


/*listar todos os alunos com a sua idade ordenados por ordem crescente de idade*/

/*média das idades*/

/*número de disciplinas*/

/*lista com nomes de professores e alunos*/

/*nome do professor mais velho e a sua idade*/

/*número de professores por grupo*/

/*número de faltas por tipo*/

/*número de faltas por aluno,
mostrar nome do aluno*/

/*listar o valor da nota, o nome do aluno,
o nome da disciplina 
e o nome do professor*/

/*média de notas por disciplina*/

/*média de notas por professor*/

/*nome dos alunos que nunca faltaram*/

/*nome dos professores ordenados 
por ordem descendente da média 
das notas que lançam*/

/*nome dos alunos com média 
de notas superior à média*/

/*número de módulos por fazer por aluno*/

/*número de módulos por fazer por aluno 
por disciplina*/

/*Maiusculas vs Minusculas*/
select * from aluno
where nome='JOAQUIM'
collate Latin1_General_CS_AS

select * from aluno
where nome='MANUELA'
collate Latin1_General_CS_AS
and genero='F'
collate Latin1_General_CS_AS

/*valor de um identity*/
insert into aluno(nome,datanascimento)values
('daniela','2000-01-01');select scope_identity()


select * from sys.tables

select * from sys.sysobjects

select * from sys.fn_helpcollations()

