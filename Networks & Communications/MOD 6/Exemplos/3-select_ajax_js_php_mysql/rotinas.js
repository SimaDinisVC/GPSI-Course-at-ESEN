function mostraCurso(valor) {

    if (valor=="") {
      document.getElementById("mostra").innerHTML="";
      return;
    }

    if (window.XMLHttpRequest) {
      // code for IE7+, Firefox, Chrome, Opera, Safari
      pedido=new XMLHttpRequest();
    } else { // code for IE6, IE5
      pedido=new ActiveXObject("Microsoft.XMLHTTP");
    }

    pedido.onreadystatechange=function() {
      if (this.readyState==4 && this.status==200) {
          // mostra os dados vindo do servidor em #mostra
        document.getElementById("mostra").innerHTML=this.responseText;
      }
    }

    // PASSAGEM DE PARÂMETROS
    // faz uma requisição GET e passa o parâmetro q para o ficheiro obtemCursos.php
    // a variável valor é do tipo string
    pedido.open("GET","obtemCursos.php?q="+valor,true);
    pedido.send();
}