<?php

// Obtém o id pela URL
if(isset($_GET["id"]) && !empty(trim($_GET["id"])))
{
    require_once "config.php";
    
    // Prepara a sentença select
    // O PDO suporta tanto placeholder posicional (?) ou pelo placeholder name (nome)
    $sql = "SELECT * FROM persons WHERE id = :id";
    
    if($stmt = $link->prepare($sql))
    {
        // Liga o placeholder à variável
        $stmt->bindParam(":id", $param_id);
        
        $param_id = trim($_GET["id"]);
        
        // executa a sentença
        if($stmt->execute())
        {
            // Número de linhas resultante da execução da sentença
            if($stmt->rowCount() == 1)
            {
                /* Obtém um registo como array associativo. */
                $row = $stmt->fetch(PDO::FETCH_ASSOC);
                
                $first_name = $row["first_name"];
                $last_name = $row["last_name"];
                $email = $row["email"];
            } else{
                // URL contém parâmetros errados
                // header("location: error.php");
                // exit();
                $erro = "O registo não foi encontrado";
            }
            
        } else{
            $erro = "Ocorreu um erro. Tente mais tarde.";
        }
    }
     
    unset($stmt);
    unset($link);

} else{
    // O parâmetro id não veio na URL. Redirecionar para uma página de erro.
    $erro = "Ocorreu um erro. Tente mais tarde.";
    //exit();
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Ver Registo</title>
</head>
<body>
    <?php 
        if(isset($erro))
        {
            echo '<div>';
            echo $erro;
            echo '</div>';
        }
    ?>

    <div>
        <table class="table">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">Nome</th>
                <th scope="col">Apelido</th>
                <th scope="col">Email</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <!-- Pode utilizar as variáveis definidas acima ou o array associativo -->
                <td scope="row"><?php echo $row["id"]; ?></td>
                <td><?php echo $row["first_name"]; ?></td>
                <td><?php echo $row["last_name"]; ?></td>
                <td><?php echo $email; ?></td>
            </tr>
        </tbody>
        </table>

        <p><a href="index.php">Voltar</a></p>
    </div>        
</body>
</html>