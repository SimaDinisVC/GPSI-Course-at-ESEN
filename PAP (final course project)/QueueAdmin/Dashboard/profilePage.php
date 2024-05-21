<?php
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
    </div>"
?>