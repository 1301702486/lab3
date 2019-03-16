using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

public class PgsqlAccess
{
    private static string Host = "localhost";
    private static string User = "postgres";
    private static string DBname = "whu";
    private static string Password = "postgres";
    private static string Port = "5432";

    public static NpgsqlConnection GetConnection()
    {
        string connStr = 
            String.Format(
                    "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);
        var conn = new NpgsqlConnection(connStr);
        conn.Open();
        return conn;
    }

    public static void InsertInto(string tableName, string colName, string value)
    {
        using(var conn = GetConnection())
        {
            string insertStr = 
                String.Format(
                    "INSERT INTO {0} {1} VALUES {2};",
                    tableName,
                    colName,
                    value);
            using (var cmd = new NpgsqlCommand(insertStr, conn))
            {
                cmd.Prepare();
                
            }
        }
    }
}
