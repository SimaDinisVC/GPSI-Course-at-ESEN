<?php

    setcookie('tema', 'light_mode.css', (time() + 1*365*24*60*60));
    header('Location: index.php');