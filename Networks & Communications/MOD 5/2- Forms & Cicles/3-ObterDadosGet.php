<!doctype html>
<html lang="pt-pt">
    <head>
    <meta charset="utf-8">
    <title>Identifica o nome nome ...</title>
</head>

<body>
<div>
    <p>Click no link e obtenha o um nome:</p>
    
	<?php
        /*
            Pretende-se enviar dados para noutra página utilizando o endereço URL.
        */
        $nome1  = "Michael_Ramon";
        $nome2  = "Célia";
        $idade2 = 30;
        $nome3  = "Jude";
        $nome4  = "Raul-Amaral";
        $idade4 = 15;
    ?>

    <ul>
        <li>
        <!-- O link chama o ficheiro 3-ProcessaGet.php e passa um parâmetro nome.
                Este parâmetro guarda o conteúdo das variáveis. -->
            <a href="3-ProcessaGet.php?nome=<?php echo $nome1; ?>">Michael</a>
        </li>
        <li>
            <a href="3-ProcessaGet.php?nome=<?=$nome2; ?>&idade=<?= $idade2; ?>">Celia</a>
        </li>
        <li>
            <!--    Outra forma de escrever o link, recorrendo a PHP -->
            <?php echo '<a href="3-ProcessaGet.php?nome=' . $nome3 . '">Jude</a>'; ?>
        </li>
        <li>
            <a href="3-ProcessaGet.php?nome=<?= $nome4; ?>&idade=<?= $idade4; ?>">Raul</a>
        </li>
    </ul>
</div>
</body>
</html>
