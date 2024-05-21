-- 1
--SELECT value AS Jogador FROM Jogadores
--CROSS APPLY STRING_SPLIT(Nome, ' ')
--WHERE Clube_Atual = 'F.C.Porto';

-- 2
--SELECT Nome FROM Clubes
--WHERE YEAR(GETDATE()) - Ano_Formacao >= 100;

-- 3
--SELECT Nome FROM Clubes
--WHERE Ano_Formacao = (SELECT MIN(Ano_Formacao) FROM Clubes);

-- 4
--SELECT Nome, Nacionalidade FROM Jogadores
--WHERE Nacionalidade != 'Portugal'
--ORDER BY Nome;

-- 5
--SELECT value AS ClubeSEMvitoria FROM Clubes
--CROSS APPLY STRING_SPLIT(Nome, ' ')
--WHERE Nome LIKE '%Vitória%' AND value != 'Vitória';

-- 6
--SELECT Nome, Posicao FROM Jogadores
--WHERE Clube_Atual = 'S.L.Benfica' AND DATEDIFF(year, Data_Nascimento, GETDATE()) > 30;

-- 7
--SELECT N_Jogador FROM Jogadores
--WHERE Posicao = 'Guarda Redes';

-- 8
--SELECT COUNT(*) AS nJogadoresEst1LigaANO FROM Jogadores
--WHERE Nacionalidade != 'Portugal' AND Clube_Atual IN (SELECT Nome_Clube FROM Clubes_Campeonatos WHERE 'Liga_Zon_Sagres_2018' = Cod_Campeonato);

-- 9
--SELECT SUM(N_Jogos) AS N_Jogos FROM Historico_Jogadores_Campeonatos
--WHERE N_Jogador = (SELECT N_Jogador From Jogadores WHERE Nome = 'Fábio Coentrão');

-- 10
--SELECT SUM(N_Jogos) / COUNT(N_Jogador) AS N_Jogos FROM Historico_Jogadores_Campeonatos
--WHERE N_Jogador = (SELECT N_Jogador From Jogadores WHERE Nome = 'Jonas' AND Clube_Atual = 'S.L.Benfica');

-- 11
--SELECT A.Nome, SUM(B.N_Jogos) AS N_Jogos FROM Jogadores AS A, Historico_Jogadores_Campeonatos AS B
--WHERE B.N_Jogador = (SELECT N_Jogador From Jogadores WHERE Nome = A.Nome AND Clube_Atual = A.Clube_Atual)
--GROUP BY(A.Nome);

-- 12
--SELECT Data, CONCAT(Golos_Equipa_Visitada,'-', Golos_Equipa_Visitante) AS Resultado FROM Jogos
--WHERE Nome_Equipa_Visitada = 'S.L.Benfica' AND Nome_Equipa_Visitante = 'F.C.Porto' OR Nome_Equipa_Visitada = 'F.C.Porto' AND Nome_Equipa_Visitante = 'S.L.Benfica';

-- 13
--SELECT Nome FROM Jogadores
--WHERE Clube_Atual = 'S.L.Benfica';

-- 14
--SELECT SUM(N_Jogos) AS N_JogosSporting2018 FROM Historico_Jogadores_Campeonatos
--WHERE Nome_Clube = 'Sporting' AND Cod_Campeonato = 'Liga_Zon_Sagres_2018';

-- 15
--SELECT cc.Nome_Clube FROM Campeonatos as c 
--INNER JOIN Clubes_Campeonatos as cc 
--ON c.Cod_Campeonato = cc.Cod_Campeonato 
--WHERE c.Divisao = 'Primeira';

-- 16
--SELECT SUM(Golos_Equipa_Visitante) as Total_De_Golos_Sporting FROM Jogos 
--WHERE Nome_Equipa_Visitante = 'Sporting'; 

-- 17
--SELECT Nome FROM Jogadores 
--WHERE Clube_Atual = 'F.C.Porto' AND Lesionado = 'True';

-- 18
--SELECT c.Epoca FROM Campeonatos as c 
--INNER JOIN Clubes_Campeonatos as cc 
--ON c.Cod_Campeonato = cc.Cod_Campeonato 
--WHERE Nome_Clube = 'Maritimo' ORDER BY Posicao ;

