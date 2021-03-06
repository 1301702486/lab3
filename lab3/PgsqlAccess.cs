﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

public class PgsqlAccess
{
    public string Host = "localhost";
    public string User = "postgres";
    public string DBname = "whu";
    public string Password = "postgres";
    public string Port = "5432";

    // 创建PgsqlAccess的一个对象
    private static PgsqlAccess instance = new PgsqlAccess();

    // 私有化构造函数
    private PgsqlAccess() { }

    // 获取唯一可用的对象
    public static PgsqlAccess getInstance()
    {
        return instance;
    }

    // 连接数据库
    public NpgsqlConnection GetConnection()
    {
        string connStr = string.Format(
                    "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};",
                    Host, User, DBname, Port, Password);

        NpgsqlConnection conn = null;
        try
        {
            conn = new NpgsqlConnection(connStr);
            conn.Open();
        }
        catch(Exception)
        {
            if (conn != null)
            {
                conn.Close();
            }
            throw new Exception("Wrong password!");
        }
        return conn;
    }

    public void Insert(string tableName, string colList, string valueList)
    {
        using (var conn = GetConnection())
        {
            string insertStr = string.Format("insert into {0} {1} values {2};",
                    tableName, colList, valueList);
            using (var cmd = new NpgsqlCommand(insertStr, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }


    // 简易版update（不能把非空值改为空值）
    public void Update(string tableName, string colName, string value, string keyName, string keyValue)
    {
        using (var conn = GetConnection())
        {
            string updateStr = string.Format("update {0} set {1} = '{2}' where {3} = '{4}';",
                    tableName, colName, value, keyName, keyValue);

            using (var cmd = new NpgsqlCommand(updateStr, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }

    // 简易版delete（删除所有colName=value的记录）
    public void Delete(string tableName, string colName, string value)
    {
        using (var conn = GetConnection())
        {
            string deleteStr = string.Format("delete from {0} where {1} = '{2}';",
                tableName, colName, value);
            using (var cmd = new NpgsqlCommand(deleteStr, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void DropColumn(string tableName, string colName)
    {
        using (var conn = GetConnection())
        {
            string alterStr = string.Format("alter table {0} drop column {1};", tableName, colName);
            using (var cmd = new NpgsqlCommand(alterStr, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void AddColumn(string tableName, string colName, string dataType)
    {
        using (var conn = GetConnection())
        {
            string alterStr = string.Format("alter table {0} add column {1} {2};", 
                tableName, colName, dataType);
            using (var cmd = new NpgsqlCommand(alterStr, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void AlterColumn(string tableName, string colName, string dataType)
    {
        using (var conn = GetConnection())
        {
            string alterStr = string.Format("alter table {0} alter column {1} type {2};", 
                tableName, colName, dataType);
            using (var cmd = new NpgsqlCommand(alterStr, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
