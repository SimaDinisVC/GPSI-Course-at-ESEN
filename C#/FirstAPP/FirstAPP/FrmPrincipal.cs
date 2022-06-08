namespace FirstAPP
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (tbn_Nome.Text.Length > 1)
                msg = tbn_Nome.Text + ", quer mesmo sair?";
            else
                msg = "Pretende Sair?";
            DialogResult resposta = MessageBox.Show(msg,"Aviso!",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_Sobre_Click(object sender, EventArgs e)
        {
            FrmSobre form = new FrmSobre();
            form.ShowDialog();
        }

        private void btn_Ajuda_Click(object sender, EventArgs e)
        {
            FrmAjuda formAjuda = new FrmAjuda();
            formAjuda.Show();
        }
    }
}