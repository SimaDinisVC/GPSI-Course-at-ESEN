using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frm_entregar : Form
    {
        Base_Dados bd = new Base_Dados();

        public frm_entregar()
        {
            InitializeComponent();
        }

        private void txt_nmovimento_TextChanged(object sender, EventArgs e)
        {
            // procurar o movimento
            if(txt_nmovimento.Text!="")
            {
                DataTable dados_movimentos = bd.devolver_consulta("select livros.isbn, livros.titulo, movimentos.data_levantamento from movimentos inner join livros on (movimentos.id_livro=livros.id) where numero=" + txt_nmovimento.Text);
                if(dados_movimentos.Rows.Count==1)
                {
                    lbl_ISBN.Text = "ISBN:" + dados_movimentos.Rows[0][0].ToString();
                    lbl_Titulo.Text = "Titulo:" + dados_movimentos.Rows[0][1].ToString();
                    lbl_data.Text = "Data requisição:" + DateTime.Parse(dados_movimentos.Rows[0][2].ToString()).ToShortDateString();
                }
                else
                {
                    lbl_ISBN.Text = "ISBN:";
                    lbl_Titulo.Text = "Titulo:";
                    lbl_data.Text = "Data requisição:";
                }
            }
            if (lbl_ISBN.Text != "ISBN:")
                btn_Devolver.Enabled = true;
            else
                btn_Devolver.Enabled = false;

        }

        private void txt_idlivro_TextChanged(object sender, EventArgs e)
        {
            // procurar o movimento
            if (txt_idlivro.Text != "")
            {
                DataTable dados_movimentos = bd.devolver_consulta("select livros.isbn, livros.titulo, movimentos.data_levantamento from movimentos inner join livros on (movimentos.id_livro=livros.id) where id_livro=" + txt_idlivro.Text + " and data_entrega is null");
                if (dados_movimentos.Rows.Count == 1)
                {
                    lbl_ISBN.Text = "ISBN:" + dados_movimentos.Rows[0][0].ToString();
                    lbl_Titulo.Text = "Titulo:" + dados_movimentos.Rows[0][1].ToString();
                    lbl_data.Text = "Data requisição:" + DateTime.Parse(dados_movimentos.Rows[0][2].ToString()).ToShortDateString();
                }
                else
                {
                    lbl_ISBN.Text = "ISBN:";
                    lbl_Titulo.Text = "Titulo:";
                    lbl_data.Text = "Data requisição:";
                }
            }

            if (lbl_ISBN.Text != "ISBN:")
                btn_Devolver.Enabled = true;
            else
                btn_Devolver.Enabled = false;
           
        }

        private void btn_Devolver_Click(object sender, EventArgs e)
        {
            if (txt_idlivro.Text != "") { 
                bd.executar_sql("Update movimentos set data_entrega=getdate() where id_livro=" + txt_idlivro.Text + " and data_entrega is null");
                bd.executar_sql("Update Livros SET Disponivel = 1 WHERE id = " + txt_idlivro.Text);
            }
            else { 
                bd.executar_sql("Update movimentos set data_entrega=getdate() where numero=" + txt_nmovimento.Text );
            }
            MessageBox.Show("Devolvido com sucesso", "Devolver Livro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
