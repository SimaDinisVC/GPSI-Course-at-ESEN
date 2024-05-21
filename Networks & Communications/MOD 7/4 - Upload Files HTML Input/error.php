<?php
if ($_FILES["photo"]["error"] > 0) {
    echo "Erro: " . $_FILES["photo"]["error"] . "<br>";
} else {
    echo "Nome do ficheiro: " . $_FILES["photo"]["name"] . "<br>";
    echo "Tipo do ficheiro: " . $_FILES["photo"]["type"] . "<br>";
    echo "Tamanho do ficheiro: " . ($_FILES["photo"]["size"] / 1024) . "
KB<br>";
    echo "Pasta onde foi guardado: " . $_FILES["photo"]["tmp_name"];
}
?>