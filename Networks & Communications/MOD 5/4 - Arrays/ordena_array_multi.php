<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Ordenação de arry multidimensional</title>
</head>
<body>
	<?php
		// Cria array
		// studentID => array ('name' => 'Name', 'grade' => XX.X)
		$students = array (
			256 => array ('name' => 'Jon', 'grade' => 98.5),
			2 => array ('name' => 'Vance', 'grade' => 85.1),
			9 => array ('name' => 'Stephen', 'grade' => 94.0),
			364 => array ('name' => 'Steve', 'grade' => 85.1),
			68 => array ('name' => 'Rob', 'grade' => 74.6)
		);
	
		
		// ordena pelo nome
		function name_sort ($x, $y) {
			// strcasecmp - devolve um número negativo, a primeira string é menor que a segunda alfabeticamente, 0 se as strings forem iguais e positivo se a 2ª string é amsior que a primeira.
			return strcasecmp($x['name'], $y['name']);
		}

	
		// Ordena pelo grau
		// Ordenação DESCENDENTE!
		function grade_sort ($x, $y) {
			return ($x['grade'] < $y['grade']);
		}
	
		// Print the array as is:
		echo '<h3>Apresenta array</h3><pre>' . print_r($students, 1) . '</pre>';
	
	
		//Ordena pelo nome
		uasort ($students, 'name_sort');
		echo '<h3>Ordenação do array pelo nome</h3><pre>' . print_r($students, 1) . '</pre>';
	
	
		// Ordena pelo grau de forma descendente
		uasort ($students, 'grade_sort');
		echo '<h3>Ordenação do array pela nota (grade)</h3><pre>' . print_r($students, 1) . '</pre>';
	
	?>
</body>
</html>