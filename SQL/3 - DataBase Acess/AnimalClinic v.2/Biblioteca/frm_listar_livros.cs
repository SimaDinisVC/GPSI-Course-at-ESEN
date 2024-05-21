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

    public partial class frm_listar_livros : Form
    {
        Base_Dados bd = new Base_Dados();
        public frm_listar_livros()
        {
            InitializeComponent();
        }

        private void frm_listar_livros_Load(object sender, EventArgs e)
        {
           
            // Carregar os dados de todos os livros
            DGV_Livros.DataSource = bd.devolver_consulta("SELECT * FROM Livros WHERE disponivel=1");
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que deseja apagar o livro " + DGV_Livros.SelectedRows[0].Cells[2].Value.ToString() + "( ID " + DGV_Livros.SelectedRows[0].Cells[0].Value.ToString() + ") ?", "Apagar Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                bd.executar_sql("Delete from Livros where id=" + DGV_Livros.SelectedRows[0].Cells[0].Value);
                DGV_Livros.DataSource = bd.devolver_consulta("SELECT * FROM Livros WHERE disponivel=1");
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Livro frm = new Frm_Livro(DGV_Livros.SelectedRows[0].Cells[0].Value.ToString());  
            frm.Show();
        }

        private void DGV_Livros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
