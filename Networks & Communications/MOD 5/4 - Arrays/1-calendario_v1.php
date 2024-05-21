<!doctype html>
<html>
    <head>
    <meta charset="utf-8">
    <title>Criar e acesso ao array</title>
</head>

<body>

    <?php
        // define os arrays dos meses em português
        include('lib/utils.php');

        if($_SERVER['REQUEST_METHOD'] == 'POST'){
            // Depois de submeter mostra a data selecionada
            echo $_POST['dia']. "/" . $_POST['mes'] . "/" . $_POST['ano'];
            echo "<br>";
            echo $_POST['n_dia']. "/" . $_POST['n_mes'] . "/" . $_POST['n_ano'];
        }
    ?>


    <!-- PREVENÇÃO DE ATAQUES - SEGURANÇA
		 a função htmlspecialchars() converte caracteres especiais em HTML entities. 
		 Por exemplo, converte o carácter  < em &lt;
    -->		
    <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
    <?php

        // O primeiro método usa o conceito de ciclo para preencher o select
        echo '<select name="dia">';
            for($dia=1; $dia <= 31; $dia++) {
                echo "<option value=\"$dia\">$dia</option>\n";
            }
        echo '</select>';

        echo '<select name="mes">';
            foreach ($meses as $key => $valor) {
                echo "<option value=\"$key\">$valor</option>\n";
            }
        echo '</select>';

        echo '<select name="ano">';
            for ($anos=2000; $anos <= 2030; $anos++) {
                echo "<option value=\"$anos\">$anos</option>\n";
            }
        echo '</select>';


        echo "<br><br><br>";

        // -----------------------------------------------------------------
        // Outra versão
        // -----------------------------------------------------------------

        // Cria os arrays dias do mês e anos:
        $n_dias = range (1, 31);
        $n_anos = range (2000, 2030);

        /*
            Também poderiamos ter um array de caracteres
            $character_array = range('e','i'); //  returns array('e','f','g','h','i');
        */

        echo '<select name="n_dia">';
            foreach ($n_dias as $valor) {
                echo "<option value=\"$valor\">" . $valor . "</option>\n";
                // poderá usar a função next() para obter o valor seguinte do array
                next($n_dias);
            }
        echo '</select>';

        echo '<select name="n_mes">';
            foreach ($meses as $key => $valor) {
                echo "<option value=\"$key\">$valor</option>\n";
            }
        echo '</select>';

        echo '<select name="n_ano">';
            foreach ($n_anos as $valor) {
                echo "<option value=\"$valor\">$valor</option>\n";
            }
        echo '</select>';


        echo '<input type="submit" name="enviar" value="Validar">';
    ?>
    
    </form>
</body>
</html>