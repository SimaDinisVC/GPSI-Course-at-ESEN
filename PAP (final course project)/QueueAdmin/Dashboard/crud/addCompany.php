<?php
    session_start();

    include '../../database/config.php';

    $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
    $link = new PDO($db, DB_USERNAME, DB_PASSWORD);

    $sql = "SELECT NIF FROM empresa WHERE NIF = :NIFCompany";
    $result = $link->prepare($sql);
    $data = array(':NIFCompany' => $_POST['NIFCompany']);

    if($result->execute($data)){
        if ($result->rowCount() == 1) {
            header("Location: ../?content=NIFisUsed");
            exit();
        }
    }

    $data = [
        ":NIFCompany" => $_POST['NIFCompany'],
        ":nomeCompany" => $_POST['nomeCompany'],
        ":areaEmp" => $_POST['areaEmp']
    ];

    unset($result);

    if (isset($_FILES["logoCompany"]) && !empty($_FILES["logoCompany"] && $_FILES["logoCompany"]["error"] != UPLOAD_ERR_NO_FILE)) {
        $allowed = array("jpg" => "image/jpg", "jpeg" => "image/jpeg", "png" => "image/png");
        $filename = $_FILES["logoCompany"]["name"];
        $filetype = $_FILES["logoCompany"]["type"];
        $filesize = $_FILES["logoCompany"]["size"];

        // Verifica o tipo MYME do ficheiro
        if (in_array($filetype, $allowed)) {
            $novo_nome_ficheiro = $_POST['NIFCompany'] . '.' . pathinfo($filename, PATHINFO_EXTENSION);

            $sql = "INSERT INTO empresa (NIF, Nome, logoPath, AreaEmpresarial, emailAdmin) VALUES (:NIFCompany, :nomeCompany, :logoPath, :areaEmp, :emailAdmin)";
            $result = $link->prepare($sql);
            $data[":logoPath"] = $novo_nome_ficheiro;
            $data[":emailAdmin"] = $_SESSION['loggedID'];
            $result->execute($data);

            $file_content = file_get_contents($_FILES["logoCompany"]["tmp_name"]);
            $api_url = 'http://localhost:4000/upload';

            $imagem_base64 = base64_encode($file_content);

            $data = array(
                'imagem' => $imagem_base64,
                'nome_ficheiro' => $novo_nome_ficheiro
            );
    
            
            $ch = curl_init();
            curl_setopt($ch, CURLOPT_URL, $api_url);
            curl_setopt($ch, CURLOPT_POST, true);
            curl_setopt($ch, CURLOPT_POSTFIELDS, http_build_query($data));
            curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
            $response = curl_exec($ch);
            curl_close($ch);
            header("Location: ../?content=FileTypeNotSupported");
            exit();
        }
        else {
            header("Location: ../?content=FileTypeNotSupported");
            exit();
        }
    } else {
        $sql = "INSERT INTO empresa (NIF, Nome, AreaEmpresarial, emailAdmin) VALUES (:NIFCompany, :nomeCompany, :areaEmp, :emailAdmin)";
        $result = $link->prepare($sql);
        $data[":emailAdmin"] = $_SESSION['loggedID'];
        $result->execute($data);
        header("Location: ../");
        exit();
    }
    


?>