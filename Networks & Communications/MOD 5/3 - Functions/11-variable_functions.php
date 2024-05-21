<?php
    
    /**
     * Variable functions
     * O PHP suporta o conceito de função variável. 
     * Se o nome de uma variável tiver parênteses no final, o PHP procura uma função 
     * com o mesmo nome, qualquer que seja a avaliação da variável, tentando executá-la. 
     * Pode ser usado para implementar callbacks, tabelas de função ...
     */
    
    function mostraNome($nome){
         echo "Nome $nome";
    }
    $func = 'mostraNome';
    $func("Adelino");
?>