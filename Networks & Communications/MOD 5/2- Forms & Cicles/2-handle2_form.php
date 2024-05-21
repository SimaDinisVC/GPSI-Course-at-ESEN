<!doctype html>
<html>
<head>
    <meta charset="utf-8">
    <title>Form Feedback</title>
    <style>
        #container{width: 600px; margin:0 auto; margin-bottom:10px;}
        #caixa {text-align: center; width: 600px; margin:0 auto;}
        .erro {font-weight: bold; color: #C00;}
    </style>
</head>

<body>
   
    <?php
        
        /*
            Este programa é semelhante ao anterior.

            QUAL O OBJETIVO DO ARRAY $_POST?

            EXECUTA E ANALISA O CÓDIGO APRESENTADO. DE SEGUIDA RESPONDE ÀS NOTAS
            APRESENTADAS EM MAIÚSCULAS.
        */

        // deteta se o formulário foi submetido, agora numa versão melhorada
        if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST['enviado'])) {
            
            // inicialização das variáveis
            $nome       = $_POST['nome'];
            $email      = $_POST['email'];
            $idade      = $_POST['idade'];
            $comentario = $_POST['comentario'];
            // a variável erro permitirá a acumulação dos vários erros que poderão
            // ocorrer nos diferentes testes.
            $erro = "<p class=\"erro\">Deve inserir ";

            
            /* 
                empty()
                Return true - se a variável toma o valor 0 (zero), FALSE, string vazia ou NULL
            */
            
            if(!empty($_POST['nome'])){
                $nome = $_POST['nome'];
            }
            else {
                $nome = NULL;
                $erro .= "o nome "; // acumula mensagem de erro
            }

            if(!empty($_POST['email'])) {
                $email = $_POST['email'];
            }
            else {
                $email = NULL;
                $erro .= ", o email "; // acumula mensagem de erro
            }

            if(!empty($_POST['comentario'])) {
                $comentario = $_POST['comentario'];
            }
            else {
                $comentario = NULL;
                $erro .= ", o comentário"; // acumula mensagem de erro
            }

            // ALTERA O CÓDIGO HTML DE FORMA A EVITAR A FUNÇÃO ISSET SEGUINTE
            if(isset($_POST['sexo'])) {
                
                $sexo = $_POST['sexo'];
                if($sexo == 'M') {
                    echo '<p><b>Bom dia Sr. </b> ';
                }
                elseif($sexo == 'F') {
                    echo '<p><b>Bom dia Sra. </b> ';
                }
            }
            else {
                // variável não foi inicializada
                $sexo = NULL;
                $erro .= " e o sexo";   // acumula mensagem de erro
            }

            $erro .= "</p>"; // fecha o parágrafo inicializado
            
            if(!empty($erro)){
                // mostra as diferentes mensagens de erro acumuladas
                echo $erro;
            }

            // se todos os campos foram preenchidos então apresenta um resumo 
            // da informação inserida no formulário.
            if($nome && $email && $sexo && $comentario) {
                echo $nome . " pelo comentário: " . $comentario . "<br />";
                echo "Envieremos informação para o endereço " . $email;
            }
            else {
                echo '<p class="erro"> Deve preencher todos os campos</p>';
            }
        }
    ?>
    
    <form action="<?php echo $_SERVER["PHP_SELF"]; ?>" method="post">
        
        <!-- fieldset - coloca um limite à volta dos elementos nele inserido -->
        <fieldset id="container">
            
            <!-- insere um cabeçalho no fieldset -->
            <legend>Insira a informação no formulário</legend>
            <p><b>Nome:   </b><input type="text" name="nome" size="20" maxlength="40" /></p>
            <p><b>Email: </b><input type="email" name="email" size="40" maxlength="60"></p>
            <p><b>Sexo:</b><input type="radio" name="sexo" value="M">Masculino
               <input type="radio" name="sexo" value="F">Feminino
            </p>
            <p><b>Atividade</b>
            <select name="idade">
                <option value="0-17">Menor</option>
                <option value="18-65">Produtor</option>
                <option value="60+">Reformado</option>
            </select>
            </p>
            <p><b>Comentário:</b>
                <textarea name="comentario" rows="3" cols="40"></textarea>
            </p>
            
        </fieldset>
        
        <div id="caixa">
            <input type="submit" name="submit" value="Enviar">
            <input type="hidden" name="enviado" value="TRUE" />
        </div>
        
    </form>
    
</body>
</html>