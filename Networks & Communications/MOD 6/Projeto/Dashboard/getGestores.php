<?php
include '../database/config.php';

$db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
$link = new PDO($db, DB_USERNAME, DB_PASSWORD);

$sql = "SELECT * FROM users WHERE cargo = 'gestor'";
// Executa o comando SQL
if ($result = $link->query($sql)) 
{
    echo '<div class="modal fade" id="modalAtualizarEmpregado" tabindex="-1" aria-labelledby="modalAtualizarEmpregadoLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title text-dark" id="modalAtualizarEmpregadoLabel">Atualizar Gestor</h5>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <div class="modal-body">
                    <form id="updateGestor">
                    <input type="hidden" id="registoId" name="registoId" value="">
                    <div class="mb-3">
                        <label for="nomeEmpregado" class="form-label text-dark">Nome:</label>
                        <input type="text" class="form-control" id="inputNomee" name="nomeEmpregado" required>
                    </div>
                    <div class="mb-3">
                        <label for="senhaEmpregado" class="form-label text-dark">Password:</label>
                        <input type="password" class="form-control" id="inputPasss" name="senhaEmpregado" required>
                    </div>
                    <button type="submit" class="btn btn-primary">Atualizar</button>
                </form>
            </div>
        </div>
    </div>
</div>
<script>
    document.getElementById(\'updateGestor\').addEventListener(\'submit\', function(event) {
    event.preventDefault();
    
    var registoId = document.getElementById(\'registoId\').value;
    var nomeEmpregado = document.getElementById(\'inputNomee\').value;
    var senhaEmpregado = document.getElementById(\'inputPasss\').value;

    var formData = {
        registoId: registoId,
        nomeEmpregado: nomeEmpregado,
        senhaEmpregado: senhaEmpregado
    };

    // Requisição AJAX
    $.ajax({
        type: \'POST\',
        url: \'updateGestor.php\',
        data: formData,
        success: function(response) {
            // Atualizar a tabela com os novos dados retornados pela requisição AJAX
            $.ajax({
                url: \'getGestores.php\',
                type: \'GET\',
                success: function(data2){
                    // Atualizar o conteúdo da tabela com os novos dados
                    $(\'#tabelaGestores\').html(data2);
                    // Fechar o modal após a atualização
                    $(\'#modalAtualizarEmpregado\').modal(\'hide\');
                },
                error: function(){
                    // Tratar erros, se necessário
                }
            });
        },
        error: function(xhr, status, error) {
            // Lidar com erros de requisição aqui
            console.error(xhr.responseText);
        }
    });
});
</script>
';

    // verifica se existem registos
    if ($result->rowCount() > 0) {
        echo "<table class=\"table table-dark\" >";
        echo "<thead>";
        echo "<tr>";
        echo "<th scope=\"col\">#</th>";
        echo "<th scope=\"col\">Nome</th>";
        echo "<th scope=\"col\">Email</th>";
        echo "<th scope=\"col\">Cargo</th>";
        echo "<th scope=\"col\">Opções</th>";
        echo "</tr>";
        echo "</thead>";

        echo "<tbody class=\"table-group-divider\">";
            /* 
                o método fetch() retira um registo de cada vez no conjunto de registos
                guardados em $result. Devolve um array.
            */
        while ($row = $result->fetch()) {
            echo "<tr>";
            echo "<td>" . $row['userID'] . "</td>";
            echo "<td>" . $row['nome'] . "</td>";
            echo "<td>" . $row['email'] . "</td>";
            echo "<td>" . $row['cargo'] . "</td>";
            echo "<td>";
            echo "<a href='' class='btn btn-light btn-sm me-1' title='Ver Registo'> <i class='far fa-eye'></i> Ver </a>";
            echo "<a class='btn btn-outline-light btn-sm me-1' data-bs-toggle=\"modal\" data-bs-target=\"#modalAtualizarEmpregado\" title='Atualizar Registo' data-registo-id=".$row['userID']."><i class='far fa-edit'></i> Atualizar </a>";
            echo "<a href='deletePerfile.php?id=" . $row['userID'] . "' class='btn btn-danger btn-sm' title='Eliminar Registo'> <i class='far fa-trash-alt'></i> Apagar</a>";
            echo "</td>";
            echo "</tr>";
        }

        // Fazer aqui o AJAX
        echo "</tbody>";
        echo "</table>";

        // Liberta os registos poupando memória
        unset($result);
    } else {
        echo "<p><em>Não há gestores registados.</em></p>";
    }
}

echo "<script>document.getElementById('modalAtualizarEmpregado').addEventListener('show.bs.modal', function (event) {
    var button = event.relatedTarget;
    var registoId = button.getAttribute('data-registo-id');
    document.getElementById('registoId').value = registoId;
  });</script>
  ";

// Fecha a ligação ao servidor
unset($link);
?>
