<?php
if(isset($_GET["fname"]) && isset($_GET["lname"])) {
    $fname = htmlspecialchars($_GET["fname"]);
    $lname = htmlspecialchars($_GET["lname"]);
    
    // Cria o nome completo pela junção do nome e apelido
    $fullname = $fname . " " . $lname;

    // Visualiza a mensagem
    echo "Olá, $fullname! Bem-vindo ao nosso website.";
} else {
    echo "Bem-vindo ao nosso website.";
}
?>
