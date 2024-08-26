<?php
    $nome = "rOBeRtO";
    $nome = strtolower($nome);
    
    if ($nome == 'roberto'){
        echo "Bem vindo ".$nome;
    } else {
        echo "Você não é Roberto.";
    }

    echo "<hr>";

    for ($x = 1; $x <= 10; $x++){
        if ($x % 2 == 0){
            echo $x;
            echo "<br>";
        } else {
            echo "ÍMPAR";
            echo "<br>";
        }
    }

    echo "<hr>";

    $a = 1;
    while ($a <= 10){
        echo $a;
        echo "<br>";
        $a++;
    }
?>