<?php

    /* 
        Antes de armazenar qualquer informação em variáveis de sessão, primeiro
        deve iniciar a sessão.

        session_start() - indica que a sessão vai ser iniciada - primeira função a aparecer
        cria automaticamente o SID

        A função session_start() primeiro verifica se já existe uma sessão pela presença de
        um ID de sessão. Se a sessão já estiver sido iniciada, é possível a manipulação das
        variáveis de sessão, caso contrário, uma nova sessão será criada com um novo ID.

        Deve chamar a função session_start() no início da página, ou seja, antes de qualquer 
        saída gerada pelo script.

        Sessões e cookies guardam os dados globalmente, logo acessíveis por todo o site.
        Recorde que as sessões são armazenadas no servidor e os cookies são preservados 
        no browser (no lado do cliente).
        
    */

    session_start();

    // A presente página, o formulário do login, não pode aparecer depois
    // do utilizador estar autenticado.

    // Verifica se o utilizador tem a autenticação realizada.
    if(isset($_SESSION['loggedin']) && $_SESSION['loggedin'] == true) {
        header("location: dasboard.php");
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Login</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <style>
        .marginTop{
            margin-top: 150px;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="row marginTop">
            <div class="col-md-6 col-md-offset-3">

                <form action="processa/valida.php" method="post">
                    <div class="form-group">
                        <label for="InputEmail1">Endereço email</label>
                        <input type="email" name="email" class="form-control" id="InputEmail1" placeholder="Email" required>
                    </div>
                    <div class="form-group">
                        <label for="InputPassword1">Senha</label>
                        <input type="password" name="senha" class="form-control" id="InputPassword1" placeholder="Senha" required>
                    </div>
                    <input type="submit" class="btn btn-primary" value="Entrar">
                </form>
                
            </div>
        </div>
    </div>    
    <script src="js/bootstrap.min.js"></script>
</body>
</html>