-- 19
--SELECT TOP 2 cc.Pontos, cc.Nome_Clube FROM Campeonatos as c 
--INNER JOIN Clubes_Campeonatos as cc 
--ON c.Cod_Campeonato = cc.Cod_Campeonato 
--WHERE cc.Cod_Campeonato = 'Liga_Zon_Sagres_2016' 
--ORDER BY cc.Pontos;

-- 20
--SELECT Nome_Equipa_Visitada, Nome_Equipa_Visitante, Data FROM Jogos 
--WHERE Campeonato = 'Liga_Zon_Sagres_2017' 
--ORDER BY Data;

-- 21
--SELECT A.Cod_Campeonato, B.Nome_Clube FROM Campeonatos AS A, Clubes_Campeonatos AS B
--WHERE A.Epoca = 2018 AND B.Nome_Clube = (SELECT B.Nome_Clube WHERE Posicao = 1 AND B.Cod_Campeonato = A.Cod_Campeonato);

-- 22
--SELECT * FROM Jogos
--WHERE Espetadores > (SELECT AVG(Espetadores) FROM Jogos);

-- 23
--SELECT TOP 3 * FROM Jogos
--ORDER BY Espetadores DESC;

-- 24
--SELECT Nome_Clube FROM Clubes_Campeonatos
--WHERE Cod_Campeonato = 'Liga_Zon_Sagres_2016' AND Posicao BETWEEN 1 AND 2;

-- 25
--SELECT *, DATEDIFF(day, GETDATE(), Data) AS DiasRestantes FROM Jogos
--WHERE DATEDIFF(day, GETDATE(), Data) > 0;

-- 26
--SELECT Data, Nome_Equipa_Visitada, Nome_Equipa_Visitante, Estadio FROM Jogos
--WHERE YEAR(Data) = 2017;

-- 27
--SELECT AVG(Espetadores) FROM Jogos
--WHERE YEAR(Data) = 2018;

-- 28
--SELECT Nome, Clube_Atual, Posicao FROM Jogadores
--ORDER BY Clube_Atual, Posicao DESC

-- 29
--SELECT Nome, Clube_Atual FROM Jogadores 
--WHERE (DATEDIFF(YEAR, data_nascimento, GETDATE())) >= 18 and (DATEDIFF(YEAR, data_nascimento, GETDATE())) <= 20;

-- 30
--SELECT N_Jogo, (Espetadores * 2.5) as Valor_a_pagar_bilhetes FROM Jogos 
--WHERE Estadio LIKE '%Municipal%'

-- 31
--SELECT Nome_Equipa_Visitada, Nome_Equipa_Visitante, ABS(Golos_Equipa_Visitada - Golos_Equipa_Visitante) AS Diferenca_Golos FROM Jogos 
--WHERE Nome_Equipa_Visitada = 'S.L.Benfica' OR Nome_Equipa_Visitante = 'S.L.Benfica'
--ORDER BY ABS(Golos_Equipa_Visitada - Golos_Equipa_Visitante)

-- 32
--SELECT Nome, Clube_Atual, (DATEDIFF(YEAR, data_nascimento, GETDATE()) + 5) AS Idade_daqui_a_5anos FROM Jogadores 

-- 33
--SELECT Nome_Equipa_Visitada, Nome_Equipa_Visitante FROM Jogos 
--WHERE Estadio = 'Municipal Braga' OR Estadio = 'Alvalade' OR Estadio = 'Luz' OR Estadio = 'Dragão'

-- 34
--SELECT cc.Nome_Clube, c.Divisao FROM Clubes_Campeonatos as cc 
--INNER JOIN Campeonatos as c ON c.Cod_Campeonato = cc.Cod_Campeonato
--WHERE c.Cod_Campeonato LIKE '%2018'
--ORDER BY c.Divisao, cc.Nome_Clube

-- 35
--SELECT cc.Nome_Clube, c.Cod_Campeonato, c.Divisao 
--FROM Clubes_Campeonatos as cc 
--INNER JOIN Campeonatos as c ON c.Cod_Campeonato = cc.Cod_Campeonato
--WHERE cc.Nome_Clube = 'Académico Viseu'