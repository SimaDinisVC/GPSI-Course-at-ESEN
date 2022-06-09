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
            string[] words = lblWelcome.Text.Split(' '); // Cria lista onde faz o split em espaços
            lblWelcome.Text = words[0] + " " + txtNome.Text; // Vai buscar o "Bem-Vindo" e adiciona o Nome do User
            if (txtNome.Text != "") // se o nome do user não for vazio ele mete ! no final
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

        private void txtSalário_TextChanged(object sender, EventArgs e)
        {
            bool vSalM = true; //  validação de dados
            int salM;
            int.TryParse(txtSalário.Text, out salM);
            if (salM == 0)
            {
                vSalM = false;
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            FrmCalculadora formCalc = new FrmCalculadora();
            formCalc.Show();
            formCalc.Focus();
        }
    }
}