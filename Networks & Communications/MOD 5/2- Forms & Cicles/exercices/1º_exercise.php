<!DOCTYPE html>
<html lang="pt-PT">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Verificador de estado social</title>
</head>
<body>
    <h1>Verificador de estado social</h1>
    <?php
        if ($_SERVER["REQUEST_METHOD"] == "POST") {
            $nome = $_POST["nome"];
            $idade = $_POST["idade"];
            if ($idade >= 0 and $idade < 14) {
                $classificacao = "Criança";
            }
            else if ($idade >= 14 and $idade < 18) {
                $classificacao = "Adolescente";
            }
            else if ($idade >= 18 and $idade < 65) {
                $classificacao = "Adulto";
            }
            else if ($idade >= 65) {
                $classificacao = "Idoso";
            }

            if ($classificacao) {
                if ($nome != "") {
                    echo "Olá $nome, a tua classificação é: $classificacao";
                }
                else {
                    echo "A tua classificação é: $classificacao";
                }
            }
        }
    ?>

    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="POST">
        Nome: <input type="text" name="nome"><br>
        Idade: <input type="number" name="idade" required><br>
        <input type="submit" value="Enviar Dados">
    </form>
</body>
</html>