<?php
    session_start();

    $filepath = '../data/userData.json';

    $json_content = file_get_contents($filepath); // Get the existent userdata
    $data = (array) json_decode($json_content); // Decode the existent userdata

    // Forms Validation
    if (!array_key_exists($_POST['emailInput'], $data)) { // if the email doesn't exists send it back with an alert
        header("Location: ./?content=EmailNotFound");
        exit();
    } else if ($data[$_POST['emailInput']][0] != $_POST['passwordInput']) { // if the password is not correct send it back with an alert
        
        header("Location: ./?content=PasswordNotMatch");
        exit();
    }
    else {
        // Login Accepted

        $_SESSION['loggedin'] = true;
        $_SESSION['loggedEmail'] = $_POST['emailInput'];
        
        if (isset($_POST['remember']) && $_POST['remember'] == true) { // if user checked remember's button
            $randomBytes = random_bytes(16); // Generate 16 bytes of data randomly
            $randomId = bin2hex($randomBytes); // parse to hexadecimal data

            // create a cookie with the time setted for 1 day
            setcookie("loggedUserSessionID", $randomId, time()+86400, "/");
            $data[$_POST['emailInput']][1] =  $randomId; // save the cookie id to the array 

            $usersData = json_encode($data, JSON_PRETTY_PRINT); // encodes to JSON with pretty identation
            file_put_contents($filepath, $usersData); // save the new data
        }

        header("Location: ../DashBoard/");
        exit();
    }
?>