<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulário - PHP</title>
</head>
<body>
    <h1>Formulário em PHP</h1>
    
    <form action="processamento.php" method="POST">
        <label for="nome">Nome:</label><br>
        <input type="text" name="nome"><br>
        <label for="idade">Idade:</label><br>
        <input type="text" name="idade"><br>
        <label for="email">E-mail:</label><br>
        <input type="text" name="email"><br><br>
        <input type="submit" value="ENVIAR">
    </form> 
    
    <?php

    ?>
</body>
</html>

