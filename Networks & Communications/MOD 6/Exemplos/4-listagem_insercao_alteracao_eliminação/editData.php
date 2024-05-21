<?php
include_once("functions.php");
$con = pdo_connect_mysql();

// recebe o id do elemento
$id = $_POST["id"];

// obtém a informação do elemento cujo id da tabela é igual ao id que vem do pedido (javascript)
$sql = "SELECT * FROM comments WHERE id='$id'";

if($result = $con->query($sql)){
    if($result->rowCount() > 0){
        
        $row = $result->fetch();
        // devolve o formulário
        echo '<form id="frmedit" action="">
                <input type="hidden" id="id" name="id" value="'. $row['id'] . '">
                <div class="form-group">
                    <label for="recipient-name" class="col-form-label">Autor:</label>
                    <input type="text" class="form-control" name="inputAuthor" id="inputAuthor" value="' . $row['author'] . '">
                </div>
                <div class="form-group">
                    <label for="message-text" class="col-form-label">Mesagem:</label>
                    <input type="text" class="form-control" name="inputMessage" id="inputMessage" value="' . $row['message'] . '">
                </div>
        </form>';
        
    } else{
        echo "<p class='lead'><em>Não foram encontrados registos.</em></p>";
    }
}

// Close connection
unset($con);

?>