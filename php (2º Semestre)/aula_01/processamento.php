  
<?php
    $nome = $_POST['nome'];
    $idade = $_POST['idade'];
    $email = $_POST['email'];

    echo "Bom dia <span style='color:red;'>"  . $nome . "</span><br>";
    echo "você tem <span style='color:green;'>" . $idade . "</span> anos de vida<br>";
    echo "Seu e-mail é: <span style='color:blue;'>" . $email . "</span><br>"; 
?>
