<?php
    session_start();

    include '../libs/verificationLoginSession.php'; // verification module

    if ($_SESSION['loggedin'] == false) {
        header("Location: ../Home/");
        exit();
    }
?>
<!DOCTYPE html>
<html lang="pt-PT" class="min-vh-100">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
    <link rel="stylesheet" href="style.css">
    <link rel="canonical" href="https://getbootstrap.com/docs/5.3/examples/dashboard/">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/@docsearch/css@3">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
</head>
<body>
    <div class="d-flex flex-nowrap vh-100 vw-100">
        <div class="sidebar d-flex flex-column flex-shrink-0 p-3">
        <a class="navbar-brand me-0 text-dark fs-4 px-2" href="../Home/">QueuePro</a>
          <hr>
          <ul class="nav nav-pills flex-column mb-auto">
            <li class="nav-item">
              <a href="../Home/" class="nav-link text-white" aria-current="page">
              <span class="material-icons pe-none me-2 pb-1 vam">home</span>
                Home
              </a>
            </li>
            <li>
              <a href="." class="nav-link active text-white" aria-current="page">
              <span class="material-icons pe-none me-2 pb-1 vam">space_dashboard</span>
                DashBoard
              </a>
            </li>
            <li>
              <a href="#" class="nav-link text-white" aria-current="page">
              <span class="material-icons pe-none me-2 pb-1 vam">query_stats</span>
                Análise de Dados
              </a>
            </li>
            <li>
              <a href="#" class="nav-link text-white" aria-current="page">
              <span class="material-icons pe-none me-2 pb-1 vam">apartment</span>
                Empresa
              </a>
            </li>
            <li>
              <a href="#" class="nav-link text-white" aria-current="page">
              <span class="material-icons pe-none me-2 pb-1 vam">people_alt</span>
                Clientes
              </a>
            </li>
          </ul>
          <hr class="my-3 border-light">
          <div class="dropdown">
            <a href="#" class="d-flex align-items-center text-light text-decoration-none dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
              <img src="https://github.com/SimaDinisVC.png" alt="" width="32" height="32" class="rounded-circle me-2">
              <strong><?php echo $_SESSION['loggedEmail']; ?></strong>
            </a>
            <ul class="dropdown-menu dropdown-menu-dark text-small shadow">
              <li><a class="dropdown-item" href="#">Definições</a></li>
              <li><a class="dropdown-item" href="#">Perfil</a></li>
              <li><hr class="dropdown-divider"></li>
              <li><a class="dropdown-item" href="deslogar.php">Sign out</a></li>
            </ul>
          </div>
        </div>
        <div class="main-container d-flex flex-column flex-shrink-0 px-5 py-2 text-bg-dark">
            <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 border-bottom">
                <h1 class="h2">Senhas Semanais</h1>
            </div>
            <canvas class="mt-4 w-100" id="myChart" style="max-height: 100%; max-width: 100%;"></canvas>
        </div>
    </div>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.min.js" integrity="sha384-BBtl+eGJRgqQAUMxJ7pMwbEyER4l1g+O15P+16Ep7Q9Q+zqX6gSbd85u4mG4QzX+" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/chart.js@4.3.2/dist/chart.umd.js" integrity="sha384-eI7PSr3L1XLISH8JdDII5YN/njoSsxfbrkCTnJrzXt+ENP5MOVBxD+l6sEG4zoLp" crossorigin="anonymous"></script>
<script src="graph.js"></script>
</body>
</html>