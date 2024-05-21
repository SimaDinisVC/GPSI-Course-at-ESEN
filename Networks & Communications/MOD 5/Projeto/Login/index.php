<?php
    session_start();

    include '../libs/verificationLoginSession.php'; // verification module

    if ($_SESSION['loggedin'] == true) {
        header("Location: ../Home/");
        exit();
    }
?>
<!DOCTYPE html>
<html lang="pt-PT">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <link rel="stylesheet" href="style.css">
    <title>Log In</title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark pt-3 pb-3" aria-label="Thirteenth navbar example">
        <div class="container">
            <a class="navbar-brand me-0" href="../Home/">QueuePro</a>
            <button class="navbar-toggler ms-auto collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#navbarsExample11" aria-controls="navbarsExample11" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse d-lg-flex" id="navbarsExample11">
                <a class="navbar-brand col-lg-3 me-0"></a>
                <ul class="navbar-nav col-lg-6 justify-content-lg-center">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="../Home/">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link " aria-current="page" href="#">Why QueuePro</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link " aria-current="page" href="#">Contacts</a>
                    </li>
                </ul>
                <div class="d-lg-flex col-lg-3 justify-content-lg-end">
                    <a class="btn btn-outline-dark br" role="button" href="../Home/">Sign Up</a> 
                </div>
            </div>
        </div>
    </nav>
    <?php
        if(isset($_GET['content'])) {
            if ($_GET['content'] == 'EmailNotFound') {
                echo "<div class=\"container-fluid\" style=\"display:flex; justify-content:center;\">
                    <div class=\"alert alert-dismissible alert-costum fade show d-flex align-items-center mb-2 mt-0\" role=\"alert\">
                        <div class=\"text-light\">O email introduzido não está registado.</div>
                        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>
                    </div>
                </div>";
            } else if ($_GET['content'] == 'PasswordNotMatch') {
                echo "<div class=\"container-fluid\" style=\"display:flex; justify-content:center;\">
                    <div class=\"alert alert-dismissible alert-costum fade show d-flex align-items-center mb-2 mt-0\" role=\"alert\">
                        <div class=\"text-light\">A palavra-passe está incorreta.</div>
                        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>
                    </div>
                </div>";
            }
        }
    ?>
    <div class="form-signin w-100 m-auto mt-5">
        <form class="rounded-3 needs-validation" action="logar.php" method="POST" novalidate>
            <h1 class="h3 mb-3 fw-normal">Sign In</h1>
            <div class="form-floating mb-3">
                <input type="email" class="form-control br" id="email" name="emailInput" placeholder="name@example.com" required>
                <label for="email">Endereço de Email</label>
                <div class="valid-feedback">
                    Válido!
                </div>
                <div class="invalid-feedback">
                    Forneça um email válido!
                </div>
            </div>
            <div class="form-floating mb-3">
                <input type="password" class="form-control br" id="password" name="passwordInput" placeholder="Password" required>
                <label for="password">Palavra-Passe</label>
                <div class="valid-feedback">
                    Válida!
                </div>
                <div class="invalid-feedback">
                    Forneça uma palavra-passe válida!
                </div>
            </div>
            <div class="form-check text-start my-3">
                <input class="form-check-input" type="checkbox" name="remember" id="flexCheckDefault">
                <label class="form-check-label text-light" for="flexCheckDefault">Remember me</label>
            </div>
            <button class="w-100 btn btn-costum br btn-lg" type="submit">Entrar</button>
            <hr class="my-4 border-light">
            <a class="mb-3 text-light d-flex justify-content-center" href="#">Esqueceu-se da sua palavra-passe?</a>
        </form>
    </div>
    <div class="container">
        <footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
            <p class="col-md-4 mb-0 text-light">&copy; 2023 QueuePro, Inc</p>
            <a href="/" class="col-md-4 d-flex align-items-center justify-content-center mb-3 mb-md-0 me-md-auto link-body-emphasis text-decoration-none">
            </a>
            <ul class="nav col-md-4 justify-content-end">
                <li class="nav-item"><a href="." class="nav-link px-2 text-light">Home</a></li>
                <li class="nav-item"><a href="#" class="nav-link px-2 text-light">Why QueuePro</a></li>
                <li class="nav-item"><a href="#" class="nav-link px-2 text-light">Contacts</a></li>
            </ul>
        </footer>
    </div>
    <script src="../libs/validation.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.min.js" integrity="sha384-BBtl+eGJRgqQAUMxJ7pMwbEyER4l1g+O15P+16Ep7Q9Q+zqX6gSbd85u4mG4QzX+" crossorigin="anonymous"></script>
</body>
</html>