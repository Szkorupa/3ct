<?php
    include_once("polaczenie.php");

    if (isset($_POST['submit'])) {    
     $name = $_POST['name'];
     $cena = $_POST['cena'];
     $zapytanie_dodaj = $polaczenie->query(query: "INSERT INTO `zakupy`(`nazwa`, `cena`) VALUES ('$name','$cena');");

     if ($zapytanie_dodaj){
        echo("Dodano rekord $name, $cena");
    } else {
        echo("Error 777 (Jackpot)");
    }
    }

    echo("\n<a href='index.php'>Cofnij</a>");

    $polaczenie->close();
?>