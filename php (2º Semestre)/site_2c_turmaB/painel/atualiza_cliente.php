<?php

    include 'conecta.php';

    $id_cliente = $_REQUEST['id_clienteSelecionado'];
    $nome_clienteNovo = $_REQUEST['nome_clienteNovo'];
    $email_clienteNovo = $_REQUEST['email_clienteNovo'];
    $telefoneNovo = $_REQUEST['telefoneNovo'];

    $consulta = "UPDATE clientes SET nome_cliente = '$nome_clienteNovo', email_cliente = '$email_clienteNovo', telefone = '$telefoneNovo' WHERE id_cliente = $id_cliente";
    $conexao->query($consulta);

    header('Location: index.php');

?>