<?php
    session_start();
    
    include '../database/config.php';

    if (isset($_COOKIE['loggedUserSessionID'])) {
        $sql = "UPDATE users SET cookieID = NULL WHERE userID=:userID";
        $stmt = $link->prepare($sql);
        $stmt->bindParam(":userID", $_SESSION['loggedID']);

        $stmt->execute();
        unset($stmt);

        setcookie("loggedUserSessionID", "", time()-1, "/"); // if exists, delete the cookie from the browser
    }

    session_destroy();
    unset($link);

    header("Location: ../Login/");
    exit();
?>