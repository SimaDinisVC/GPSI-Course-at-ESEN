<?php

    // Esta estrutura surgiu com o PHP 8.
    // Pretende facilitar a escrita de código e é semelhante à estrutura switch()
    $x = 10;

    echo match($x){
        5 => 'parou no 5',
        10 => 'parou no 10',
        15 => 'parou no 15',
        default => 'é um número diferente'
    };

    echo "<br>";

    $x = 22;
    $opcao = match($x){
        2 => 'é 2',
        4, 5, 6 => 'é 4, 5 ou 6',
        default => 'é outro número'
    };
    echo $opcao;
?>