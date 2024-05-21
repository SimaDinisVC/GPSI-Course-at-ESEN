<?php
/**
 * Date: 2020-10-05
 * Update: 2021-11-15
 * Author: Adelino Amaral
 */

 // Insira as credenciais de uma conta válida no servidor
define('DB_SERVER', 'localhost');
define('DB_USERNAME', 'SimaDinisVC');
define('DB_PASSWORD', 'simao78910');
define('DB_NAME', 'company');

/**
 * Cria uma ligação ao servidor
 * 
 * $pdo = new PDO("mysql:host=hostname;dbname=database", "username", "password");
 * Descrição dos parâmetros:
 * localhost: localhost ou IP do servidor MySQL, 
 * username e password representam as credenciais de acesso ao servidor MySQL
 * database nome da base dedados.
 */ 
try{
    // define a string para o DNS - data source name, com reconhecimento dos
    // caracteres em português.
    $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 

    $link = new PDO($db, DB_USERNAME, DB_PASSWORD);

    // Set the PDO error mode to exception
    // Define o atributo PDO::ATTR_ERRMODE como PDO::ERRMODE_EXCEPTION, informa o PDO para 
    // lançar exceções sempre que ocorrer um erro na base de dados.
    $link->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    //$mysqli->set_charset("utf8");

    // Informação do host
    //echo "Ligação realizada com sucesso. Informação do Host: " . $link->getAttribute(constant("PDO::ATTR_CONNECTION_STATUS"));

    // Fecha a ligação à base de dados. Também poderá usar a função unset().
    // $link = null;
    // No entanto, a conexão com o servidor de base de dados MySQL será encerrada automaticamente 
    // assim que a execução do script terminar.

} catch(PDOException $e){
    
    // define a mensagem de erro ocorrida
    // Há outros métodos que poderam explorar: getCode(), getFile(), getLine(), getTrace(), getTraceAsString()

    die("ERRO: Não foi possível estabelecer a ligação. " . $e->getMessage());
}
?>