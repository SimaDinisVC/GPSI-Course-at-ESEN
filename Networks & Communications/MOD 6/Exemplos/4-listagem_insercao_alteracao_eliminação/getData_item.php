<?php
include_once("functions.php");
$con = pdo_connect_mysql();

$sql = "SELECT * FROM comments";
if($result = $con->query($sql)){
    if($result->rowCount() > 0){
        
            while($row = $result->fetch()){
                echo "<tr>";
                    echo "<td>" . $row['id'] . "</td>";
                    echo "<td>" . $row['author'] . "</td>";
                    echo "<td>" . $row['message'] . "</td>";
                    echo '<td>
                            <button type="button" class="btn btn-warning" onclick="editData(' . $row['id'] . ')" data-toggle="modal" data-target="#editModal">Editar</button>
                            <button type="button" class="btn btn-danger" onclick="removeData(' . $row['id'] . ')">Remover</button>
                        </td>';
                echo "</tr>";
            }
        // Free result set
        unset($result);
    } else{
        echo "<p class='lead'><em>Não foram encontrados registos...</em></p>";
    }
}

// Close connection
unset($con);

?>