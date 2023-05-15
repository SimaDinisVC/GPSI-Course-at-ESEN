using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod10_Ex1
{
    public partial class Frm_Empregado : Form
    {
        public Empregado emp
        { 
            get; 
            private set; 
        }

        public Frm_Empregado(Empregado emp)
        {
            InitializeComponent();
            this.emp = emp;
            if (emp != null ) 
            { 
                Text = "Ver/editar empregado";
                chk_editar.Enabled = true;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnl_programador.Visible = Cmb_cargo.SelectedIndex == Empresa.CARGO_PROGRAMADOR;
            pnl_analista.Visible = Cmb_cargo.SelectedIndex == Empresa.CARGO_PROGRAMADOR;
        }

        public void updateChkEditar(bool flag)
        {
            Cmb_cargo.Enabled = flag;
            dtp_data.Enabled = flag;
            
            // Enable para todas as caixas de texto para o formolário

            foreach (Control c in Controls)
            {
                if (c is TextBox)
                    c.Enabled = flag;
            }
            foreach (Control c in pnl_analista.Controls) 
            {
                if (c is TextBox)
                    c.Enabled = flag;
            }
            foreach (Control c in pnl_programador.Controls)
            {
                if (c is TextBox)
                    c.Enabled = flag;
            }
        }
    }
}
