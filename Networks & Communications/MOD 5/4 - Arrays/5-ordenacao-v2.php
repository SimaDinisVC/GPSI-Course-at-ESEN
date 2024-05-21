<!doctype html>
<html lang="pt-pt">
    <head>
    <meta charset="utf-8">
    <title>Untitled Document</title>
</head>

<body>
<?php

    if(isset($_POST['submitted']))
    {
        // explode - divide uma string em strings. Identifica cada string pela separação de um espaço.
        // palavras_strings - é um array de strings
        $palavras_strings = explode(' ' , $_POST['palavras']);

        // Ordena o array palavras_strings
        sort($palavras_strings);

        // junta os elementos do array numa string
        // string_palavras - representa uma string
        $string_palavras = implode('<br />', $palavras_strings);

        // imprime o resultado
        print "<p>Palavras ordenadas: <br />$string_palavras</p>";
    }
?>

<div>
    <p>Insira palavras a ordenar, cada uma separada por um espaço:</p>
    <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">

        <input type="text" name="palavras" size="60" />
        <input type="submit" name="submit" value="Ordenar!" />
        <input type="hidden" name="submitted" value="TRUE" />
    </form>
</div>   
</body>
</html>
