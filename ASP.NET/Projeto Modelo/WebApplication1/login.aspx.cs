using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;


namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        BaseDados bd = new BaseDados();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                if (Request.Cookies["User"] != null)
                {
                    //inputEmail.Value = Request.Cookies["User"].Value.ToString();
                    txt_user.Value = Request.Cookies["User"].Value;
                    //if (Request.Cookies["Password"] != null)
                    //inputPassword.Value = Request.Cookies["Password"].Value.ToString();
                    inputPassword.Value = Request.Cookies["Password"].Value;
                }
            }
            //lbl_erro.Text = "";
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {

        }

        protected void login_ServerClick(object sender, EventArgs e)
        {

            if (Chk_remember.Checked == true)
            {
                Response.Cookies["User"].Value = txt_user.Value;
                Response.Cookies["Password"].Value = inputPassword.Value;
            }

            string sqlstr = "select count(username) from utilizadores where username = '" + txt_user.Value + "' and pass = HASHBYTES('MD5',@pass)";
            List<SqlParameter> lista = new List<SqlParameter>();
            lista.Add(new SqlParameter("@pass", inputPassword.Value));

            DataTable login = bd.devolve_consulta(sqlstr, lista);

           // if (login.Rows[0][0].ToString() == "1")


                //if (bd.devolve_consulta("Select username from utilizadores where username='" + txt_user.Value + "' and pass='" + FormsAuthentication.HashPasswordForStoringInConfigFile(inputPassword.Value, "MD5") + "'").Rows.Count != 0)
                //{
                //    Session["user"] = txt_user.Value;
                //    Session["perfil"] = bd.devolve_consulta("Select perfil from utilizadores where username='" + txt_user.Value + "'").Rows[0][0].ToString();
                //    if (Request.Cookies["url"] != null)
                //        Response.Redirect(Request.Cookies["url"].Value);
                //    else
                //        Response.Redirect("computadores.aspx");
                //}
                //else
                //{
                //    lbl_erro.Text = "Erro no Login";
                //}
                if (login.Rows[0][0].ToString() == "1")
                {
                    if (bd.devolve_consulta("Select Perfil from utilizadores where Username='" + txt_user.Value + "'").Rows[0][0].ToString() == "cliente")
                        Session["user"] = txt_user.Value;
                    else
                        Session["admin"] = txt_user.Value;
                //  Response.Redirect("computadores.aspx");
                    Response.Redirect("index.aspx");
                }
                else
                {
                    //lbl_erro.Text = "Erro no Login";
                    lbl_erro.Visible = true;
                }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //string email = bd.devolve_consulta("select email from utilizadores where username='" + txt_user.Value + "'").Rows[0][0].ToString();
            //if (email != null)
            //{
            // Mail do utilizador que está a pedir para recuperar a password
            string email = bd.devolve_consulta("select count(email) from utilizadores where Username='" + txt_user.Value + "'").Rows[0][0].ToString();
            if (email == "0")
            {
                Response.Write("<script> alert('Username não encontrado') </script>");
                return;
            }
            else
                email = bd.devolve_consulta("select email from utilizadores where Username='" + txt_user.Value + "'").Rows[0][0].ToString();

                // Criar o Token (código chave para enviar por email)
                string token = System.Guid.NewGuid().ToString();
                // Gravar na tabela da BD o Token
                bd.executa_SQL("insert into recuperar_password (username, id) values('" + txt_user.Value + "','" + token + "')");

                // Instanciar o objeto mail definindo a conta utilizada para o envio (1º paramêtro) 
                // e o mail de destino para onde será enviada a mensagem (2º paramêtro)
                MailMessage mail = new MailMessage("gpsiesenpsi@gmail.com", email);

            // Configuração da Mensagem
            // mail.From = new MailAddress("esengpsi12@gmail.com"); // Mail do remetente (serviço configurado para envio)
            mail.From = new MailAddress("gpsiesenpsi@gmail.com");
            mail.Subject = "TecNavarro - Recuperação de Password"; // String usada como Assunto do Mail
                mail.Body= String.Format("Por favor redefina sua senha clicando aqui:<a href='{0}recuperar_password.aspx?id=" + token + "'>Clique aqui para redefinir sua senha</a>", HttpContext.Current.Request.Url.AbsoluteUri.Substring(0,(HttpContext.Current.Request.Url.AbsoluteUri).Length - 10));
               
                // Configuração da conta usada para envio da mensagem
                mail.IsBodyHtml = true; // perite utilizar tags de html na mensagem
                SmtpClient smtp = new SmtpClient(); // Objeto SMTP usado para envio
                smtp.Host = "smtp.gmail.com"; //SMTP Server Address
                //smtp.Credentials = new System.Net.NetworkCredential("esengpsi12", "navarro2020"); // Credênciais da conta de mail utilizada para envio
            smtp.Credentials = new System.Net.NetworkCredential("gpsiesenpsi", "yfoxqjeibjxsbizn");

            // Envio da mensagem para o destinatário
            smtp.EnableSsl = true;
                smtp.Send(mail);

            // Libertar os objetos
            // mail = null;
            // smtp = null;

            // ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "successalert();", true);
            Response.Write("<script> alert('Foi enviado um email para a conta do utilzador')</script>)");

        }
    }
}