<?php
    require_once("rotinas.php");
    $con = pdo_connect_mysql();

    //$sql = "SELECT name FROM contacts WHERE name LIKE ?";
    $sql = "SELECT name FROM contacts WHERE name LIKE :name";
    $stmt = $con->prepare($sql);
    $param = $_GET['q']."%";
    //$stmt->bindParam("s", $param);
    $stmt->bindParam(":name", $param);
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