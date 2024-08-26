<?php 
    $servidor = "localhost";
    $usuario = "root";
    $senha = "";
    $banco = "cadastro_cliente";

    $conexao = new mysqli($servidor, $usuario, $senha, $banco);

    if (mysqli_connect_errno()) {
        echo "Erro de conexão";
    }
    // else {
    // echo "Conectado ao banco de dados com sucesso!";
    // }
?>