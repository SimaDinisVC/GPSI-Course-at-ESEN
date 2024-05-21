<?php
    session_start();

    include '../libs/searchforIDonData.php'; // include a function to search the data by ID

    $filepath = '../data/userData.json';

    $json_content = file_get_contents($filepath); // Get the existent userdata
    $data = (array) json_decode($json_content); // Decode the existent userdata

    $_SESSION['loggedin'] = false;
    unset($_SESSION['loggedEmail']);

    if (isset($_COOKIE['loggedUserSessionID'])) {
        $userData = searchforID($data, $_COOKIE['loggedUserSessionID']);

        if ($userData != null) {
            unset($data[$userData['email']][1]); // delete, the cookie ID from the data
            $usersData = json_encode($data, JSON_PRETTY_PRINT); // encodes to JSON with pretty identation
            file_put_contents($filepath, $usersData); // save the new data

        }
        setcookie("loggedUserSessionID", "", time()-1, "/"); // if exists, delete the cookie from the browser
    }

    header("Location: ../Login/");
    exit();
?>