<?php
    $host = "localhost";
    $username = "root";
    $password = "";
    $dbname = "baza24092024";

    $conn = new mysqli($host, $username, $password, $dbname);

    if ($conn->connect_error) {
        die("Połączenie nieudane: " . $conn->connect_error);
    }
?>