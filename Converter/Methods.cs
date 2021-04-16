using Converter.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Converter.Model;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace Converter
{
    public class Methods
    {
        public static NumberStyles DecimalNumberStyle { get; private set; }

        public static void AddKontrahentFromCSV(string path)
        {
            var connectionString = SqlHelper.getConnection();
            var lineNumber = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (lineNumber != 0)
                        {
                            var values = line.Split(';');
                            var sql = @"INSERT INTO dbo.Constructors (Name, Surname, IDBuyer, Phone) VALUES('" + values[0] + "','" + values[1] + "','" + values[2] + "','" + values[3] + "')";
                            //var sql = @"INSERT INTO dbo.Constructors (Name, Surname, IDBuyer, Phone)) VALUES('" + values[0] + "','" + values[1] + "','" + values[2] +  "')";
                            var cmd = new SqlCommand();
                            cmd.CommandText = sql;
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.Connection = conn;
                            cmd.ExecuteNonQuery();
                        }
                        lineNumber++;
                    }
                }
                conn.Close();
            }
            MessageBox.Show("successful import");


        }
        public static void AddKontrahentFromXML(string path)
        {
            var connectionString = SqlHelper.getConnection();
            XmlSerializer serializer = new XmlSerializer(typeof(XMLContractors));
            using (StreamReader reader = new StreamReader(path))
            {
               
                    var xml = (XMLContractors)serializer.Deserialize(reader);

                    foreach (var item in xml.contractors)
                    {
                        var sql = @"INSERT INTO dbo.Constructors (Name, Surname, IDBuyer, Phone) VALUES('" + item.name + "','" + item.surname + "','" + item.id + "','" + item.phone + "')";
                        using (var conn = SqlHelper.OpenConnection(connectionString))
                        {
                            using (var comm = new SqlCommand(sql, conn))
                            {
                                var result = comm.ExecuteNonQuery();
                            }
                        }
                    }
                    MessageBox.Show("successful import");
        


               
            }
        }

        public static void AddKontrahentFromJSON(string path)
        {
            var connectionString = SqlHelper.getConnection();
            string FIleJson = File.ReadAllText(path);
            JSONContractors JSONContractors = JsonConvert.DeserializeObject<JSONContractors>(FIleJson);

            foreach (var item in JSONContractors.contractors)
            {
                var sql = @"INSERT INTO dbo.Constructors (Name, Surname, IDBuyer, Phone) VALUES('" + item.name + "','" + item.surname + "','" + item.id + "','" + item.phone + "')";
                using (var conn = SqlHelper.OpenConnection(connectionString))
                {
                    using (var comm = new SqlCommand(sql, conn))
                    {
                        var result = comm.ExecuteNonQuery();
                    }
                }
            }
            MessageBox.Show("successful import");

        }


        public static List<Contractor> GetContractors(string connectionString)
        {
            string SelectAllContractors = @"Select Name, Surname, IDBuyer, Phone from dbo.Constructors";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(SelectAllContractors, conn))
                {
                    using (var reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return SqlHelper.ReadAll(reader, Contractor.ReadContractor);
                        }
                        else
                            return new List<Contractor>();
                    }

                }
            }
        }


        public static List<Stock> GetStock(string connectionString)
        {
            string SelectAllProduct = @"Select ProductID, ProductName, ProductPrice from dbo.Stock";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(SelectAllProduct, conn))
                {
                    using (var reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return SqlHelper.ReadAll(reader, Stock.ReadStock);
                        }
                        else
                            return new List<Stock>();
                    }

                }
            }
        }

        public static int RemoveContractor(string connectionString, string parametr1)
        {
            var queryString = @"Delete from dbo.Constructors  where IDBuyer = @IDBuyer";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(queryString, conn))
                {
                    comm.Parameters.AddWithValue("@IDBuyer", parametr1);

                    var result = comm.ExecuteNonQuery();

                    return result;
                }
            }
        }

        public static int RemoveProduct(string connectionString, string parametr1)
        {
            var queryString = @"Delete from dbo.Stock  where ProductID = @ProductID";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(queryString, conn))
                {
                    comm.Parameters.AddWithValue("@ProductID", parametr1);

                    var result = comm.ExecuteNonQuery();

                    return result;
                }
            }
        }




        public static int EditContractor(string connectionString, string parametr1, string parametr2, string parametr3, string parametr4)
        {
            var queryString = @"update dbo.Constructors set Name =@Name, Surname = @Surname, Phone = @Phone where IDBuyer = @IDBuyer";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(queryString, conn))
                {
                    comm.Parameters.AddWithValue("@Name", parametr1);
                    comm.Parameters.AddWithValue("@Surname", parametr2);
                    comm.Parameters.AddWithValue("@IDBuyer", parametr3);
                    comm.Parameters.AddWithValue("@Phone", parametr4);
                    var result = comm.ExecuteNonQuery();

                    return result;
                }
            }
        }

        public static int EditProduct(string connectionString, string parametr3,string parametr1, decimal parametr2)
        {
            var queryString = @"update dbo.Stock set ProductName =@ProductName, ProductPrice = @ProductPrice where ProductID = @ProductID";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(queryString, conn))
                {
                    comm.Parameters.AddWithValue("@ProductName", parametr1);
                    comm.Parameters.AddWithValue("@ProductPrice", parametr2);
                    comm.Parameters.AddWithValue("@ProductID", parametr3);
                    var result = comm.ExecuteNonQuery();

                    return result;
                }
            }
        }

        public static int AddNewContractor(string connectionString, string parametr1, string parametr2, string parametr3, string parametr4)
        {
            var queryString = @"INSERT INTO dbo.Constructors (Name, Surname, IDBuyer, Phone) VALUES(@Name, @Surname, @IDBuyer, @Phone)";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(queryString, conn))
                {
                    comm.Parameters.AddWithValue("@Name", parametr1);
                    comm.Parameters.AddWithValue("@Surname", parametr2);
                    comm.Parameters.AddWithValue("@IDBuyer", parametr3);
                    comm.Parameters.AddWithValue("@Phone", parametr4);

                    var result = comm.ExecuteNonQuery();

                    return result;
                }
            }
        }

        public static int AddNewUser(string connectionString, string parametr1, string parametr2, string parametr3, string parametr4, string parametr5)
        {
            var queryString = @"INSERT INTO dbo.Users (UserName, UserP, UserSeeContractors, UserEditContractors, UserAccessInvoice) VALUES(@UserName, @UserP, @UserSeeContractors, @UserEditContractors, @UserAccessInvoice)";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(queryString, conn))
                {
                    comm.Parameters.AddWithValue("@UserName", parametr1);
                    comm.Parameters.AddWithValue("@UserP", parametr2);
                    comm.Parameters.AddWithValue("@UserSeeContractors", parametr3);
                    comm.Parameters.AddWithValue("@UserEditContractors", parametr4);
                    comm.Parameters.AddWithValue("@UserAccessInvoice", parametr5);
                    
                    var result = comm.ExecuteNonQuery();

                    return result;
                }
            }
        }


        public static int AddNewProduct(string connectionString, string parametr1, decimal parametr2)
        {
            var queryString = @"INSERT INTO dbo.Stock(ProductName, ProductPrice) VALUES(@ProductName, @ProductPrice)";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(queryString, conn))
                {
                    comm.Parameters.AddWithValue("@ProductName", parametr1);
                    comm.Parameters.AddWithValue("@ProductPrice", parametr2);
                

                    var result = comm.ExecuteNonQuery();

                    return result;
                }
            }
        }
        public static string DotToComma(string parametr1)
        {
            string parametr2;
            if (parametr1.Contains("."))
            {
                parametr2 = parametr1.Replace(".", ",");
            }
            else
            {
                parametr2 = parametr1;
            }
            return parametr2;
       
        }


    



        public static string CheckedBox (CheckBox checkBox)
            {
            if (checkBox.CheckState == CheckState.Checked )
            {
                return "1";
            }
            else
            {
                return "0";
            }
            }


        public static   void FillCombo(ComboBox comboBox)
        {
            var connectionString = SqlHelper.getConnection();
            string Query = "select * from dbo.Users";
            SqlConnection conDataBase = new SqlConnection(connectionString);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString(1);
                    sName = sName.TrimEnd();
                    comboBox.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error Message");
            }

        }


        public static void FillComboDataBase(ComboBox comboBox)
        {
            var connectionString = SqlHelper.getConnection();
            string Query = "SELECT name FROM master.dbo.sysdatabases";
            SqlConnection conDataBase = new SqlConnection(connectionString);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString(0);
                    sName = sName.TrimEnd();
                    comboBox.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error Message");
            }

        }




    }
}
