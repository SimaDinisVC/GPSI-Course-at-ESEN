<?php

    /**
     * 
     * Scope de uma variável PHP (PHP variable scope)
     * Por vezes, poderá haver necessidade de declarar variáveis que necessitem de existir 
     * durante todo o código (variáveis globais) ou apenas em certos momentos do código 
     * (variáveis locais). Chama-se a esta propriedade scope. Por defeito, as variáveis são 
     * locais, pelo que não estão acessíveis em todo o programa.
     * 1.	Variável local (scope local)
     * 2.	Variável global (scope local)
     * 3.	Variável estática (scope local)
     * 4.	Parâmetro de uma função (scope local)
     * Quando o acesso à variável está fora do scope da variável, o PHP causa um erro 
     * undefined variable.
     * 
     * 
     * O PHP suporta a passagem de argumentos "por valor" (o padrão), 
     * passagem "por referência", e valores padrões. 
     * Lista de argumentos de tamanho variável e argumentos nomeados também são suportadas.
     * Vamos explorar estes conceitos ao longo deste tema.
     * 
     * PASSGEM POR VALOR E POR REFERÊNCIA
     * Por padrão, argumentos de função são passados por valor, o valor do argumento 
     * pode mudar dentro da função, mas não é alterado fora da função. 
     * Para permitir que uma função modifique os seus argumentos, estes devem ser passados 
     * por referência.
     */

    // definição de cada passo em metros
    define('CADA_PASSO',0.8);

    /**
     * A variável passo diz-se local porque está definida dentro da função.
     * Se fizer uso desta variável fora da função será visualizado o erro
     * "undefined variable".
     */
    function mostra_passo(){
        $passo = CADA_PASSO;    // $passo é uma variável local
        return $passo;  // return faz com que a função devolva um valor.
    }

    /**
     * Description: determina quantos quilometros existem em $passos
     * Parâmetros: $passos - só é acessível dentro da função.
     */
    function PassosPorQuilometro($passos)
    {
        return $passos * CADA_PASSO;
    }


    /**
     * Description: determina o número de milhas por quilometro.
     * A variável $total é visivel dentro deste ficheiro,
     * como tal, chamamos "variável global" e aplica-se a palavra global.
     */
    function km2mi($quilometros)
    {
        global $total;
        $total += $quilometros;    // equivale a $total = $total + $quilometros; - total de quilometros
        return $quilometros * 0.6;
    }
    

    /**
     * Description: determina e apresenta o número de quilometros.
     * $ptotal - trata-se de uma variável local porque é reconhecida dentro
     * da função, no entanto guarda os valores entre as chamadas da
     * função.
     */
    function percorre($quilometros)
    {
        // $ptotal é inicializada só na primeira chamada da função
        static $ptotal=0;

        $ptotal += $quilometros;    
        echo "percorreu mais $quilometros do total de $ptotal<br>\n";
    }

    /*
        Recursividade
        Consiste em chamar a função dentro dela.
    */
    function Fatorial($numero)
    {
        if ($numero == 1)
            return $numero;
        else
            return $numero * Fatorial($numero -1);
    }


    /*
    ##
        Chamadas das funções
    ##
    */

    echo "Cada passo mede ".mostra_passo()." metros<br>" ;

    echo "Com 2000 passos caminhei " . PassosPorQuilometro(2000) . " metros<br>";

    echo "--------------------------------------------------------<br>";
    
    /**
     * As variáveis seguintes são visíveis fora das funções, não são 
     * reconhecidas dentro das funções.
     * Um parâmetro passa uma cópia do valor para a função.
     */
    $valor1 = 100;
    $valor2 = 200;
    echo "$valor1 quilometros são " . km2mi($valor1) . " milhas <br>\n";
    echo "$valor2 quilometros são " . km2mi($valor2) . " milhas <br>\n";
    // total é uma variável global definidadentro da função km2milhas
    echo 'percorreu no total ' . $total . " quilometros <br>\n";

    echo "--------------------------------------------------------<br>";

    // outra forma de guardar os valores totais sem utilizar uma variável global
    // usamos uma variável static
    percorre(100);
    percorre(200);
    percorre(50);

    echo "--------------------------------------------------------<br>";

    // Fatorial de 5 = 1 x 2 x 3 x 4 x 5 = 120
    echo "Fatorial de 5 --> " . Fatorial(5) . "<br>\n";
    echo "Fatorial de 7 --> " . Fatorial(7) . "<br>\n";

    echo "--------------------------------------------------------<br>";
?>