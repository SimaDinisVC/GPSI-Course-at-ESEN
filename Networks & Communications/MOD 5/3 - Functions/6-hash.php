<?php

    /*
        Retirado de: https://pt.wikipedia.org/wiki/Fun%C3%A7%C3%A3o_hash

        Uma função hash é um algoritmo que mapeia dados de comprimento variável 
        para dados de comprimento fixo. 
        Os valores devolvidos por uma função hash são chamados valores hash, 
        códigos hash, somas hash (hash sums), checksums ou simplesmente hashes.

        Estas funções são utilizadas em bases de dados, verificam a integridade de 
        ficheiros após download (permitem verificar se os ficheiros foram alterados) 
        ou permitem a comparação se senhas com os valores existentes em bases de dados.


        Apresenta-se duas funções que criam códigos hash: a MD5 (Algoritmo de Message Digest)
        e a SHA1 (Algoritmo de Hashing Seguro).
    */

    // entrada
    $input = "Curso de Programação";

    // O MD5 (Message-Digest algorithm 5) é um algoritmo de hash de 128 bits (32 dígitos)
    $result1 = md5($input);

    // (Secure Hash Algorithm) - 160 bits conhecido como resumo da mensagem (40 dígitos).
    $result2 = sha1($input);

    // saída : c8305294b8e10b323b3841fd8d51fbae
    echo $result1;
    echo "<br>";
    // saída: d222fc3fb3fbc44802f924ae71793e8c10c53c82
    echo $result2;


    echo "<br>----------------------------------------------------------<br>";

    $senha = "pipocas2019";

    // senha guardada na base de dados
    $senhaEnc = sha1($senha);

    if($senhaEnc == "7b745dd427a6b12b5e3c09b0ba08d397512ed33c"){
        echo "Pode entrar no sistema";
    } else {
        echo "Lamento, não tem autorização para entrar no sistema!!!";
    }

?>

