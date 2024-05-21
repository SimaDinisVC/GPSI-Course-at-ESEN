<?php
include_once("functions.php");
$con = pdo_connect_mysql();

$id = $_POST['id'];

$sql = "DELETE FROM comments WHERE id=$id";

if($result = $con->query($sql)){
    if($result->rowCount() == 1) echo "1";
    else echo "0";
}

unset($con);

?>