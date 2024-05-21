<?php

require_once "config.php";
 
// Inicializa variáveis
$first_name = $last_name = $email = "";
$first_name_err = $last_name_err = $email_err = "";
 
// Deteta se o formulário foi submetido
if(isset($_POST["id"]) && !empty($_POST["id"]))
{
    // Obtém o valor do id
    $id = $_POST["id"];
    
    // Validação do nome, aceita apenas letras
    $input_first_name = trim($_POST["first_name"]);
    if(empty($input_first_name)){
        $name_err = "Insira o nome.";
    } elseif(!filter_var($input_first_name, FILTER_VALIDATE_REGEXP, array("options"=>array("regexp"=>"/^[a-zA-Z\s]+$/")))){
        $first_name_err = "Insira um nome válido.";
    } else{
        $first_name = $input_first_name;
    }

     // Validação do apelido, aceita apenas letras
     $input_last_name = trim($_POST["last_name"]);
     if(empty($input_last_name)){
         $last_name_err = "Insira o apelido.";
     } elseif(!filter_var($input_last_name, FILTER_VALIDATE_REGEXP, array("options"=>array("regexp"=>"/^[a-zA-Z\s]+$/")))){
         $last_name_err = "Insira um apelido válido.";
     } else{
         $last_name = $input_last_name;
     }
    
     $input_email = trim($_POST["email"]);
     if(empty($input_email)){
         $email_err = "Insira o email.";
     } elseif(!filter_var($input_email, FILTER_VALIDATE_EMAIL)){
         $email_err = "Insira um email válido.";
     } else{
         $email = $input_email;
     }

    
    // Verifica se existem erros, considerando que uma variável vazia é sinal de não haver erro
    if(empty($first_name_err) && empty($last_name_err) && empty($email_err))
    {
        // Prepara a setençã
        $sql = "UPDATE persons SET first_name=:first_name, last_name=:last_name, email=:email WHERE id=:id";

        if($stmt = $link->prepare($sql)){
           
            $stmt->bindParam(":first_name", $param_first_name);
            $stmt->bindParam(":last_name", $param_last_name);
            $stmt->bindParam(":email", $param_email);
            $stmt->bindParam(":id", $param_id);
            
            $param_first_name = $first_name;
            $param_last_name = $last_name;
            $param_email = $email;
            $param_id = $id;
            
            if($stmt->execute())
            {
                // Records updated successfully. Redirect to landing page
                header("location: index.php");
                exit();
            } else{
                echo "Algo aconteceu, tente mais tarde.";
            }
        }

        unset($stmt);
    }
    
    unset($link);
} else{

    // Verifica se o ID foi passado por parâmetro
    if(isset($_GET["id"]) && !empty(trim($_GET["id"])))
    {
        // Obtém o parâmetro da URL
        $id =  trim($_GET["id"]);
        
        // Obtém os resultados para mostrar nas input's
        $sql = "SELECT * FROM persons WHERE id = :id";
        if($stmt = $link->prepare($sql))
        {
            $stmt->bindParam(":id", $param_id);
            $param_id = $id;
        
            if($stmt->execute())
            {
                if($stmt->rowCount() == 1){
                    $row = $stmt->fetch(PDO::FETCH_ASSOC);
                
                    $first_name       = $row["first_name"];
                    $last_name    = $row["last_name"];
                    $email     = $row["email"];
                } else{
                    // O ID é inválido
                    header("location: error.php");
                    exit();
                }
                
            } else{
                echo "Oops! algo de errado aconteceu...";
            }
        }
        
        unset($stmt);
        unset($link);
    }  else{
        header("location: error.php");
        exit();
    }
}
?>
 
<!DOCTYPE html>
<html lang="pt-pt">
<head>
    <meta charset="UTF-8">
    <title>Atualizar Registo</title>
</head>
<body>
   
    <h2>Atualize os seus dados</h2> <hr>
    <p>Altere os campos que pretende modificar.</p>
    <form action="<?php echo htmlspecialchars(basename($_SERVER['REQUEST_URI'])); ?>" method="post">
        <div>
            <label>Nome</label>
            <input type="text" name="first_name" value="<?php echo $first_name; ?>">
            <span><?php echo $first_name_err;?></span>
        </div>
        <div>
            <label>Apelido</label>
            <input type="text" name="last_name" value="<?php echo $last_name; ?>">
            <span><?php echo $last_name_err;?></span>
        </div>
        <div>
            <label>Email</label>
            <input type="text" name="email" value="<?php echo $email; ?>">
            <span><?php echo $email_err;?></span>
        </div>

        <!-- Guarda o ID para posteriormente atualizar o registo correto -->
        <input type="hidden" name="id" value="<?php echo $id; ?>"/>
        <input type="submit" class="btn btn-primary" value="Gravar">
        <a href="index.php" class="btn btn-default">Cancelar</a>
    </form>
           
</body>
</html>