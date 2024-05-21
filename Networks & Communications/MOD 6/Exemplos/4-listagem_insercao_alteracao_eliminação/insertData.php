<?php
include_once("functions.php");
$con = pdo_connect_mysql();

// obtém os valores submetidos pelo formulário
$author = $_POST['inputAuthor'];
$message = $_POST['inputMessage'];

$sql = "INSERT INTO comments (id, author, message) VALUES (NULL, '$author', '$message')";
$result = $con->query($sql);
if($result){
    if($result->num_rows == 1) echo true;    // marca sucesso
    else echo false;  // marca falha
}

// Close connection
unset($con);

?>