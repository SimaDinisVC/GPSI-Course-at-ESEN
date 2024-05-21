-- 1
--SELECT * FROM Leitores
--ORDER BY nome ASC;

-- 2
--SELECT AVG(preco) FROM Livros

-- 3
--SELECT Nome FROM Leitores
--WHERE data_nasc = (SELECT MIN(data_nasc) FROM Leitores);
-- ou
----WHERE DATEDIFF(year, data_nasc, GETDATE()) = (SELECT MAX(DATEDIFF(year, data_nasc, GETDATE())) FROM Leitores);

-- 4
--SELECT COUNT(*) AS N_Leitores FROM Leitores

-- 5
--SELECT COUNT(*) AS N_LeitoresAtivos FROM Leitores
--WHERE ativo = 1;

-- 6
--SELECT genero, COUNT(*) AS N_Leitores FROM Leitores
--GROUP BY(genero);

-- 7
--SELECT nome, DATEDIFF(year, data_nasc, GETDATE()) AS Idade FROM Leitores;

-- 8
--SELECT nome, DATEDIFF(year, data_nasc, GETDATE()) AS Idade FROM Leitores
--WHERE DATEDIFF(year, data_nasc, GETDATE()) < 20;

-- 9
--SELECT nome FROM Leitores
--WHERE MONTH(data_nasc) = MONTH(GETDATE());

-- 10
--SELECT * FROM Livros
--WHERE YEAR(data_aquisicao) < ano;

-- 11
--SELECT nome FROM Livros
--ORDER BY preco ASC;

-- 12
--SELECT * FROM Livros
--WHERE estado = 0;

-- 13
--SELECT * FROM Livros
--WHERE preco BETWEEN 2 AND 20;

-- 14
--SELECT nemprestimo, DATEDIFF(day, data_emprestimo, data_devolve) AS dias FROM Emprestimos

-- 15
--SELECT nome FROM Livros
--WHERE nlivro = (SELECT TOP 1 nlivro FROM Emprestimos GROUP BY nlivro ORDER BY COUNT(nlivro) DESC);

-- 16
--SELECT (CONVERT(DECIMAL, COUNT(*)) / COUNT(DISTINCT(nleitor))) AS MédiaEmprestimos FROM Emprestimos;

-- 17
--SELECT A.nome AS NomeLeitor, B.nome AS NomeLivro FROM Emprestimos AS C
--INNER JOIN Leitores AS A 
--ON C.nleitor = A.nleitor
--INNER JOIN Livros AS B
--ON C.nlivro = B.nlivro

-- 18
--SELECT A.nome, COUNT(B.nleitor) AS NEmprestimos FROM Leitores AS A
--LEFT JOIN Emprestimos AS B
--ON A.nleitor = B.nleitor
--GROUP BY(A.nome)

-- 19
--UPDATE Livros 
--SET preco += 0.5;

-- 20
--DELETE Leitores
--WHERE ativo = 0;