<?php
    require_once "config.php";
    
    // Esta versão de inserção de múltiplos registos tem um formato
    // que fica protegida contra alguns ataques
    try{
        $sql = "INSERT INTO persons (first_name, last_name, email) 
                VALUES (:first_name, :last_name, :email)";

        $stmt = $link->prepare($sql);
        
        $stmt->bindParam(':first_name', $first_name, PDO::PARAM_STR);
        $stmt->bindParam(':last_name', $last_name, PDO::PARAM_STR);
        $stmt->bindParam(':email', $email, PDO::PARAM_STR);
        
        /* Atribuição de valores nos parâmetro de cada registo */
        $first_name = "Hermione";
        $last_name = "Granger";
        $email = "hermionegranger@mail.com";
        $stmt->execute();
        
        $first_name = "Ron";
        $last_name = "Weasley";
        $email = "ronweasley@mail.com";
        $stmt->execute();
        
        echo "Registos inseridos com sucesso.";
    } catch(PDOException $e){
        die("ERRO: A query não foi preparada ou executada: $sql. " . $e->getMessage());
    }
    
    unset($stmt);
    unset($link);