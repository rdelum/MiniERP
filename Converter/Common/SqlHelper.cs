using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.SQL
{
    public static class SqlHelper
    {


        public static string getConnection()
        {
            return Properties.Settings.Default.CheckNT
               ? $"Data Source={Properties.Settings.Default.SerwerName};Initial Catalog={Properties.Settings.Default.DataBaseName};Integrated Security=SSPI"
               : $"Data Source={Properties.Settings.Default.SerwerName};Initial Catalog={Properties.Settings.Default.DataBaseName};User ID={Properties.Settings.Default.Login};Password={Properties.Settings.Default.Password}";
        }
        public static SqlConnection OpenConnection(string connectionString)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static T ReadSingle<T>(SqlDataReader reader, Func<SqlDataReader, T> readFunc, T defaultValue = default(T))
        {
            while (reader.Read())
                return readFunc(reader);
            return defaultValue;
        }

        public static List<T> ReadAll<T>(SqlDataReader reader, Func<SqlDataReader, T> readFunc)
        {
            List<T> list = new List<T>();
            while (reader.Read())
                list.Add(readFunc(reader));
            return list;
        }

        public static Tuple<string[], string[][]> ReadAll(SqlDataReader reader)
        {
            List<string[]> list = new List<string[]>();
            string[] header = null;
            if (header == null)
                header = ReadHeader(reader);
            while (reader.Read())
            {
                string[] row = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++)
                    row[i] = reader.GetValue(i)?.ToString();
                list.Add(row);
            }
            return new Tuple<string[], string[][]>(header, list.ToArray());
        }

        public static string[] ReadHeader(SqlDataReader reader)
        {
            List<string> names = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
                names.Add(reader.GetName(i));
            return names.ToArray();
        }
    }
}