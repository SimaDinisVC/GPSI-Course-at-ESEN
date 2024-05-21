<!DOCTYPE html>
<html lang="pt-pt">
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta http-equiv="X-UA-Compatible" content="ie=edge">
	<title>Comentários</title>
	<link rel="stylesheet" href="css/bootstrap.min.css">
	<style>
		#warning {
			display: none;
		}
	</style>
</head>

<body>

	<!-- Formulário -->
	<div class="container">
		<form id="frmauthors" action="">
			<div class="form-group">
				<label for="inputAuthor">Autor</label>
				<input type="text" class="form-control" name="inputAuthor" id="inputAuthor" placeholder="Inserir autor">
			</div>
			<div class="form-group">
				<label for="inputMessage">Mesagem</label>
				<input type="text" class="form-control" name="inputMessage" id="inputMessage" placeholder="Inserir mesagem">
			</div>
			<button type="submit" class="btn btn-primary" id="saveComment">Gravar Comentário</button>
		</form>
		<br>
		<div class="alert alert-warning" role="alert" id="warning"></div>
	</div>

	<br>

	<!-- Modal EDIT -->
	<div class="modal fade" id="editModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
		<div class="modal-dialog" role="document">
			<div class="modal-content">
				<div class="modal-header">
					<h5 class="modal-title" id="exampleModalLabel">Editar Dados</h5>
					<button type="button" class="close" data-dismiss="modal" aria-label="Close">
						<span aria-hidden="true">&times;</span>
					</button>
				</div>
				<!-- preenche o modal com os dados que vem do formulário -->
				<div class="modal-body" id="edit-item-model">
				</div>
				<div class="modal-footer">
					<button type="button" class="btn btn-secondary" data-dismiss="modal">Fechar</button>
					<button type="button" class="btn btn-primary" id="saveEdit" data-dismiss="modal">Gravar Alterações</button>
				</div>
			</div>
		</div>
	</div>

	<!-- lista elementos na tabela -->
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
							<th>Ação</th>
						</tr>
					</thead>
					<tbody id="response">

					</tbody>
				</table>
			</div>
		</div>
	</div>

	<script src="js/jquery-3.4.1.min.js"></script>
	<script src="js/popper.min.js"></script>
	<script src="js/bootstrap.min.js"></script>

	<script src="js/rotinas.js"></script>
</body>

</html>