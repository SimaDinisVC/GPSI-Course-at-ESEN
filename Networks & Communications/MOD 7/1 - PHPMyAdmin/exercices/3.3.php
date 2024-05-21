<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <title>3.3</title>
</head>
<body>
    <div class="container mt-5 px-5">
    <form action="<?php echo $_SERVER['PHP_SELF']?>" method="POST">
        <div class="mb-3">
            <label for="Nome" class="form-label">Nome</label>
            <input type="text" class="form-control" name="first_name" required>
        </div>
        <div class="mb-3">
            <label for="Apelido" class="form-label">Apelido</label>
            <input type="text" class="form-control" name="last_name" required>
        </div>
        <div class="mb-3">
            <label for="Email" class="form-label">Email</label>
            <input type="email" class="form-control" name="email" required>
            <div id="emailHelp" class="form-text">Não partilhe o seu email com qualquer outra pessoa.</div>
        </div>
        <button type="submit" class="btn btn-primary">Submeter</button>
    </form>
    <div style="margin-top:10px;">
    <?php 
        if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST['first_name'])) {
            require_once "../config.php"; 
     
            try{ 
                // Define o comando SQL com 3 parâmetros 
                $sql = "INSERT INTO persons (first_name, last_name, email)  
                        VALUES (:first_name, :last_name, :email)"; 
                // Prepara o comando SQL 
                $stmt = $link->prepare($sql); 
                
                // Ligação dos parâmetros aos campos da tabela 
                $stmt->bindParam(':first_name', $firstname, PDO::PARAM_STR); 
                $stmt->bindParam(':last_name', $lastname, PDO::PARAM_STR); 
                $stmt->bindParam(':email', $email, PDO::PARAM_STR); 
        
                $firstname = $_POST['first_name']; 
                $lastname = $_POST['last_name']; 
                $email = $_POST['email']; 
                
                // executa a query preparada 
                $stmt->execute(); 
        
                $last_id = $link->lastInsertId(); 
                echo "Registo $last_id foi inserido com sucesso."; 
            } catch(PDOException $e){ 
                die("ERRO: Não foi possível executar o comando. " . $e->getMessage()); 
        
            } 
            unset($link);
        }
    ?>
    </div>
    </div>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.min.js" integrity="sha384-BBtl+eGJRgqQAUMxJ7pMwbEyER4l1g+O15P+16Ep7Q9Q+zqX6gSbd85u4mG4QzX+" crossorigin="anonymous"></script>
</body>
</html>