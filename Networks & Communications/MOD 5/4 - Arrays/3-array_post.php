<!doctype html>
<html lang="pt-pt">
    <head>
    <meta charset="utf-8">
    <title>Array Datas</title>
</head>

<body>
<?php
    if(isset($_POST['enviou']))
    {
        echo "<p>Adicionou o evento <b>{$_POST['nome']}</b> no dia:";

        if (isset($_POST['dias']) AND is_array($_POST['dias'])) {

            foreach ($_POST['dias'] as $dia) {
                echo "<b>$dia</b>\n";
            }

        } else {
            echo 'Selecione um dia da semana associado ao evento!';
        }

        echo '</p>';
    }
?>
    
    
<div>
    <p>Utilize este formulários para adicionar um evento:</p>
   
    <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">

        <p>Nome Evento: <input type="text" name="nome" size="30" /></p>
        <p>Dias do Evento:
        <input type="checkbox" name="dias[]" value="Domingo" /> Dom
        <input type="checkbox" name="dias[]" value="Segunda-feira" /> Seg
        <input type="checkbox" name="dias[]" value="Terça-feira" /> Ter
        <input type="checkbox" name="dias[]" value="Quarta-feira" /> Qua 
        <input type="checkbox" name="dias[]" value="Quinta-feira" /> Qui
        <input type="checkbox" name="dias[]" value="Sexta-feira" /> Sex 
        <input type="checkbox" name="dias[]" value="Sábado" /> Sab 
        </p>
        <input type="submit" name="submit" value="Adicionar Evento!" />
        <input type="hidden" name="enviou" valor="TRUE" />
    </form>
</div>
</body>
</html>
