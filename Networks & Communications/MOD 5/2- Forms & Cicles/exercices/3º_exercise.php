<!DOCTYPE html>
<html lang="pt-PT">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Formulário de Registo</h1><br>
    <h4>Preencha os campos da fatura</h4>
    <form action="<?php echo $_SERVER["PHP_SELF"] ?>" method="POST">
        <label for="email">Email: </label>
        <input type="email" name="email" required><br>
        <label for="password">Password: </label>
        <input type="password" name="password" required><br>
        <label for="chkPassword">Confirme a Password: </label>
        <input type="password" name="chkPassword" required><br>
        <label for="inputNascimento">Ano de nascimento:</label>
        <input type="number" name="nascimento" id="inputNascimento" style="width:17%" placeholder="YYYY" required><br>
        <label for="cor">Cor favorita: </label>
        <input type="color" name="cor" required>
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