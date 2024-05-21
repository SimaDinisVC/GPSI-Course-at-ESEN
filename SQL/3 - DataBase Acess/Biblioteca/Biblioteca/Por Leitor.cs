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
    public partial class Por_Leitor : Form
    {
        Base_Dados db = new Base_Dados();
        public Por_Leitor()
        {
            InitializeComponent();
        }

        private void Por_Leitor_Load(object sender, EventArgs e)
        {
            DataTable leitores = db.devolver_consulta("SELECT DISTINCT Nome FROM Leitores");
            for (int i = 0; i < leitores.Rows.Count; i++)
            {
                comboBox1.Items.Add(leitores.Rows[i][0].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv1.DataSource = db.devolver_consulta("SELECT * FROM Movimentos WHERE nprocesso = (SELECT N_processo FROM Leitores WHERE Nome ='" + comboBox1.Text + "')");
        }
    }
}
