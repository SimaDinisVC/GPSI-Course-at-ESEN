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
    public partial class lblAvaliação : Form
    {
        public lblAvaliação(int carreira, string cidade, int salário)
        {
            InitializeComponent();
            if (carreira == 0)
                lblApresentação.Text = String.Format("Visto que não tem anos de Carreira na área, está a receber atualmente {0}€ Mensais e vive em {1} a sua avaliação é dada como:", salário, cidade);
            else
                lblApresentação.Text = String.Format("Visto que tem {0} anos de Carreira na área, está a receber atualmente {1}€ Mensais e vive em {2} a sua avaliação é dada como:", carreira, salário, cidade);
            switch (cidade)
            {
                case "Lisboa":
                    if (carreira<2 && salário == 30.000)
                    {
                        lblResultado.Text = "Justo";
                        lblResultado.BackColor = Color.Green;
                    }
                    else
                    {
                        lblResultado.Text = "Injusto";
                        lblResultado.BackColor = Color.Red;
                    }
                    if (carreira>2 && carreira <6)
                    {

                    }
                    else
                    {

                    }
                    break;
                case "Porto":
                    break;
                case "Viseu":
                    break;
                case "Leiria":
                    break;
                default:
                    break;
            }
        }
    }
}
