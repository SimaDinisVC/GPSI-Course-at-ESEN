<?php

    # Um gerador é uma função que permite gerar séries de valores.
    # Cada valor é devolvido pela função através da instrução yield.
    # Ao contrário do return, a instrução yiled guarda o estado da função.
    # permitindo que a função continue a partir do estado onde ficou na última chamada
    function buscar_numero()
    {
        for($i=0; $i < 10; $i++)
        {
            yield($i);
        }
    }


    # A função geradora funciona como um iterador, podendo ser usada num ciclo
    # até que o gerador não tenha mais valores para devolver com o yield
    foreach(buscar_numero() as $numero)
    {
        echo "$numero<br>";
    }


    function buscar_nome()
    {
        
        yield 'Adelino';
        yield 'Maria';
        yield from ['Fernando', 'Ana', 'António'];
        yield 'Amaral';
    }

    echo '<br>';
    foreach(buscar_nome() as $nome)
    {
        echo "$nome<br>";
    }
