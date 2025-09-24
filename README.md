
# Blog Data Reader - C# Console Application

A simple C# console application that demonstrates database connectivity using [ADO.NET](https://ado.net/) to fetch and display blog data from a SQL Server database.

## Features

-   Connects to SQL Server database using [ADO.NET](https://ado.net/)
    
-   Demonstrates two data retrieval methods:
    
    -   **DataAdapter** with DataTable
        
    -   **DataReader** for forward-only reading
        
-   Displays blog information including ID, title, author, and content
    
-   Proper connection management (open/close)
    

## Prerequisites

-   .NET Framework or .NET Core/.NET 5+
    
-   SQL Server (LocalDB or full version)
    
-   Database backup file (`Script.sql`)
    

## Installation

1.  Clone the repository:
    

bash

git clone <repository-url>
cd blog-data-reader

2.  Restore the database:
    
    -   Open SQL Server Management Studio
        
    -   Restore the database using the provided `Script.sql` file
        
    -   Alternatively, run the SQL script to create the database and table
        
3.  Update the connection string in `Program.cs` if needed:
    

csharp

string connectionString = "Server=.;Database=TrainingBatch5;User Id=sa;Password=23032106;TrustServerCertificate=True;";

## Project Structure

text

BlogDataReader/
│
├── Program.cs                 # Main application file
├── Script.sql                 # Database backup script
└── README.md                  # This file

## Code Overview

The application demonstrates two approaches to data retrieval:

### 1. DataAdapter Approach

csharp

SqlDataAdapter adapter = new SqlDataAdapter(command);
DataTable dataTable = new DataTable();
adapter.Fill(dataTable);

### 2. DataReader Approach

csharp

SqlDataReader sqlDataReader = command.ExecuteReader();
while (sqlDataReader.Read())
{
    // Read data row by row
}

## Usage

1.  Build the project:
    

bash

dotnet build

2.  Run the application:
    

bash

dotnet run

3.  The application will:
    
    -   Display the connection string
        
    -   Open database connection
        
    -   Fetch data using both DataAdapter and DataReader
        
    -   Display blog records in the console
        
    -   Close the connection properly
        

## Database Schema

The application connects to a table with the following structure:

sql

CREATE TABLE Tbl_Blog (
    BlogId INT PRIMARY KEY,
    BlogTitle NVARCHAR(255),
    BlogAuthor NVARCHAR(255),
    BlogContent NVARCHAR(MAX),
    DeleteFlag BIT
);

## Configuration

Modify the following connection string parameters in `Program.cs` as needed:

-   `Server`: Database server name (use `.` for local instance)
    
-   `Database`: Database name
    
-   `User Id`: SQL Server username
    
-   `Password`: SQL Server password
    

## Security Notes

-   The connection string contains sensitive credentials
    
-   Consider using secure configuration methods for production
    
-   Enable `TrustServerCertificate=True` only for development environments
    

## Technologies Used

-   C#
    
-   [ADO.NET](https://ado.net/)
    
-   SQL Server
    
-   System.Data.SqlClient
    

## Contributing

Feel free to submit issues and enhancement requests!

## License

This project is for educational purposes.