<?php

    $versao_navegador = $_SERVER['HTTP_USER_AGENT'];

    echo "**" . $versao_navegador . "**";

    /*
        strpos - encontra a posição da primeira ocorrência de uma substring numa string
    */
    if (strpos($versao_navegador, 'Safari/603.3') == true){
       echo "<br>O teu browser é o Safari versão 603.3";
    }

    echo "<br>";

    /*
        substr - retornar parte de uma string
    */
    echo "**" . PHP_OS . "**<br>";

    if (strtoupper(substr(PHP_OS, 0, 3)) === 'WIN') {
        echo 'O servidor tem o sistema operativo WINDOWS!';
    }
    elseif(strtoupper(substr(PHP_OS, 0, 6)) === 'DARWIN'){
        echo 'O servidor tem o sistema operativo MAC/APPLE!';
    } else {
        echo 'Sistema Operativo desconhecido!';
    }

    /*
        Um pormenor importante na utilização da função strtoupper. Vê o exemplo abaixo.
        mb_strtoupper() será mais adequado. O uso desta última função ocorre sem erros se estiver
        ativa a extensão mb_string no php.ini
    */

    echo "<br>";
    echo strtoupper("António");
    echo "<br>";
    echo "Agora vê este resultado: " . mb_strtoupper("António");
?>