<?php
    session_start();

    if ($_SESSION['loggedin'] == false) {
        header("Location: ../Home/");
        exit();
    }

    if (isset($_GET['id']) && !empty($_GET['id'])) {
        $id = $_GET['id'];
    }
    else {
        $id = $_SESSION['loggedID'];
    }

    include '../database/config.php';

    $sql = "DELETE FROM users WHERE userID = :userID";
    $stmt = $link->prepare($sql);
    $stmt->bindParam(":userID", $id);
    $stmt->execute();

    unset($stmt);
    unset($link);

    if ($id == $_SESSION['loggedID']) {
        include 'deslogar.php';
    }
    else {
        header("Location: ./?redirect=page_gestores");
        exit();
    }
?>