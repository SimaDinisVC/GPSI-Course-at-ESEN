<?php
include '../database/config.php';

$db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
$link = new PDO($db, DB_USERNAME, DB_PASSWORD);

$data = [
    ":inputEmail" => $_POST['inputEmail'],
    ":inputNome" => $_POST['inputNome'],
    ":inputPass" => $_POST['inputPass']
];

// Aconselha-se a usar parâmetros, assim melhoras este exemplo.
$sql = "INSERT INTO users (email, nome, password, cargo) VALUES (:inputEmail, :inputNome, :inputPass, 'gestor')";
$result = $link->prepare($sql);
if($result->execute($data)){
    if($result->rowCount() == 1) echo true;    // marca sucesso
    else echo false;  // marca falha
}

// Close connection
unset($con);

?>