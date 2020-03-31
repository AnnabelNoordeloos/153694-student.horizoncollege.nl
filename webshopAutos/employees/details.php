<?php
include "../connectdb.php";

$id = array (
    "Products" => "productCode",
    "ProductLines" => "productLine",
    "Employees" => "employeeNumber",
    "Offices" => "officeCode",
    "Customers" => "customerNumber",
    "Orders" => "orderNumber"
);

function details($select, $from, $where)
{
    global $db;
    global $id;

    $sql = "SELECT $select FROM $from WHERE $where = ':ID'";
    $params = array(
        ":ID" => $id
    );
    $result = $db->prepare($sql);
    $result->execute($params);
    $Array = $result->fetchAll(PDO:: FETCH_ASSOC);

    foreach ($Array as $dataArray){
        echo "<tr>";
        foreach($dataArray as $data){
            echo "<td>$data</td>";
        }
        echo "<td><a href='delete.php?id={$data[0]}'>Delete</a></td>";
        echo "</tr>";
    }
}

details ("*", "employees", "employeeNumber");
?>
