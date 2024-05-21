<?php

    include '../../database/config.php';

    $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
    $link = new PDO($db, DB_USERNAME, DB_PASSWORD);

    $sql = "DELETE FROM setor WHERE id_setor = :id";
    $result = $link->prepare($sql);
    $data = array(':id' => $_GET['id_setor']);
    $result->execute($data);

    header("Location: ../");
    exit();

?>