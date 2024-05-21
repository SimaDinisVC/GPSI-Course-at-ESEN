<?php
    require_once("rotinas.php");
    $con = pdo_connect_mysql();

    $param = $_GET['q']."%";

    // outra forma de utilizar os parâmetros
    $sql = "SELECT name FROM contacts WHERE name LIKE '$param'";
    $results = $con->query($sql);
    if($results){
        if($results->rowCount() > 0){
            while($row = $results->fetch()){
                echo $row["name"] . "; ";
            }
        } else{
            // Poderiamos enviar diretamente a mensagem, o envio de um 
            // código pode ajudar a personalizar as mensagens no lado do cliente
            echo "1";
        }
    } else{
        //echo "ERRO: Não pode executar o comando $sql. " . $con->error;
        echo "2";
    }
    unset($con);
?>