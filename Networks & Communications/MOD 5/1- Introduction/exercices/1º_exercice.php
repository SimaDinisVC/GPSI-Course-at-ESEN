<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Verificar Par ou Ímpar</title>
    <style>
        body {
            background-color: rgb(123,123,123);
            height: 97vh;
            width: 100vdh;
            display: flex;
            flex-direction: column;
            align-items:center;
            justify-content:center;
        }

        .green {
            color: rgb(0,210,0);
        }

        .red {
            color: rgb(210,0,0);
        }
    </style>
</head>
<body>
    <h1>Verificador de números pares e ímpares</h1>

    <!-- script php de resposta à solicitação do form -->
    <?php
        // Só executa o script quando a origem da solicitação é POST,
        // é por isso que quando abrimos o site este código não é executado,
        // pois a solicitação que foi feita de início é de GET.
        // Logo este script vai sempre responder à solicitação do form.
        if ($_SERVER["REQUEST_METHOD"] == "POST") {  
            $numero = $_POST["numero"];

            // Verifica se o número é par ou ímpar
            if ($numero % 2 == 0) {
                echo "<p class=\"green\">O número $numero é par.</p>";
            } else {
                echo "<p class=\"red\">O número $numero é ímpar.</p>";
            }
        }
    ?>

    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="POST">
        <label for="numero">Introduza o número:</label>
        <input type="text" name="numero" id="numero" required>
        <br><br>
        <input type="submit" value="Verificar">
    </form>
</body>
</html>