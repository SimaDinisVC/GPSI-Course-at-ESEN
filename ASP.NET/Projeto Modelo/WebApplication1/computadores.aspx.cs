using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string filtro = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            // Testa se houve um pedido de consulta
            if (Request.QueryString["pesquisa"] != null)
                Produtos.FilterExpression = "marca like '" + Request.QueryString["pesquisa"] + "%' or modelo like '%" + Request.QueryString["pesquisa"] + "%'";

            // Testa se houve a escolha de um tipo de computador
            else if (Request.QueryString["tipo"] != null)
                Produtos.FilterExpression = "tipologia='" + Request.QueryString["tipo"] + "'";

            // Testa se o cliente já viu os detalhes de algum computador
            if (Request.Cookies["visitado"] != null)
                Visitado.FilterExpression = "ean<>'" + Request.Cookies["visitado"] + "'";

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostrar os detalhes do computador
            Response.Redirect("detalhes.aspx?ean=" + GridView1.SelectedValue);
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostrar os detalhes do computador
            Response.Redirect("detalhes.aspx?ean=" + GridView2.SelectedValue);
        }

        protected void CHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Atualizar o filtro com a escolha da marca

            // Filtrar os computadores segundo os parametros 
            string filtro = "";

            // Filtrar por Marca
            foreach (ListItem item in CHK_ListaMarcas.Items)
            {
                if (item.Selected)
                {
                    // Testa se é o primeira das marcas do filtro
                    if (filtro == "")
                        filtro += "marca='" + item.Value + "'";
                    else
                        filtro += " or marca='" + item.Value + "'";
                }
            }

            // Filtrar por tipo de processador
            int itens_selecionado = 0;
            foreach (ListItem item in Chk_Processador.Items)
            {
                if (item.Selected)
                {
                    itens_selecionado++;
                    // Testa se é o primeiro dos filtros 
                    if (filtro == "")
                        filtro += "processador='" + item.Value + "'";
                    else
                        // Testa se é o primeiro dos processadores do filtro
                        if (itens_selecionado == 1)
                        filtro += " and processador='" + item.Value + "'";
                    else
                        filtro += " or processador='" + item.Value + "'";
                }
            }

            // Filtrar por tipo de memoria
            itens_selecionado = 0;
            foreach (ListItem item in CheckBoxList2.Items)
            {
                if (item.Selected)
                {
                    itens_selecionado++;
                    // Testa se é o primeiro dos filtros 
                    if (filtro == "")
                        filtro += "memoria_ram='" + item.Value + "'";
                    else
                        // Testa se é o primeiro dos processadores do filtro
                        if (itens_selecionado == 1)
                        filtro += " and memoria_ram='" + item.Value + "'";
                    else
                        filtro += " or memoria_ram='" + item.Value + "'";
                }
            }

            // Filtrar por tipo de processador
            itens_selecionado = 0;
            foreach (ListItem item in CheckBoxList3.Items)
            {
                if (item.Selected)
                {
                    itens_selecionado++;
                    // Testa se é o primeiro dos filtros 
                    if (filtro == "")
                        filtro += "ecran='" + item.Value + "'";
                    else
                        // Testa se é o primeiro dos processadores do filtro
                        if (itens_selecionado == 1)
                        filtro += " and ecran='" + item.Value + "'";
                    else
                        filtro += " or ecran='" + item.Value + "'";
                }
            }

            if (filtro == "")
                filtro = "len(ean)>0";

            // Testa se foram aplicados filtros
            if (filtro != "")
            {
                // Testa se foi escolhido um tipo de computador
                if (Request.QueryString["tipo"] == null)
                    Produtos.FilterExpression = filtro;
                else
                    Produtos.FilterExpression = filtro + "and tipologia='" + Request.QueryString["tipo"] + "'";
            }
        }

    }
}
