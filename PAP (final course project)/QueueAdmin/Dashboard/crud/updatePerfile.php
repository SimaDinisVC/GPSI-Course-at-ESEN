<?php
    session_start();

    if ($_SESSION['loggedin'] == false) {
        header("Location: ../Home/");
        exit();
    }

    if ($_POST['senha'] != $_POST['confirmarSenha']) {
        header("Location: ./?redirect=page_perfile&content=PasswordsNotMatch");
        exit();
    }

    // Verifica se o ficheiro fez uploaded sem erros
    if (isset($_FILES["photo"]) && !empty($_FILES["photo"])) {
        $allowed = array("jpg" => "image/jpg", "jpeg" => "image/jpeg", "png" => "image/png");
        $filename = $_FILES["photo"]["name"];
        $filetype = $_FILES["photo"]["type"];
        $filesize = $_FILES["photo"]["size"];

        // Verifica o tipo MYME do ficheiro
        if (in_array($filetype, $allowed)) {
            move_uploaded_file($_FILES["photo"]["tmp_name"], 'assets/'. $_SESSION['loggedID'] .'.'. pathinfo($filename, PATHINFO_EXTENSION));
        }
        else {
            header("Location: ./?redirect=page_perfile&content=FileTypeNotSupported");
            exit();
        }
    }

    include '../database/config.php';

    $sql = "UPDATE users SET nome = :nome";

    if (!empty($_POST['senha'])) {
        $sql .= ", password = :password";
    }
    if (isset($_FILES["photo"]) && !empty($_FILES["photo"])) {
        $sql .= ", PerfileImgPath = :PerfileImgPath";
    }

    $sql .= " WHERE userID = :userID";

    $stmt = $link->prepare($sql);
    $stmt->bindParam(":nome", $_POST['nome']);

    if (!empty($_POST['senha'])) {
        $stmt->bindParam(":password", $_SESSION['loggedID']);
    }
    if (isset($_FILES["photo"]) && !empty($_FILES["photo"])) {
        $path = 'assets/'. $_SESSION['loggedID'] .'.'. pathinfo($filename, PATHINFO_EXTENSION);
        $stmt->bindParam(":PerfileImgPath", $path);
    }

    $stmt->bindParam(":userID", $_SESSION['loggedID']);
    $stmt->execute();

    unset($stmt);
    unset($link);

    header("Location: ./?redirect=page_perfile");
    exit();
?>