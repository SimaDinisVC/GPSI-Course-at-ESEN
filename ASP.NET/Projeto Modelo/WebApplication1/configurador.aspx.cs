using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        BaseDados bd = new BaseDados();
        protected void Page_PreRender(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
                lbl_preco.Text = "3000";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            lbl_preco.Text = TextBox1.Text;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}