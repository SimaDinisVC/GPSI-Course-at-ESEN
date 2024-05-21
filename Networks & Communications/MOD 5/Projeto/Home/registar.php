<?php
    session_start();

    $filepath = '../data/userData.json';

    $json_content = file_get_contents($filepath); // Get the existent userdata
    $data = (array) json_decode($json_content); // Decode the existent userdata

    if (array_key_exists($_POST['emailInput'], $data)) { // if the email exists send it back with an alert
        header("Location: ./?content=EmailAlreadyUsed");
        exit();
    }
    else{
        $data[$_POST['emailInput']] = array($_POST['passwordInput']); // Add the new user to the array
    }

    $usersData = json_encode($data, JSON_PRETTY_PRINT); // encodes to JSON with pretty identation

    file_put_contents($filepath, $usersData); // save the new data

    header("Location: ./");
    exit();
?>