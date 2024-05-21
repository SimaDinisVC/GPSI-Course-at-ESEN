<?php
    session_start();

    include '../database/config.php';

    $sql = "SELECT * FROM users WHERE email = :email AND cargo = :cargo";
    $stmt = $link->prepare($sql);
    $stmt->bindParam(":email", $email);
    $stmt->bindParam(":cargo", $cargo);

    $email = $_POST['emailInput'];
    $cargo = $_POST['cargoInput'];

    $stmt->execute();
    if($stmt->rowCount() == 0) {
        unset($stmt);
        unset($link);
        header("Location: ./?content=EmailNotFound");
        exit();
    }
    $row = $stmt->fetch();

    if($_POST['passwordInput'] != $row["password"]) {
        unset($stmt);
        unset($link);
        header("Location: ./?content=PasswordNotMatch");
        exit();
    }

    // Login Accepted

    $_SESSION['loggedin'] = true;
    $_SESSION['loggedID'] = $row["userID"];
    $_SESSION['cargo'] = $_POST['cargoInput'];
    
    if (isset($_POST['remember']) && $_POST['remember'] == true) { // if user checked remember's button
        $randomBytes = random_bytes(16); // Generate 16 bytes of data randomly
        $randomId = bin2hex($randomBytes); // parse to hexadecimal data

        // create a cookie with the time setted for 1 day
        setcookie("loggedUserSessionID", $randomId, time()+86400, "/");
        
        unset($stmt);
        $sql = "UPDATE users SET cookieID = :cookieID WHERE userID=:userID";
        $stmt = $link->prepare($sql);

        $stmt->bindParam(":cookieID", $randomId);
        $stmt->bindParam(":userID", $_SESSION['loggedID']);

        $stmt->execute();
    }

    header("Location: ../DashBoard/");
    exit();
?>