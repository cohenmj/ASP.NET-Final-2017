using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace ProductService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {
        public List<ProductSer> ReturnProducts(string id)
        {
            List<ProductSer> products = new List<ProductSer>();
            string connectionString = WebConfigurationManager.ConnectionStrings["FinalExam"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ProductID, Name, Type, Description FROM Product WHERE ProductID = " + id;
            cmd.Connection = con;

            using (con)
            {
                con.Open();
                //can't figure out how to get a message to display when null
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProductSer ps = new ProductSer();
                    ps.id = (int)reader["ProductID"];
                    ps.name = (string)reader["Name"];
                    ps.type = (string)reader["Type"];
                    //Price wasn't working, so I cut it out
                    ps.description = (string)reader["Description"];
                    products.Add(ps);
                }
            }
            return products;
        }
    }
}
