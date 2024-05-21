<!DOCTYPE html>
<html lang="pt-pt">
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta http-equiv="X-UA-Compatible" content="ie=edge">
	<title>Comentários</title>
	<link rel="stylesheet" href="css/bootstrap.min.css">
	 <style>
		 #warning{
			 display: none;
		 }
	 </style>
</head>

<body>
	<!-- form for inserting a comment -->
	<div class="container">
		<form id="frmauthors" action="">
			<div class="form-group">
				<label for="inputAuthor">Autor</label>
				<input type="text" class="form-control" name="inputAuthor" id="inputAuthor" placeholder="Insira o autor">
			</div>
			<div class="form-group">
				<label for="inputMessage">Mesagem</label>
				<input type="text" class="form-control" name="inputMessage" id="inputMessage" placeholder="Insira a mesagem">
			</div>
			<button type="submit" class="btn btn-primary" id="saveComment">Grave Comentário</button>
		</form>
		<br>
		<div class="alert alert-warning" role="alert" id="warning"></div>
	</div>

	<br>

	<!-- list elements of the table -->
	<div class="container">
		<div class="card">
			<div class="card-body">
				<h5 class="card-title">Mensagens</h5>
				<table class='table table-bordered table-striped'>
					<thead>
						<tr>
							<th>#</th>
							<th>Autor</th>
							<th>Mesagem</th>
						</tr>
					</thead>
					<tbody id="response">
		 				<!-- here list elements from datatable -->
					</tbody>
				</table>
			</div>
		</div>
	</div>

	<script src="js/jquery-3.4.1.min.js"></script>
	<script src="js/popper.min.js"></script>
	<script src="js/bootstrap.min.js"></script>

	<script>
		const frmauthors = document.querySelector("#frmauthors");
		const response = document.querySelector("#response");

		// get data to fill the table
		function getDataTable() {
			$.ajax({
				url: 'getData.php',
				type: 'get', // can be post or get
				success: function(responsedata) {
					response.innerHTML = responsedata ;
				},
				error: function() {
					console.log("erro")
				}
			});
		}

		/*
			There are three forms to send values to server in jquery:
				data: $("#frmauthors input").serialize(),
				data: "inputAuthor="+iauthor+"&inputMessage="+imessage,
				data: {inputAuthor:iauthor,inputMessage:imessage},
		*/
		function insertDataTable(e) 
		{
			// prevent form loading
			e.preventDefault();

			const inputAuthor = document.querySelector("#inputAuthor");
			const inputMessage = document.querySelector("#inputMessage");
			const warning = document.querySelector("#warning");

			// obtém os dados inseridos no formulário
			iauthor = inputAuthor.value;
			imessage = inputMessage.value;
			
			if(iauthor=="" && imessage=="")
			{
				//$("#warning").css("display", "block").html("Preencha os campos...");
				warning.style.display = "block";
				warning.innerHTML = "Preencha os campos...";
			}
			else{
				
				$.ajax({
					url:"insertData.php",
					type:"post",
					// sending information in the request body
					data: "inputAuthor="+iauthor+"&inputMessage="+imessage,
					success: function(data){
						// data save the value true or false
						
						// clears form information
						//$("#inputAuthor").val("")
						inputAuthor.value = "";
						inputMessage.value = "";
						// $("#warning").css("display", "none")	// hide
						warning.style.display = "none";	// hide
						
						// update table 
						getDataTable()
						if(data){
							//$("#warning").css("display", "block").html("O registo foi gravado!");	// show
							warning.style.display = "block";
							warning.innerHTML = "O registo foi gravado!";
							$("#warning").delay(2000).fadeOut()	// faz desaparecer a mensagem de erro
						}
						else{
							// $("#warning").css("display", "block").html("O registo não foi gravado!");
							warning.style.display = "block";
							warning.innerHTML = "O registo não foi gravado!";
							$("#warning").delay(2000).fadeOut()	// faz desaparecer a mensagem de erro
						}
					},
					error: function(data){
						warning.style.display = "block";
						warning.innerHTML = "O registo não foi gravado!";
						console.log("dataerror")
					}
				});
			}
		}


		// Deteção se a página carregou os dados por completo
		document.addEventListener("DOMContentLoaded", function(event) {

			frmauthors.addEventListener("submit", function(event) {
				insertDataTable(event);
			});

			// mostra comentários
			getDataTable();
		});
	</script>
</body>

</html>