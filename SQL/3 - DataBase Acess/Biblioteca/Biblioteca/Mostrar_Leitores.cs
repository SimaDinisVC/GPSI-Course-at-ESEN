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
    public partial class Mostrar_Leitores : Form
    {
        Base_Dados db = new Base_Dados();
        string Tipo;
        public Mostrar_Leitores(string Tipo_pesquisa)
        {
            InitializeComponent();
            Tipo = Tipo_pesquisa;
        }

        private void Mostrar_Leitores_Load(object sender, EventArgs e)
        {
            dgv_leitores.DataSource = db.devolver_consulta("select * from Leitores");
            DataTable leitores = db.devolver_consulta("SELECT DISTINCT " + Tipo + " FROM Leitores");
            for (int i = 0; i < leitores.Rows.Count; i++)
            {
                comboBox1.Items.Add(leitores.Rows[i][0].ToString());
            }
        }

        private void dgv_leitores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_leitores.DataSource = db.devolver_consulta("SELECT * FROM Movimentos WHERE nprocesso = (SELECT N_processo FROM Leitores WHERE " + Tipo + "='"+ comboBox1.Text+"')");
        }
    }
}
