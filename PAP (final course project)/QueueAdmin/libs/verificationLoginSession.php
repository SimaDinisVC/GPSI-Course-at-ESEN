<?php
    // Script Code

    include '../database/config.php';

    $sql = "SELECT * FROM users WHERE cookieID = :cookieID";
    
    if (isset($_COOKIE['loggedUserSessionID'])) { // verify if are any coockies
        $stmt = $link->prepare($sql);
        $stmt->bindParam(":cookieID", $_COOKIE['loggedUserSessionID']);
        $stmt->execute();

        if ($stmt->rowCount() == 1) {  // if exists a cookie available it logges you in with them
            $row = $stmt->fetch(PDO::FETCH_ASSOC);

            $_SESSION['loggedin'] = true;
            $_SESSION['loggedID'] = $row['userID'];
        }
        else { // if exists a cookie that is not available to login anymore it unsets the cookie
            $_SESSION['loggedin'] = false;
            unset($_SESSION['loggedID']);
            setcookie("loggedUserSessionID", "", time()-1, "/");
        }
    }
    else if (!isset($_SESSION['loggedin'])) { // also if doesn't exists a session its unset everything
        $_SESSION['loggedin'] = false;
        unset($_SESSION['loggedID']);
        setcookie("loggedUserSessionID", "", time()-1, "/");
    }

    unset($stmt);
    unset($link);
?>