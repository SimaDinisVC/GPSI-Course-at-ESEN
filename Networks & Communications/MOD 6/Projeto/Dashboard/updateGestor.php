<?php
include '../database/config.php';

$db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
$link = new PDO($db, DB_USERNAME, DB_PASSWORD);

$data = [
    ":idRegisto" => $_POST['registoId'],
    ":inputNome" => $_POST['nomeEmpregado'],
    ":inputPass" => $_POST['senhaEmpregado']
];

// Aconselha-se a usar parâmetros, assim melhoras este exemplo.
$sql = "UPDATE users SET  nome = :inputNome, password = :inputPass) WHERE userID = :idRegisto ";
$result = $link->prepare($sql);
if($result->execute($data)){
    if($result->rowCount() == 1) echo true;    // marca sucesso
    else echo false;  // marca falha
}

// Close connection
unset($con);
?>