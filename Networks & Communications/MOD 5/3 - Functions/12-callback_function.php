<?php
    /*
    Uma função callback é uma função passada a outra função como argumento, 
    que é então invocado dentro da função externa para completar 
    algum tipo de rotina ou ação.
    Funções de callback não precisam ser apenas funções simples, podem ser métodos 
    de objetos, incluindo os estáticos.
    */


    $double = function($a) {
        return $a * 2;
    };

    // cria um array com os elementos 1, 2, 3, 4, 5
    $numbers = range(1, 5);

    // entra a função $double e o array $numbers
    // devolve um array cujos elementos estão multiplicados por 2
    // array_map(callable $callback, array $array1, array $... = ?): array
    $new_numbers = array_map($double, $numbers);

    // junta os elementos de um array numa string separados por espaço
    print implode(' ', $new_numbers);