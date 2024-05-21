<?php
    include '../../database/config.php';

    $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
    $link = new PDO($db, DB_USERNAME, DB_PASSWORD);

    $sql = "DELETE FROM estabelecimento WHERE id_loja = :id";
    $result = $link->prepare($sql);
    $data = array(':id' => $_GET['id']);
    echo $data;


    if($result->execute($data)){
        header("Location: ../");
        exit();
    }

?>