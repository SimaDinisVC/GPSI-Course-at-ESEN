<?php
    // Script Code

    include '../libs/searchforIDonData.php';

    $filepath = '../data/userData.json';

    $json_content = file_get_contents($filepath); // Get the existent userdata
    $data = (array) json_decode($json_content); // Decode the existent userdata

    if (isset($_COOKIE['loggedUserSessionID'])) { // verify if are any coockies
        $userData = searchforID($data, $_COOKIE['loggedUserSessionID']);
        if ($userData != null) {  // if exists a cookie available it logges you in with them
            $_SESSION['loggedin'] = true;
            $_SESSION['loggedEmail'] = $userData['email'];
        }
        else { // if exists a cookie that is not available to login anymore it unsets the cookie
            $_SESSION['loggedin'] = false;
            unset($_SESSION['loggedEmail']);
            setcookie("loggedUserSessionID", "", time()-1, "/");
        }
    }
    else if (!isset($_SESSION['loggedin'])) { // also if doesn't exists a session its unset everything
        $_SESSION['loggedin'] = false;
        unset($_SESSION['loggedEmail']);
        setcookie("loggedUserSessionID", "", time()-1, "/");
    }
?>