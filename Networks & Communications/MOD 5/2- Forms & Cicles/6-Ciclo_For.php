<?php
    // Define a constante NUM_DIAS
    define("NUM_DIAS", 31);
?>
<!doctype html>
<html lang="pt-pt">
    <head>
    <meta charset="utf-8">
    <title>Datas</title>
	<style>
		.container {
			margin: 120px auto;
			width: 500px;
			border: 1px dotted #ccc;
			background-color: #eee;
		}
		form {
			margin-left: 20px;
			padding: 20px 0;
		}
		.aviso{
			color: red;
		}
	</style>
</head>

<body>
    <div class="container">
        
        <!--
            DESCREVE NESTE ESPAÇO O OBJETIVO DESTE EXERCÍCIO.
            
            EXECUTA E ANALISA O CÓDIGO APRESENTADO. DE SEGUIDA RESPONDE ÀS NOTAS
            APRESENTADAS EM MAIÚSCULAS.
        -->

		<form action="6-resp.php" method="post">
            <!-- PRESTA ATEMÇÃO AO ATRIBUTO REQUIRED, QUAL O SEU OBJETIVO -->
			<p>Complete o registo:</p>
            <p>Email: <input type="email" name="email" size="30" required />
            <span class="aviso">&nbsp;&nbsp;*</span></p>

            <p>Password: <input type="password" name="password" size="20" required />
            <span class="aviso">&nbsp;&nbsp;*</span></p>

            <p>Confirma Password: <input type="password" name="confirma" size="20" required />
            <span class="aviso">&nbsp;&nbsp;*</span></p>
            
            <p>Data de Nascimento:
            <select name="dia">
                <option value="">Dia</option>
                <?php // Imprime 31 dias:
                    for ($i = 1; $i <= NUM_DIAS; $i++) {
                        echo "<option value=\"$i\">$i</option>\n";
                    }
                ?>
            </select>

            <select name="mes">
                <option value="">Mês</option>
                <option value="1">Janeiro</option>
                <option value="2">Fevereiro</option>
                <option value="3">Março</option>
                <option value="4">Abril</option>
                <option value="5">Maio</option>
                <option value="6">Junho</option>
                <option value="7">Julho</option>
                <option value="8">Agosto</option>
                <option value="9">Setembro</option>
                <option value="10">Outubro</option>
                <option value="11">Novembro</option>
                <option value="12">Dezembro</option>
            </select>

            <input type="text" name="ano" value="AAAA" size="4" />
			<span class="aviso">&nbsp;&nbsp;*</span>
            <!-- pode validar a data com a função checkdate($month, $dia, $year) -->
            </p> 

            <p>Cor Favorita:
            <select name="cor">
                <option value="">Escolha uma</option>
                <option value="vermelho">Vermelho</option>
                <option value="amarelo">Amarelo</option>
                <option value="verde">Verde</option>
                <option value="azul">Azul</option>
            </select>
			<span class="aviso">&nbsp;&nbsp;*</span>
            </p>

            <p><input type="checkbox" name="termo" value="Sim" /> Aceitação do termo.
            <span class="aviso">&nbsp;&nbsp;*</span></p>
            <input type="submit" name="submit" value="Registar" />

            <!-- QUAL A IMPORTÂNCIA DO INPUT DO TIPO HIDDEN -->
			<input type="hidden" name="enviou" value="TRUE" />
        </form>
		<p><span class="aviso">&nbsp;&nbsp;*</span>&nbsp; Campo de preenchimento obrigatório</p>
		
    </div>
</body>
</html>
