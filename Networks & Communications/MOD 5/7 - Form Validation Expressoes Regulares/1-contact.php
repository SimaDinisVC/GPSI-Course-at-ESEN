<?php

include "libs/valida.php";

// inicialização de variáveis
$nameErr = $emailErr = $messageErr = $subjectErr = "";
$name = $email = $subject = $message = "";
$nameEmptyErr = $emailEmptyErr = $categoryEmptyErr = $subjectEmptyErr = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {

    $name = checkInput($_POST["message"]) ?? null;
    $email = checkInput($_POST["email"]) ?? null;
    $subject = checkInput($_POST["subject"]) ?? null;
    $message = checkInput($_POST["message"]) ?? null;
    $category = $_POST["category"] ?? null;

    // valida o nome
    if (empty($name)) {
        $nameEmptyErr = 'O nome não pode ficar em branco.';
    } // Allow letters and white space 
    else if (!preg_match("/^[a-zA-Z ]*$/", $name)) {
        $nameErr = 'Permite caracteres e espaço em branco.';
    } else {
        echo $name . '<br>';
    }

    // email validate
    if (empty($email)) {
        $emailEmptyErr = 'O email não pode ficar em branco.';
    } // E-mail format validation. We could use the function $email = filterEmail($_POST["email"]);
    else if (!preg_match("/^([a-z0-9\+_\-]+)(\.[a-z0-9\+_\-]+)*@([a-z0-9\-]+\.)+[a-z]{2,6}$/ix", $email)) {
        $emailErr = 'Insira um email válido.';
    } else {
        echo $email . '<br>';
    }

    // category validate
    if (empty($category)) {
        $categoryEmptyErr = 'Indique a categoria.';
    } else {
        echo $category . '<br>';
    }

    // subject validate
    if (empty($subject)) {
        $subjectEmptyErr = 'Indique o assunto.';
    } else {
        echo $subject . '<br>';
    }


    // message validate
    if (empty($_POST["message"])) {
        $messageErr = "Insira um comentário.";
    } else {
        $message = filterString($_POST["message"]);
        if ($message == FALSE) {
            $messageErr = "Insira um comentário válido.";
        }
    }

    
    // checks for errors before processing
    if (empty($nameErr) && empty($emailErr) && empty($messageErr)) {
        echo "Realiza uma operação específica, por exemplo, envio de um email";
    }
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <title>Formulário de Contacto</title>
    <style type="text/css">
        .error {
            color: red;
            font-weight: 400;
            /* display: block; */
            padding: 6px 0;
            font-size: 14px;
        }

        .success {
            color: green;
        }
    </style>
</head>

<body>
    <h2>Contacto</h2>
    <p>Preencha os campos do forumlário.</p>
    <!-- Repare na atribuição do atributo value, toma o valor inserido anteriormente. -->
    <form action="<?php echo $_SERVER["PHP_SELF"]; ?>" method="post">
        <p>
            <label for="inputName">Nome:<sup>*</sup></label>
            <input type="text" name="name" id="inputName" value="<?php echo $name; ?>">
            <span class="error">
                <?php echo $nameEmptyErr; ?>
                <?php echo $nameErr; ?>
            </span>
        </p>

        <p>
            <label for="inputEmail">Email:<sup>*</sup></label>
            <input type="text" name="email" id="inputEmail" value="<?php echo $email; ?>">
            <span class="error">
                <?php echo $emailEmptyErr; ?>
                <?php echo $emailErr; ?>
            </span>
        </p>
        <p>
            <label for="inputCategory">Categoria: <sup>*</sup></label>
            <select id="inputCategory" name="category">
                <option selected="" disabled>...</option>
                <option value="Aluno">Aluno</option>
                <option value="Professor">Professor</option>
            </select>
            <span class="error">
                <?php echo $categoryEmptyErr; ?>
            </span>
        </p>
        <p>
            <label for="inputSubject">Assunto: <sup>*</sup></label>
            <input type="text" name="subject" id="inputSubject" value="<?php echo $subject; ?>">
            <span class="error">
                <?php echo $subjectEmptyErr; ?>
                <?php echo $subjectErr; ?>
            </span>
        </p>
        <p>
            <label for="inputComment">Mensagem:<sup>*</sup></label>
            <textarea name="message" id="inputComment" rows="5" cols="30"><?php echo $message; ?></textarea>
            <span class="error">
                <?php echo $messageErr; ?>
            </span>
        </p>
        <input type="submit" name="send" value="Send">
        <input type="reset" value="Reset">
    </form>
</body>

</html>