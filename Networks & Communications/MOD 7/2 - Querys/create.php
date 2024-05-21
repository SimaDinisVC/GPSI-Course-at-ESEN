<?php
// Include config file
require_once "config.php";
 
// Define variables and initialize with empty values
$firstname = $lastname = $email = "";
$firstname_err = $lastname_err = $email_err = "";
 
// Processing form data when form is submitted
if($_SERVER["REQUEST_METHOD"] == "POST"){
    // Validate name
    $input_firstname = trim($_POST["txtFirstName"]);
    if(empty($input_firstname)){
        $firstname_err = "Preencha o nome.";
    }else{
        $firstname = $input_firstname;
    }

    // Validate last name
    $input_lastname = trim($_POST["txtLastName"]);
    if(empty($input_lastname)){
        $lastname_err = "Preencha o apelido.";     
    } else{
        $lastname = $input_lastname;
    }
    
    // Validate salary
    $input_email = trim($_POST["txtEmail"]);
    if(empty($input_email)){
        $email_err = "Preencha o email.";     
    } else{
        $email = $input_email;
    }
    

    // Check input errors before inserting in database
    if(empty($firstname_err) && empty($lastname_err) && empty($email_err)){

        // Prepare an insert statement
        $sql = "INSERT INTO persons (first_name, last_name, email) VALUES (:firstname, :lastname, :email)";
 
        if($stmt = $link->prepare($sql)){
            // Bind variables to the prepared statement as parameters
            $stmt->bindParam(":firstname", $param_firstname);
            $stmt->bindParam(":lastname", $param_lastname);
            $stmt->bindParam(":email", $param_email);
            
            // Set parameters
            $param_firstname = $firstname;
            $param_lastname = $lastname;
            $param_email = $email;

            /*
                As linhas anteriores poderiam ficar da seguinte forma:
                $stmt->bindParam(':first_name', $_POST['first_name'], PDO::PARAM_STR);
                $stmt->bindParam(':last_name', $_POST['last_name'], PDO::PARAM_STR);
                $stmt->bindParam(':email', $_POST['email'], PDO::PARAM_STR);
            */
            
            // Attempt to execute the prepared statement
            if($stmt->execute()){

                // Obteriamos o id do registo inserido
                // $last_id = $link->lastInsertId();
                // echo "Registo $last_id foi inserido com sucesso.";

                // Records created successfully. Redirect to landing page
                header("location: index.php");
                exit();
            } else{
                echo "Surgiu um problema. Por favor, tente mais tarde.";
            }
        }
         
        // Close statement
        unset($stmt);
    }
    
    // Close connection
    unset($link);
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Create Record</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
</head>
<body>
    <div class="container">
        <div class="row mt-4">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <div class="display-5 fw-bold">Cria Registo</div>
                <p class="my-3">Preencha os campos.</p>
                <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
                    <div class="form-group">
                        <label>Nome</label>
                        <input type="text" name="txtFirstName" class="form-control" value="<?php echo $firstname; ?>">
                        <span class="form-text"><?php echo $firstname_err;?></span>
                    </div>
                    <div class="form-group">
                        <label>Apelido</label>
                        <input type="text" name="txtLastName" class="form-control"><?php echo $lastname; ?></input>
                        <span class="form-text"><?php echo $lastname_err;?></span>
                    </div>
                    <div class="form-group">
                        <label>Email</label>
                        <input type="email" name="txtEmail" class="form-control" value="<?php echo $email; ?>">
                        <span class="form-text"><?php echo $email_err;?></span>
                    </div>
                    <div class="d-flex justify-content-end mt-2">
                        <input type="submit" class="btn btn-primary" value="Enviar">
                        <a href="index.php" class="btn btn-default">Cancelar</a>
                    </div>
                </form>
            </div>
        </div>
        <div class="col-md-2"></div>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" 
        integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" 
        crossorigin="anonymous"></script>
</body>
</html>