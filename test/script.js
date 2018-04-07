function addRecord() {
var x = document.getElementById("numb").value;
var adoConn = new ActiveXObject("ADODB.Connection");
var adoRS = new ActiveXObject("ADODB.Recordset");



adoConn.Open("Provider=Microsoft.ACE.OLEDB.12.0;;Data Source='/Drawers.accdb'");
adoRS.Open("INSERT INTO draw VALUES ('"+x+"'"+",22,'23','232','32')", adoConn);




adoConn.Close();
}  

function deleteRecord() {
var x = document.getElementById("numb").value;
var adoConn = new ActiveXObject("ADODB.Connection");
var adoRS = new ActiveXObject("ADODB.Recordset");

adoConn.Open("Provider=Microsoft.ACE.OLEDB.12.0;;Data Source='/Drawers.accdb'");
adoRS.Open("DELETE FROM draw WHERE DRAW='"+x+"'", adoConn);


adoConn.Close();
}  

function updateRecord() {
var x = document.getElementById("numb").value;
var adoConn = new ActiveXObject("ADODB.Connection");
var adoRS = new ActiveXObject("ADODB.Recordset");



adoConn.Open("Provider=Microsoft.ACE.OLEDB.12.0;;Data Source='/Drawers.accdb'");
adoRS.Open("Select * FROM Draw WHERE DRAW='"+x+"'", adoConn);
document.getElementById("demo").innerHTML='<p>'+adoRS.GetString()+'</p>';



adoConn.Close();
}  