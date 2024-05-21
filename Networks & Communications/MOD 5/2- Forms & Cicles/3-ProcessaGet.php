<!doctype html>
<html lang="pt-pt">
    <head>
    <meta charset="utf-8">
    <title>Recebe dados</title>
</head>

<body>
<?php

    /* 
        Esta página recebe os dados pela URL, vindo do ficheiro 3-ObterDadosGet.php
        Observe a url deste ficheiro no browser...

        $_GET[] - obtém dados a partir da URL.
        $_GET['nome'] - guarda o valor do parâmetro nome.

        EXECUTA E ANALISA O CÓDIGO APRESENTADO. DE SEGUIDA RESPONDE ÀS NOTAS
        APRESENTADAS EM MAIÚSCULAS.
    */
    
    // obtém os dados atribudos aos parâmetros
    if(!empty($_GET['nome'])) {

        // o parâmetro idade pode não ter sido enviado na url.
        // QUAL A MELHOR FUNÇÃO A APLICAR NESTE CASO, A FUNÇÃO ISSET() OU EMPTY() ? PORQUÊ.
		if(empty($_GET['idade'])){
			$idade = "??";
		}
		else {
			$idade = $_GET['idade'];
		}
		
        $nome = $_GET['nome'];
        
        echo "Olá " . $nome . " tens " . $idade . " anos";
		
    }
    else {
        echo "<p>O nome do utilizador não existe!!</p>";
    }

	// sleep(5);
	// header("Location: 3-ObterDadosGet.html");
	
?>
	<br>	
	<a href="3-ObterDadosGet.php">Salte para a página anterior</a>
</body>
</html>
