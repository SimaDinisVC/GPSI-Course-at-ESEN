

<p>----------------------------HTML--------------------------------</p>

<?php
    echo '<h1>Variáveis predefinidas</h1>';

    // Variável Global
    $ficheiro   = $_SERVER['SCRIPT_FILENAME'];  // caminho do ficheiro desde a raíz
    $browser    = $_SERVER['HTTP_USER_AGENT'];  // informação sobre o browser
    $servidor   = $_SERVER['SERVER_SOFTWARE'];  // versão do servidor e do PHP ...
    $host       = $_SERVER['HTTP_HOST'];        // nome da máquina servidora


    echo "<p>Nome e caminho do script: <b>$ficheiro</b></p>";

    echo "<p>Nome do browser: <b>$browser</b></p>";

    echo "<p>Nome do servidor web: <b>$servidor</b></p>";

    echo "<p>Nome do host: <b>$host</b></p>";

    echo "<p>Este servidor web executa a versão PHP <b>" . 
        PHP_VERSION . "</b> no sistema operativo <b>" . PHP_OS . "</b></p>";

     echo "SO: <b>" .php_uname() . "</b>";
?>



<p>---------------------------DEBUG---------------------------------</p>

<h1>A função print_r</h1>
<p>O debuging de um programa é uma tarefa muito comum. O aluno tem que saber utilizar esta técnica.</p>
<pre>
<?php
    echo 'O que ficou guardado na variável $host ?<br>';
    echo '<p>Para fazer o debug basta escrever: <b>print_r($host)</b></p>';
    
    
    print_r($_SERVER) . '<br />';
    echo "<br><br><br><br>-------------------------- OUTRA FORMA EQUIVALENTE --------------------------<br>";
    var_dump($_SERVER);

?>
</pre>
