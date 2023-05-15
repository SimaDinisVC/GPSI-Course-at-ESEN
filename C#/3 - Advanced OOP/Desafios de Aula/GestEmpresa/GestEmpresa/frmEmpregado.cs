using System;
using System.Windows.Forms;

namespace GestEmpresa
{
    public partial class frmEmpregado : Form
    {
        // Propriedade de leitura; apenas a classe pode escrever
        // Dados do formulário para ver ou editar
        public Empregado Emp { get; private set; }

        public frmEmpregado(Empregado _emp)
        {
            InitializeComponent();

            Emp = _emp;

            // Ver/Editar o empregado
            if (Emp != null)
            {
                Text = "Ver/Editar Empregado";
                chkEditar.Enabled = true;
                updateChkEditar(false);
            }
            else // Novo empregado porque Emp não foi ainda inicializado
            {
                Text = "Novo Empregado";
                chkEditar.Enabled = false;
                chkEditar.Checked = true;
                updateChkEditar(true);
            }

            // se clicar na tecla ENTER ou no botão OK assumido a ação OK (aceitar os dados do formulário)
            AcceptButton = btnOk;
            // Se clicar na tyecla ESC ou no botão Cancelar, assume a ação Cancel (Ignorar os dados)
            CancelButton = btnCancel;

            // Ignorar a validação dos dados caso clic o no botão cancelar
            btnCancel.CausesValidation = false;

            // Fecha a janela e retorna a mensagem de ação correspendente
            btnCancel.DialogResult = DialogResult.Cancel;
            btnOk.DialogResult = DialogResult.OK;

            cmbCargo.DataSource = Empresa.cargos;
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;

            // Atualizar o cargfo consoante o tipo de empregado
            if (Emp is Programador)
                cmbCargo.SelectedIndex = Empresa.CARGO_PROGRAMADOR;
            else if (Emp is Analista)
                cmbCargo.SelectedIndex = Empresa.CARGO_ANALISTA;
            else // Novo empregado. Assume-se inicialmente ser um programador
                cmbCargo.SelectedIndex = Empresa.CARGO_PROGRAMADOR;

            pnlProgramador.Visible = (Emp is Programador) || (Emp == null);
            pnlAnalista.Visible = Emp is Analista;
        }

        // è executado sempre que se mostra a janela
        private void frmEmpregado_Load(object sender, System.EventArgs e)
        {
            if (Emp != null)
            {
                txtNome.Text = Emp.Nome;
                txtID.Text = Emp.ValorID.ToString();
                txtEmail.Text = Emp.eMail;
                txtTelefone.Text = Emp.Telefone;
                if (Emp.DataNasc == new System.DateTime())
                    // Neste caso não podemos igualar Value com 01/01/0001 por ser uma data inválida
                    dtpDataNasc.Value = DateTime.Now.Date;
                else
                    dtpDataNasc.Value = Emp.DataNasc.Date;
                        
                

                txtRua.Text = Emp.MoradaAtual.Rua;
                txtCodPostal.Text = Emp.MoradaAtual.CodPostal;
                txtLocalidade.Text = Emp.MoradaAtual.Localidade;

                if (Emp is Programador)
                    txtEspecialidade.Text = ((Programador)Emp).Especialidade;
                else if (Emp is Analista) 
                    txtProjeto.Text = ((Analista)Emp).Projeto;

                                  
            }
        }

        private void updateChkEditar(bool chk)
        {
            cmbCargo.Enabled = chk;
            dtpDataNasc.Enabled = chk;

            // Enabled de todos as TextBox do formulário
            foreach (Control c in Controls)
                if (c is TextBox)
                    c.Enabled = chk;

            // Enabled de todos as TextBox dos paineis
            foreach (Control c in pnlAnalista.Controls)
                if (c is TextBox)
                    c.Enabled = chk;

            foreach (Control c in pnlProgramador.Controls)
                if (c is TextBox)
                    c.Enabled = chk;

            // Enabled de todos as TextBox do grupo da morada
            foreach (Control c in grpMorada.Controls)
                if (c is TextBox)
                    c.Enabled = chk;

            // O ID é de nyumeração automática. Nunca pode ter permissão para o editar
            txtID.Enabled = false;
        }

        private void chkEditar_CheckedChanged(object sender, System.EventArgs e)
        {
            updateChkEditar(chkEditar.Checked);
        }

        private void cmbCargo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            pnlProgramador.Visible = cmbCargo.SelectedIndex == Empresa.CARGO_PROGRAMADOR;
            pnlAnalista.Visible = cmbCargo.SelectedIndex == Empresa.CARGO_ANALISTA;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            if (cmbCargo.SelectedIndex == Empresa.CARGO_PROGRAMADOR)
            {
                // Cria uma nova instância da classe Programador, se
                // for um novo empregado ou se na edição foi alterado o cargo do empregado para proggramador e anteriormente era analista
                if (Emp == null || !(Emp is Programador))
                    Emp = new Programador();

                // Atualiza os dados específicosa do programador
                // Nota: primeiro é necessário converter o Empregado para Programador com o cast (Programador)
                // ((Programador)Emp).Especialidade não é o mesmo que (Programador)Emp.Especialidade, Porquê?
                ((Programador)Emp).Especialidade = txtEspecialidade.Text;
            }
            else if (cmbCargo.SelectedIndex == Empresa.CARGO_ANALISTA)
            {
                if (Emp == null || !(Emp is Analista))
                    Emp = new Analista();

                ((Analista)Emp).Projeto = txtProjeto.Text;
            }

            // Atualizar os dados comuns ao empregado
            Emp.Nome = txtNome.Text;
            Emp.eMail = txtEmail.Text;
            Emp.Telefone = txtTelefone.Text;
            Emp.DataNasc = dtpDataNasc.Value;
            Emp.MoradaAtual = new Morada(txtRua.Text, txtCodPostal.Text, txtLocalidade.Text);
        }
    }
}
