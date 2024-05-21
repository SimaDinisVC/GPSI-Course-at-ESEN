<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Checkbox</title>
</head>
<body>
    <!--
        Este exemplo tem por objetivo o uso de inputs do tipo checkbox, 
        quer dizer que poderemos selecionar vários elementos.
        Repara no atributo name.
    -->
    <form action="5-processa.php" method="post">
        <p>Formulário de teste</p>
        <input type="checkbox" name="caixa_fruta[]" value="Laranja">Laranja<br>
        <input type="checkbox" name="caixa_fruta[]" value="Pera">Pera<br>
        <input type="checkbox" name="caixa_fruta[]" value="Maçã">Maçã<br>
        <input type="checkbox" name="caixa_fruta[]" value="Ananás">Ananás
        <br><br>
        <input type="submit" value="Enviar">
    </form>

    <!-- ALTERA O CÓDIGO POR FORMA A FICAREM SELECIONADOS DOIS ELEMENTOS (LARANJA E MAÇÃ). -->
</body>
</html>