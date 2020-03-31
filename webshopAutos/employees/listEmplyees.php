<?php
include "../connectdb.php";

echo "<table class=\"table\">";
echo "<thead>";
echo "    
        <tr>
          <th>Office code</th>
          <th>Last name</th>
        </tr>";
echo "</thead>";

function selectTables($select, $from){
    global $db;
    $sql = "SELECT $select FROM $from";

    $result = $db->prepare($sql);
    $result-> execute();
    $array = $result->fetchAll(PDO:: FETCH_ASSOC);

    echo "<tbody>";
    foreach($array as $dataArray)
    {
        echo "<tr>";
        foreach($dataArray as $data) {
            echo "<td>$data</td>";
        }
        echo "<td><a href='details.php?id={$data[0]}'>details</a></td>";
        echo "</tr>";
    }
    echo "</table>";
    echo "</tbody>";
}


selectTables("employeeNumber, lastName", "employees");





/*$sql = "SELECT employeeNumber, lastName FROM employees";


$result = $db->prepare($sql);
$result-> execute();
$array = $result->fetchAll(PDO:: FETCH_ASSOC);

?>

<?php
echo "<table class=\"table\">";
echo "<thead>";
echo "    
<tr>
  <th>Employee number</th>
  <th>Last name</th>
  <th>First name</th>
  <th>Extention</th>
  <th>Email</th>
  <th>OfficeCode</th>
  <th>ReportsTo</th>
  <th>JobTitle</th>
</tr>";
echo "</thead>";
echo "<tbody>";
foreach($array as $index => $dataArray)
{
    echo "<tr>";
    foreach($dataArray as $index => $data) {
        if($index == 0){
            echo "<td><a href=\"details.php/?data=$data\">$data</a></td>";
        }else {
            echo "<td>$data</td>";
        }
    }
    echo "</tr>";
}
echo "</tbody>";
echo "</table>";
?>

<style>
    .data {
        border: 1px solid black;
    }
</style>

*/

