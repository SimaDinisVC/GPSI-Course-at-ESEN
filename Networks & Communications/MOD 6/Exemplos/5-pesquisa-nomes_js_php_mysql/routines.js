function mostra(str){
	
	var pedido;

	if(str.length == 0){
		document.getElementById("output").innerHTML = "";
		return;
	}

	pedido = new XMLHttpRequest();
	pedido.onreadystatechange = function() {
		if (this.readyState == 4 && this.status == 200) {
			if(this.responseText == 1){
				document.getElementById("output").innerHTML = "<p>Não encontrou</p>";
			}else if(this.responseText == 2){
				document.getElementById("output").innerHTML = "Pedimos desculpas. Contacte o administrador da rede. " + this.responseText;
			}else{
				document.getElementById("output").innerHTML = this.responseText;
			}
			
			// O mesmo que
			// document.getElementById("output").innerHTML = pedido.responseText;
		}
	};
	pedido.open("GET","getinfo.php?q="+str,true);
	pedido.send();
}