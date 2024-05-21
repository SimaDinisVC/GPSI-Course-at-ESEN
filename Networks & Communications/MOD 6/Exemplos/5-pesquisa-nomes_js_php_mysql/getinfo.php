<?php
    require_once("rotinas.php");
    $con = pdo_connect_mysql();

    // outra forma de utilizar os parâmetros, comm placeholder (?)
    $sql = "SELECT name FROM contacts WHERE name LIKE ?";
    $stmt = $con->prepare($sql);
    $param = $_GET['q']."%";
    // 1 representa a ordem dos parâmetros, neste caso só tem 1 parâmetro
    $stmt->bindParam(1, $param);
    if($stmt->execute()){
        if($stmt->rowCount() > 0){
            while($row = $stmt->fetch()){
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
    
    unset($stmt);
    unset($con);
?>