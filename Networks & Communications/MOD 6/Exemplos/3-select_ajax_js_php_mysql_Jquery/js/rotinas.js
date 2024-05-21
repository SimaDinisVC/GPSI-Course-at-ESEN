
function mostraCurso(valor) {

    if (valor=="") {
      document.getElementById("mostra").innerHTML="";
      return;
    }

    $.ajax({
      // URL para a qual enviaremos a requisição
      url:'obtemCursos.php',  
      // qual método/verbo HTTP que será utilizado na requisição: post ou get
      type:'get',             
      data: "q="+valor,
      // beforeSend recebe uma função que é executada antes da requisição ser enviada.
      beforeSend:function(){  
          console.log("A ENVIAR...")
      },

      // se o pedido foi executado com sucesso
      success:function(responsedata) {
          // a informação devolvida da base de dados será inserida na tabela cujo id="response"
          // $("#response").html(responsedata)
          document.getElementById("mostra").innerHTML=responsedata;
      },

      // se ocorreu algum erro no processamento do pedido
      error:function(){ 
          console.log("erro")
      }
  })

}