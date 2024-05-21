using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm16 : System.Web.UI.Page
    {
        BaseDados bd = new BaseDados();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["perfil"] == null) Response.Redirect("login.aspx");
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.executa_SQL("update compras set estado='Em expedição' where id=" + GridView2.SelectedValue);
            Response.Redirect("lista_compras.aspx");
        }
    }
}