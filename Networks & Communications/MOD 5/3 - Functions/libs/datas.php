<?php

	// Permite definir os caracteres portugueses, por exemplo 5ª
	header('Content-Type: text/html; charset=UTF-8');

    /*
        Tratamento de datas
    */

	function data_actual_pt() {

		$d2p = getdate(time());

		switch($d2p["weekday"]) {
			case "Monday": $dds = "2ª Feira"; break;
			case "Tuesday": $dds = "3ª Feira"; break;
			case "Wednesday": $dds = "4ª Feira"; break;
			case "Thursday": $dds = "5ª Feira"; break;
			case "Friday": $dds = "6ª Feira"; break;
			case "Saturday": $dds = "Sábado"; break;
			case "Sunday": $dds = "Domingo"; break;
		}

		switch($d2p["month"]) {
			case "January": $mes = "Janeiro"; break;
			case "February": $mes = "Fevereiro"; break;
			case "March": $mes = "Março"; break;
			case "April": $mes = "Abril"; break;
			case "May": $mes = "Maio"; break;
			case "June": $mes = "Junho"; break;
			case "July": $mes = "Julho"; break;
			case "August": $mes = "Agosto"; break;
			case "September": $mes = "Setembro"; break;
			case "October": $mes = "Outubro"; break;
			case "November": $mes = "Novembro"; break;
			case "December": $mes = "Dezembro"; break;
		}

		//$data = sprintf("%s, %d de %s, %d", $dds, $d2p["mday"], $mes, $d2p["year"]);
		$data = $dds . ', ' . $d2p["mday"] . ' de ' . $mes . ' de ' . $d2p["year"];
		return $data;
	}



	function data_actual_pt_arr()
	{
		$m = date("n");
		$d = date("l");
		$n = date("j");
		$y = date("Y");
		$h = date("H");
		$i = date("i");


		//Meses
		$mes = array('1' => "Janeiro",
					 '2' => "Fevereiro",
					 '3' => "Março",
					 '4' => "Abril",
					 '5' => "Maio",
					 '6' => "Junho",
					 '7' => "Julho",
					 '8' => "Agosto",
					 '9' => "Setembro",
					 '10' => "Outubro",
					 '11' => "Novembro",
					 '12' => "Dezembro");

		//dias da semana
		 $dia = array("Monday" => "Segunda-Feira",
					  "Tuesday" => "Terça-Feira",
					  "Wednesday" => "Quarta-Feira",
					  "Thursday" => "Quinta-Feira",
					  "Friday" => "Sexta-Feira",
					  "Saturday" => "Sabado",
					  "Sunday" => "Domingo");


		$strdata = "$dia[$d], $n de $mes[$m] de $y";
		return($strdata);
	}


	// Calcula o número de anos decorridos até hoje
	// $inicio no formato "AAAA-MM-DD";
	function ContaAnosDecorridos($inicio){
		$fim = date("Y-m-d");

		$diferenca = abs(strtotime($fim) - strtotime($inicio));
		$num_anos = floor($diferenca / (365*60*60*24));
		return $num_anos;
	}

	function getWeekdayName($date = '2021-11-18') {
		// // formato inglês
		// $timestamp = strtotime($date);
		// $weekdayName = date('l',$timestamp);
		//return $weekdayName;

		// formato português
		return strftime("%A", strtotime($date));
		
	 }



	
?>