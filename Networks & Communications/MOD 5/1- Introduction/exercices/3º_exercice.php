<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calculadora de IMC</title>
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

        .yellow {
            color: rgb(210,210,0);
        }

        .red {
            color: rgb(210,0,0);
        }
    </style>
</head>
<body>
    <h1>Calculadora de IMC</h1>
    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
        Peso (em kg): <input type="text" name="peso" required><br>
        Altura (em metros): <input type="text" name="altura" required><br>
        <input type="submit" value="Calcular">
    </form>

    <?php
    function calcularIMC($peso, $altura) {
        return $peso / ($altura * $altura);
    }

    // Só executa o script quando a origem da solicitação é POST,
    // é por isso que quando abrimos o site este código não é executado,
    // pois a solicitação que foi feita de início é de GET.
    // Logo este script vai sempre responder à solicitação do form.
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $peso = (float) $_POST["peso"];
        $altura = (float) $_POST["altura"];

        $imc = calcularIMC($peso, $altura);
        echo "<h3> O IMC resultante é: " . number_format($imc, 3) . "</h3>"; // formata para 2 casas decimais

        // Classificação
        if ($imc < 18.5) {
            echo "<p class=\"red\">Você está abaixo do peso.</p>";
        } elseif ($imc >= 18.5 && $imc < 24.9) {
            echo "<p class=\"green\">Você está com peso normal.</p>";
        } elseif ($imc >= 25 && $imc < 29.9) {
            echo "<p class=\"yellow\">Você está com sobrepeso.</p>";
        } else {
            echo "<p class=\"red\">Você está com obesidade.</p>";
        }
    }
    ?>
</body>
</html>