<?php
include 'functions.php';

// Obtém o id pela URL
if(isset($_GET["id"]) && !empty(trim($_GET["id"])))
{
    require_once "config.php";
    
    // Prepara a sentença select
    // O PDO suporta tanto placeholder posicional (?) ou pelo placeholder (nome)
    $sql = "SELECT * FROM employees WHERE id = :id";
    
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
                
                $name = $row["name"];
                $address = $row["address"];
                $salary = $row["salary"];
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
    // URL doesn't contain id parameter. Redirect to error page
    $erro = "Ocorreu um erro. Tente mais tarde.";
    //exit();
}
?>


<?= template_header('Ver Item') ; ?>
<div class="container">
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
                    <th scope="col">Morada</th>
                    <th scope="col">Salário</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td scope="row"><?php echo $row["id"]; ?></td>
                    <td><?php echo $row["name"]; ?></td>
                    <td><?php echo $row["address"]; ?></td>
                    <td><?php echo $row["salary"]; ?></td>
                </tr>
            </tbody>
            </table>

            <p><a href="index.php">Voltar</a></p>
        </div>        
</div>

<?=template_footer(); ?>