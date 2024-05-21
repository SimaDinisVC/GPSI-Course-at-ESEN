using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        BaseDados bd = new BaseDados();
        public DataTable dados;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Produtos_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            Response.Redirect("carrinho.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
          
           int rowindex = int.Parse(e.CommandArgument.ToString());

            if (e.CommandName == "aumentar_quantidade")
            {
                bd.executa_SQL("update produtos_compra set quantidade=quantidade+1 where id=" + GridView1.Rows[rowindex].Cells[0].Text);
                bd.executa_SQL("update compras set total=total+" + GridView1.Rows[rowindex].Cells[4].Text + " where id=" + FormView1.SelectedValue);
            }
            else if (e.CommandName == "diminuir_quantidade")
                if (bd.devolve_consulta("select quantidade from produtos_compra where id=" + GridView1.Rows[rowindex].Cells[0].Text).Rows[0][0].ToString() != "1")
                {
                    bd.executa_SQL("update produtos_compra set quantidade=quantidade-1 where id=" + GridView1.Rows[rowindex].Cells[0].Text);
                    bd.executa_SQL("update compras set total=total-" + GridView1.Rows[rowindex].Cells[4].Text + " where id=" + FormView1.SelectedValue);
                }
            
            if (e.CommandName == "Apagar")
            {
                bd.executa_SQL("delete from produtos_compra where id=" + GridView1.Rows[rowindex].Cells[0].Text);
                bd.executa_SQL("update compras set total=total-(" + GridView1.Rows[rowindex].Cells[4].Text + " * " + GridView1.Rows[rowindex].Cells[3].Text + ") where id=" + FormView1.SelectedValue);

                if (bd.devolve_consulta("select count(id) from produtos_compra where id_compra=" + FormView1.SelectedValue).Rows[0][0].ToString() == "0")
                    bd.executa_SQL("delete from compras where id=" + FormView1.SelectedValue);   
            }
            
            Response.Redirect("carrinho.aspx");
            
        }

        protected void fechar_encomenda_Click(object sender, EventArgs e)
        {
            int id_compra = int.Parse(bd.devolve_consulta("select id from compras where finalizada=0 and id_cliente='" + Session["user"] + "'").Rows[0][0].ToString());
            bd.executa_SQL("update compras set estado='Em processamento', finalizada=1 where id=" + id_compra);
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "successalert();", true);
            Response.Redirect("computadores.aspx");
        }

        protected void continuar_comprar_Click(object sender, EventArgs e)
        {
            Response.Redirect("computadores.aspx");
        }
    }
}