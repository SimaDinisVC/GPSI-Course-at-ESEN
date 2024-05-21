<!DOCTYPE html>
<html lang="pt-PT">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulário de upload</title>
</head>
<body>
    <b><?php if (!empty($msg)) echo $msg; ?></b>
    <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post" enctype="multipart/form-data">
        <h2>Upload de um Ficheiro</h2>
        <label for="fileSelect">Ficheiro:</label>
        <input type="file" name="photo" id="fileSelect">
        <input type="submit" name="submit" value="Upload">
        <p><strong>Aceita apenas:</strong> os formatos .jpg, .jpeg, .gif, .png
            com tamanho máximo 5 MB.</p>
    </form>

    <?php
    define('FILENAME', 'upload/');
    // $maxsize = 5 * 1024 * 1024;
    define('MAXSIZE', 5 * 1024 * 1024);
    // Verifica se o formulário foi submetido
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        // Verifica se o ficheiro fez uploaded sem erros
        if (isset($_FILES["photo"]) && $_FILES["photo"]["error"] == 0) {
            $allowed = array("jpg" => "image/jpg", "jpeg" => "image/jpeg", "gif" =>
            "image/gif", "png" => "image/png");
            $filename = $_FILES["photo"]["name"];
            $filetype = $_FILES["photo"]["type"];
            $filesize = $_FILES["photo"]["size"];

            // Verifica a extensão do ficheiro
            $ext = pathinfo($filename, PATHINFO_EXTENSION);
            if (!array_key_exists($ext, $allowed)) die("Erro: Selecione um tipo de ficheiro autorizado.");

            // Verifica o tamanho do ficheiro - 5MB maximum
            if ($filesize > MAXSIZE) $msg = "Erro: O tamanho fo ficheiro ultrapassou o limite.";
            // Verifica o tipo MYME do ficheiro
            if (in_array($filetype, $allowed)) {
                // Verifique se o ficheiro existe antes de fazer upload
                if (file_exists(FILENAME . $filename)) {
                    $msg = $filename . " já existe.";
                } else {
                    move_uploaded_file($_FILES["photo"]["tmp_name"], FILENAME .
                        $filename);
                    $msg = "O ficheiro foi transferido com sucesso.";
                }
            } else {
                $msg = "Erro na transferência do ficheiro. Tente de novo.";
            }
        } else {
            $msg = "Erro: " . $_FILES["photo"]["error"];
        }
    }
    ?>
</body>
</html>