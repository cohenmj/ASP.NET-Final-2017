using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cohen451Final.ServiceReference1;


namespace Cohen451Final.QuestionB
{
    public partial class QuestionB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ServiceReference1.ProductServiceClient psc = new ProductServiceClient();
            string i = txtProdID.Value.ToString();

            gvProduct.DataSource = psc.ReturnProducts(i);
            gvProduct.DataBind();
        }
    }
}