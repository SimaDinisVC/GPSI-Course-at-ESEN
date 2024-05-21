using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        public DataTable dados;
        protected void Page_Load(object sender, EventArgs e)
        {
            // if (Session["perfil"].ToString() == "admin")
            //{
            //    if (!IsPostBack)
            //    {
            //        RadioButtonList1.Visible = true;
            //        RadioButtonList1.SelectedValue = "Em processamento";
            //        SqlDataSource1.FilterExpression = "estado='Em processamento'";
            //    }
            //}

            if (Session["user"] == null && Session["admin"] == null)
                Response.Redirect("login.aspx");

            if (Session["admin"] != null)
            {
                if (!IsPostBack)
                {
                    RadioButtonList1.Visible = true;
                    RadioButtonList1.SelectedValue = "Em processamento";
                    SqlDataSource1.FilterExpression = "estado='Em processamento'";
                    Button1.Visible = true;
                }
                else
                {
                    if (RadioButtonList1.SelectedValue == "Em expedição")
                    {
                        //SqlDataSource1.FilterExpression = "estado='Espera confirmação'";
                        Button1.Visible = false;
                    }else Button1.Visible = true;
                }
            }
            else
            {
                SqlDataSource1.FilterExpression = "id_cliente='" + Session["user"] + "' and finalizada=true";
                //SqlDataSource1.FilterExpression = "id_cliente='" + Session["user"] + "'";
                //SqlDataSource1.FilterExpression = "finalizada=true";
                Button1.Visible = false;
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataSource1.FilterExpression = "estado='" + RadioButtonList1.SelectedValue + "'";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BaseDados bd = new BaseDados();
            bd.executa_SQL("update compras set estado='Em expedição' where id=" + GridView1.SelectedValue);
            Response.Redirect("compras.aspx");
        }
    }
}