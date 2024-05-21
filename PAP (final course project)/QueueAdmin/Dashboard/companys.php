<?php session_start() ?>
<div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 border-bottom">
    <h1 class="h2">Empresas</h1>
</div>
<div class="container mt-5">
    <div class="modal fade" id="modalAdicionarEmpregado" tabindex="-1" aria-labelledby="modalAdicionarEmpregadoLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title text-dark" id="modalAdicionarEmpregadoLabel">Adicionar Empresa</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <form action="./crud/addCompany.php" method='POST' enctype="multipart/form-data" id="addCompany">
                        <div class="mb-3">
                            <label for="NIFCompany" class="form-label text-dark">NIF</label>
                            <input type="text" class="form-control" id="NIFCompany" name="NIFCompany" required>
                        </div>
                        <div class="mb-3">
                            <label for="nomeCompany" class="form-label text-dark">Nome</label>
                            <input type="text" class="form-control" id="nomeCompany" name="nomeCompany" required>
                        </div>
                        <div class="mb-3">
                            <label for="areaEmp" class="form-label text-dark">Área Empresarial</label>
                            <input type="text" class="form-control" id="areaEmp" name="areaEmp" required>
                        </div>
                        <div class="mb-3">
                            <label for="logoCompany" class="form-label text-dark">Logotipo</label>
                            <input type="file" class="form-control" id="logoCompany" name="logoCompany">
                        </div>
                        <button type="submit" class="btn btn-primary">Adicionar</button>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <a class="btn btn-primary mb-5" data-bs-toggle="modal" data-bs-target="#modalAdicionarEmpregado">Adicionar Empresa</a>
        <?php
            $error_messages = array(
                'NIFisUsed' => 'O NIF introduzido já está registado',
                'FileTypeNotSupported' => 'Por favor introduza um ficheiro JPG, JPEG ou PNG'    
            );
            if(isset($_GET['content']) && isset($error_messages[$_GET['content']])) {
                echo "<div class=\"container-fluid\" style=\"display:flex; justify-content:center;\">
                    <div class=\"alert alert-dismissible alert-custom fade show d-flex align-items-center mb-2 mt-0\" role=\"alert\">
                        <div class=\"text-light\">{$error_messages[$_GET['content']]}</div>
                        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>
                    </div>
                </div>";
            }
            
        ?>
    </div>
    <table class="table table-dark" >
    <thead>
    <tr>
        <th scope="col">NIF</th>
        <th scope="col">Nome</th>
        <th scope="col">Área Empresarial</th>
        <th scope="col">Logotipo</th>
        <th scope="col">Opções</th>
        </tr>
    </thead>
    <?php
    include '../database/config.php';
    $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
        $link = new PDO($db, DB_USERNAME, DB_PASSWORD);


    $sql = "SELECT * FROM empresa WHERE emailAdmin = '".$_SESSION['loggedID']."' ORDER BY Nome";


    $result = $link->query($sql);

    if ($result->rowCount() > 0) {

        echo "<tbody class=\"table-group-divider\">";
            /* 
                o método fetch() retira um registo de cada vez no conjunto de registos
                guardados em $result. Devolve um array.
            */
        while ($row = $result->fetch()) {
            echo "<tr>";
            echo "<td>" . $row['NIF'] . "</td>";
            echo "<td>" . $row['Nome'] . "</td>";
            echo "<td>" . $row['AreaEmpresarial'] . "</td>";
            echo "<td>" ; 
            echo ($row['logoPath']) ? "<span class=\"material-icons vam\" >check</span>" : "<span class=\"material-icons vam\" >close</span>" ;
            echo "</td>";
            echo "<td >";
            echo "<a class='btn btn-light btn-sm me-1' href=\"setPage.php?page=establishments&company=".$row['NIF']."\"><span class=\"material-icons vam\" >store</span></a>";
            echo "<a class='btn btn-outline-primary btn-sm me-1' data-bs-toggle=\"modal\" data-bs-target=\"#modalAtualizarEmpregado\" title='Atualizar Registo' data-registo-id=".$row['NIF']."><i class='far fa-edit'></i><span class=\"material-icons vam\" >edit</span></a>";
            echo "<a href='crud/deleteCompany.php?NIF=" . $row['NIF'] . "' class='btn btn-danger btn-sm' title='Eliminar Registo'> <i class='far fa-trash-alt'></i><span class=\"material-icons vam\" >delete</span></a>";
            echo "</td>";
            echo "</tr>";
        }


        echo "</tbody>";
        echo "</table>";

        // Liberta os registos poupando memória
        unset($result);
    } else {
        echo "</table>";
        echo "<div class=\"d-flex h-100 w-100 mt-5 justify-content-center align-items-center\"><p><em>Ainda não existem empresas.</em></p></div>";
    }


    unset($link);

    ?>
</div>