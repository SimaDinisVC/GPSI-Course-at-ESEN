<?php
    session_start();

    include '../libs/verificationLoginSession.php'; // verification module
?>
<!DOCTYPE html>
<html lang="pt-PT">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <link rel="stylesheet" href="./astyle.css">
    <title>Why QueuePro?</title>
</head>
<body class="min-vh-100">
    <nav class="navbar navbar-expand-lg navbar-dark pt-3" aria-label="Thirteenth navbar example">
        <div class="container">
            <a class="navbar-brand me-0 text-light" href="../Home/">QueuePro</a>
            <button class="navbar-toggler ms-auto collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#navbarsExample11" aria-controls="navbarsExample11" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse d-lg-flex" id="navbarsExample11">
                <a class="navbar-brand col-lg-3 me-0"></a>
                <ul class="navbar-nav col-lg-6 justify-content-lg-center">
                    <li class="nav-item">
                        <a class="nav-link text-light" aria-current="page" href="../Home/">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link active text-light" aria-current="page" href="./">Why QueuePro</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link text-light" aria-current="page" href="#">Contacts</a>
                    </li>
                </ul>
                <div class="d-lg-flex col-lg-3 justify-content-lg-end">
                    <a class="btn btn-outline-light br" role="button" href="<?php echo ($_SESSION['loggedin']) ? "../DashBoard/" : "../Login/"; ?>"><?php echo ($_SESSION['loggedin']) ? "Dashboard" : "Log In"; ?></a>
                </div>
            </div>
        </div>
    </nav>
    <div class="container col-xxl-9 py-5">
        <div class="row flex-lg-row-reverse align-items-center py-5">
            <div class="col-10 col-sm-8 col-lg-5">
                <img src="coffe-queue.png" class="d-block mx-lg-auto img-fluid" alt="Bootstrap Themes" width="500" height="500" loading="lazy">
            </div>
            <div class="col-lg-7">
                <h1 class="display-5 fw-bold text-body-emphasis lh-1 mb-3">Trabalhamos com <span class="queuepro"><?php 
                $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
                $link = new PDO($db, DB_USERNAME, DB_PASSWORD);

                $sql = "SELECT Email FROM admin";
                $stmt = $link->prepare($sql);
                $stmt->execute();
                
                echo $stmt->rowCount();

                unset($stmt);
                unset($link);
                ?></span> empresas todos os dias!</h1>
                <p class="lead">asdasdasd.</p>
                <div class="d-grid gap-2 d-md-flex justify-content-md-start">
                    <button type="button" class="btn btn-primary btn-lg px-4 me-md-2" href="../Home/">Registar</button>
                    <button type="button" class="btn btn-outline-light btn-lg px-4" href="<?php echo ($_SESSION['loggedin']) ? "../DashBoard/" : "../Login/"; ?>" ><?php echo ($_SESSION['loggedin']) ? "Dashboard" : "Log In"; ?></button>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
            <p class="col-md-4 mb-0 text-light">&copy; 2023 QueuePro, Inc</p>
            <a href="/" class="col-md-4 d-flex align-items-center justify-content-center mb-3 mb-md-0 me-md-auto link-body-emphasis text-decoration-none">
            </a>
            <ul class="nav col-md-4 justify-content-end">
                <li class="nav-item"><a href="../Home/" class="nav-link px-2 text-light">Home</a></li>
                <li class="nav-item"><a href="./" class="nav-link px-2 text-light">Why QueuePro</a></li>
                <li class="nav-item"><a href="#" class="nav-link px-2 text-light">Contacts</a></li>
            </ul>
        </footer>
    </div>
</body>
</html>