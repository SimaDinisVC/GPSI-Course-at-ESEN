using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GYMachines.Content;

namespace GYMachines
{
    public partial class login : System.Web.UI.Page
    {
        DataBase db = new DataBase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["User"] != null)
                {
                    //inputEmail.Value = Request.Cookies["User"].Value.ToString();
                    email.Value = Request.Cookies["email"].Value;
                    //if (Request.Cookies["Password"] != null)
                    //inputPassword.Value = Request.Cookies["Password"].Value.ToString();
                    Password.Value = Request.Cookies["Password"].Value;
                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            return;
        }

        protected void login_ServerClick(object sender, EventArgs e)
        {
            if (Chk_remember.Checked == true)
            {
                Response.Cookies["email"].Value = email.Value;
                Response.Cookies["Password"].Value = Password.Value;
            }

            string sqlstr = "select count(username) from Utilizadores where email = '" + email.Value + "' and pass = HASHBYTES('MD5',@pass)";
            List<SqlParameter> lista = new List<SqlParameter>();
            lista.Add(new SqlParameter("@pass", Password.Value));

            DataTable login = db.devolve_consulta(sqlstr, lista);

            if (login.Rows[0][0].ToString() == "1")
            {
                if (db.devolve_consulta("Select perfil from Utilizadores where email='" + email.Value + "'").Rows[0][0].ToString() == "cliente")
                    Session["user"] = email.Value;
                else
                    Session["admin"] = email.Value;
                //  Response.Redirect("computadores.aspx");
                Response.Redirect("Default.aspx");
            }
            else
            {
                //lbl_erro.Text = "Erro no Login";
                lbl_erro.Visible = true;
            }
        }
    }
}