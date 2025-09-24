using System.Data;
using System.Data.SqlClient;

// Console.WriteLine("Hello, World!");
// Console.ReadLine();
// Console.ReadKey();

string connectionString = "Server=.;Database=TrainingBatch5;User Id=sa;Password=23032106;TrustServerCertificate=True;";

Console.WriteLine("Connection String: " + connectionString);
Console.WriteLine("");

SqlConnection connection = new SqlConnection(connectionString);

Console.WriteLine("Connection opening . . . ");
connection.Open();
Console.WriteLine("Connection opened successfully!");
Console.WriteLine("");

string sqlQuery = @"SELECT [BlogId]
      ,[BlogTitle]
      ,[BlogAuthor]
      ,[BlogContent]
      ,[DeleteFlag]
  FROM [dbo].[Tbl_Blog]";

SqlCommand command = new SqlCommand(sqlQuery, connection);
SqlDataAdapter  adapter = new SqlDataAdapter(command);
DataTable dataTable = new DataTable();
adapter.Fill(dataTable);
Console.WriteLine("Data fetched By Data Adapter!");
foreach (DataRow row in dataTable.Rows)
{
    Console.WriteLine($"BlogNo.: {row["BlogId"]}, Title: {row["BlogTitle"]}, Author: {row["BlogAuthor"]}, Content: {row["BlogContent"]}");
}

Console.WriteLine("");

Console.WriteLine("Data fetched By Data Reader!");
SqlDataReader sqlDataReader = command.ExecuteReader();
while (sqlDataReader.Read())
{
    Console.WriteLine($"BlogNo.: {sqlDataReader["BlogId"]}, Title: {sqlDataReader["BlogTitle"]}, Author: {sqlDataReader["BlogAuthor"]}, Content: {sqlDataReader["BlogContent"]}");
}

Console.WriteLine("");

Console.WriteLine("Connection closing . . . ");
connection.Close();
Console.WriteLine("Connection closed successfully!");

