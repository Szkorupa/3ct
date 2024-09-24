<?php
    include 'db.php';

    $id = $_GET['id'];
    $sql = "DELETE FROM users WHERE id=$id";

    if($conn->query($sql) === TRUE) {
        echo "Użytkownik został usunięty";
    } else {
        echo "Błąd: " . $sql . "<br>" . $conn->error;
    }
    $conn->close();
?>