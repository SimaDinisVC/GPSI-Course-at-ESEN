<?php
    // eliminar a logo do server caso exista

    include '../../database/config.php';

    $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
    $link = new PDO($db, DB_USERNAME, DB_PASSWORD);

    $sql = "DELETE FROM empresa WHERE NIF = :NIFCompany";
    $result = $link->prepare($sql);
    $data = array(':NIFCompany' => $_GET['NIF']);

    if($result->execute($data)){
        header("Location: ../");
        exit();
    }

?>