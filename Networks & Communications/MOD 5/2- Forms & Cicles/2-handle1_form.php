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
           O exemplo que se apresenta usa um formulário e o seu correspondente 
           tratamento. No exemplo anterior, foi apresentado um formulário e o
           seu tratamento foi relegado noutro ficheiro.

            isset() - determina se a variável existe ou não é NULL
            Return:
                true - se tomar o valor 0, '' ou outro valor
                false - se não existir ou tomar o valor NULL (null)

            EXECUTA E ANALISA O CÓDIGO APRESENTADO. DE SEGUIDA RESPONDE ÀS NOTAS
            APRESENTADAS EM MAIÚSCULAS.
        */
    
        // permite verificar se o formulário foi submetido
        if (isset($_POST['enviado']))
        {
            // obtém os valores dos inputs do formulário (os dados do formulário)
            $nome       = $_POST['nome'];
            $email      = $_POST['email'];
            $idade      = $_POST['idade'];
            $comentario = $_POST['comentario'];

            // verifica se foi selecionada uma opção na tag radio
            if(isset($_POST['sexo']))
            {
                // obtém o valor do sexo selecionado (M/F)
                $sexo = $_POST['sexo'];

                // verifica o sexo da opção selecionada
                if($sexo == 'M') {
                    echo '<p><b>Bom dia Sr. </b> ';
                }
                elseif($sexo == 'F') {
                    echo '<p><b>Bom dia Sra. </b> ';
                }
            }
            else
            {
                // se não selecionou uma opção então a variável sexo tomará o valor NULL
                $sexo = NULL;
                echo "Não selecionou o sexo.";
            }

            // apresenta um resumo da informação recolhida.
            // ESTE BLOCO DE CÓDIGO PODE FICAR NOUTRO LOCAL DESTE FICHEIRO?
            if($sexo == 'M' || $sexo == 'F') {
                echo $nome . " pelo comentário " . $comentario . "<br />";
                echo "Envieremos informação para o endereço " . $email;
            }
        }
    ?>
    
    
    <form action="<?php echo $_SERVER["PHP_SELF"]; ?>" method="post">
        
        <!-- fieldset - coloca um limite à volta dos elementos nele inserido -->
        <fieldset id="container">
            
            <!-- insere um cabeçalho no fieldset -->
            <legend>Insira a informação no formulário</legend>

            <!-- ALTERA O CÓDIGO SEGUINTE POR FORMA A QUE OS CAMPOS nome E COMENTARIO SEJAM
            DE PREENCHIMENTO OBRIGATÓRIO -->
            <p><b>Nome:   </b><input type="text" name="nome" size="20" maxlength="40" required></p>
            <p><b>Email: </b> <input type="email" name="email" size="40" maxlength="60" required></p>
            
            <!-- PRETENDE-SE QUE O SEXO MASCULINO ESTEJA SELECIONADO POR DEFEITO -->
            <p><b>Sexo:</b>   <input type="radio" name="sexo" value="M" selected>Masculino
                              <input type="radio" name="sexo" value="F">Feminino
            </p>
            <p><b>Atividade</b>
            <!-- PRETENDE-SE QUE A OPÇÃO PRODUTOR ESTEJA SELECIONADA POR DEFEITO -->
            <select name="idade">
                <option value="0-17">Menor</option>
                <option value="18-65" selected>Produtor</option>
                <option value="60+">Reformado</option>
            </select>
            </p>
            <p><b>Comentário:</b>
                <textarea name="comentario" rows="3" cols="40"></textarea>
            </p>
            
        </fieldset>
        
        <div id="caixa">
            <input type="submit" name="submit" value="Enviar">
            <!-- OBSERVE A APLICAÇÃO DO INPUT DO TIPO HIDDEN -->
            <input type="hidden" name="enviado" value="TRUE" />
        </div>
     </form>
    
</body>
</html>