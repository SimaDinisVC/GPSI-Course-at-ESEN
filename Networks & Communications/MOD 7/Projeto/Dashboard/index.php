<?php
    session_start();

    include '../libs/verificationLoginSession.php'; // verification module

    if ($_SESSION['loggedin'] == false) {
      header("Location: ../Home/");
      exit();
    }

    // Get the email
    $db = "mysql:host=" . DB_SERVER . ";dbname=" . DB_NAME . ";charset=utf8"; 
    $link = new PDO($db, DB_USERNAME, DB_PASSWORD);

    $sql = "SELECT * FROM users WHERE userID = :userID";
    $stmt = $link->prepare($sql);
    $stmt->bindParam(":userID", $_SESSION['loggedID']);
    $stmt->execute();
    $row = $stmt->fetch();

    $nome = $row['nome'];
    $email = $row['email'];
    $imgPath = $row['PerfileImgPath'];

    unset($stmt);
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
              <a href="." class="nav-link <?php echo (!isset($_GET['redirect']) || empty($_GET['redirect'])) ? "active" : "" ?> text-white " aria-current="page">
              <span class="material-icons pe-none me-2 pb-1 vam">space_dashboard</span>
                DashBoard
              </a>
            </li>
            <li>
              <a class="nav-link <?php echo (isset($_GET['redirect']) && $_GET['redirect'] == "page_gestores") ? "active" : "" ?> text-white" aria-current="page" onclick="redirecionar('page_gestores')">
              <span class="material-icons pe-none me-2 pb-1 vam">people_alt</span>
                Gestores
              </a>
            </li>
            <li>
              <a class="nav-link text-white" aria-current="page">
              <span class="material-icons pe-none me-2 pb-1 vam">query_stats</span>
                Análise de Dados
              </a>
            </li>
            <li>
              <a class="nav-link text-white" aria-current="page">
              <span class="material-icons pe-none me-2 pb-1 vam">apartment</span>
                Empresa
              </a>
            </li>
            
          </ul>
          <hr class="my-3 border-light">
          <div class="dropdown">
            <a href="#" class="d-flex align-items-center text-light text-decoration-none dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
              <img src="<?php echo (!empty($imgPath) ) ? $imgPath : 'https://upload.wikimedia.org/wikipedia/commons/a/ac/Default_pfp.jpg'?>" alt="" width="32" height="32" class="rounded-circle me-2">
              <strong><?php echo $email ?></strong>
            </a>
            <ul class="dropdown-menu dropdown-menu-dark text-small shadow">
              <li><a class="dropdown-item" >Definições</a></li>
              <li><a class="dropdown-item <?php echo (isset($_GET['redirect']) && $_GET['redirect'] == "page_perfile") ? "active" : "" ?> " onclick="redirecionar('page_perfile')">Perfil</a></li>
              <li><hr class="dropdown-divider"></li>
              <li><a class="dropdown-item" href="deslogar.php">Sign out</a></li>
            </ul>
          </div>
        </div>
        <div class="main-container d-flex flex-column flex-shrink-0 px-5 py-2 text-bg-dark overflow-auto">
          <?php
            if (!isset($_GET['redirect']) || empty($_GET['redirect'])) {
              echo "<div class=\"d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 border-bottom\">
                <h1 class=\"h2\">Senhas Semanais</h1>
              </div>
              <canvas class=\"mt-4 w-100\" id=\"myChart\" style=\"max-height: 100%; width: auto;\"></canvas>
              ";
            }
            
            if (isset($_GET['redirect']) && $_GET['redirect'] == 'page_gestores') {
              echo "<div class=\"d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 border-bottom\">
              <h1 class=\"h2\">Gestores da Empresa</h1>
            </div>
            <div class=\"container mt-5\">
                    <a href=\"create.php\" class=\"btn btn-primary mb-5\">Adicionar Empregado</a>";
                      // lista todos os empregados
                      $sql = "SELECT * FROM users WHERE cargo = 'gestor'";
                      // Executa o comando SQL
                      if ($result = $link->query($sql)) 
                      {
                          // verifica se existem registos
                          if ($result->rowCount() > 0) {
                              echo "<table class=\"table table-dark\" >";
                              echo "<thead>";
                              echo "<tr>";
                              echo "<th scope=\"col\">#</th>";
                              echo "<th scope=\"col\">Nome</th>";
                              echo "<th scope=\"col\">Email</th>";
                              echo "<th scope=\"col\">Cargo</th>";
                              echo "<th scope=\"col\">Opções</th>";
                              echo "</tr>";
                              echo "</thead>";
  
                              echo "<tbody class=\"table-group-divider\">";
                                  /* 
                                      o método fetch() retira um registo de cada vez no conjunto de registos
                                      guardados em $result. Devolve um array.
                                  */
                              while ($row = $result->fetch()) {
                                  echo "<tr>";
                                  echo "<td>" . $row['userID'] . "</td>";
                                  echo "<td>" . $row['nome'] . "</td>";
                                  echo "<td>" . $row['email'] . "</td>";
                                  echo "<td>" . $row['cargo'] . "</td>";
                                  echo "<td>";
                                  echo "<a href='read.php?id=" . $row['userID'] . "' class='btn btn-light btn-sm me-1' title='Ver Registo'> <i class='far fa-eye'></i> Ver </a>";
                                  echo "<a href='update.php?id=" . $row['userID'] . "' class='btn btn-outline-light btn-sm me-1' title='Atualizar Registo'> <i class='far fa-edit'></i> Atualizar </a>";
                                  echo "<a href='deletePerfile.php?id=" . $row['userID'] . "' class='btn btn-danger btn-sm' title='Eliminar Registo'> <i class='far fa-trash-alt'></i> Apagar</a>";
                                  echo "</td>";
                                  echo "</tr>";
                              }
                              echo "</tbody>";
                              echo "</table>";
  
                              // Liberta os registos poupando memória
                              unset($result);
                          } else {
                              echo "<p><em>Não há gestores registados.</em></p>";
                          }
                      }
                      
                      // Fecha a ligação ao servidor
                      unset($link);
                echo "</div>";
            }

            if (isset($_GET['redirect']) && $_GET['redirect'] == 'page_perfile') {
              $img = (!empty($imgPath) ) ? $imgPath : 'https://upload.wikimedia.org/wikipedia/commons/a/ac/Default_pfp.jpg';
              echo "<div class=\"d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 border-bottom\">
                        <h1 class=\"h2\">Perfil</h1>
                      </div>
                      <div class=\"container mt-5\">
                          <form action=\"updatePerfile.php\" method=\"POST\" enctype=\"multipart/form-data\">
                              <div class=\"mb-3 d-flex\">
                                  <img id=\"preview\" class=\"rounded-circle\" src=\" $img\" alt=\"Pré-visualização da Imagem\" width=\"120\" height=\"120\" style=\"margin-top: 10px;\">
                                  <input type=\"file\" class=\"form-control mt-5 mb-5\" style=\"margin-left: 20px;\" name=\"photo\" id=\"imagemPerfil\">
                              </div>
                              <div class=\"mb-3 d-flex\" style=\"gap:20px;\">
                                <div class=\"mb-3\" style=\"width:50%\">
                                    <label for=\"nome\" class=\"form-label\">Nome:</label>
                                    <input type=\"text\" class=\"form-control\" name=\"nome\" placeholder=\"Seu Nome\" value=\"$nome\">
                                </div>
                                <div class=\"mb-3\" style=\"width:50%\">
                                    <label for=\"email\" class=\"form-label\">Email:</label>
                                    <input type=\"email\" class=\"form-control\" id=\"email\" value=\" $email \" disabled>
                                </div>
                              </div>
                              <div class=\"mb-3\">
                                  <label for=\"senha\" class=\"form-label\">Nova Senha:</label>
                                  <input type=\"password\" class=\"form-control\" name=\"senha\" placeholder=\"Nova Senha\">
                              </div>
                              <div class=\"mb-3\">
                                  <label for=\"confirmarSenha\" class=\"form-label\">Confirmar Nova Senha:</label>
                                  <input type=\"password\" class=\"form-control\" name=\"confirmarSenha\" placeholder=\"Confirmar Nova Senha\">
                              </div>";
                if(isset($_GET['content'])) {
                  if ($_GET['content'] == 'PasswordsNotMatch') {
                      echo "<div class=\"container-fluid\" style=\"display:flex; justify-content:center;\">
                          <div class=\"alert alert-dismissible alert-costum fade show d-flex align-items-center mb-2 mt-0\"  role=\"alert\">
                              <div class=\"text-light\">As passwords não coinsidem.</div>
                              <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>
                          </div>
                      </div>";
                  }
                  if ($_GET['content'] == 'FileTypeNotSupported') {
                    echo "<div class=\"container-fluid\" style=\"display:flex; justify-content:center;\">
                        <div class=\"alert alert-dismissible alert-costum fade show d-flex align-items-center mb-2 mt-0\"  role=\"alert\">
                            <div class=\"text-light\">Apenas são aceites ficheiros jpg, jpeg e png</div>
                            <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>
                        </div>
                    </div>";
                  }
              }
              echo "<div class=\"align-items-end\">
                        <button type=\"submit\" class=\"btn btn-outline-primary mt-5 mb-2 me-2\">Salvar Alterações</button>
                        <button type=\"button\" class=\"btn btn-outline-danger mt-5 mb-2\" data-bs-toggle=\"modal\" data-bs-target=\"#Modal\">Excluir Perfil</button>
                      </div>
                  </form>
                  <div class=\"modal fade\" id=\"Modal\" tabindex=\"-1\" aria-labelledby=\"ModalLabel\" aria-hidden=\"true\">
                      <div class=\"modal-dialog\">
                          <div class=\"modal-content\">
                              <div class=\"modal-header\">
                                  <h1 class=\"modal-title fs-5 text-dark\" id=\"ModalLabel\">Excluir Conta</h1>
                                  <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Close\"></button>
                              </div>
                              <form class=\"rounded-3 needs-validation\" action=\"deletePerfile.php\" method=\"POST\" novalidate>
                                  <div class=\"modal-body\">
                                      <p class=\"text-dark\">Pretende mesmo excluir a sua conta?</p>
                                  </div>
                                  <div class=\"modal-footer\">
                                  <button type=\"button\" class=\"btn btn-secondary\" data-bs-dismiss=\"modal\">Fechar</button>
                                      <button type=\"submit\" class=\"btn btn-danger\">Excluir</button>
                                  </div>
                              </form>
                          </div>
                      </div>
                  </div>
              </div>";
            }
          ?>
        </div>
      </div>

<script>
  function redirecionar(page) {
    const urlAtual = window.location.href;

    const parms = /(\?|&)redirect=/; // regex for detection

    if (parms.test(urlAtual)) { // when it has a redirect replace by the new one
        var newURL = urlAtual.replace(/(\?|&)redirect=.*?(&|$)/, '$1redirect='+page+'$2');
    } else { // when it has not a redirect include it on the url
        var separator = urlAtual.includes('?') ? '&' : '?';
        var newURL = urlAtual + separator + 'redirect='+page;
    }

    // refresh the page with the new url
    window.location.href = newURL;
  }
</script>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.min.js" integrity="sha384-BBtl+eGJRgqQAUMxJ7pMwbEyER4l1g+O15P+16Ep7Q9Q+zqX6gSbd85u4mG4QzX+" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/chart.js@4.3.2/dist/chart.umd.js" integrity="sha384-eI7PSr3L1XLISH8JdDII5YN/njoSsxfbrkCTnJrzXt+ENP5MOVBxD+l6sEG4zoLp" crossorigin="anonymous"></script>
<script src="graph.js"></script>
</body>
</html>