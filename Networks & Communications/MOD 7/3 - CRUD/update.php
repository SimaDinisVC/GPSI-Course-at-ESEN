<?php
include 'functions.php';
require_once "config.php";
 
// Inicializa variáveis
$name = $address = $salary = $username = $password = "";
$name_err = $address_err = $salary_err = $username_err = $password_err = "";
 
// Deteta se o formulário foi submetido
if(isset($_POST["id"]) && !empty($_POST["id"]))
{
    // Obtém o valor do id
    $id = $_POST["id"];
    
    // Validação do nome, aceita apenas letras
    $input_name = trim($_POST["name"]);
    if(empty($input_name)){
        $name_err = "Insira o nome.";
    } elseif(!filter_var($input_name, FILTER_VALIDATE_REGEXP, array("options"=>array("regexp"=>"/^[a-zA-Z\s]+$/")))){
        $name_err = "Insira um nome válido.";
    } else{
        $name = $input_name;
    }
    
    // Validação da morada
    $input_address = trim($_POST["address"]);
    if(empty($input_address)){
        $address_err = "Insira a morada.";     
    } else{
        $address = $input_address;
    }
    
    // Validação do salário como inteiro positivo
    $input_salary = trim($_POST["salary"]);
    if(empty($input_salary)){
        $salary_err = "Insira um valor.";     
    } elseif(!ctype_digit($input_salary)){
        $salary_err = "Insira um valor inteiro positivo.";
    } else{
        $salary = $input_salary;
    }
    
    // Verifica se existem erros, considerando que uma variável vazia é sinal de não haver erro
    if(empty($name_err) && empty($address_err) && empty($salary_err))
    {
        // Prepara a setençã
        $sql = "UPDATE employees SET name=:name, address=:address, salary=:salary WHERE id=:id";

        if($stmt = $link->prepare($sql)){
           
            $stmt->bindParam(":name", $param_name);
            $stmt->bindParam(":address", $param_address);
            $stmt->bindParam(":salary", $param_salary);
            $stmt->bindParam(":id", $param_id);
            
            $param_name = $name;
            $param_address = $address;
            $param_salary = $salary;
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
        $sql = "SELECT * FROM employees WHERE id = :id";
        if($stmt = $link->prepare($sql))
        {
            $stmt->bindParam(":id", $param_id);
            $param_id = $id;
        
            if($stmt->execute())
            {
                if($stmt->rowCount() == 1){
                    $row = $stmt->fetch(PDO::FETCH_ASSOC);
                
                    $name       = $row["name"];
                    $address    = $row["address"];
                    $salary     = $row["salary"];
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
 
 <?= template_header('Atualizar Item') ; ?>
<div class="container">
    <h2>Atualize os seus dados</h2> <hr>
    <p>Altere os campos que pretende modificar.</p>
    <form action="<?php echo htmlspecialchars(basename($_SERVER['REQUEST_URI'])); ?>" method="post">
        <div>
            <label>Nome</label>
            <input type="text" name="name" value="<?php echo $name; ?>">
            <span><?php echo $name_err;?></span>
        </div>
        <div>
            <label>Morada</label>
            <textarea name="address" class="form-control"><?php echo $address; ?></textarea>
            <span><?php echo $address_err;?></span>
        </div>
        <div>
            <label>Salário</label>
            <input type="text" name="salary" value="<?php echo $salary; ?>">
            <span><?php echo $salary_err;?></span>
        </div>

        <!-- Guarda o ID para posteriormente atualizar o registo correto -->
        <input type="hidden" name="id" value="<?php echo $id; ?>"/>
        <input type="submit" class="btn btn-primary" value="Gravar">
        <a href="index.php" class="btn btn-default">Cancelar</a>
    </form>
</div>
<?=template_footer(); ?>