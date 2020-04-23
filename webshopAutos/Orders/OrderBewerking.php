<?php
include "../connectdb.php";
//include "../employees/listEmplyees.php";

$OrderLine = $_GET["orderline"];

//selectTables("o.orderNumber, o.orderDate, o.requiredDate, o.shippedDate, o.Status, o.comments", "order AS o JOIN customers AS USING c customerNumber
//        WHERE o.orderNumber = :NUM");

$sql = "SELECT o.orderNumber, o.orderDate, o.requiredDate, o.Status
      FROM order AS o JOIN customers AS USING c customerNumber
      WHERE o.orderNumber = :NUM";

$params =  array(
    ":NUM" => $OrderLine
);
$result = $db->prepare($sql);
$result-> execute($params);
$array = $result->fetchAll(PDO:: FETCH_ASSOC);
?>

<?php
echo "<table class=\"table\">";
echo "<thead>";
echo "    
<tr>
  <th>Order Number</th>
  <th>Order Date</th>
  <th>Required Date</th>
  <th>Shipped Date</th>
  <th>Status</th>
  <th>Comments</th>
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

<style>
    .data {
        border: 1px solid black;
    }
</style>
