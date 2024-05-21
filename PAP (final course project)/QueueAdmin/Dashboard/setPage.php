<?php
    session_start();
   
    $_SESSION['dash_page'] = $_GET['page'];

    if (isset($_GET['company'])) {
        $_SESSION['company'] = $_GET['company'];
    }
    
    if (isset($_GET['establishment'])) {
        $_SESSION['establishment'] = $_GET['establishment'];
    }

    header("Location: ./");
?>