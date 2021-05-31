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
