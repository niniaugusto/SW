<?php

    include 'conecta.php';

    $id_clienteSelecionado = $_REQUEST['id_cliente'];

    $sql = "DELETE FROM clientes WHERE id_cliente=$id_clienteSelecionado";
    $query = $conexao->query($sql);

    header('Location: index.php');

?>