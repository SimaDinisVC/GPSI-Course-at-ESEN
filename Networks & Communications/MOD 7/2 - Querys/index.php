<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Dashboard</title>
</head>
<body>

    <h3>Detalhes do Empregados</h3>
    <p>Exemplificação do CRUD com empregados <a href="create.php">Adicionar Empregado</a></p>
        
    <?php
         require_once "config.php";
                
        // lista todos os empregados
        $sql = "SELECT * FROM persons";
        
        // Executa o comando SQL
        if ($result = $link->query($sql)) 
        {
            // verifica se existem registos
            if ($result->rowCount() > 0) {
                echo "<table>";
                echo "<thead>";
                echo "<tr>";
                echo "<th>#</th>";
                echo "<th>Nome</th>";
                echo "<th>Apelido</th>";
                echo "<th>Email</th>";
                echo "<th>Ação</th>";
                echo "</tr>";
                echo "</thead>";

                echo "<tbody>";
                    /* 
                        o método fetch() retira um registo de cada vez no conjunto de registos
                        guardados em $result. Devolve um array.  
                    */
                while ($row = $result->fetch()) {
                    echo "<tr>";
                    echo "<td>" . $row['id'] . "</td>";
                    echo "<td>" . $row['first_name'] . "</td>";
                    echo "<td>" . $row['last_name'] . "</td>";
                    echo "<td>" . $row['email'] . "</td>";
                    echo "<td>";
                    echo "<a href='read.php?id=" . $row['id'] . "' title='Ver Registo'>Ver Registo </a> &nbsp;&nbsp;| &nbsp;&nbsp;";
                    echo "<a href='update.php?id=" . $row['id'] . "' title='Atualizar Registo'>Atualizar Registo </a> &nbsp;&nbsp;|&nbsp;&nbsp;";
                    echo "<a href='delete.php?id=" . $row['id'] . "' title='Eliminar Registo'> Apagar Registo</a>";
                    echo "</td>";
                    echo "</tr>";
                }
                echo "</tbody>";
                echo "</table>";

                // determina o total dos empregados
                $sql = "SELECT COUNT(email) as Total FROM persons";
                if ($result = $link->query($sql)){
                    $row = $result->fetch();
                    echo '<div><br><br>';
                    echo "Total de empregados: " . $row['Total'];
                    echo '</div>';
                    
                }

                // Liberta os registos poupando memória
                unset($result);
            } else {
                echo "<p><em>Não há empregados registados.</em></p>";
            }
        } else {
            echo "ERRO: $sql. " . $mysqli->error;
        }
        
        // Fecha a ligação ao servidor
        unset($link);
        ?>
           
</body>
</html>