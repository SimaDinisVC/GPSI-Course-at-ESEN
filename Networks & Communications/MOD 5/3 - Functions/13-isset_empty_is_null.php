<?php
$var = "";
print "isset():". isset($var)."<br/>";
$var = "apple";
print "isset('apple'):". isset($var)."<br/>";
$var = NULL;
print "isset('NULL'):". isset($var)."<br/>";
$var = FALSE;
print "isset('FALSE'):". isset($var)."<br/>";
$var = 0;
print "isset('0'):". isset($var)."<br/>";
print "isset(undefined):". isset($var3)."<br/>";

print "<br/>EMPTY: <br/>";
$var = "";
print 'empty(""): ' . empty($var) . "<br/>";
$var = 'apple';
print "empty('apple'): " . empty($var) . "<br/>";
$var = null;
print "empty(null): " . empty($var) . "<br/>";
$var = FALSE;
print "empty(FALSE): " . empty($var) . "<br/>";
$var = 0;
print "empty(0): " . empty($var) . "<br/>";
print "empty(undefined): " . empty($var1) . "<br/>";

print "<br/>IS_NULL: <br/>";
$var = "";
print 'is_null(""): ' . is_null($var) . "<br/>";
$var = 'apple';
print "is_null('apple'): " . is_null($var) . "<br/>";
$var = null;
print "is_null(null): " . is_null($var) . "<br/>";
$var = FALSE;
print "is_null(FALSE): " . is_null($var) . "<br/>";
$var = 0;
print "is_null('0'): " . is_null($var) . "<br/>";
print "is_null(undefined):" . is_null($var2) . "<br/>";