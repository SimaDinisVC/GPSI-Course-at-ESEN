<?php
    session_start();

    include '../../database/config.php';

    $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
    $link = new PDO($db, DB_USERNAME, DB_PASSWORD);

    $data = [
        ":Rua" => $_POST['address'],
        ":codigoPostal" => $_POST['cp'],
        ":Localidade" => $_POST['local']
    ];

    $sql = "INSERT INTO morada (Rua, codigoPostal, Localidade) VALUES (:Rua, :codigoPostal, :Localidade)";
    $result = $link->prepare($sql);
    $result->execute($data);

    $id_morada = $link->lastInsertId();
    unset($result);

    $data = [
        ":Rua" => $_POST['nome'],
        ":telefone" => $_POST['telefone'],
        ":AgendarSenhas" => (isset($_POST['AgendarSenhas']))? 1 : 0,
        ":RetirarSenhasApp" => (isset($_POST['RetirarSenhasApp']))? 1 : 0,
        ":RetirarSenhasApenasLoja" => (isset($_POST['RetirarSenhasApenasLoja']))? 1 : 0,
        ":semSetores" => (isset($_POST['semSetores']))? 1 : 0,
        ":idMorada" => $id_morada,
        ":NIF_empresa" => $_SESSION['company']
    ];

    $sql = "INSERT INTO estabelecimento (Nome, telefone, AgendarSenhas, RetirarSenhasApp, RetirarSenhasApenasLoja, semSetores, idMorada, NIF_empresa) 
    VALUES (:Rua, :telefone, :AgendarSenhas, :RetirarSenhasApp, :RetirarSenhasApenasLoja, :semSetores, :idMorada, :NIF_empresa)";
    $result = $link->prepare($sql);
    $result->execute($data);

    header("Location: ../");
    exit();
?>