using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Master : System.Web.UI.MasterPage
    {
        BaseDados bd = new BaseDados();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Escrever opções de consulta na caixa de pesquisa
            if (!IsPostBack) txt_pesquisa.Value = Request.QueryString["pesquisa"];

            // Verificar se há produtos no carrinho de compras
            if (Session["user"] != null)
            {
                // if (Session["perfil"].ToString() == "cliente")
                if (int.Parse(bd.devolve_consulta("select count(id) from compras where id_cliente='" + Session["user"] + "' and finalizada=0").Rows[0][0].ToString()) > 0)
                {
                    int id = int.Parse(bd.devolve_consulta("select id from compras where id_cliente='" + Session["user"] + "' and finalizada = 0").Rows[0][0].ToString());
                    if (int.Parse(bd.devolve_consulta("select count(ean) from Produtos_Compra where id_compra=" + id).Rows[0][0].ToString()) > 0)
                    {
                        int nprodutos = int.Parse(bd.devolve_consulta("select sum(quantidade) from Produtos_Compra where id_compra= (select id from compras where finalizada=0 and id_cliente='" + Session["user"] + "')").Rows[0][0].ToString());
                        HiddenField1.Value = nprodutos.ToString();
                    }
                }
                else
                {
                    HiddenField1.Value = "0";
                }
            }
            else
            {
                int novas_encomendas = int.Parse(bd.devolve_consulta("select count(id) from compras where estado='Em processamento'").Rows[0][0].ToString());
                if (novas_encomendas>0)
                HiddenField2.Value = novas_encomendas.ToString();
                else
                {
                    HiddenField2.Value = "0";
                }
            }
            
        }

        protected void pesquisa_click(object sender, EventArgs e)
        {
            Response.Redirect("computadores.aspx?pesquisa=" + txt_pesquisa.Value);
        }

        protected void aceitar_Click(object sender, EventArgs e)
        {
            Response.Cookies["aceitar_cookies"].Value = "sim";
            //Response.Redirect("~/computadores.aspx");
            Response.Redirect("index.aspx");
        }
    }
}