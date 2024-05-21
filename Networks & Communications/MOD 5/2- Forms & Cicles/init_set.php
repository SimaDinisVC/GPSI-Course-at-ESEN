<!doctype html>
<html lang="pt-pt">
    <head>
    <meta charset="utf-8">
    <title>Receção dos dados</title>
	<style>
		.marca{
            color:red; 
            background:yellow;
        }
	</style>
</head>

<body>
<?php
    /* 
            Error reporting é uma diretiva de configuração que deverá estar ativa
            somente durante o desenvolvimento da aplicação e nunca deverá permanecer
            ativa numa aplicação em produção.
            
            No ficheiro php.ini deve colocar-se error_reporting=E_ALL
            Quando uma aplicação entra em produção, é importante que o utilizador 
            não visualize mensagens de erro não controladas, podem revelar 
            informações sensíveis.
            
            Também por este motivo, display_errors=on só quando deve passar a off (produção).
            
            Uma forma de evitar a visualização dos erros no browser consiste no envio dos
            mesmos para um ficheiro:
            error_log=path/php_erro.log
            
            As diretivas podem ser definidas em tempo de execução com a função ini_set, 
            caso não seja possível aceder e/ou modificar o ficheiro de configuração php.ini
            
            Formato: init_set('diretiva', 'valor');
            
            ini_set('log_errors', 'On');
            ini_set('error_log', '/logs/erro_log');
            ini_set('error_reporting', E_ALL | E_STRICT);
    */

    // define em tempo de execução a diretiva display_errors=on (modo de desenvolvimento)
    ini_set ('display_errors', 1);

    // Mostra todos os problemas!
    error_reporting (E_ALL | E_STRICT);

    // Guarda os dados do formulário em variáveis
    // Obtém os dados do array associativo $_POST - falaremos de arrays mais tarde.
    $titulo         = $_POST['titulo'];
    $nome           = $_POST['nome'];
    $resposta       = $_POST['resposta'];
    $comentarios    = $_POST['comentarios'];

    // Visualiza os dados recebidos:
    echo "<p class=\"marca\">Obrigado, $titulo $nome pelos comentários.</p>
           <p class=\"marca\">Considerou a informação como '$resposta' e adicionou o comentário:<br /><b>$comentarios</b></p>";
?>
</body>
</html>
