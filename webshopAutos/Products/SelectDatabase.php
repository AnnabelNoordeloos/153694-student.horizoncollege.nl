<?php
include "../connectdb.php";

$sql = "SELECT * FROM productlines";
$result = $db->prepare($sql);
$result->execute();

$array = $result->fetchAll();
?>

<ul class="list-group list-group-flush">
    <?php
foreach ($array as $column){
    echo "<li class=\"list-group - item\"><a href=\"../productlines/index.php/?productline=$column[0]\">$column[0]</a></li>";
}
?>
</ul>
