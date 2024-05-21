<?php
    $x = 10;    // integer
    $y = '20';  // string
    $z = $x + $y;

    echo "<h1>Conversão de tipos</h1>";

    echo "O valor da variável z é: " . $z . " (" . gettype($z) . ")<br />";

    // na adição, o valor de y é convertido para inteiro
    $z = $x + (int)$y;

    // a conversão não altera o tipo da variável
    echo "O valor da variável y é: " . $y . " o tipo da variável é (". gettype($y) . ")";

    // para alterar o tipo da variável utilizamos a função settype()
    $f = 20.05;
    echo '<br />' . $f . '<br />'; // float number

    settype($f, 'integer');
    echo "O valor convertido de f para inteiro é " . $f . '<br />'; // 20 integer number

    settype($f, 'string');
    echo $f . ' passou a: ' . gettype($f) .'<br />'; // '20' string

    settype($f, 'float');
    echo $f . '<br />'; // 20 float number

?>