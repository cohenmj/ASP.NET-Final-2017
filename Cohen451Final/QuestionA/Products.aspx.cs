using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cohen451Final.QuestionA
{
    public partial class Products1 : System.Web.UI.Page
    {
        Products currentCart;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["ProdCount"].Expires = DateTime.Now.AddYears(1);
            if (Session["currentCart"] != null)
            {
                currentCart = (Products)Session["currentCart"];
                Response.Cookies["ProdCount"].Value = currentCart.Items.Count.ToString();
                lblProductCount.Text = Response.Cookies["ProdCount"].Value;
            }
            else
            {
                lblProductCount.Text = "No Current Session";
            }
            Response.Cookies["ProdCount"].Value = DataAccess.count("SELECT Count(ProductID) FROM Product");
        }
    }
}