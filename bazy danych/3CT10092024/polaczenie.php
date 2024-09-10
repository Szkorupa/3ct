<?php
    $server = "localhost";
    $user = "root";
    $password = "";
    $db = "baza10092024";
    $polaczenie = new mysqli($server, $user, $password, $db);

    if (mysqli_connect_errno()!=0) {
        die("<php> Nieudalo sie polaczyc " . $polaczenie->mysqli_connect_errno() . "</php>");
    } else {
        echo("<h5>Połączenie udane $db</h5>");
    }
?>



