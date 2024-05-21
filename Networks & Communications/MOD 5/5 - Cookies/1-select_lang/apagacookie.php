<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Elimina Cookie</title>
</head>
<body>
	<?php

		// apaga o cookie, indicando o nome do cookie e um tempo inferior.
		setcookie("selecionou_idioma", $_GET['lingua'], time()-1);
		
		// redireciona para a página index.php
		header("Location: index.php");
	?>
</body>
</html>