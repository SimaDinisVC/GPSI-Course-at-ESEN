using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class frmPrincipal : Form
    {
        frmAjuda formAjuda = new frmAjuda();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string msg;

            if (txtNome.Text.Length > 0)
                msg = txtNome.Text + ", quer mesmo sair?";
            else
                msg = "Quer mesmo sair?";

            DialogResult resposta = MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (resposta == DialogResult.Yes)
                Application.Exit();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frmAcerca form = new frmAcerca();

            form.ShowDialog();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
 
            formAjuda.Show();
            formAjuda.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cota, pagar, desconto;

            if (chkSocio.Checked)
                desconto = 0.5;
            else
                desconto = 0;

            double.TryParse(txtCota.Text, out cota);
            pagar = cota - cota * desconto;

            lblResultado.Text = pagar.ToString();
        }
    }
}
