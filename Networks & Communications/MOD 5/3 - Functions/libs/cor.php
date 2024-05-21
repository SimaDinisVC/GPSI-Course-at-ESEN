<?php
    // Permite definir os caracteres portugueses, por exemplo 5ª
    header('Content-Type: text/html; charset=UTF-8');

    // definição de constantes
    define("RED","#FF0000");
    define("GREEN","#00FF00");
    define("BLUE","#0000FF");


    /**
     * A função pode devolver valores recorrendo à instrução opcional return. 
     * Qualquer tipo pode ser devolvido, incluindo arrays e objetos. 
     * Return faz com que a função termine a sua execução imediatamente e passe 
     * o controle à linha onde a função foi chamada. 
     */
    
    /**
     * A função getRGB aceita o parâmetro $color por valor com
     * um valor por default
    */
    function getRGB($code=RED)
    {
        //$code = RED; // default color
        switch ($code){
            case 'red': $code = "RED";
            break;
            case 'green': $code = "GREEN";
            break;
            case 'blue': $code = "BLUE";
            break;
         }
         return $code;
    }

?>