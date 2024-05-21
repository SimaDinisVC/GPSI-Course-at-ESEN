<?php
session_start();
if(isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] === true){
    $entrou = true;
}else {
    $entrou = false;
}
include('functions.php');
template_header('Home', $entrou);
?>

<div class="container"><h1>Olá</h1></div>

<?=template_footer()?>