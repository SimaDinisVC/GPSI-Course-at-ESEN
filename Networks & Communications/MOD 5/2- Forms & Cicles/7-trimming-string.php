<!DOCTYPE html>
<html lang="pt-pt">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Trimming String</title>
    <style>
        body {
            max-width: 550px;
            font-family: Arial;
        }
        div#container {
            display: inline-block;
            padding: 30px;
            background: #4dc3d2;
            border: #45b3c1 1px solid;
            border-radius: 2px;
        }
        .demoInput {
            margin-bottom: 30px;
        }

        .demoInput textarea {
            width: 200px;
            padding: 10px;
            border: #46b3c1 1px solid;
            border-radius: 2px;
        }

        .demoInput input:focus {
            outline: none;
        }

        .demoInput select {
            width: 200px;
            height: 30px;
            border: #46b3c1 1px solid;
            border-radius: 2px;
            background: #FFF;
        }

        .demoInput input[type=submit] {
            width: 200px;
            padding: 10px;
            border: #636363 1px solid;
            color: #FFF;
            background: #757575;
        }
        .output {
            margin-top: 20px;
            padding: 30px 0px;
            line-height: 25px;
            color: #676767;
        }
        .output-row {
            margin-bottom: 30px;
            border: #72c6d0 1px solid;
            padding: 6px 0px;
        }
        .output-row label {
            width: 200px;
            background: #58dcec;
            padding: 10px;
        }
        .output-value {
            margin: 0px 15px;
        }
        .highlight-space {
            background: #09ffe8;
        }
</style>
</head>
<body>
    <div id="container">
        <!-- repara no valor do atributo action, dá uma explicação. -->
        <form name="frmTrim" action="" method="post">
            <div class="demoInput">
                <textarea type="text" name="strUserInput" placeholder="Insira dados"></textarea>
            </div>
            <div class="demoInput">
                <select name="trimType">
                    <option value="trim">trim()</option>
                    <option value="ltrim">ltrim()</option>
                    <option value="rtrim">rtrim()</option>
                </select>
            </div>
            <div class="demoInput">
                <input type="submit" name="send" value="Aplicar Limpeza" />
            </div>
        </form>
    </div>

    <?php
        /**
         * As funções trim(), ltrim() ou rtrim() eliminam espaços em branco
         * entre palavras de uma string.
         * 
         * EXPLORA OUTRAS FUNCIONALIDADES DESTAS FUNÇÕES.
         * 
         * String Trimming - processo de limpar os espaços em branco indesejados, 
         * no início e no fim, de numa string.
         * Os utilizadores, por vezes, inserem espaços em branco desnecessários
         * durante o preenchimento de formulários.
         */

        if(isset($_POST["send"])) {
            
            switch($_POST["trimType"]) {
                case "trim":
                    $trimmedString = trim($_POST["strUserInput"]);
                    break;
                case "ltrim":
                    $trimmedString = ltrim($_POST["strUserInput"]);
                    break;
                case "rtrim":
                    $trimmedString = rtrim($_POST["strUserInput"]);
                    break;
            }
    ?>

    <div class="output">
        <div class="output-row">
            <label>Aplicar Tipo de Trimming:</label>
            <span class="output-value"><?php echo $_POST["trimType"]; ?></span>
        </div>
        <div class="output-row">
            <label>Antes do Trimming:</label>
            <span class="output-value highlight-space"><?php echo $_POST["strUserInput"]; ?></span>
        </div>
        <div class="output-row">
            <label>Depois do Trimming:</label>
            <span class="output-value highlight-space"><?php echo $trimmedString; ?></span>
        </div>
    </div>
    <?php         
        }
    ?>
</body>
</html>




