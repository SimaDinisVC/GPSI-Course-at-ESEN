<?php

/**
 * From: https://www.tutorialrepublic.com/php-tutorial/php-form-validation.php
 * Date: 2018-10-02
 * Update: 2023-09-28
 * 
 * Pretende-se implementar recursos básicos de segurança, como a validação da entrada de dados 
 * do utilizador evitando a inserção  de dados potencialmente prejudiciais que comprometam 
 * a segurança do site ou possam bloquear a aplicação.
 * 
 * Notas:
 * filter_var ( mixed $variable [, int $filter = FILTER_DEFAULT [, mixed $options ]] ) : mixed
 * Filters a variable with a specified filter.
 * 
 * Tipos de filtros:
 *  Validate filters    - https://www.php.net/manual/en/filter.filters.validate.php
 *  Sanitize filters    - https://www.php.net/manual/en/filter.filters.sanitize.php
 *  Other filters       
 *  Filter flags        - https://www.php.net/manual/en/filter.filters.flags.php
 * 
 * 
 * A função preg_match() procura uma string num padrão e devolve verdadeiro se existir um padrão ou devolve falso.
 * 
 * Tanto a função filter_var() como preg_match() requerem a compreensão de expressões regulares.
 * 
 */


 
// To protect against XSS attacks, we created a custom function checkInput()
function checkInput($input)
{
    $input = trim($input);
    $input = stripslashes($input);
    $input = htmlspecialchars($input);
    return $input;
}

// Functions to filter user inputs
function filterName($field){
    // Sanitize user name

    $field = filter_var(trim($field), FILTER_SANITIZE_FULL_SPECIAL_CHARS);
    
    // Validates the field according to the indicated regular expression
    // Does not accept special characters. Than, change the regular expression
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
    $field = filter_var(trim($field), FILTER_SANITIZE_FULL_SPECIAL_CHARS);
    
    // Validate user name
    if(filter_var($field, FILTER_VALIDATE_REGEXP, array("options"=>array("regexp"=>"/^[0-9-]+$/")))){
        return $field;
    } else{
        return FALSE;
    }
}


function filterString($field){
    // Sanitize string
    $field = filter_var(trim($field), FILTER_SANITIZE_FULL_SPECIAL_CHARS);
    
    if(!empty($field)){
        return $field;
    } else{
        return FALSE;
    }
}

