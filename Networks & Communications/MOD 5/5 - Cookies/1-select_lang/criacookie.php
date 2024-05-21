<?php
	// A função setcookie() deve aparecer antes da tag <html>, permitindo criar um cookie.
	// O cookie terá o nome "selecionou_idioma", guarda um dos valores "pt-pt" ou "es" e
	// expira passado 1 dia = 86400
	setcookie("selecionou_idioma", $_GET['lingua'], time()+86400);

	// 1horas tem 3600 segundos. 1 dias = 24horas * 3600segundos = 86400
?>

<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Cria cookie</title>
</head>
<body>
	<?php
	
		// redireciona para a página vercookie.php
		header("Location: vercookie.php");
	?>
	
</body>
</html>