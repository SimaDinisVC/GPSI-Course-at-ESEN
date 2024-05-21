<?php
    session_start();

    include '../database/config.php';

    $sql = "SELECT * FROM admin WHERE Email = :email";
    $stmt = $link->prepare($sql);
    $stmt->bindParam(":email", $email);

    $email = $_POST['emailInput'];

    $stmt->execute();
    if($stmt->rowCount() == 0) {
        unset($stmt);
        unset($link);
        header("Location: ./?content=EmailNotFound");
        exit();
    }
    $row = $stmt->fetch();

    if($_POST['passwordInput'] != $row["Password"]) {
        unset($stmt);
        unset($link);
        header("Location: ./?content=PasswordNotMatch");
        exit();
    }

    // Login Accepted

    $_SESSION['loggedin'] = true;
    $_SESSION['loggedID'] = $row["Email"];
    
    if (isset($_POST['remember']) && $_POST['remember'] == true) { // if user checked remember's button
        $randomBytes = random_bytes(16); // Generate 16 bytes of data randomly
        $randomId = bin2hex($randomBytes); // parse to hexadecimal data

        // create a cookie with the time setted for 1 day
        setcookie("loggedUserSessionID", $randomId, time()+86400, "/");
        
        unset($stmt);
        $sql = "UPDATE admin SET cookieID = :cookieID WHERE Email = :userID";
        $stmt = $link->prepare($sql);

        $stmt->bindParam(":cookieID", $randomId);
        $stmt->bindParam(":userID", $_SESSION['loggedID']);

        $stmt->execute();
    }

    header("Location: ../DashBoard/");
    exit();
?>