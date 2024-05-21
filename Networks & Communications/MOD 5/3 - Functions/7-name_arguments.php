<?php

    // Os argumentos são avaliados da esquerda para a direita.


    // $b e $c são argumentos opcionais. 
    // Não é possível passar argumentos opcionais e depois argumentos obrigatórios.
    function adicionar($a, $b=10, $c = 30)
    {
        echo $a + $b + $c;
    }
    adicionar(100, 10, 300);

    // se desejarmos atribuir um valor a $c e não a $b, não era possível

    echo "<br>";

    // passamos os valores dos argumentos a e b
    adicionar(100, 300);

    echo "<br>";


    /**
     * N amed arguments
     * O PHP 8.0.0 introduziu argumentos nomeados como uma extensão aos parâmetros posionais. 
     * Argumentos nomeados permitem a passagem de argumentos para uma função utilizando
     * os nomes de parâmetros, em vez da posição do parâmetro. 
     * Isto torna o significado do argumento auto documentável, e tornam os argumentos independente
     * de ordem, além de permitir saltar argumentos com defaults.
     * Usar palavras reservadas como nomes de parâmetro é permitido.
     */

     /**
      * Argumentos nomeados podem ser combinados com argumentos posicionais.
      * Nesse caso, os argumentos nomeados devem estar depois dos argumentos posicionais. 
      * Também é possível especificar somente alguns dos argumentos opcionais de uma função, 
      * independente da ordem.
      */

    // atribuimos valores numa ordem aleatória dos argumentos
    adicionar(c:1000, a:0); //
    echo "<br>";

    adicionar(500, c:1000);


    /**
     * A lista de argumentos numa função pode incluir uma vírgula final, que será ignorada. 
     * É particularmente útil quando a quantidade de argumentos é longa ou contém nomes longos, 
     * sendo conveniente listar os argumentos verticalmente.
     */
    function varios_args(
        $primeiro,
        $segundo,
        $uma_variavel_com_nome_longo,
        $parametro_com_default = 5,
        $de_novo = 'argumento padrão', // Essa vírgula final não era permitida antes do PHP 8.0.0.
    ) {
        // ...
    }