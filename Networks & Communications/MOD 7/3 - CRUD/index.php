<?php
include 'functions.php';
template_header('Listagem') ;
?>
<div class="container">
    
    <h3>Detalhes do Empregados</h3>
    <p>Exemplificação do CRUD com empregados <a href="create.php"><b>Adicionar Empregado</b></a></p>
        
    <?php
         require_once "config.php";
                
        // lista todos os empregados
        $sql = "SELECT * FROM employees";
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
                echo "<th>Morada</th>";
                echo "<th>Salário</th>";
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
                    echo "<td>" . $row['name'] . "</td>";
                    echo "<td>" . $row['address'] . "</td>";
                    echo "<td>" . $row['salary'] . "€</td>";
                    echo "<td>";
                    echo "<a href='read.php?id=" . $row['id'] . "' title='Ver Registo'> <i class='far fa-eye'></i> Ver Registo </a> &nbsp;&nbsp;| &nbsp;&nbsp;";
                    echo "<a href='update.php?id=" . $row['id'] . "' title='Atualizar Registo'> <i class='far fa-edit'></i> Atualizar Registo </a> &nbsp;&nbsp;|&nbsp;&nbsp;";
                    echo "<a href='delete.php?id=" . $row['id'] . "' title='Eliminar Registo'> <i class='far fa-trash-alt'></i> Apagar Registo</a>";
                    echo "</td>";
                    echo "</tr>";
                }
                echo "</tbody>";
                echo "</table>";

                // determina o total dos salários
                $sql = "SELECT SUM(salary) as Total FROM employees";
                if ($result = $link->query($sql)){
                    $row = $result->fetch();
                    echo '<div><br><br>';
                    echo "Total em salários: " . $row['Total'];
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
</div>

<?=template_footer(); ?>