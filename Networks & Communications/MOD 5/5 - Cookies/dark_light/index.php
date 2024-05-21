<?php
    //echo $_COOKIE['tema']; exit;
    $tema = 'light_mode.css';
    if(isset($_COOKIE['tema'])) $tema = $_COOKIE['tema'];
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="<?php echo $tema; ?>">
</head>
<body>
    <!-- 
        
    -->
    <h1>Muda Visual</h1>
    <a href="light_mode.php">Light Mode</a> | <a href="dark_mode.php">Dark Mode</a>
</body>
</html>