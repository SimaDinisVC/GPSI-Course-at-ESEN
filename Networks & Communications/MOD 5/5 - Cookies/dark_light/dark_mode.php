<?php

    setcookie('tema', 'dark_mode.css', (time()+365*24*60*60));
    header('Location: index.php');