<!DOCTYPE html>
<html lang="pt-PT">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php 
        if ($_SERVER["REQUEST_METHOD"] == "POST") {
            $preço = $_POST["preco"];
            $qnt = $_POST["quantidade"];
            $desconto = $_POST["desconto"];
            $envio = $_POST["gastos_envio"];

            $subtotal = $preco * $qnt;
            $valorIVA = $subtotal * 0.23;
            $valorTotal = $subtotal + $valorIVA + $envio - $desconto;

            echo "<h3>Detalhes da compra:</h3>";
            echo $qnt . " x " . $preco . "€";
            echo "Taxa de envio: " . $envio . "€";
            echo "Desconto:" . $desconto . "€";
            echo "Total: " . $valorTotal . "€";
            echo "A fatura da sorte é: " . rand(0, 99999);
        }
    ?>
    <h1>Calculadora de compras</h1><br>
    <h4>Preencha os campos da fatura</h4>
    <form action="<?php echo $_SERVER["PHP_SELF"] ?>" method="POST">
        <label for="preco">Preço: </label>
        <input type="text" name="preco" required> €<br>
        <label for="quantidade">Quantidade: </label>
        <input type="number" name="quantidade" required><br>
        <label for="desconto">Desconto: </label>
        <input type="number" name="desconto" required> %<br>
        <label for="gastos_envio">Gastos de Envio: </label>
        <select name="gastos_envio" required>
            <option value="5">Até 5Kg</option>
            <option value="10">Até 10Kg</option>
            <option value="15">Mais de 10kg</option>
        </select><br>


        <input type="submit" value="Calcular">
    </form>
</body>
</html>