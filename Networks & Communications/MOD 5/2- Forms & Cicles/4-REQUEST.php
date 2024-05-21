<!doctype html>
<html>
    <head>
    <meta charset="utf-8">
    <title>Uso da variável $_REQUEST</title>
    <style>
        #container{width: 600px; margin:0 auto; margin-bottom:10px;}
        #caixa {text-align: center; width: 600px; margin:0 auto;}
        .erro {font-weight: bold; color: #C00;}
    </style>
</head>

<body>
    <?php
        
        /*
            O objetivo deste exemplo é semelhante aos formulários anteriores,
            difere na captura dos dados do formulário.

             EXECUTA E ANALISA O CÓDIGO APRESENTADO. DE SEGUIDA RESPONDE ÀS NOTAS
            APRESENTADAS EM MAIÚSCULAS.
        */


        /*
            $_REQUEST - array pré-definido, requisita informação do protocolo HTTP.
            guarda todos os dados enviados pela requisição HTTP. 
            Em alternativa podes recorrer aos métodos GET ou POST
        */

        // MELHORA ESTA CONDIÇÃO.
        if (empty($_REQUEST['submitted']))
        {
            // obtém o valor guardado no input com o nome "nome" do formulário.
            $nome = $_REQUEST['nome'];

            // A função stripslashes() remove backslashes (podem ser adicionados pela função addslashes().
            // Considere a string: <span style=\"font-size:2em;\">Olá Mundo!</span>
            // Execute: stripslashes("<span style=\"font-size:2em;\">Olá Mundo!</span>");
            // Resultado: <span style="font-size:2em;">Olá Mundo!</span>
            $email = stripslashes($_REQUEST['email']);

            // ESTUDA A FUNÇÃO addslashes() E CRIA UM EXEMPLO PRÁTICO.
            
            /*
                Os outros elementos do formulário não são utilizados para simplificar a comprensão do exercício.
                $_REQUEST['sexo'];
                $_REQUEST['idade'];
                $_REQUEST['comentario'];
            */

            echo "Obrigado " . $nome . " pelo seu contributo!!<br />";
            echo "Envieremos informação para o endereço " . $email;
            
        }
    ?>
    
    
    <!-- 
        O envio dos dados do formulário utiliza o método POST, logo os dados são
        enviados na mensagem.

        $_SERVER["PHP_SELF"] - guarda o caminho e o nome do ficheiro
    -->
    <form action="<?php echo $_SERVER["PHP_SELF"]; ?>" method="post">
        
        <!-- fieldset - coloca um limite à volta dos elementos nele inserido -->
        <fieldset id="container">
            
            <!-- insere um cabeçalho no fieldset -->
            <legend>Insira a informação no formulário</legend>
            <p><b>Nome:   </b><input type="text" name="nome" size="20" maxlength="40" /></p>
            <p><b>Email: </b><input type="text" name="email" size="40" maxlength="60"></p>
            <p><b>Sexo:</b><input type="radio" name="sexo" value="M">Masculino
               <input type="radio" name="sexo" value="F">Feminino
            </p>
            <p><b>Idade</b>
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
            <input type="hidden" name="submitted" value="TRUE" />
        </div>
        
    </form>  
      
</body>
</html>