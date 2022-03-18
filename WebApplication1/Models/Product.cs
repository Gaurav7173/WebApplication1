using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string ProductType { get; set; }

        public DataSet GetProductData()
        {
            var ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\WebApplication1\WebApplication1\App_Data\ProductDatabase.mdf;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand command = new SqlCommand("select * from Product",conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
    }
}