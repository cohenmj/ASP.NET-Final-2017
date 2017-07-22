using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Cohen451Final
{
    public partial class Cohen : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblA.Text = Response.Cookies["ProdCount"].Value;
            lblD.Text = DateTime.Now.ToString();
        }

        
    }
}