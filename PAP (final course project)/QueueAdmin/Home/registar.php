<?php
    session_start();

    include '../database/config.php';

    $sql = "SELECT * FROM admin WHERE Email = :email";
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
                $sql = "INSERT INTO admin (Email, Password) VALUES (:email, :password)";
                $stmt = $link->prepare($sql);

                $stmt->bindParam(":email", $email);
                $stmt->bindParam(":password", $password);
                
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