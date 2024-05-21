using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication12
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void aceitar_Click(object sender, EventArgs e)
        {
            Response.Cookies["aceitar_cookies"].Value = "sim";
            //Response.Redirect("~/computadores.aspx");
            Response.Redirect("Default.aspx");
        }
    }
}