using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        BaseDados bd = new BaseDados();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user="";
            if(username1.Value!="") user = username1.Value;
            if(username2.Value!="") user = username2.Value;
            string e_mail = email.Value;
            //string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(Password.Value, "MD5");

            int n = Convert.ToInt32(bd.devolve_consulta("Select count(*) from utilizadores where username='" + user + "'").Rows[0][0]);
            if (n > 0)
            {
                Label1.Text = "Utilizador já registado";
                //Response.Write("<script>alert('Já exite um utilizador registado com este username');</script>");
            }
            else
            {
                var encodedResponse = Request.Form["g-Recaptcha-Response"];
                var isCaptchaValid = ReCaptcha.Validate(encodedResponse);

                if (isCaptchaValid)
                {
                    string strSQL = "INSERT INTO utilizadores(username,pass,perfil,email)";
                    strSQL += "VALUES (@username, HASHBYTES('MD5',@pass),@perfil,@email)";

                    List<SqlParameter> parametros = new List<SqlParameter>();
                    parametros.Add(new SqlParameter("@username", user));
                    parametros.Add(new SqlParameter("@pass", Password.Value));
                    parametros.Add(new SqlParameter("@perfil", "cliente"));
                    parametros.Add(new SqlParameter("@email", e_mail.ToString()));

                    bd.executa_SQL(strSQL, parametros);

                    if (FileUpload1.HasFile)
                    {
                        string filename = FileUpload1.FileName;
                        FileUpload1.SaveAs(Server.MapPath("~/imagens/") + user + ".jpg");
                    }

                    Response.Write("<script>alert('Foi criada a sua conta');</script>");
                    Response.Redirect("login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Tem de provar que não é um Robot');</script>");
                }
            }

        }
       
    }
}