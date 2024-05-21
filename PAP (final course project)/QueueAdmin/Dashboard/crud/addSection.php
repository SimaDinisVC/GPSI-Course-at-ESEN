<?php
    session_start();

    include '../../database/config.php';

    $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
    $link = new PDO($db, DB_USERNAME, DB_PASSWORD);
    
    $data = [
        ":letra_indicativa" => $_POST['letra'],
        ":Nome" => $_POST['nome'],
        ":id_loja" => $_SESSION['establishment']
    ];

    $sql = "INSERT INTO setor (letra_indicativa, Nome, id_loja) VALUES (:letra_indicativa, :Nome, :id_loja)";
    $result = $link->prepare($sql);
    $result->execute($data);

    header("Location: ../");
    exit();

?>