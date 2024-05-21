<?php
include_once("functions.php");
$con = pdo_connect_mysql();

// obtém os valores submetidos pelo formulário
$data = [
    ":author" => $_POST['inputAuthor'],
    ":message" => $_POST['inputMessage']
];

// Aconselha-se a usar parâmetros, assim melhoras este exemplo.
$sql = "INSERT INTO comments (author, message) VALUES (:author, :message)";
$result = $con->prepare($sql);
if($result->execute($data)){
    if($result->rowCount() == 1) echo true;    // marca sucesso
    else echo false;  // marca falha
}

// Close connection
unset($con);

?>