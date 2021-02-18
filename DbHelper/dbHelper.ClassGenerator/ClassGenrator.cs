using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace dbHelper.ClassGenerator
{
    public class ClassGenrator
    {
        private readonly string outputDirectory;
        private readonly string connectionString;
        private readonly string databaseName;

        public ClassGenrator(string outputDirectory, string connectionString, string databaseName)
        {
            this.outputDirectory = outputDirectory;
            this.connectionString = connectionString;
            this.databaseName = databaseName;
        }

        public void GenerateClasses()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(
                    $"SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' AND TABLE_CATALOG='{databaseName}'",
                    connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    string sql = $"declare @TableName sysname = '{tableName}'{DbSchemaProvider.querySchemaSql}";
                    SqlCommand command = new SqlCommand(sql, connection);
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    string code = (string)command.ExecuteScalar();

                    if (string.IsNullOrWhiteSpace(code))
                    {
                        continue;
                    }

                    Directory.CreateDirectory(Path.GetFullPath(outputDirectory));
                    string path = Path.Combine(outputDirectory, $"{tableName}.cs");
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    using (FileStream fs = File.Create(path))
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes(code);
                        fs.Write(info, 0, info.Length);
                        Console.WriteLine($"Created {path}");
                    }
                }
            }
        }

    }
}
