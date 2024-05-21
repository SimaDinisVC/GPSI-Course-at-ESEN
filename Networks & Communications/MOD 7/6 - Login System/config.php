<?php
define('DB_SERVER', 'localhost');
define('DB_USERNAME', 'SimaDinisVC');
define('DB_PASSWORD', 'simao78910');
define('DB_NAME', 'company');

/* Attempt to connect to MySQL database */
try{
    $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
    $link = new PDO($db, DB_USERNAME, DB_PASSWORD);
    // Set the PDO error mode to exception
    $link->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch(PDOException $e){
    die("ERROR: Problemas na ligação ao servidor. " . $e->getMessage());
}
?>