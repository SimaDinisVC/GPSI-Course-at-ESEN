<?php

    echo "<h2>Processamento do formulário</h2>";

    // verifica se o array caixa_fruta das frutas existe
    if(isset($_POST['caixa_fruta'])){

        // guarda uma referência ao array numa variável    
        $frutaescolhida = $_POST['caixa_fruta'];

        // count($frutaescolhida) - conta o número de elementos do array
        if(count($frutaescolhida) != 0)
            // percorre o array
            for($i=0; $i < count($frutaescolhida); $i++){
                echo $frutaescolhida[$i] . "<br>";
            }
    }else {
        echo "Não foi escolhida qualquer fruta";
    }

    // CRIA O MESMO EXEMPLO UTILIZANDO UM SÓ FICHEIRO E NÃO DOIS.
?>