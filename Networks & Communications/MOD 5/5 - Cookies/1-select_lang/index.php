<?php

	// verifica se a variável selecionou_idioma existe
	if(isset($_COOKIE['selecionou_idioma'])){
		
		if($_COOKIE['selecionou_idioma'] == "pt-pt"){
			// redireciona para a página index_pt.php
			header("Location: index_pt.php");	
			
		} else if($_COOKIE['selecionou_idioma'] == "es"){
			// redireciona para a página index_es.php
			header("Location: index_es.php");
		}
		
	}
?>
<!DOCTYPE html>
<html lang="pt-pt">
<head>
	<meta charset="UTF-8">
	<title>Cookies</title>
	<link rel="stylesheet" href="css/styles.css">
</head>
<body>
	<div class="container">
		<h2>Selecione o idioma: </h2>
		<div class="row">
			<div class="col-md-2">
				<a href="criacookie.php?lingua=pt-pt">
					<img src="images/pt.png" alt="Portugal" class="bandeira">
				</a>
			</div>
			<div class="col-md-10">
				<a href="criacookie.php?lingua=es">
					<img src="images/es.jpg" alt="" class="bandeira">
				</a>
			</div>
		</div>
	</div>
</body>
</html>