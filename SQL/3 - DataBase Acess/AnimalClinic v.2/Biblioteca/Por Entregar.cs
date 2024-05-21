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
    public partial class Por_Entregar : Form
    {
        Base_Dados db = new Base_Dados();
        public Por_Entregar()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dgv1.DataSource = db.devolver_consulta("SELECT * FROM Movimentos WHERE  DATEDIFF(y,Data_entrega,Convert(date, '" + dateTimePicker1.Value.ToShortDateString() + "'))=0"); 
        }
    }
}
