using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        BaseDados bd = new BaseDados();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (bd.devolve_consulta("Select count(id) from recuperar_password where id='" + Request.QueryString["id"] + "'").Rows[0][0].ToString() != "1")
            //    Response.Redirect("computadores.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string utilizador = bd.devolve_consulta("select username from recuperar_password where id='" + Request.QueryString["id"] + "'").Rows[0][0].ToString();

            //string SQLquery = "Update utilizadores set pass= HASHBYTES('MD5',@pass) where username='" + utilizador + "'";
            string SQLquery = "Update utilizadores set pass= HASHBYTES('MD5',@pass) where username='" + utilizador + "'";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@pass", TextBox1.Text));
            parametros.Add(new SqlParameter("user", utilizador));
            bd.executa_SQL(SQLquery, parametros);
            
            // Apagar o Token
            bd.executa_SQL("delete from recuperar_password where id='" + Request.QueryString["id"] + "'");
            Response.Redirect("login.aspx");
            //bd.executa_SQL("Delete from recuperar_password where username='"+ utilizador + "'");

        }
    }
}