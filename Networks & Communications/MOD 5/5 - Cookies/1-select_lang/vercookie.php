<!DOCTYPE html>
<html lang="pt-pt">
<head>
	<meta charset="UTF-8">
	<title>Vê cookie</title>
</head>
<body>
	<?php
		/*
			Abre a janela Inspecionar > separador Application e 
			clica em Cookies. Analisa os valores associados ao
			cookie criado.
		*/
	
		// VERIFICA SE OS COOKIES ESTÃO HABILITADOS
		if(count($_COOKIE) > 0) {
			
			if(!$_COOKIE['selecionou_idioma']){
				header("Location: erro.php");
			}
			else if($_COOKIE['selecionou_idioma'] == "pt-pt"){
				// redireciona para a página index_pt.php
				header("Location: index_pt.php");	

			} else if($_COOKIE['selecionou_idioma'] == "es"){
				// redireciona para a página index_es.php
				header("Location: index_es.php");
			}
			
		} else {
			echo "Os Cookies estão desabilitados.";
		}

	?>
</body>
</html>