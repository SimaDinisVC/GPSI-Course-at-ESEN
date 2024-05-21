-- 1
--SELECT DISTINCT Nome FROM Produtos

-- 2
--SELECT Referencia, Nome, Preco * Taxa_Iva AS Valor_IVA FROM Produtos

-- 3
--SELECT Referencia, Nome, Preco + Preco * Taxa_Iva AS Valor_Pagar FROM Produtos

-- 4
--SELECT AVG(Preco) AS MEDIA FROM Produtos

-- 5
--SELECT * FROM Produtos
--WHERE Tipo='Limpeza';

-- 6
--SELECT * FROM Produtos
--WHERE GETDATE() > Data_validade;

-- 7
--SELECT * FROM Produtos
--WHERE MONTH(GETDATE()) = MONTH(Data_validade) AND YEAR(GETDATE()) = YEAR(Data_validade);

-- 8
--SELECT Tipo, COUNT(Tipo) AS N_Produtos FROM Produtos
--GROUP BY(Tipo);

-- 9
--SELECT * FROM Produtos
--WHERE Tipo = 'Bebidas' AND (Preco + (Preco * Taxa_Iva)) < 5;

-- 10
--SELECT * FROM Produtos
--WHERE Tipo = 'Charcutaria' OR Tipo = 'Enlatados';

-- 11
--SELECT * FROM Produtos
--WHERE Desconto IS NULL;

-- 12
--SELECT * FROM Produtos
--WHERE (Preco + (Preco * Taxa_Iva)) > 5 AND (Preco + (Preco * Taxa_Iva)) < 10;

-- 13
--SELECT * FROM Produtos
--WHERE Preco > (SELECT AVG(Preco) FROM Produtos);

-- 14
--SELECT SUM(Stock) AS Stock_Total FROM Produtos

-- 15
--SELECT Nome FROM Produtos
--WHERE Stock = (SELECT MAX(Stock) FROM Produtos);

-- 16
--SELECT COUNT(*) AS N_Registos FROM Produtos

-- 17
--SELECT Nome FROM Produtos
--WHERE Stock = (SELECT MIN(Stock) FROM Produtos);

-- 18
--SELECT P.Nome AS PROD_Nome, R.Nome AS REP_Nome FROM Produtos AS P, Repositores AS R
--WHERE P.Repositor = R.NIF;

-- 19
--SELECT * FROM Produtos
--WHERE Preco > (SELECT AVG(Preco) FROM Produtos);

-- 20
--SELECT Nome, Preco + Preco * Taxa_Iva AS Valor FROM Produtos
--WHERE Stock > 0;

-- 21
--SELECT NIF, R.NOME FROM Produtos As P
--RIGHT JOIN Repositores AS R
--ON P.Repositor = R.NIF 
--WHERE P.Repositor IS NULL

-- 22
--SELECT Loja AS Localidade, COUNT(*) AS N_Lojas FROM Repositores
--GROUP BY(Loja);

-- 23
--SELECT MAX(Loja) AS LojaMaisVisitada FROM Repositores

-- 24
--SELECT Loja AS Localidade, AVG(DATEDIFF(year, Data_Nascimento, GETDATE())) AS MédiaIdade FROM Repositores
--GROUP BY(Loja);

-- 25
--UPDATE Repositores
--SET Data_Nascimento = '12/03/2002'

-- 26
--UPDATE Produtos 
--SET Preco = Preco - (Preco * 0.1)
--WHERE GETDATE() > Data_validade;

-- 27
--SELECT * FROM Repositores
--WHERE Hora_Saida - Hora_Entrada = (SELECT MAX(Hora_Saida - Hora_Entrada) FROM Repositores);

-- 28
--SELECT * FROM Repositores
--WHERE LEN(Nome) = (SELECT MAX(LEN(NOME)) FROM Repositores);

-- 29
--SELECT Preco FROM Produtos
--WHERE Fornecedor LIKE '%b';

-- 30
--DELETE FROM Produtos
--WHERE GETDATE() > Data_validade;