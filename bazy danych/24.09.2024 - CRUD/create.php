<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h2>Dodaj użytkowników</h2>
    <form action="store.php" method="post">
        <label for="name">Imie: </label><br>
        <input type="text" id="name" name="name" required>
        <label for="email">Email: </label><br>
        <input type="email" id="email" name="email" required>
        <input type="submit" value="Dodaj">
    </form>
</body>
</html>