<?php session_start() ?>
<div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 border-bottom">
    <h1 class="h2">Setores</h1>
</div>
<div class="container mt-5">
    <div class="modal fade" id="modalAdicionarEmpregado" tabindex="-1" aria-labelledby="modalAdicionarEmpregadoLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title text-dark" id="modalAdicionarEmpregadoLabel">Adicionar Setor</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <form action="crud/addSection.php" method='POST' enctype="multipart/form-data" id="addGestor">
                        <div class="d-flex justify-content-between" >
                            <div class="mb-3">
                                <label for="nome" class="form-label text-dark">Nome</label>
                                <input type="text" class="form-control" id="nome" name="nome" required>
                            </div>
                            <div class="mb-3">
                                <label for="letra" class="form-label text-dark">Letra Indentificadora</label>
                                <input type="text" class="form-control" id="letra" name="letra" required>
                            </div>
                        </div>
                        <button type="submit" class="btn btn-primary">Adicionar</button>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <a class="btn btn-primary mb-5" data-bs-toggle="modal" data-bs-target="#modalAdicionarEmpregado">Adicionar Setor</a>
    <table class="table table-dark" >
    <thead>
    <tr>
        <th scope="col">Nome</th>
        <th scope="col">Indicador</th>
        <th scope="col">Opções</th>
        </tr>
    </thead>
    <?php
    include '../database/config.php';
    $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
        $link = new PDO($db, DB_USERNAME, DB_PASSWORD);


    $sql = "SELECT * FROM setor WHERE id_loja = '" . $_SESSION['establishment'] . "' ORDER BY Nome";


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
            echo "<td>" . $row['letra_indicativa'] . "</td>";
            echo "<td>";
            echo "<a class='btn btn-light btn-sm me-1' href=\"http://localhost:4000/callTicket?NIF_Empresa=".$_SESSION['company']."&id_loja=".$_SESSION['establishment']."&id_setor=".$row['id_setor']."\" target=\"_blank\"><span class=\"material-icons vam\" >confirmation_number</span></a>";
            echo "<a class='btn btn-outline-primary btn-sm me-1' data-bs-toggle=\"modal\" data-bs-target=\"#modalAtualizarEmpregado\" title='Atualizar Registo' data-registo-id=".$row['id_setor']."><i class='far fa-edit'></i><span class=\"material-icons vam\" >edit</span></a>";
            echo "<a href='crud/deleteSection.php?id_setor=" . $row['id_setor'] . "' class='btn btn-danger btn-sm' title='Eliminar Registo'> <i class='far fa-trash-alt'></i><span class=\"material-icons vam\" >delete</span></a>";
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