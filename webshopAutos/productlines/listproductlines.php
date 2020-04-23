<?php
include "../connectdb.php";
$productLine = $_GET["productline"];

/*$select = "*";
$from = "Products";

function selectTables($select, $from){
    global $db;
    $sql = "SELECT $select FROM $from";

    $result = $db->prepare($sql);
    $result-> execute();
    $array = $result->fetchAll(PDO:: FETCH_ASSOC);

    foreach($array as $dataArray)
        {
         echo "<tr>";
            foreach($dataArray as $data) {
        echo "<td>$data</td>";
        }
        echo "</tr>";
}
}

*/
$sql = "SELECT * FROM products WHERE productline =:PL";
   $params =  array(
       ":PL" => $productLine
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
  <th>Product Code</th>
  <th>Product Name</th>
  <th>Product Line</th>
  <th>Product Scale</th>
  <th>Product Vendor</th>
  <th>Product Description</th>
  <th>Quantity in stock</th>
  <th>Price</th>
  <th>MSRP</th>
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



