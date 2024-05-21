<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Document</title>
</head>
<body>
	
	<h1>
		Página em português <?php  echo "(" . htmlentities($_COOKIE['selecionou_idioma']) . ")";  ?>
	</h1>
	
	
	<a href="apagacookie.php?lingua=pt-pt">Apaga Cookie</a>
	
	
</body>
</html>