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
    public partial class pesaquisa_palavrachave : Form
    {
        Base_Dados bd = new Base_Dados();
        public pesaquisa_palavrachave()
        {
            InitializeComponent();
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            string[] palavras_chave = txt_palavraschave.Text.Split(',');
            string SQLText = "Select * from livros where ";
            for (int i = 0; i < palavras_chave.Length; i++)
            {
                if (i > 0) SQLText += " and ";
                SQLText += "keywords like '%" + palavras_chave[i] + "%'"; 
            }
            dgv_livros.DataSource = bd.devolver_consulta(SQLText);
        }
    }
}
