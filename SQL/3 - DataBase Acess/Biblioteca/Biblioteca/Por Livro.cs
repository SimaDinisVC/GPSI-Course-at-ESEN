using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteca
{
    public partial class Por_Livro : Form
    {
        Base_Dados db = new Base_Dados();
        public Por_Livro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv1.DataSource = db.devolver_consulta("SELECT * FROM Movimentos WHERE id_livro IN (SELECT id FROM Livros WHERE Titulo ='" + textBox1.Text + "')");
        }
    }
}
