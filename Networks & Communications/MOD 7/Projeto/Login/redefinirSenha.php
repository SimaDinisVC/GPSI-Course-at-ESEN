<?php
    session_start();

    include '../database/config.php';

    // Verify if the token exists in the database
    $sql = "SELECT * FROM users WHERE passwordToken = :token";
    $stmt = $link->prepare($sql);
    $stmt->bindParam(":token", $token);

    $token = $_POST['token'];

    $stmt->execute();
    if($stmt->rowCount() != 1) {
        unset($stmt);
        unset($link);
        header("Location: ./?content=EmailNotFound");
        exit();
    }
    unset($stmt);


    $sql = "UPDATE users SET password = :password, passwordToken = NULL WHERE passwordToken = :token";
    $stmt = $link->prepare($sql);
    $stmt->bindParam(":password", $password);
    $stmt->bindParam(":token", $token);

    $password = $_POST['ResetPasswordInput'];

    $stmt->execute();

    unset($stmt);
    unset($link);
    header("Location: ./?content=PasswordChangedSuccessfully");
    exit();
?>