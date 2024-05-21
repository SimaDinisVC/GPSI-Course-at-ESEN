using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalClinic
{
    public partial class MainForm : Form
    {
        // Campos
        List<Form> Forms = new List<Form>() { // Lista de Forms Derivados usados
            new forms.frmAnimais(),
            new forms.frmMedicos(),
            new forms.frmConsultas()
        };
        private Form FormAtual; // Form que fica no pnlPrincipal (FormFilho)
        private Button ButtonAtual;
        private Random random; // Para sortear a paleta de cores
        private int tempindex; // Para não repetir cores obtemos o index anterior
        public static bool TemaAtual = false; // False <=> Dark & True <=> Light
        public static bool IconAtual = false;

        // Construtor
        public MainForm()
        {
            Text = Clinica.appname;
            InitializeComponent();
            btnLogo.Image = new Bitmap(Properties.Resources.Logo_white, new Size(150, 150));
            random = new Random();
        }

        // Métodos

        private Color ObterCor() // Obtem uma cor Randomizada da paleta de cores
        {
            int index = random.Next(Cores.paleta.Count);
            while (index == tempindex)
            {
                index = random.Next(Cores.paleta.Count);
            }
            tempindex = index;
            string cor = Cores.paleta[index];

            return ColorTranslator.FromHtml(cor);
        }

        private void AtivarButton(object sender) // Muda as Definições Estética dos Buttons
        {
            if (sender != null)
            {
                if (ButtonAtual != (Button)sender)
                {
                    DesativarButton();
                    ButtonAtual = (Button)sender;
                    Color cor = ObterCor();
                    Cores.CorDefenida = cor;
                    ButtonAtual.BackColor = cor;
                    ButtonAtual.ForeColor = Color.White;
                    ButtonAtual.Font = new Font("Montserrat SemiBold", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    pnlTitleBar.BackColor = cor;
                }
            }
        }

        private void DesativarButton() // Repõe Definições Estéticas dos Buttons
        {
            foreach (Control btnAnterior in pnlMenu.Controls)
            {
                if (btnAnterior.GetType() == typeof(Button))
                {
                    btnAnterior.BackColor = pnlMenu.BackColor;
                    btnAnterior.ForeColor = pnlMenu.ForeColor;
                    btnAnterior.Font = new Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void AbrirFormFilho(Form FormFilho, object sender) // Abre Form Filho no Painel Principal
        {
            if (FormAtual != FormFilho) // Descontinua os requests quando clicamos varias vezes no mesmo botão
            {
                if (FormAtual != null)
                    FormAtual.Visible = false;
                FormAtual = FormFilho;
                AtivarButton(sender); // Ativa o Button do Form associado
                lblTitle.Text = FormFilho.Text.ToString(); // Muda o Titulo conforme o Form Filho
                FormFilho.TopLevel = false; // Indica ao Form que é um Form para ser usado dentro de um Form (Form Filho)
                FormFilho.FormBorderStyle = FormBorderStyle.None; // Retira as bordas do Form
                FormFilho.Dock = DockStyle.Fill; // Vai preencher o espaço todo
                this.pnlPrincipal.Controls.Add(FormFilho); // Adiciona o Form ao Painel
                this.pnlPrincipal.Tag = FormFilho; // Adiciona o Objeto Form na Tag de Facil acesso do painel
                FormFilho.BringToFront(); // Traz o Formulário para a frente
                FormFilho.Show(); // Mostra o Formulário
            }
        }

        public void HospedarAbrirFormFilho(Form FormNeto)
        {
            FormAtual.Visible = false;
            lblTitle.Text = FormNeto.Text.ToString();
            FormNeto.TopLevel = false;
            FormNeto.FormBorderStyle = FormBorderStyle.None;
            FormNeto.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(FormNeto);
            FormNeto.BringToFront();
            FormNeto.Show();
        }

        public void DeshospedarAbrirFormFilho(Form FormNeto)
        {
            FormAtual.Visible = true;
            lblTitle.Text = FormAtual.Text.ToString();
            FormAtual.TopLevel = false;
            FormAtual.FormBorderStyle = FormBorderStyle.None;
            FormAtual.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Remove(FormNeto);
            FormAtual.BringToFront();
            FormAtual.Show();
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(Forms[0], sender);
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(Forms[1], sender);
        }

        private void btnRececionista_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(Forms[2], sender);
        }

        private void btnLogo_Click(object sender, EventArgs e) // Vai para a aba HOME
        {
            if (FormAtual != null)
                FormAtual.Visible = false;
            Reset();
        }

        private void Reset() // Reset de Buttons
        {
            DesativarButton();
            lblTitle.Text = "        HOME";
            if (tgbTema.CheckState.ToString() == "Checked")
                pnlTitleBar.BackColor = Color.FromArgb(167, 189, 201);
            else
                pnlTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            ButtonAtual = null;
            FormAtual = null;
        }

        private void tgbTema_CheckedChanged(object sender, EventArgs e) // Mudança de Tema
        {
            if (tgbTema.Checked)
            {
                TemaAtual = true; // Tema Light
                pnlMenu.BackColor = Color.FromArgb(229, 230, 220);
                pnlMenu.ForeColor = Color.Black;
                pnlLogo.BackColor = Color.FromArgb(168, 168, 158);
                pnlPrincipal.BackColor = Color.Gainsboro;
                lblTema.ForeColor = Color.Black;
                lblIcons.ForeColor = Color.Black;
                if (ButtonAtual == null)
                    pnlTitleBar.BackColor = Color.FromArgb(167, 189, 201);
                if (tgbIcons.CheckState.ToString() == "Unchecked")
                {
                    btnAnimais.Image = Properties.Resources.paw_black;
                    btnMedicos.Image = Properties.Resources.doctor_black;
                    btnRececionistas.Image = Properties.Resources.receptionist_black;
                }
            }
            else
            {
                TemaAtual = false; // Tema Dark
                pnlMenu.BackColor = Color.FromArgb(51, 51, 70);
                pnlMenu.ForeColor = Color.Gainsboro;
                pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
                pnlPrincipal.BackColor = Color.FromArgb(46, 50, 58);
                lblTema.ForeColor = Color.White;
                lblIcons.ForeColor = Color.White;
                if (ButtonAtual == null)
                    pnlTitleBar.BackColor = Color.FromArgb(0, 150, 136);
                if (!tgbIcons.Checked)
                {
                    btnAnimais.Image = Properties.Resources.paw_white;
                    btnMedicos.Image = Properties.Resources.doctor_white;
                    btnRececionistas.Image = Properties.Resources.receptionist_white;
                }
            }

            foreach (Control btnAnterior in pnlMenu.Controls) // Tratamento de Estética de Buttons
            {
                if (btnAnterior.GetType() == typeof(Button) && btnAnterior != ButtonAtual)
                {
                    btnAnterior.BackColor = pnlMenu.BackColor;
                    btnAnterior.ForeColor = pnlMenu.ForeColor;
                }
            }

            foreach (Form frm in Forms) // Passa informação aos Forms Filhos de que o Tema foi alterado
            {
                if (frm is forms.frmAnimais && frm.Visible == true)
                    ((forms.frmAnimais)frm).LoadTema();
                else if (frm is forms.frmMedicos && frm.Visible == true)
                    ((forms.frmMedicos)frm).LoadTema();
            }
        }

        private void tgbIcons_CheckedChanged(object sender, EventArgs e) // Mudança de Icons de Cor
        {
            IconAtual = tgbIcons.Checked;
            if (tgbIcons.Checked)
            {
                btnAnimais.Image = Properties.Resources.paw_color;
                btnMedicos.Image = Properties.Resources.doctor_color;
                btnRececionistas.Image = Properties.Resources.receptionist_color;
            }
            else
            {
                if (tgbTema.Checked)
                {
                    btnAnimais.Image = Properties.Resources.paw_black;
                    btnMedicos.Image = Properties.Resources.doctor_black;
                    btnRececionistas.Image = Properties.Resources.receptionist_black;
                }
                else
                {
                    btnAnimais.Image = Properties.Resources.paw_white;
                    btnMedicos.Image = Properties.Resources.doctor_white;
                    btnRececionistas.Image = Properties.Resources.receptionist_white;
                }
            }

            foreach (Form frm in Forms) // Passa informação aos Forms Filhos de que os Icons foram alterados
            {
                if (frm is forms.frmMedicos && frm.Visible == true)
                    ((forms.frmMedicos)frm).LoadTema();
            }
        }
    }
}
