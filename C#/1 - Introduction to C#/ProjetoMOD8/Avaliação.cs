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
    public partial class FrmAvaliação : Form
    {
        public FrmAvaliação(int carreira, string cidade, int salário)
        {
            InitializeComponent();
            if (carreira == 0)
                if (cidade == "")
                {
                    lblApresentação.Text = String.Format("Visto que não tem anos de Carreira na área, está a receber atualmente {0}€ Mensais e vive em {1} a sua avaliação é dada como:", salário, "Desconhecido");
                    lblResultado.Text = "Sem dados";
                    lblResultado.ForeColor = Color.Yellow;
                }
                else
                    lblApresentação.Text = String.Format("Visto que não tem anos de Carreira na área, está a receber atualmente {0}€ Mensais e vive em {1} a sua avaliação é dada como:", salário, cidade);
            else
                if (cidade == "")
                {
                lblApresentação.Text = String.Format("Visto que tem {0} anos de Carreira na área, está a receber atualmente {1}€ Mensais e vive em {2} a sua avaliação é dada como:", carreira, salário, "Desconhecido");
                lblResultado.Text = "Sem dados";
                lblResultado.ForeColor = Color.Yellow;
                }
            else
                lblApresentação.Text = String.Format("Visto que tem {0} anos de Carreira na área, está a receber atualmente {1}€ Mensais e vive em {2} a sua avaliação é dada como:", carreira, salário, cidade);
            switch (cidade)
            {
                case "Lisboa":
                    if (carreira < 2 && salário == 2500)
                    {
                        lblResultado.Text = "Justa";
                        lblResultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (carreira < 2 && salário < 2500)
                        {
                            lblResultado.Text = "Injusta";
                            lblResultado.ForeColor = Color.Red;
                            lblConcelho.Text = string.Format("O seu salário mensal está abaixo da média, é necessário um aumento de {0}€.", 2500 - salário);
                        }
                        else if (carreira < 2 && salário > 2500)
                        {
                            lblResultado.Text = "Incerta";
                            lblResultado.ForeColor = Color.Yellow;
                            lblConcelho.Text = "O seu salário mensal está acima da média.";
                        }
                    }
                    if (carreira > 1 && carreira < 6 && salário == 3300)
                    {
                        lblResultado.Text = "Justa";
                        lblResultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (carreira > 1 && carreira < 6 && salário < 3300)
                        {
                            lblResultado.Text = "Injusta";
                            lblResultado.ForeColor = Color.Red;
                            lblConcelho.Text = string.Format("O seu salário mensal está abaixo da média, é necessário um aumento de {0}€.", 3300 - salário);
                        }
                        else if (carreira > 1 && carreira < 6 && salário > 3300)
                        {
                            lblResultado.Text = "Incerta";
                            lblResultado.ForeColor = Color.Yellow;
                            lblConcelho.Text = "O seu salário mensal está acima da média.";
                        }
                    }
                    if (carreira > 5 && salário == 4200)
                    {
                        lblResultado.Text = "Justa";
                        lblResultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (carreira > 5 && salário < 4200)
                        {
                            lblResultado.Text = "Injusta";
                            lblResultado.ForeColor = Color.Red;
                            lblConcelho.Text = string.Format("O seu salário mensal está abaixo da média, é necessário um aumento de {0}€.", 4200 - salário);
                        }
                        else if (carreira > 5 && salário > 4200)
                        {
                            lblResultado.Text = "Incerta";
                            lblResultado.ForeColor = Color.Yellow;
                            lblConcelho.Text = "O seu salário mensal está acima da média.";
                        }

                    }
                    break;
                case "Porto":
                    if (carreira < 2 && salário == 2200)
                    {
                        lblResultado.Text = "Justa";
                        lblResultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (carreira < 2 && salário < 2200)
                        {
                            lblResultado.Text = "Injusta";
                            lblResultado.ForeColor = Color.Red;
                            lblConcelho.Text = string.Format("O seu salário mensal está abaixo da média, é necessário um aumento de {0}€.", 2200 - salário);
                        }
                        else if (carreira < 2 && salário > 2200)
                        {
                            lblResultado.Text = "Incerta";
                            lblResultado.ForeColor = Color.Yellow;
                            lblConcelho.Text = "O seu salário mensal está acima da média.";
                        }
                    }
                    if (carreira > 1 && carreira < 6 && salário == 3100)
                    {
                        lblResultado.Text = "Justa";
                        lblResultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (carreira > 1 && carreira < 6 && salário < 3100)
                        {
                            lblResultado.Text = "Injusta";
                            lblResultado.ForeColor = Color.Red;
                            lblConcelho.Text = string.Format("O seu salário mensal está abaixo da média, é necessário um aumento de {0}€.", 3100 - salário);
                        }
                        else if (carreira > 1 && carreira < 6 && salário > 3100)
                        {
                            lblResultado.Text = "Incerta";
                            lblResultado.ForeColor = Color.Yellow;
                            lblConcelho.Text = "O seu salário mensal está acima da média.";
                        }
                    }
                    if (carreira > 5 && salário == 4200)
                    {
                        lblResultado.Text = "Justa";
                        lblResultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (carreira > 5 && salário < 4200)
                        {
                            lblResultado.Text = "Injusta";
                            lblResultado.ForeColor = Color.Red;
                            lblConcelho.Text = string.Format("O seu salário mensal está abaixo da média, é necessário um aumento de {0}€.", 4200 - salário);
                        }
                        else if (carreira > 5 && salário > 4200)
                        {
                            lblResultado.Text = "Incerta";
                            lblResultado.ForeColor = Color.Yellow;
                            lblConcelho.Text = "O seu salário mensal está acima da média.";
                        }
                    }
                    break;
                case "Viseu":
                    if (carreira < 2 && salário == 1800)
                    {
                        lblResultado.Text = "Justa";
                        lblResultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (carreira < 2 && salário < 1800)
                        {
                            lblResultado.Text = "Injusta";
                            lblResultado.ForeColor = Color.Red;
                            lblConcelho.Text = string.Format("O seu salário mensal está abaixo da média, é necessário um aumento de {0}€.", 1800 - salário);
                        }
                        else if (carreira < 2 && salário > 1800)
                        {
                            lblResultado.Text = "Incerta";
                            lblResultado.ForeColor = Color.Yellow;
                            lblConcelho.Text = "O seu salário mensal está acima da média.";
                        }
                    }
                    if (carreira > 1 && carreira < 6 && salário == 2400)
                    {
                        lblResultado.Text = "Justa";
                        lblResultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (carreira > 1 && carreira < 6 && salário < 2400)
                        {
                            lblResultado.Text = "Injusta";
                            lblResultado.ForeColor = Color.Red;
                            lblConcelho.Text = string.Format("O seu salário mensal está abaixo da média, é necessário um aumento de {0}€.", 2400 - salário);
                        }
                        else if (carreira > 1 && carreira < 6 && salário > 2400)
                        {
                            lblResultado.Text = "Incerta";
                            lblResultado.ForeColor = Color.Yellow;
                            lblConcelho.Text = "O seu salário mensal está acima da média.";
                        }
                    }
                    if (carreira > 5 && salário == 3500)
                    {
                        lblResultado.Text = "Justa";
                        lblResultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (carreira > 5 && salário < 3500)
                        {
                            lblResultado.Text = "Injusta";
                            lblResultado.ForeColor = Color.Red;
                            lblConcelho.Text = string.Format("O seu salário mensal está abaixo da média, é necessário um aumento de {0}€.", 3500 - salário);
                        }
                        else if (carreira > 5 && salário > 3500)
                        {
                            lblResultado.Text = "Incerta";
                            lblResultado.ForeColor = Color.Yellow;
                            lblConcelho.Text = "O seu salário mensal está acima da média.";
                        }
                    }
                    break;
                case "Leiria":
                    if (carreira < 2 && salário == 2000)
                    {
                        lblResultado.Text = "Justa";
                        lblResultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (carreira < 2 && salário < 2000)
                        {
                            lblResultado.Text = "Injusta";
                            lblResultado.ForeColor = Color.Red;
                            lblConcelho.Text = string.Format("O seu salário mensal está abaixo da média, é necessário um aumento de {0}€.", 2000 - salário);
                        }
                        else if (carreira < 2 && salário > 2000)
                        {
                            lblResultado.Text = "Incerta";
                            lblResultado.ForeColor = Color.Yellow;
                            lblConcelho.Text = "O seu salário mensal está acima da média.";
                        }
                    }
                    if (carreira > 1 && carreira < 6 && salário == 2600)
                    {
                        lblResultado.Text = "Justa";
                        lblResultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (carreira > 1 && carreira < 6 && salário < 2600)
                        {
                            lblResultado.Text = "Injusta";
                            lblResultado.ForeColor = Color.Red;
                            lblConcelho.Text = string.Format("O seu salário mensal está abaixo da média, é necessário um aumento de {0}€.", 2600 - salário);
                        }
                        else if (carreira > 1 && carreira < 6 && salário > 2600)
                        {
                            lblResultado.Text = "Incerta";
                            lblResultado.ForeColor = Color.Yellow;
                            lblConcelho.Text = "O seu salário mensal está acima da média.";
                        }
                    }
                    if (carreira > 5 && salário == 3700)
                    {
                        lblResultado.Text = "Justa";
                        lblResultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (carreira > 5 && salário < 3700)
                        {
                            lblResultado.Text = "Injusta";
                            lblResultado.ForeColor = Color.Red;
                            lblConcelho.Text = string.Format("O seu salário mensal está abaixo da média, é necessário um aumento de {0}€.", 3700 - salário);
                        }
                        else if (carreira > 5 && salário > 3700)
                        {
                            lblResultado.Text = "Incerta";
                            lblResultado.ForeColor = Color.Yellow;
                            lblConcelho.Text = "O seu salário mensal está acima da média.";
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
