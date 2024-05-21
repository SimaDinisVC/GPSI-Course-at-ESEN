<?php
include "functions.php";

// Initialize the session
session_start();
 
// Check if the user is logged in, if not then redirect him to login page
if(!isset($_SESSION["loggedin"]) || $_SESSION["loggedin"] !== true){
    header("location: login.php");
    exit;
}

/*
    Se os dados vierem de fontes externas, como dados de formulários preenchidos por 
    utilizadores anônimos, haverá o risco de que contenham scripts maliciosos
    para lançar ataques de script entre sites (XSS). 
    Portanto, deve fazer scape desses dados usando a função htmlspecialchars() 
    antes de os mostrar no browser, para que qualquer tag HTML que os contenha se 
    torne inofensiva. Por exemplo, depois de scape de caracteres especiais, 
    a string "<script>alert("XSS")</script> torna-se &lt;script&gt;alert("XSS")&lt;/script&gt;
    que não é executada pelo browser.
*/
?>

<?=template_header('Dashboard', true)?>
<div class="container">
    <h1 class="my-2">Hi, <b><?php echo htmlspecialchars($_SESSION["username"]); ?></b>. 
    Este é o dashboard.</h1>
    <p>
        <a href="reset-password.php">Reset à Senha</a>
    </p>
</div>

<?=template_footer()?>