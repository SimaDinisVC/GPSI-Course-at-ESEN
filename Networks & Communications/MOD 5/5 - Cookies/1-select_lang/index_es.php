<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Document</title>
</head>
<body>
	
	<h1>
		Página em espanhol <?php  echo "(" . htmlentities($_COOKIE['selecionou_idioma']) . ")";  ?>
	</h1>
	
	
	
	<a href="apagacookie.php?lingua=es">Apaga Cookie</a>
</body>
</html>