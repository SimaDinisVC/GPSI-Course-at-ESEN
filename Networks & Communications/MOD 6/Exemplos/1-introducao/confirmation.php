<?php
if($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = htmlspecialchars(trim($_POST["name"]));
    $comment = htmlspecialchars(trim($_POST["comment"]));
    
    // Check if form fields values are empty
    if(!empty($name) && !empty($comment)) {
        echo "<p>Olá, <b>$name</b>. O seu comentário foi recebido com sucesso.<p>";
        echo "<p>Escreveu: <b>$comment</b></p>";
    } else {
        echo "<p>Por favor, preencha os campos do formulário!</p>";
    }
} else {
    echo "<p>Desculpe, algo não correy bem. Tente novamente.</p>";
}
?>