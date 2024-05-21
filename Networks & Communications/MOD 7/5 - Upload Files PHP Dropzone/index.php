<!DOCTYPE html>
<html>
<head>
	<title>Funcionamento da Libraria Dropzone File Upload</title>
  	<!-- Bootstrap Css -->
  	<link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet">
  	<script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
	<!-- Dropzone.js is an JavaScript libraries. -->
    <script src="https://unpkg.com/dropzone@6.0.0-beta.1/dist/dropzone-min.js"></script>
    <link href="https://unpkg.com/dropzone@6.0.0-beta.1/dist/dropzone.css" rel="stylesheet" type="text/css" />
</head>
<body>
   
<div class="container">
  <div class="row">
    <div class="col-md-12">
      <h2>Exemplo de aplicação</h2>
      <form action="upload.php" enctype="multipart/form-data" class="dropzone" id="image-upload">
        <div>
          <h3>Arraste ficheiros para a caixa</h3>
        </div>
      </form>
      <button id="uploadFile">Upload de Ficheiros</button>
    </div>
  </div>
</div>
   
<script type="text/javascript">
   
    Dropzone.autoDiscover = false;
   
    var myDropzone = new Dropzone(".dropzone", { 
       autoProcessQueue: false,
       maxFilesize: 1,
       acceptedFiles: ".jpeg,.jpg,.png,.gif, .docx, .pdf"
    });
   
    $('#uploadFile').click(function(){
       myDropzone.processQueue();
    });
       
</script>
   
</body>
</html>