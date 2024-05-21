<?php
function pdo_connect_mysql() {
	;$DATABASE_HOST = 'localhost';
    $DATABASE_USER = 'SimaDinisVC';
    $DATABASE_PASS = 'simao78910';
    $DATABASE_NAME = 'company';
    try {
    	$link = new PDO(
			'mysql:host=' . $DATABASE_HOST . 
			';dbname=' . $DATABASE_NAME . 
			';charset=utf8', 
			$DATABASE_USER, $DATABASE_PASS);
		$link->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
		return $link;
    } catch (PDOException $e) {
    	// If there is an error with the connection, stop the script and display the error.
    	exit('Falhou a conexão à base de dados!' . $e->getMessage());
    }
}


function template_header($title, $entrou) {
echo <<<EOT
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>$title</title>
		<link href="css/styles.css" rel="stylesheet" type="text/css">
		<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.1/css/all.css">
	</head>
	<body>
    <nav class="navtop">
    	<div>
    		<h1>Demo Website</h1>
EOT;
		
			if($entrou === false){
            	echo '<a href="login.php"><i class="fas fa-sign-in-alt"></i>Login</a>';
			}else {
				echo '<a href="logout.php"><i class="fas fa-sign-in-alt"></i>Sair</a>';
			}
echo <<<EOT
    	</div>
    </nav>
EOT;
}

// <a href="read.php"><i class="fas fa-address-book"></i>Contacts</a>

function template_footer() {
echo <<<EOT
    </body>
</html>
EOT;
}

/**
 * $password - input password
 * $lenght - length of the password
 */
function verify_password($password, $lenght = 0) {
	// Validate new password
    if(empty(trim($password))){
        return $new_password_err = "Insira a nova senha.";     
    } elseif(strlen(trim($password)) < $lenght){
        return $new_password_err = "A senha deve ter pelo menos 6 caracteres.";
    } else{
        return $new_password = trim($password);
    }
	//return $new_password;
}

?>
