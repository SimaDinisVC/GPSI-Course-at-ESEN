<?php
    require_once "config.php";
   
    // Versão de inserção de multiplos registos de forma pura e crua.
    try{
        $sql = "INSERT INTO persons (first_name, last_name, email) VALUES
            ('John', 'Rambo', 'johnrambo@mail.com'),
            ('Clark', 'Kent', 'clarkkent@mail.com'),
            ('John', 'Carter', 'johncarter@mail.com'),
            ('Harry', 'Potter', 'harrypotter@mail.com')";      
        $link->exec($sql);
        echo "Dados inseridos com sucesso.";
    } catch(PDOException $e){
        die("ERRO: Não foi possível executar o comando. " . $e->getMessage());
    }

    unset($pdo);
?>