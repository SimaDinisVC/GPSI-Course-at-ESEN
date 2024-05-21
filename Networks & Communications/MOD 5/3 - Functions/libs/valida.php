<?php

/**
 * From: https://www.tutorialrepublic.com/php-tutorial/php-form-validation.php
 * Date: 2018-10-02
 * 
 * Pretende-se implementar recursos básicos de segurança, 
 * como a validação da entrada de dados do utilizador evitando a inserção  de
 * dados potencialmente prejudiciais que comprometam a segurança do site ou 
 * possam bloquear a aplicação.
 * 
 * Notes:
 * filter_var ( mixed $variable [, int $filter = FILTER_DEFAULT [, mixed $options ]] ) : mixed
 * Filters a variable with a specified filter.
 * 
 */

// Functions to filter user inputs
function filterName($field){
    // Sanitize user name
    $field = filter_var(trim($field), FILTER_SANITIZE_STRING);
    
    // valida o campo segundo a expressão regular indicada
    if(filter_var($field, FILTER_VALIDATE_REGEXP, array("options"=>array("regexp"=>"/^[a-zA-Z\s]+$/"))))
    {
        return $field;
    } else{
        return FALSE;
    }
}


// sanitizes and validates an email address
function filterEmail($field){
    // Sanitize e-mail address - first remove illegal characters from $email
    $field = filter_var(trim($field), FILTER_SANITIZE_EMAIL);
    
    // Validate e-mail address
    if(filter_var($field, FILTER_VALIDATE_EMAIL)){
        return $field;
    } else{
        return FALSE;
    }
}

function filterCodPostal($field){
    // Sanitize user name
    $field = filter_var(trim($field), FILTER_SANITIZE_STRING);
    
    // Validate user name
    if(filter_var($field, FILTER_VALIDATE_REGEXP, array("options"=>array("regexp"=>"/^[0-9-]+$/")))){
        return $field;
    } else{
        return FALSE;
    }
}


function filterString($field){
    // Sanitize string
    $field = filter_var(trim($field), FILTER_SANITIZE_STRING);
    
    if(!empty($field)){
        return $field;
    } else{
        return FALSE;
    }
}
