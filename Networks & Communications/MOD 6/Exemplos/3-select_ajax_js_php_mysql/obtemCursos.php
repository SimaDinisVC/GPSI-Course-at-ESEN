<?php
// intval - lê o valor inteiro da variável
$q = intval($_GET['q']);

require_once("rotinas.php");
$con = pdo_connect_mysql();

$sql="SELECT * FROM cursos WHERE id_curso = '".$q."'";
$result = $con->query($sql);
if($result){
    if($result->rowCount() > 0){
        // o output vai ser recebido pela função anónima do evento onreadystatechange
        echo "<table>
        <tr>
        <th>Designação</th>
        <th>Sigla</th>
        </tr>";
        // retira um registo de cada vez da tabela cursos
        while($row = $result->fetch()) {
            echo "<tr>";
            echo "<td>" . $row['id_curso'] . "</td>";
            echo "<td>" . $row['nome'] . "</td>";
            echo "<td>" . $row['sigla'] . "</td>";
            echo "</tr>";
        }
        echo "</table>";
        unset($con);
    }
    else {
        echo "Não existem cursos registados";
    }
}
?>