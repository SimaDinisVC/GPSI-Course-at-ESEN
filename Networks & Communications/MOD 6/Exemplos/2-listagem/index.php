<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta http-equiv="X-UA-Compatible" content="ie=edge">
	<title>Obtém Dados</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
</head>

<body>
    <!-- o card tem que ter uma largura caso pretenda ocupar um menor espaço -->
	<div class="card" style="width: 38rem;">
		<div class="card-body">
			<h5 class="card-title">Mensagens</h5>
			<table class='table table-bordered table-striped'>
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Autor</th>
                        <th>Mensagens</th>
                    </tr>
                </thead>
                <!-- 
                    aqui serão apresentados os registos vindos da tabela. preste atenção à função
                    javscript, getDataTable()
                -->
                <tbody id="response">

                </tbody>                            
            </table>
			<button class="btn btn-primary" id="displaydata">Mostra Comentários</button>
		</div>
	</div>

    <!-- apresentação do resultado da operação -->
    <div id="resultado"></div>

	<script src="js/jquery-3.4.1.min.js"></script>
	<script src="js/popper.min.js"></script>
	<script src="js/bootstrap.min.js"></script>

     <script>
        // obtém dados da tabela
        function getDataTable(){
            response = document.querySelector("#response");

            $.ajax({
                // URL para a qual enviaremos a requisição
                url:'getData.php',
                // qual método/verbo HTTP que será utilizado na requisição: post ou get
                type:'get',
                // beforeSend recebe uma função que é executada antes da requisição ser enviada.
                beforeSend:function(){

                        //VAMOS COLOCAR UM ICON A GIRAR

                    console.log("A ENVIAR...")
                },
                // se o pedido foi executado com sucesso
                success:function(responsedata) {
                    // a informação devolvida da base de dados será inserida na tabela cujo id="response"
                    response.innerHTML = responsedata;
                },
                // se ocorreu algum erro no processamento do pedido
                error:function(){ 
                    console.log("erro")
                }
            })
            /*
            .done(function(msg){
                // função de callback done é executada quando a requisição é finalizada com sucesso 
                // e nos permite tratar o retorno do servidor, que é recebido por meio do parâmetro msg
                $("#resultado").html(msg);
            })
            .fail(function(jqXHR, textStatus, msg){
                // função de callback fail, por sua vez, é executada quando ocorre algum erro na requisição. 
                De modo semelhante, a mensagem de erro é recebida no parâmetro msg.
                alert(msg)
            });
            */
        }


        // Deteção se a página carregou os dados por completo
        document.addEventListener("DOMContentLoaded", function(event) {
            let displaydata = document.querySelector("#displaydata");
            // Mosta comentários ao clicar no botão
            displaydata.addEventListener("click", function(){
                // mostra comentários
                getDataTable();
            });
        });

    </script>
</body>

</html>