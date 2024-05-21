<?php
// Initialize the session
session_start();
include "functions.php";

/*
    At the time of login we'll verify the given password with the 
    password hash stored in the database using the PHP password_verify() 
    function, as demonstrated in the next example.
    Tip: Password salting is a technique which is widely used to 
    secure passwords by randomizing password hashes, so that if 
    two users have the same password, they will not have the same 
    password hashes. This is done by appending or prepending a random 
    string, called a salt, to the password before hashing.
*/
 
// Check if the user is already logged in, if yes then redirect him to welcome page
if(isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] === true){
    header("location: dashboard.php");
    exit;
}else {
    $entrou = false;
}
 
 
// Define variables and initialize with empty values
$username = $password = "";
$username_err = $password_err = $login_err = "";
 
// Processing form data when form is submitted
if($_SERVER["REQUEST_METHOD"] == "POST"){

    $link = pdo_connect_mysql();
 
    // Check if username is empty
    if(empty(trim($_POST["username"]))){
        $username_err = "Insira o nome de utilizador.";
    } else{
        $username = trim($_POST["username"]);
    }
    
    // Check if password is empty
    if(empty(trim($_POST["password"]))){
        $password_err = "Insira a senha.";
    } else{
        $password = trim($_POST["password"]);
    }
    
    // Validate credentials
    if(empty($username_err) && empty($password_err)){
        // Prepare a select statement
        $sql = "SELECT id, username, password FROM users WHERE username = :username";
        
        if($stmt = $link->prepare($sql)){
            // Bind variables to the prepared statement as parameters
            $stmt->bindParam(":username", $param_username, PDO::PARAM_STR);
            
            // Set parameters
            $param_username = trim($_POST["username"]);
            
            // Attempt to execute the prepared statement
            if($stmt->execute()){
                // Check if username exists, if yes then verify password
                if($stmt->rowCount() == 1){
                    if($row = $stmt->fetch()){
                        $id = $row["id"];
                        $username = $row["username"];
                        $hashed_password = $row["password"];
                        if(password_verify($password, $hashed_password)){
                            // Password is correct, so start a new session
                            session_start();
                            
                            // Store data in session variables
                            $_SESSION["loggedin"] = true;
                            $_SESSION["id"] = $id;
                            $_SESSION["username"] = $username;                            
                            
                            // Redirect user to welcome page
                            header("location: dashboard.php");
                        } else{
                            // Password is not valid, display a generic error message
                            $login_err = "O nome de utilizador ou a senha estão errados.";
                        }
                    }
                } else{
                    // Username doesn't exist, display a generic error message
                    $login_err = "O nome de utilizador ou a senha estão errados.";
                }
            } else{
                echo "Oops! Algo acontecer. Por favor, tente mais tarde.";
            }

            // Close statement
            unset($stmt);
        }
    }
    // Close connection
    unset($link);
}
?>


<?=template_header('Entrar no Sistema', $entrou)?>

    <div class="container">
        <h2>Login</h2>

        <?php 
        if(!empty($login_err)){
            echo '<div class="alert-danger">' . $login_err . '</div>';
        }        
        ?>

        <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
            <div class="my-2">
                <label>Username</label>
                <input type="text" name="username" value="<?php echo $username; ?>">
                <span class="error"><?php echo $username_err; ?></span>
            </div>    
            <div class="my-2">
                <label>Password</label>
                <input type="password" name="password">
                <span class="error"><?php echo $password_err; ?></span>
            </div>
            <div class="my-2">
                <input type="submit" value="Entrar">
            </div>
            <p>Não tem conta? <a href="register.php">Registe-se</a>.</p>
        </form>
    </div>

<?=template_footer()?>