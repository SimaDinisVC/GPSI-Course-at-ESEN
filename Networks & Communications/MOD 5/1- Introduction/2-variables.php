<!doctype html>
<html lang="pt-pt">
    <head>
    <meta charset="utf-8">
    <title>Variáveis</title>
    <style>
		.perigo {
			color: red;
		}
		.avanco {
			text-indent: 20px;
		}
	</style>
</head>
<body>
   	<h1>Aplicação de variáveis</h1>
    <?php
      /*
			Todas as palavras reservadas em PHP são case-sensitive

        	As variáveis guardam valores, estas podem ser dos seguintes tipos:
            	string, integer, double, array, object, boolean, NULL
          
            Exemplos:
                $x = 20;	// $x representa uma váriável do tipo inteiro

                # uma string deve estar envolvida entre aspas ou plicas.
                $x = 'This is a string';

    	*/

        // Definição de variáveis
        $ano = 2015;
        $media = 88;
        $titulo = 'Relatório de Compras';

        // Endereço do utilizador
        $rua = "Rua dos Capitães, 4";
        $cidade = "Viseu";
        $cod_postal = 3505;

        // Imprime o endereço
        echo "<p>O endereço é:<br />$rua <br />$cod_postal $cidade</p>";

        // Nome do utilizador
        $nome = 'Ricardo';
        $apelido = "Ramos";

        // Aspas e plicas não são a mesma coisa, verifique a diferença
        $nome1 = '$nome $apelido';
        $nome2 = "$nome $apelido";

        // Aspas e plicas não são a mesma coisa, embora representem strings
		// Utilizando aspas
        echo "<h1>Aspas</h1>
				<p class=\"perigo avanco\">Nome do utilizador (versão 1): $nome1 </p>
                <p class=\"avanco\">Nome do utilizador (versão 2): $nome2</p>";
                
        // Utilizando aspas e plicas
        echo "<h1>Aspas outra versão</h1>
				<p class='perigo avanco'>Nome do utilizador (versão 1): $nome1 </p>
				<p class='avanco'>Nome do utilizador (versão 2): $nome2</p>";

        // Utilizando plicas. Analisa o comportamento desta função echo!!!
        echo '<h1>Plica</h1>
				<p>nome1 é $nome1 <br /> name2 é $nome2</p>';

        // Outra forma de escrita recorrendo à concatenação
		echo "<h1>Aspas concatenação</h1>
				<p class=\"perigo avanco\">Nome do utilizador (versão 1) " . $nome1 . "</p>
				<p class=\"avanco\">Nome do utilizador (versão 2) " . $nome2 . "</p>";
    ?>
</body>
</html>