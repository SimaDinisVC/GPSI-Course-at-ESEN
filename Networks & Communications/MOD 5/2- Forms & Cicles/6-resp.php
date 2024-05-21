<?php
// APRSENTA A INFORMAÇÃO SUBMETIDA NO FORMULÁRIO SEGUNDO UMA LÓGICA PRÁTICA.
if(empty($_POST['dia']))
{
    echo "<p>Não preencheu o campo dia</p>";
}
if(empty($_POST['mes']))
{
    echo "<p>Não preencheu o campo mes</p>";
}
if(empty($_POST['ano']))
{
    echo "<p>Não preencheu o campo ano</p>";
}
?>

