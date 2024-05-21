<!doctype html>
<html lang="pt-pt">
<head>
    <meta charset="UTF-8">
    <title>Funções</title>
</head>
<body>
<?php
	
    /*
        Como o próprio nome diz, a declaração "include" inclui o conteúdo de um determinado 
        ficheiro no ficheiro atual.
        A declaração "require" é idêntica à "include", exceto no caso de falha que produz um 
        erro fatal de nível E_COMPILE_ERROR. Por outras palavras, ela parará o script 
        enquanto que a "include" apenas emitirá um alerta (E_WARNING) permitindo 
        que o script continue.

        "include_once" e "require_once" são idênticas às declarações anteriores com uma diferença,
        se o conteúdo do ficheiro foi já carregado este não volta a ser carregado.
    */

    include 'libs/cor.php';
    include 'libs/util.php';

    $color_code = getRGB();
    echo $color_code . "<br>";
    $color_code = getRGB(BLUE);
    echo $color_code . "<br>";

    echo "--------------------------------------------------------<br>";
    
    $x = 1;
    $num = contador($x);
    $num = contador($x);
    $num = contador($x);
    customFont("Arial", 2, $color_code, $num);
    
    echo "--------------------------------------------------------<br>";
    
    $y = 5;
    echo $y . "<br>"; // Output: 5

    // o parâmetro $y é passado por referência, o valor de $y sai alterado.
    // verifica o cabeçalho da função.
    selfMultiply($y);
    echo $y . "<br>"; // Output: 25

    echo "--------------------------------------------------------<br>";

    list($indice, $nome, $peso) = mostraLista();
    echo "$indice - $nome e tenho $peso Kg<br>";
    
    echo "--------------------------------------------------------<br>";
    
    Mostra('João', 'Maria', 'José', 'Pedro');
    
?>
</body>
</html>
