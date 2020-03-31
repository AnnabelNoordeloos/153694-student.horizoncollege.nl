<?php
include "../connectdb.php";


/*include "../productlines/listproductlines.php";

selectTables(city, offices);*/
$sql = "SELECT * FROM offices";

$result = $db->prepare($sql);
$result ->execute();

$array = $result->fetchAll(PDO:: FETCH_ASSOC);

echo "<table class=\"table\">";
echo "<thead>";
echo "    
<tr>
  <th>Office Code</th>
  <th>City</th>
  <th>Phone</th>
  <th>AddressLine1</th>
  <th>AddressLine2</th>
  <th>State</th>
  <th>Country</th>
  <th>PostalCode</th>
  <th>Territory</th>
</tr>";
echo "</thead>";
echo "<tbody>";
foreach($array as $dataArray)
{
    echo "<tr>";
    foreach($dataArray as $data) {
        echo "<td>$data</td>";
    }
    echo "</tr>";
}
echo "</tbody>";
echo "</table>";
?>
