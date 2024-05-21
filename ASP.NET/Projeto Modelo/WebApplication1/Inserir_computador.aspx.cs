using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            
        }

        protected void FormView1_ItemInserting(object sender, FormViewInsertEventArgs e)
        {
            BaseDados bd = new BaseDados();

            // Testar se já existe algum computador com o mesmo ean
            TextBox ean = (TextBox)FormView1.FindControl("EANTextBox");
            if (bd.devolve_consulta("select count(ean) from t_computadores where ean='" + ean.Text + "'").Rows[0][0].ToString() == "1")
            {
                Response.Write("Erro");
                e.Cancel = true;
            }

            // Fazer o upload da foto do computador para a pasta do servidor
            FileUpload f = (FileUpload)FormView1.FindControl("FileUpload1");
            if (f.HasFile)
            {
                f.SaveAs(Server.MapPath("~/imagens/") + ean.Text + ".jpg");
            }

        }
    }
}