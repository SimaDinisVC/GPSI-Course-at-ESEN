using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GYMachines
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Abandon();
            if (Request.Cookies["url"] != null)
                Response.Redirect(Request.Cookies["url"].Value);
            else
                //Response.Redirect("computadores.aspx");
                Response.Redirect("Default. aspx");
        }
    }
}