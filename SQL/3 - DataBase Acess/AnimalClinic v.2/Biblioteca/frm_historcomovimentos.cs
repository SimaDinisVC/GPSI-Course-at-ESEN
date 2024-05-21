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
    public partial class frm_historcomovimentos : Form
    {
        Base_Dados bd = new Base_Dados();
        public frm_historcomovimentos()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bd.devolver_consulta("select * from movimentos where datediff(d,data_levantamento," + dateTimePicker1.Value.ToShortDateString() + ")<0 and datediff(d,data_levantamento," + dateTimePicker2.Value.ToShortDateString() + ")<0");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bd.devolver_consulta("select * from movimentos where datediff(d,data_levantamento," + dateTimePicker1.Value.ToShortDateString() + ")<0 and datediff(d,data_levantamento," + dateTimePicker2.Value.ToShortDateString() + ")<0");
        }

        private void frm_historcomovimentos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bd.devolver_consulta("select * from movimentos");
        }
    }
}
