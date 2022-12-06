using MySql.Data.MySqlClient;
string conStr="server=localhost; uid=root;password=password;database=classicmodels";
MySqlConnection con=new MySqlConnection();
try{
    con.ConnectionString=conStr;
    con.Open();
    string query = "SELECT * FROM Employees";
    MySqlCommand cmd = new MySqlCommand(query,con);
    MySqlDataReader rdr = cmd.ExecuteReader();

    while (rdr.Read())
    {
        Console.WriteLine(rdr[0]+"--"+rdr[1]+"--"+rdr[2]+"--"+rdr[3]);
    }
    rdr.Close();
}
catch(Exception a){
    Console.WriteLine(a.Message);
}
finally{
    con.Close();
}