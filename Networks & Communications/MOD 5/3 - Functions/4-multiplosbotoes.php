<?php

// O PHP suporta argumentos em quantidade variável em funções definidas pelo utilizador.

function get_post_action($name)
{
	// func_get_args() - Gets an array of the function's argument list. 
    $params = func_get_args();

    foreach ($params as $name) {
        if (isset($_POST[$name])) {
            return $name;
        }
    }
}

// verifica se foi enviado um post
if( $_SERVER['REQUEST_METHOD'] == 'POST')
{
	// os parametros da função get_post_action devem ser as mesmas de cada case
	switch (get_post_action('save', 'send', 'publish')) 
	{
	    case 'save':
	        //save article and keep editing
	    	echo "Gravar, continue a editar";
	        break;

	    case 'send':
	        //save article and redirect
	    	echo "Enviar mensagem";
	        break;

	    case 'publish':
	        //publish article and redirect
	    	echo "Publicar artigo";
	        break;

	    default:
	        //no action sent
	}
}

?>


<form method="post" action="<?php echo $_SERVER["PHP_SELF"]; ?>">
    <p>
        <input type="submit" name="save" value="Salvar e continuar editando" />
        <input type="submit" name="send" value="Enviar" />
        <input type="submit" name="publish" value="Publicar" />
    </p>
</form>