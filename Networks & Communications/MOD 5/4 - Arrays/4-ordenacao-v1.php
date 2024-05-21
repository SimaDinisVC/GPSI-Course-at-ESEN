<!doctype html>
<html>
    <head>
    <meta charset="utf-8">
    <title>Ordena array</title>
</head>
<style>
    table {margin-left: 200px; 	border-collapse: collapse;}
    table, td, tr {
        border: 1px solid black;
    }
</style>
<body>
    
    <table>
        <tr>
            <td><h2>Rating</h2></td>
            <td><h2>Titulo</h2></td>
        </tr>
        <?php

            // Cria o array:
            $filmes = array (
                10 => 'Casablanca',
                9 => 'To Kill a Mockingbird',
                2 => 'The English Patient',
                8 => 'Stranger Than Fiction',
                5 => 'Story of the Weeping Camel',
                7 => 'Donnie Darko'
            );

            echo '<tr><td colspan="2"><b>Ordem original:</b></td></tr>';
            foreach ($filmes as $key => $value) {
                echo "<tr><td>$key</td>
                      <td>$value</td></tr>\n";
            }

            // Ordena pelo valor e não pela chave
            asort($filmes); 

            echo '<tr><td colspan="2"><b>Ordenação por titulo:</b></td></tr>';
            foreach ($filmes as $key => $value) {
                echo "<tr><td>$key</td>
                <td>$value</td></tr>\n";
            }

            // ordena pela chave e não pelo valor
            krsort($filmes);

            echo '<tr><td colspan="2"><b>Ordenação por rating:</b></td></tr>';
            foreach ($filmes as $key => $value) {
                echo "<tr><td>$key</td>
                <td>$value</td></tr>\n";
            }

        ?>
    </table>
</body>
</html>