using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Cohen451Final.QuestionA
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        Products currentCart;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["product_id"];

                if (id != null)
                {
                    gvProductDetails.DataSource = DataAccess.selectQuery("SELECT * FROM Product WHERE ProductID= " + id);
                    gvProductDetails.DataBind();
                }
            }
        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            if (Session["currentCart"] == null)
            {
                currentCart = new Products();
                Session["currentCart"] = currentCart;
            }
            string id = Request.QueryString["product_id"];
            currentCart = (Products)Session["currentCart"];
            DataTable dt = DataAccess.selectQuery("SELECT * FROM Product WHERE ProductID= " + Request.QueryString["product_id"]);
            DataRow row = dt.Rows[0];

            currentCart.Insert(new Prod(Int32.Parse(id),
                row["Name"].ToString(),
                row["Description"].ToString(),
                Double.Parse(row["Price"].ToString()),
                row["Type"].ToString()));
        }
    }
}