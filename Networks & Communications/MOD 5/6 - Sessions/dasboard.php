<?php
    session_start();

    // verifica se fez login, isto é, se o utilizador já foi autenticado.
    // Esta verificação é obrigatória no início de todas as páginas.
    if(!isset($_SESSION['loggedin'])){
        header("location: index.php");
        exit();
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
</head>
<body>
    <div class="container">
        <nav class="navbar navbar-default">
            <div class="container-fluid">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" 
                        data-toggle="collapse" 
                        data-target="#bs-example-navbar-collapse-1" 
                        aria-expanded="false">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">SI LOGIN</a>
                </div>

                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav navbar-right">
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
                                <?php 
                                    /*
                                        Utilização dos dados da sessão.
                                        O acesso aos dados da sessão obriga à chamada da função session_start()
                                        no início da página e usar o array associativo $_SESSION.
                                    */
                                    echo $_SESSION['email']; 
                                ?>
                              <span class="caret"></span></a>
                            <ul class="dropdown-menu">
                                <li><a href="#">Definições</a></li>
                                <li><a href="#">Configurações</a></li>
                                <li role="separator" class="divider"></li>
                                <li><a href="processa/logout.php">Sair</a></li>
                            </ul>
                        </li>
                    </ul>
                </div><!-- /.navbar-collapse -->
            </div><!-- /.container-fluid -->
        </nav>
        
        <div class="alert alert-warning" role="alert">
            <?php
                /*
                    este SID fica guardao no cookie, identificando a sessão.
                    O cookie é enviado para o servidor e desta forma o php gere a sessão com esse SID.
                */
                echo "Está na sessão: " . session_id();
            ?>
        </div>
    </div>
    
    <script src="js/jquery-3.2.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>