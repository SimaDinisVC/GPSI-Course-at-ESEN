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
    public partial class frm_requesitar : Form
    {
        Base_Dados bd = new Base_Dados();
        public frm_requesitar()
        {
            InitializeComponent();
        }

        private void txt_idLivro_TextChanged(object sender, EventArgs e)
        {
            if(txt_idLivro.Text!="")
            {
                DataTable dados_livro = bd.devolver_consulta("select isbn,titulo,autor from livros where id=" + txt_idLivro.Text + " and disponivel=1");
                if(dados_livro.Rows.Count==1)
                {
                    lbl_ISBN.Text = "ISBN:" + dados_livro.Rows[0][0].ToString();
                    lbl_Titulo.Text = "Titulo:" + dados_livro.Rows[0][1].ToString();
                    lbl_autor.Text = "Autor:" + dados_livro.Rows[0][2].ToString();
                }
                else
                {
                    lbl_ISBN.Text = "ISBN:";
                    lbl_Titulo.Text = "Titulo:";
                    lbl_autor.Text = "Data requisição:";
                }
            }
            else
            {
                lbl_ISBN.Text = "ISBN:";
                lbl_Titulo.Text = "Titulo:";
                lbl_autor.Text = "Data requisição:";
            }

            if (lbl_ISBN.Text != "ISBN:" && lbl_nome.Text != "Nome:")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void txt_nprocesso_TextChanged(object sender, EventArgs e)
        {
            if (txt_nprocesso.Text != null)
            {
                DataTable dados_livro = bd.devolver_consulta("select nome,cc,email from leitores where n_processo='" + txt_nprocesso.Text + "' and ativo=1");
                if (dados_livro.Rows.Count == 1)
                {
                    lbl_nome.Text = "Nome:" + dados_livro.Rows[0][0].ToString();
                    lbl_CC.Text = "CC:" + dados_livro.Rows[0][1].ToString();
                    lbl_turma.Text = "Email:" + dados_livro.Rows[0][2].ToString();
                }
            }

            if (lbl_ISBN.Text != "ISBN:" && lbl_nome.Text != "Nome:")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Guardar os dados da requesição

            bd.executar_sql("Insert into movimentos (nprocesso, id_livro) values ('" + txt_nprocesso.Text + "'," + txt_idLivro.Text + ")");
            bd.executar_sql("Update Livros SET Disponivel = 0 WHERE id = " + txt_idLivro.Text);
            MessageBox.Show("Requisiçao foi realizada com sucesso", "Requisitar Livro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
