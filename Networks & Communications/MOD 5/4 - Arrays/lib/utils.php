<?php

        // estamos a indicar que o primeiro índice começa em 1, por defeito toma o valor 0 (ZERO)
        $meses = array (1 => 'Janeiro', 
                'Fevereiro', 
                'Março', 
                'Abril', 
                'Maio', 
                'Junho', 
                'Julho', 
                'Agosto', 
                'Setembro', 
                'Outubro', 
                'Novembro', 
                'Dezembro'
        );
        
    /*
    Outra forma de escrever um array.

        $meses = ['Janeiro', 
            'Fevereiro', 
            'Março', 
            'Abril', 
            'Maio', 
            'Junho', 
            'Julho', 
            'Agosto', 
            'Setembro', 
            'Outubro', 
            'Novembro', 
            'Dezembro'
        ];

    */

    /**
     * Data: 05-10-2020
     * Descrição:  Converte os elementos da string $valueStr num array
     * o parâmtero opcional não deve ser o primeiro na lista
     * Return: devolve um array com os elementos da string
    */    
    function divideFaixa($valueStr, $separador=":"){
        
        // extração dos valores da string separados pelo separador $separador
        $array = explode($separador, $valueStr);
        return $array;
    }

    
    // passar um array como parâmetro
    function showMonth($month){
        foreach($month as $indice => $valor)
            echo $indice . ' > ' . $valor . '<br>';

        //print_r($month);
    }

?>