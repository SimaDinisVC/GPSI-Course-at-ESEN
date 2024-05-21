<?php
    session_start();

    include '../database/config.php';

    $sql = "SELECT * FROM users WHERE email = :email";
    if($stmt = $link->prepare($sql)) {
        $stmt->bindParam(":email", $email);

        $email = $_POST['emailInput'];
        if($stmt->execute()) {
            if($stmt->rowCount() == 1){
                unset($link);
                unset($stmt);
                header("Location: ./?content=EmailAlreadyUsed");
                exit();
            }
            else{
                unset($stmt);
                $sql = "INSERT INTO users (email, nome, password, cargo) VALUES (:email, :nome, :password, :cargo)";
                $stmt = $link->prepare($sql);

                $stmt->bindParam(":email", $email);
                $stmt->bindParam(":nome", $nome);
                $stmt->bindParam(":password", $password);
                $stmt->bindParam(":cargo", $cargo);
                
                $password = $_POST['passwordInput']; // password encrypt
                $cargo = 'admin';

                $stmt->execute();
            }
        }
    }
    unset($link);
    unset($stmt);

    header("Location: ./");
    exit();
?>