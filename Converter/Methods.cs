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
        //public static NumberStyles DecimalNumberStyle { get; private set; }


        public static List<Invoice> GetInvoices(string connectionString)
        {
            string SelectAllInvoice = @"Select InvoiceNumber, InvoiceContractorID, InvoiceID, InvoiceElementID, InvoiceDate, InvoiceValueNet, InvoiceValueGross, InvoiceUser  from dbo.Invoices";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(SelectAllInvoice, conn))
                {
                    using (var reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return SqlHelper.ReadAll(reader, Invoice.ReadInvoice);
                        }
                        else
                            return new List<Invoice>();
                    }

                }
            }
        }



        public static List<Invoice> ContractorHistory(string connectionString, string parametr1)
        {
            string SelectAllInvoice = @"Select InvoiceNumber, InvoiceContractorID, InvoiceID, InvoiceElementID, InvoiceDate, InvoiceValueNet, InvoiceValueGross, InvoiceUser  from dbo.Invoices where InvoiceContractorID = @ContractorID";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(SelectAllInvoice, conn))
                {
                    comm.Parameters.AddWithValue("@ContractorID", parametr1);
                    using (var reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return SqlHelper.ReadAll(reader, Invoice.ReadInvoice);
                        }
                        else
                            return new List<Invoice>();
                    }

                }
            }
        }


        public static List<InvoiceElements> GetInvoiceElements(string connectionString, string parametr1)
        {
            string SelectAllIProductsFromInvoice = @"Select InvoiceElementID , InvoiceID, InvoiceValueNet, InvoiceElementTax, InvoiceValueGross, StockId from dbo.InvoiceElements 
                                        join dbo.Stock on stock.ProductID = InvoiceElements.StockId where InvoiceID = @InvocieIDD";

            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(SelectAllIProductsFromInvoice, conn))
                {
                                comm.Parameters.AddWithValue("@InvocieIDD", parametr1);
                    using (var reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return SqlHelper.ReadAll(reader, InvoiceElements.ReadInvoiceElements);
                        }
                        else
                            return new List<InvoiceElements>();
                    }

                }
            }
        }



        public static string GetSumInvoiceElementGross(string connectionString, string parametr1)
        {
            string sql = @"Select sum(InvoiceValueGross) from dbo.InvoiceElements 
                                       where InvoiceID = @InvocieIDD";

            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@InvocieIDD", parametr1);
                var Sumelements = cmd.ExecuteScalar();
                string SumGross = (Sumelements).ToString();
                conn.Close();
                return SumGross;
            }

        }


        public static string GetSumInvoiceElementNet(string connectionString, string parametr1)
        {
            string sql = @"Select sum(InvoiceValueNet * InvElemQTY ) from dbo.InvoiceElements 
                                       where InvoiceID = @InvocieIDD";

            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@InvocieIDD", parametr1);
                var Sumelements = cmd.ExecuteScalar();
                string SumNet = (Sumelements).ToString();
                conn.Close();
                return SumNet;
            }

        }

        public static string NumberLastInvoice(string connectionString)
        {
            string sql = @"Select top 1 InvoiceNumber from dbo.Invoices ORDER BY InvoiceID DESC ";

            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                var cmd = new SqlCommand(sql, conn);
                var lastnumberInvoice = (string)cmd.ExecuteScalar();
                conn.Close();
                return lastnumberInvoice;
            }

        }



        public static int NumberIdUser(string connectionString, string parametr1)
        {
            string sql = @"select top 1 UserID from dbo.Users where UserName = @UserName";

            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserName", parametr1);
                int UserID = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return UserID;
            }

        }


        public static string ContractorID(string connectionString, string parametr1)
        {
            string sql = @"select top 1 IDBuyer from dbo.Constructors where FullName = @ContractorFullName";

            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ContractorFullName", parametr1);
                string ContractorID = (cmd.ExecuteScalar()).ToString();
                conn.Close();
                return ContractorID;
            }

        }
        public static string ContractorMail(string connectionString, string parametr1)
        {
            string sql = @"select top 1 email from dbo.Constructors where IDBuyer = @ContractorID";

            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ContractorID", parametr1);
                string ContractorMail = (cmd.ExecuteScalar()).ToString();
                conn.Close();
                return ContractorMail;
            }

        }



        public static int ProduktId(string connectionString, string parametr1)
        {
            string sql = @"Select top 1 ProductID from dbo.Stock where ProductName = @ProductName";
            
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductName", parametr1);
                var lastnumberInvoice = cmd.ExecuteScalar();
                int productId = Convert.ToInt32(lastnumberInvoice);
                conn.Close();
                return productId;
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


        public static int AddNewInvoice(string connectionString, string parametr1, string parametr2, decimal parametr3, decimal parametr4, string parametr5, string parametr6, string parametr7)
        {
            var queryString = @"Insert into dbo.Invoices (InvoiceElementID, InvoiceDate, InvoiceValueGross, InvoiceValueNet, InvoiceContractorID, InvoiceUser, InvoiceNumber) 
                                                VALUES(@InvoiceElementID, @InvoiceDate, @InvoiceValueGross, @InvoiceValueNet, @InvoiceContractorID, @InvoiceUser, @InvoiceNumber)";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(queryString, conn))
                {
                    comm.Parameters.AddWithValue("@InvoiceElementID", parametr1);
                    comm.Parameters.AddWithValue("@InvoiceDate", parametr2);
                    comm.Parameters.AddWithValue("@InvoiceValueGross", parametr3);
                    comm.Parameters.AddWithValue("@InvoiceValueNet", parametr4);
                    comm.Parameters.AddWithValue("@InvoiceContractorID", parametr5);
                    comm.Parameters.AddWithValue("@InvoiceUser", parametr6);
                    comm.Parameters.AddWithValue("@InvoiceNumber", parametr7);

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

        public static void FillComboContractors(ComboBox comboBox)
        {
            var connectionString = SqlHelper.getConnection();
            string Query = "select * from dbo.Constructors";
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
                    string sName2 = myReader.GetString(1);
                    sName = sName.TrimEnd();
                    comboBox.Items.Add(sName + " "+  sName2 );

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error Message");
            }

        }


        public static void FillComboStock(ComboBox comboBox)
        {
            var connectionString = SqlHelper.getConnection();
            string Query = "select * from dbo.Stock";
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
