<?php
include 'includes/db.php';

$id = $_GET['id'];
$sql = "SELECT * FROM users WHERE id=$id";
$result = $conn->query($sql);
$user = $result->fetch_assoc();
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Edytuj użytkownika</title>
</head>
<body>
    <h2>Edytuj użytkownika</h2>    
    <form action="update.php" method="post">
        <input type="hidden" name="id" value="<?php echo $user['id']; ?>">
        <label for="name">Imię:</label><br>
        <input type="text" id="name" name="name" value="<?php echo $user['name'];?>" required> <br>
        <label for="email">Email:</label><br>
        <input type="email" id="email" name="email" value="<?php echo $user['email'];?>" required><br><br>
        <input type="submit" value="Aktualizuj">
    </form>
</body>
</html>