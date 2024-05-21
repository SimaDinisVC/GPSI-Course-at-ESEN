<?php

    /**
     * Funções anônimas, também conhecidas como closures, permitem a criação de funções 
     * que não tem um nome especificado. 
     */

    $a = function()
    {
        echo "<p>Olá</p>";
    };  // <-- O ponto e vírgula é obrigatório

    // chamada da função anónima
    $a();

    $falar = function($msg)
    {
        echo "<p>" . $msg . "</p>";
    };

    // chamada da função anónima
    $falar("Olá, estou aprender...");

    echo "------------------------------------------------------<br>";

    $x = 20;
    $y = 30;

    // Closures também podem herdar variáveis do escopo pai. 
    // Essas variáveis precisam ser referenciadas utilizando a instrução use.
    $minhaClosure = function($z) use($x, $y)
    {
        echo "$z - $x - $y";
        $y += 1000; // não vai alterar o valor de $y
    };

    $minhaClosure(10);

    echo "<p>$y</p>";   // o valor de $y não foi alterado na closure


    // Arrow function
    $minhaFuncao = fn($z) => "$x - $y - $z";

    echo $minhaFuncao(10);

