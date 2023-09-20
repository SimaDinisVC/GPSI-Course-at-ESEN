<?php

	/*
		Name of constants must follow the same rules as variable names, 
		which means a valid constant name must starts with a letter or underscore, 
		followed by any number of letters, numbers or underscores with one exception:
		the $ prefix is not required for constant names.
		
		Note: By convention, constant names are usually written in uppercase letters. 
		This is for their easy identification and differentiation from variables in the source code.
	*/
	
    // Defining constant
	define("SITE_URL", "https://www.esenviseu.net/");
 
	// Using constant
	echo 'Obrigado por visitar o site - <strong>' . SITE_URL . '</strong>';

?>