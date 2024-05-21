<?php

/* 
    * this fuction will give an array with the data that was found by the ID,
    * follow the example with the structure of it:
    * * data: ['email': ['password', 'id']]
    * * returned: ['email', 'password']
*/ 
function searchforID($data, $id) {
    foreach ($data as $email => $dados) {
        if (isset($dados[1]) && $dados[1] == $id) {
            return ['email' => $email, 'password' => $dados[0]];
        }
    }
    return null;
}

?>