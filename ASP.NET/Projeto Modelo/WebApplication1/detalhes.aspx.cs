using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        BaseDados bd = new BaseDados();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Carregar imagem do computador que foi escolhido pelo utilizador
            Image1.ImageUrl = "~/imagens/computadores/" + Request.QueryString["ean"] + ".jpg";

            // Marcar como visitado para mostrar as consultas recentes
            Response.Cookies["visitado"].Value = Request.QueryString["ean"];

            // Verificar se é um dos favoritos
            if (bd.devolve_consulta("select count(id) from favoritos where ean='" + Request.QueryString["ean"] + "' and username='" + Session["user"]+"'").Rows[0][0].ToString() == "1")
                Image2.ImageUrl = "imagens/favorito.png";
            else
                Image2.ImageUrl = "imagens/tornar_favorito.png";
        }

        protected void DetailsView1_DataBinding()
        {

        }

        protected void Bt_AddCarrinho_Click(object sender, EventArgs e)
        {
            int id_compra;

            if (bd.devolve_consulta("select count(id) from compras where id_cliente='" + Session["user"] + "' and finalizada=0").Rows[0][0].ToString() == "0")
            {
                string sql = "insert into compras (total,id_cliente) values(0,'" + Session["user"].ToString() + "')";
                bd.executa_SQL(sql);
                id_compra = int.Parse(bd.devolve_consulta("select max(id) from compras where id_cliente='" + Session["user"] + "'").Rows[0][0].ToString());
            }
            else
                id_compra = int.Parse(bd.devolve_consulta("select id from compras where id_cliente='" + Session["user"] + "' and finalizada=0").Rows[0][0].ToString());

            string produto_existente = bd.devolve_consulta("select count(id) from produtos_compra where id_compra=" + id_compra + " and ean='" + DetailsView1.Rows[0].Cells[1].Text + "'").Rows[0][0].ToString();

            if (produto_existente == "0")
            {
                string strSQL = "INSERT INTO produtos_compra(id_compra,ean,quantidade,preco)";
                strSQL += "VALUES (@id_compra, @ean,@quantidade,@preco)";

                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@id_compra", id_compra));
                parametros.Add(new SqlParameter("@ean", DetailsView1.Rows[0].Cells[1].Text));
                parametros.Add(new SqlParameter("@quantidade", 1));
                parametros.Add(new SqlParameter("@preco", double.Parse(DetailsView1.Rows[10].Cells[1].Text)));

                bd.executa_SQL(strSQL, parametros);
            }
            else
                bd.executa_SQL("update produtos_compra set quantidade=quantidade+1, preco=preco+" + double.Parse(DetailsView1.Rows[10].Cells[1].Text) + " where id_compra=" + id_compra + " and ean='" + DetailsView1.Rows[0].Cells[1].Text + "'");

            bd.executa_SQL("update compras set total=total+" + DetailsView1.Rows[10].Cells[1].Text + " where id=" + id_compra);

            Server.Transfer("detalhes.aspx?ean=" + Request["ean"]);
        
        }

        protected void Image2_Click(object sender, ImageClickEventArgs e)
        {
            if (bd.devolve_consulta("select count(id) from favoritos where ean='" + Request.QueryString["ean"] + "' and username='" + Session["user"] + "'").Rows[0][0].ToString() == "1")
                bd.executa_SQL("delete from favoritos where ean='" + Request.QueryString["ean"] + "' and username='" + Session["user"] + "'");
            else 
                bd.executa_SQL("insert into favoritos(ean,username) values('" + Request.QueryString["ean"] + "','" + Session["user"] + "')");
            
            Response.Redirect("detalhes.aspx?ean=" + Request.QueryString["ean"]);
        }
    }
}
