<?php


    /**
     * Description: devolve o quadrado de um número
     */
    function quadrado($numero)
    {
           return $numero * $numero;
    }


    /*
     * Description: define tipo e tamanho da letra
     * Parâmetros com valores predefinidos devem ficar no fim
    */
    function customFont($font, $color, $value, $size=1.5){
        echo "<p style=\"font-family: $font; font-size: {$size}em; color:$color\">" . $value . "</p>";
    }


    /**
     * Description: incrementa um valor a partir do valor inicial $x.
     * $x conserva valores entre chamadas da função pois é do tipo static
    */
    function contador($x){
        static $x;
        $x = $x + 1;
     return $x;
    }


    /*
     * Description: lê os argumentos passados à função e lista-os
    */
    function Mostra()
    {
        // Lê os argumentos passado à função no formato array
        $argumentos = func_get_args();
        
        // determina número de argumentos
        $quantidade = func_num_args();
        
        for($n=0; $n<$quantidade; $n++)
        {
            echo "Lista " . (int)($n+1) . ".º argumento = " . $argumentos[$n] . "<br>\n";
        }
    }


    // Description: exemplificação de uma função que utiliza passagem por referência
    function selfMultiply(&$number){
        $number *= $number;
        return $number;
    }


    /**
     * Uma função não pode devolver "múltiplos valores", podemos contornar o problema
     * devolvendo um array.
     */
    function mostraLista()
    {
        return array(0, "Ricardo", 70);
    }

?>