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
    public partial class mais_lidos : Form
    {
        public mais_lidos()
        {
            InitializeComponent();
        }

        private void mais_lidos_Load(object sender, EventArgs e)
        {
            Base_Dados bd = new Base_Dados();
            dataGridView1.DataSource = bd.devolver_consulta("SELECT top 3 livros.ISBN, count(*) from movimentos inner join livros on (livros.id=movimentos.id_livro) group by livros.ISBN order by count(*) desc");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
