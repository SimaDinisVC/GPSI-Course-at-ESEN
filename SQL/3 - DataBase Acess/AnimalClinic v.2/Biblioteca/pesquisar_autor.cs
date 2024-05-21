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
    public partial class pesquisar_autor : Form
    { 
        Base_Dados bd = new Base_Dados();
        public pesquisar_autor()
        {
            InitializeComponent();
        }

        private void pesquisar_autor_Load(object sender, EventArgs e)
        {
           
            // Carregar autores
            DataTable Autores = bd.devolver_consulta("Select distinct autor from livros");
            for (int i = 0; i < Autores.Rows.Count; i++)
            {
                CB_Autor.Items.Add(Autores.Rows[i][0].ToString());
            }
        }

        private void CB_Autor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGV_Livros.DataSource = bd.devolver_consulta("select * from livros where autor='" + CB_Autor.Text + "'");
        }
    }
}
