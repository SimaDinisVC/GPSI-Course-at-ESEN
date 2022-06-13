namespace ProjetoMOD8
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string msg;

            if (txtNome.Text.Length > 1)
                msg = txtNome.Text + ", quer mesmo sair?";
            else
                msg = "Quer mesmo sair?";

            DialogResult resposta = MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
                Application.Exit();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string[] words = lblWelcome.Text.Split(' '); // Cria lista onde faz o split em espa�os
            lblWelcome.Text = words[0] + " " + txtNome.Text; // Vai buscar o "Bem-Vindo" e adiciona o Nome do User
            if (txtNome.Text != "") // se o nome do user n�o for vazio ele mete ! no final
                lblWelcome.Text += "!";
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            lblWelcome.Text = "Bem-Vindo " + txtNome.Text;
            if (txtNome.Text != "")
                lblWelcome.Text += "!";
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            lblWelcome.Text = "Bem-Vinda " + txtNome.Text;
            if (txtNome.Text != "")
                lblWelcome.Text += "!";
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            FrmCalculadora formCalc = new FrmCalculadora();
            formCalc.Show();
            formCalc.Focus();
        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            // dados
            string nome = txtNome.Text;
            int carreira = int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(dtpCarreira.Text.Split("/")[2]);
            string cidade = cbxCidade.Text;
            int sal�rio = int.Parse(nud_Sal�rioM.Text);
            lblAvalia��o frm = new lblAvalia��o(carreira, cidade, sal�rio);
            frm.ShowDialog();
        }
    }
}