<?php
    include 'includes/db.php';
    $result = $conn->query("SELECT id, name, email, created_at FROM users");

    if (!$result) {
        echo "Error: " . $conn->error;
        exit();
    }
    $num_rows = $result->num_rows;
    
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Crud</title>
</head>
<body>
    <main>
        <div class="container">
            <div class="content">
            <h2 style="text-align: center;">Lista użytkowników</h2>
            <div class="table">
                <table>
                    <tr>
                        <th>ID</th>
                        <th>Imie</th>
                        <th>Email</th>
                        <th>Data utworzenia</th>
                        <th>Akcje</th>
                    </tr>
                    <?php 
                        if($result->num_rows > 0) {
                            while($row = $result->fetch_assoc()) {
                                echo "<tr>";
                                echo "<td>" . $row["id"] . "</td>";
                                echo "<td>" . $row["name"] . "</td>";
                                echo "<td>" . $row["email"] . "</td>";
                                echo "<td>" . $row["created_at"] . "</td>";
                                echo "<td>
                                <a href='edit.php?id=".$row["id"]."'>Edytuj</a>
                                <a href='delete.php?id=".$row["id"]."'>Usun</a>
                                </td>";
                                echo "</tr>";
                            }
                        } else {
                            echo "<tr><td colspan='5'>Brak użytkowników</td></tr>";
                        }
                    ?>
                </table>
            </div>
            <br>
            <div class="text">
            <a href="create.php" style="text-align: center">Dodaj nowego użytkownika</a>

            </div>
            </div>
        </div>
    </main>
</body>
</html>

<?php
$conn->close();
?>