<?php
    
    include 'conecta.php';

    $nome_cliente = $_REQUEST['nome'];
    $email_cliente = $_REQUEST['email'];
    $telefone = $_REQUEST['telefone'];

    $consulta = "INSERT INTO clientes (nome_cliente, email_cliente, telefone) VALUES ('$nome_cliente', '$email_cliente', '$telefone')";
    $conexao->query($consulta);

    header('Location: index.php');

?>