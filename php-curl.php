<?php
// uses php-curl and php-json

$query = "https://...";

$ch = curl_init();
curl_setopt($ch, CURLOPT_URL,"https://api.bypass.vip/");
curl_setopt($ch, CURLOPT_POST, 1);
curl_setopt($ch, CURLOPT_POSTFIELDS, http_build_query(array("url" => $query)));
curl_setopt($ch, CURLOPT_HTTPHEADER, array('Content-Type: application/x-www-form-urlencoded'));
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);

$response = curl_exec($ch);
curl_close ($ch);

echo "<pre>";
var_dump(json_decode($response));
