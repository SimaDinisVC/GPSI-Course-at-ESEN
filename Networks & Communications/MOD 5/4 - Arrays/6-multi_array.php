<!doctype html>
<html>
    <head>
    <meta charset="utf-8">
    <title>Array multidimensional</title>
</head>

<body>
<p>Alguns códigos postais por região:</p>
<?php

    // Cria o array: viseu
    $viseu = array(
        '3501-000' => 'Viseu',      //($k => $v), $k é a chave e $v é o valor naquela chave
        '3510-001' => 'Abraveses',
        '3520-100' => 'Mangualde'
    );

    // Cria o array: lisboa
    $lisboa = array (
        '1100-030' => 'Sé',
        '1170-401' => 'Graça',
        '1150-144' => 'Anjos',
        '1070-202' => 'Campolide' 
    );

    // Cria o array: porto
    $porto = array (
        '4000-996' => 'Sé', 
        '4100-475' => 'Aldoar',
        '4200-315' => 'Bomfim',
        '4300-493' => 'Campanhã',
        '4150-740' => 'Foz do Douro'
    );

    // Combina os arrays:
    $codpostal = array(
        'Viseu' => $viseu,      // ($cidade => $lista), $cidade é a chave e $lista é um array
        'Lisboa' => $lisboa,
        'Porto' => $porto
    );

    foreach ($codpostal as $cidade => $lista) {

        // cabeçalho:
        echo "<h2>$cidade</h2>";
        echo "<ul>";
        
        foreach ($lista as $k => $v) {
            echo "<li>$k - $v</li>\n";
        }

        echo '</ul>';

    }

?>
</body>
</html>