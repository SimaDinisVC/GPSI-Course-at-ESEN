<?php
define('DB_SERVER', 'localhost');
define('DB_USERNAME', 'SimaDinisVC');
define('DB_PASSWORD', 'simao78910');
define('DB_NAME', 'queuepro');

try{
    $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 

    // Create a connection to the server MySQL
    $link = new PDO($db, DB_USERNAME, DB_PASSWORD);

    // Set the PDO error mode to exception
    $link->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    // Informação do host
    $link->getAttribute(constant("PDO::ATTR_CONNECTION_STATUS"));

    // Fecha a ligação à base de dados. Também poderá usar a função unset($link).
    // $link = null;

} catch(PDOException $e){
    die("ERROR: It was not possible to make a connection." . $e->getMessage());
}
?>