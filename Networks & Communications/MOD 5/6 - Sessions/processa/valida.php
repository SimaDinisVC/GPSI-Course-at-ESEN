<?php
 
    session_start();

    $email  = $_POST['email'];
    $senha  = $_POST['senha'];

    /*
        É criado automaticamente um cookie na pasta /Applications/XAMPP/xamppfiles/temp/
        Consulte o php.ini, no mac (session.save_path="/Applications/XAMPP/xamppfiles/temp/")
        
        Abra o ficheiro do cookie e observe o seu conteúdo.
        
        Este cookie termina quando fechar o browser.
        
    */

    
    /**
     * O acesso aos dados guardados numa sessão pode ser feito durante a vida útil de uma sessão.
     * As duas seguintes instruções cria variáveis de sessão.
     */
    $_SESSION['loggedin']   = true; // true - indica que fez login
    $_SESSION['email'] 	    = $email;

    /*
        Se os cookies estiverem desativos devemos passar o SID da sessão para a página seguinte.

        A instrução seguinte chama index.php (default).
    */
    header("location:../");
?>