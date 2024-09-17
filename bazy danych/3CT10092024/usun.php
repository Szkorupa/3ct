<?php
    include_once("polaczenie.php");
    $idz = isset($_GET['idz'])?$_GET['idz']:header(header: "Location: index.php");

    // Test kontrolny czy dostaje idz po "gecie" :XD ->     echo("IDZ: {$_GET['idz']}");

    $zapytanie_usun = $polaczenie->query(query: "delete from zakupy where idz=$idz");
    if ($zapytanie_usun){
        echo("Usunięto rekord o IDZ = $idz");
    } else {
        echo("Error 777 (Jackpot)");
    }

    echo("\n<a href='index.php'>Cofnij</a>");

    $polaczenie->close();
?>