<?php session_start() ?>
<div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 border-bottom">
    <h1 class="h2">Estabelecimentos</h1>
</div>
<div class="container mt-5">
    <div class="modal fade" id="modalAdicionarEmpregado" tabindex="-1" aria-labelledby="modalAdicionarEmpregadoLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title text-dark" id="modalAdicionarEmpregadoLabel">Adicionar Estabelecimento</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <form action="./crud/addEstablishment.php" method='POST' enctype="multipart/form-data" id="addEstablishment">
                        <div class="mb-3">
                            <label for="nome" class="form-label text-dark">Nome</label>
                            <input type="text" class="form-control" id="nome" name="nome" required>
                        </div>
                        <div class="mb-3">
                            <label for="telefone" class="form-label text-dark">Telefone</label>
                            <input type="tel" class="form-control" id="telefone" name="telefone" required>
                        </div>
                        <div class="mb-3">
                            <label for="address" class="form-label text-dark">Endereço</label>
                            <input type="text" class="form-control" id="address" name="address" required>
                        </div>
                        <div class="mb-3 d-flex justify-content-between">
                            <div>
                                <label for=cp" class="form-label text-dark">Código-Postal</label>
                                <input type="text" class="form-control" id="cp" name="cp" required>
                            </div>
                            <div>   
                                <label for="local" class="form-label text-dark">Localidade</label>
                                <input type="text" class="form-control" id="local" name="local" required>
                            </div>
                        </div>
                        <div class="mb-3">
                            <input type="checkbox" class="form-check-input" id="AgendarSenhas" name="AgendarSenhas">
                            <label for="AgendarSenhas" class="form-check-label text-dark">Permitir o agendamento de senhas pela app</label>
                        </div>
                        <div class="mb-3">
                            <input type="checkbox" checked class="form-check-input" id="RetirarSenhasApp" name="RetirarSenhasApp">
                            <label for="RetirarSenhasApp" class="form-check-label text-dark">Permitir o pedido de senhas através da app</label>
                        </div>
                        <div class="mb-3">
                            <input type="checkbox" class="form-check-input" id="RetirarSenhasApenasLoja" name="RetirarSenhasApenasLoja">
                            <label for="RetirarSenhasApenasLoja" class="form-check-label text-dark">Restringir o pedido de senhas apenas no estabelecimento</label>
                        </div>
                        <div class="mb-3">
                            <input type="checkbox" class="form-check-input" id="semSetores" name="semSetores">
                            <label for="semSetores" class="form-check-label text-dark">Definir este estabelecimento como fila única</label>
                        </div>
                        <button type="submit" class="btn btn-primary">Adicionar</button>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <a class="btn btn-primary mb-5" data-bs-toggle="modal" data-bs-target="#modalAdicionarEmpregado">Adicionar Estabelecimento</a>
    <table class="table table-dark" >
    <thead>
    <tr>
        <th scope="col">Nome</th>
        <th scope="col">Telefone</th>
        <th scope="col">Agendar Senhas</th>
        <th scope="col">Senhas de App</th>
        <th scope="col">Senhas de Loja</th>
        <th scope="col">Fila única</th>
        <th scope="col">Opções</th>
        </tr>
    </thead>
    <?php
    include '../database/config.php';
    $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
        $link = new PDO($db, DB_USERNAME, DB_PASSWORD);


    $sql = "SELECT * FROM estabelecimento WHERE NIF_empresa = '".$_SESSION['company']."' ORDER BY Nome";


    $result = $link->query($sql);

    if ($result->rowCount() > 0) {

        echo "<tbody class=\"table-group-divider\">";
            /* 
                o método fetch() retira um registo de cada vez no conjunto de registos
                guardados em $result. Devolve um array.
            */
        while ($row = $result->fetch()) {
            echo "<tr>";
            echo "<td>" . $row['Nome'] . "</td>";
            echo "<td>" . $row['Telefone'] . "</td>";
            echo "<td>" ; 
            echo ($row['AgendarSenhas']) ? "<span class=\"material-icons vam\" >check</span>" : "<span class=\"material-icons vam\" >close</span>" ;
            echo "</td>";
            echo "<td>" ; 
            echo ($row['RetirarSenhasApp']) ? "<span class=\"material-icons vam\" >check</span>" : "<span class=\"material-icons vam\" >close</span>" ;
            echo "</td>";
            echo "<td>" ; 
            echo ($row['RetirarSenhasApenasLoja']) ? "<span class=\"material-icons vam\" >check</span>" : "<span class=\"material-icons vam\" >close</span>" ;
            echo "</td>";
            echo "<td>" ; 
            echo ($row['semSetores']) ? "<span class=\"material-icons vam\" >check</span>" : "<span class=\"material-icons vam\" >close</span>" ;
            echo "</td>";
            echo "<td >";
            echo ($row['semSetores']) ? "<a class='btn btn-light btn-sm me-1' href=\"http://localhost:4000/callTicket?NIF_Empresa=".$_SESSION['company']."&id_loja=".$row['id_loja']."\" target=\"_blank\"><span class=\"material-icons vam\" >confirmation_number</span></a>" : "<a class='btn btn-light btn-sm me-1' href=\"setPage.php?page=section&establishment=".$row['id_loja']."\"><span class=\"material-icons vam\" >format_list_numbered</span></a>";
            echo "<a class='btn btn-outline-primary btn-sm me-1' data-bs-toggle=\"modal\" data-bs-target=\"#modalAtualizarEmpregado\" title='Atualizar Registo' data-registo-id=".$row['id_loja']."><i class='far fa-edit'></i><span class=\"material-icons vam\" >edit</span></a>";
            echo "<a href='crud/deleteEstablishment.php?id=" . $row['id_loja'] . "' class='btn btn-danger btn-sm' title='Eliminar Registo'> <i class='far fa-trash-alt'></i><span class=\"material-icons vam\" >delete</span></a>";
            echo "</td>";
            echo "</tr>";
        }


        echo "</tbody>";
        echo "</table>";

        // Liberta os registos poupando memória
        unset($result);
    } else {
        echo "</table>";
        echo "<div class=\"d-flex h-100 w-100 mt-5 justify-content-center align-items-center\"><p><em>Ainda não existem estabelecimentos.</em></p></div>";
    }


    unset($link);

    ?>
</div>