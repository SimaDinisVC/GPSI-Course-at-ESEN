<?php
    session_start();

    include '../database/config.php';

    use PHPMailer\PHPMailer\PHPMailer;
    use PHPMailer\PHPMailer\SMTP;
    use PHPMailer\PHPMailer\Exception;

    // Load Composer's autoloader and constants
    require '../libs/vendor/autoload.php';
    require '../libs/constants.php';

    // Verify if the email exists in the database
    $sql = "SELECT * FROM users WHERE email = :email";
    $stmt = $link->prepare($sql);
    $stmt->bindParam(":email", $email);

    $email = $_POST['ResetEmailInput'];

    $stmt->execute();
    if($stmt->rowCount() == 0) {
        unset($stmt);
        unset($link);
        header("Location: ./?content=EmailNotFound");
        exit();
    }
    unset($stmt);

    // Password Refenition Token
    $token = uniqid();

    // Store the token in the database
    $sql = "UPDATE users SET PasswordToken = '". $token ."' WHERE email = :email";
    $stmt = $link->prepare($sql);
    $stmt->bindParam(":email", $email);
    $stmt->execute();
    unset($stmt);
    unset($link);

    try {
        // PHPMailer Configurater
        $mail = new PHPMailer(true);

        //Server settings
        $mail->SMTPDebug = SMTP::DEBUG_OFF;
        $mail->isSMTP();                                    // Send using SMTP
        $mail->Host       = MAIL_HOST;                      // Set the SMTP server to send through
        $mail->SMTPAuth   = true;                           // Enable SMTP authentication
        $mail->Username   = MAIL_USERNAME;                  // SMTP username
        $mail->Password   = MAIL_PASSWORD;                  // SMTP password
        $mail->SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS; // Enable TLS encryption; `PHPMailer::ENCRYPTION_SMTPS` also accepted
        $mail->Port       = MAIL_PORT;                      // TCP port to connect to

        //Recipients
        $mail->setFrom(MAIL_FROM, MAIL_REMETENTE);
        $mail->addAddress($email);   

        // Email Structure
        $mail->isHTML(true);    // Set email format to HTML
        $mail->CharSet = "UTF-8";
        $mail->Subject = 'Pedido de Redefinição de Senha';
        $mail->Body    = 'Clique neste link para redefinir a sua senha: <a href="http://localhost/MOD%207/Projeto/Login/?token=' . $token . '">Redefinir Senha</a>';

        // Email Sending
        $mail->send();
        
        header("Location: ./?content=EmailSentSuccessfully");
        exit();
    } catch (Exception $e) {
        header("Location: ./?content=EmailSentUnsuccessfully");
        exit();
    }
?>