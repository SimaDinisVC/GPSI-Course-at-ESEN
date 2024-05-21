function mostra(str){
	
	var pedido;

	if(str.length == 0){
		document.getElementById("output").innerHTML = "";
		return;
	}

	$.ajax({
		url:'getinfo.php',  
		type:'get',            
		data: "q="+str, 
		// se o pedido foi executado com sucesso
		success:function(responsedata) {
			if(responsedata == 1){
				document.getElementById("output").innerHTML = "<p>Não encontrou</p>";
			}else if(responsedata == 2){
				document.getElementById("output").innerHTML = "Pedimos desculpas. Contacte o administrador da rede. ";
			}else{
				document.getElementById("output").innerHTML = responsedata;
			}
		},
	})

}