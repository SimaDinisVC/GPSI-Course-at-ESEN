using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMOD8
{
    public partial class FrmCalculadora : Form
    {
        bool opeRealizada = false;
        string ope = "";
        double result = 0;
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void NumEvento(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || opeRealizada)
                txtResult.Text = "";
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
            opeRealizada = false;
        }

        private void OperadoresEvento(object sender, EventArgs e)
        {
            opeRealizada = true;
            Button btn = (Button)sender;
            string novaOpe = btn.Text;

            lblResult.Text = lblResult.Text + " " + txtResult.Text + " " + novaOpe;

            switch (ope)
            {
                case "+":
                    txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "%":
                    txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString();
                    break;
                case "x":
                    txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(txtResult.Text);
            ope = novaOpe;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lblResult.Text = "";
            result = 0;
            ope = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            opeRealizada = true;
            switch (ope)
            {
                case "+":
                    txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "%":
                    txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString();
                    break;
                case "x":
                    txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(txtResult.Text);
            txtResult.Text = result.ToString();
            result = 0;
            ope = "";
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            if(!opeRealizada && !txtResult.Text.Contains(","))
            {
                txtResult.Text += ",";
            }
            else if (opeRealizada)
            {
                txtResult.Text = "0";

            }
            if (!txtResult.Text.Contains(","))
            {
                txtResult.Text += ",";
            }
            opeRealizada = false;
        }
    }
}
