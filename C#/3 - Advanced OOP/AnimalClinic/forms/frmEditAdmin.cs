using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalClinic.forms
{
    public partial class frmEditAdmin : Form
    {
        private string NIC;

        public frmEditAdmin(bool frm_criar, string NIC = "0", int index = 0)
        {
            InitializeComponent();
            cmbTipo.DataSource = new List<string>() { "Rececionista", "Médico" };
            if (frm_criar == true)
            {
                Text = "Novo Funcionário";
                lblEditar.Visible = false;
                tglbtnEditar.Visible = false;
            }
            else
            {
                Text = "Consulta da ficha";
                btnCriar.Visible = false;
                cmbTipo.Enabled = false;
                txtNIC.Text = NIC;
                cmbTipo.SelectedIndex = index;
                cmbTipo.Enabled = false;
                reporDados(NIC);
                this.NIC = NIC;
                tglbtnEditar_CheckedChanged(null, EventArgs.Empty); // Desabilita os Controls
            }
            LoadTema();
        }

        private void LoadTema()
        {
            lblFuncionario.ForeColor = Cores.CorDefenida;
            txtDetalhes.ForeColor = Cores.CorDefenida;
            cmbTipo.ForeColor = Cores.CorDefenida;
            txtNome.ForeColor = Cores.CorDefenida;
            txtEmail.ForeColor = Cores.CorDefenida;
            txtTelefone.ForeColor = Cores.CorDefenida;
            txtNIC.ForeColor = Cores.CorDefenida;
            txtIdade.ForeColor = Cores.CorDefenida;

            if (MainForm.TemaAtual == false)
            {
                txtRua.ForeColor = Color.White;
                txtCodigoPostal.ForeColor = Color.White;
                cmbLocalidade.ForeColor = Color.White;
            }
            else
            {
                btnCriar.BackColor = Color.FromArgb(167, 189, 201);
                txtRua.ForeColor = Color.Black;
                txtCodigoPostal.ForeColor = Color.Black;
                cmbLocalidade.ForeColor = Color.Black;
                BackColor = Color.FromArgb(168, 168, 168);
                txtNome.BackColor = Color.FromArgb(229, 230, 220);
                cmbTipo.BackColor = Color.FromArgb(229, 230, 220);
                txtIdade.BackColor = Color.FromArgb(229, 230, 220);
                txtEmail.BackColor = Color.FromArgb(229, 230, 220);
                txtTelefone.BackColor = Color.FromArgb(229, 230, 220);
                txtNIC.BackColor = Color.FromArgb(229, 230, 220);
                txtDetalhes.BackColor = Color.FromArgb(229, 230, 220);
                txtRua.BackColor = Color.FromArgb(229, 230, 220);
                txtCodigoPostal.BackColor = Color.FromArgb(229, 230, 220);
                cmbLocalidade.BackColor = Color.FromArgb(229, 230, 220);
                lblTipo.ForeColor = Color.Black;
                lblEspecializacao.ForeColor = Color.Black;
                lblNome.ForeColor = Color.Black;
                lblEmail.ForeColor = Color.Black;
                lblTelefone.ForeColor = Color.Black;
                lblNIC.ForeColor = Color.Black;
                lblDataNasc.ForeColor = Color.Black;
                lblIdade.ForeColor = Color.Black;
                lblRua.ForeColor = Color.Black;
                lblCodigoPostal.ForeColor = Color.Black;
                lblLocalidade.ForeColor = Color.Black;
            }
        }

        private void reporDados(string NIC)
        {
            Rececionista r = null;
            Medico m = null;
            r = Clinica.rececionistalist.FirstOrDefault(func => func.NIC == NIC);
            if (r == null)
                m = Clinica.medicolist.FirstOrDefault(func => func.NIC == NIC);
            if (r != null)
            {
                cmbTipo.SelectedIndex = 0;
                txtNome.Text = r.Nome;
                txtEmail.Text = r.Email;
                txtTelefone.Text = r.Telefone;
                dtpDataNasc.Value = r.Data_Nasc;
                txtRua.Text = r.Morada.Rua;
                txtCodigoPostal.Text = r.Morada.CodigoPostal;
                int index = cmbLocalidade.FindStringExact(r.Morada.Localidade);
                cmbLocalidade.SelectedIndex = index;
            }
            else
            {
                cmbTipo.SelectedIndex = 1;
                txtDetalhes.Text = string.Join(Environment.NewLine, m.Especialidades);
                txtNome.Text = m.Nome;
                txtEmail.Text = m.Email;
                txtTelefone.Text = m.Telefone;
                dtpDataNasc.Value = m.Data_Nasc;
                txtRua.Text = m.Morada.Rua;
                txtCodigoPostal.Text = m.Morada.CodigoPostal;
                int index = cmbLocalidade.FindStringExact(m.Morada.Localidade);
                cmbLocalidade.SelectedIndex = index;
            }
        }

        private void txtDetalhes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDetalhes.AppendText(Environment.NewLine); // adiciona a quebra de linha
                e.Handled = true; // define como manipulado para evitar que o Enter seja inserido na TextBox
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (!Pessoa.IsValidNIC(txtNIC.Text))
                MessageBox.Show("O Número de Identificação Civíl (NIC) não é válido.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Pessoa.NICs.Contains(txtNIC.Text))
                MessageBox.Show("Atenção: Já existe um Funcionário ou Cliente com o mesmo Nº de Indentificação Civíl.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string msgAviso = "É necessário dados válidos para:"; // Mensagem de erro caso exista
                if (cmbTipo.SelectedIndex == 0)
                {
                    Rececionista func = new Rececionista(txtNIC.Text);
                    func.Nome = txtNome.Text;
                    func.Email = txtEmail.Text;
                    func.Telefone = txtTelefone.Text;
                    func.Data_Nasc = dtpDataNasc.Value;
                    func.Morada = new Morada();
                    func.Morada.Rua = txtRua.Text;
                    func.Morada.CodigoPostal = txtCodigoPostal.Text;
                    if (cmbLocalidade.SelectedItem != null)
                        func.Morada.Localidade = cmbLocalidade.SelectedItem.ToString();
                    if (func.Nome == "(Por defenir)")
                        msgAviso += "\n* Nome do Tutor";
                    if (func.Email == "(Por defenir)")
                        msgAviso += "\n* Email";
                    if (func.Telefone == "(Por defenir)")
                        msgAviso += "\n* Telefone";
                    if (func.Data_Nasc.ToString() == "01/01/0001 00:00:00")
                        msgAviso += "\n* Data de Nascimento do Tutor";
                    if (func.Morada.Rua == "(Por defenir)")
                        msgAviso += "\n* Rua";
                    if (func.Morada.CodigoPostal == "(Por defenir)")
                        msgAviso += "\n* Código Postal";
                    if (func.Morada.Localidade == "(Por defenir)")
                        msgAviso += "\n* Localidade";
                    if (msgAviso != "É necessário dados válidos para:")
                    {
                        msgAviso += "\n Deseja continuar?";
                        DialogResult result = MessageBox.Show(msgAviso, Clinica.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                            Clinica.rececionistalist.Add(func);
                        else
                            Pessoa.NICs.Remove(func.NIC);
                    }
                    else
                        Clinica.rececionistalist.Add(func);
                }
                else
                {
                    List<string> linhas = new List<string>();
                    string[] linhasArray = txtDetalhes.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    foreach (string linha in linhasArray)
                        linhas.Add(linha);
                    Medico func = new Medico(txtNIC.Text, linhas);
                    func.Nome = txtNome.Text;
                    func.Email = txtEmail.Text;
                    func.Telefone = txtTelefone.Text;
                    func.Data_Nasc = dtpDataNasc.Value;
                    func.Morada = new Morada();
                    func.Morada.Rua = txtRua.Text;
                    func.Morada.CodigoPostal = txtCodigoPostal.Text;
                    if (cmbLocalidade.SelectedItem != null)
                        func.Morada.Localidade = cmbLocalidade.SelectedItem.ToString();
                    if (func.Nome == "(Por defenir)")
                        msgAviso += "\n* Nome";
                    if (func.Email == "(Por defenir)")
                        msgAviso += "\n* Email";
                    if (func.Telefone == "(Por defenir)")
                        msgAviso += "\n* Telefone";
                    if (func.Morada.Rua == "(Por defenir)")
                        msgAviso += "\n* Rua";
                    if (func.Morada.CodigoPostal == "(Por defenir)")
                        msgAviso += "\n* Código Postal";
                    if (func.Morada.Localidade == "(Por defenir)")
                        msgAviso += "\n* Localidade";
                    if (msgAviso != "É necessário dados válidos para:")
                    {
                        msgAviso += "\n Deseja continuar?";
                        DialogResult result = MessageBox.Show(msgAviso, Clinica.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                            Clinica.medicolist.Add(func);
                        else
                            Pessoa.NICs.Remove(func.NIC);
                    }
                    else
                        Clinica.medicolist.Add(func);
                    Close();
                }
            }
        }

        private void tglbtnEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (tglbtnEditar.Checked)
            {
                lblEditar.Text = "Salvar";
                txtNome.Enabled = true;
                dtpDataNasc.Enabled = true;
                txtDetalhes.Enabled = true;
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                txtTelefone.Enabled = true;
                txtNIC.Enabled = true;
                dtpDataNasc.Enabled = true;
                txtRua.Enabled = true;
                txtCodigoPostal.Enabled = true;
                cmbLocalidade.Enabled = true;
            }
            else
            {
                lblEditar.Text = "Editar";
                btnCriar.Visible = false;
                txtNome.Enabled = false;
                cmbTipo.Enabled = false;
                dtpDataNasc.Enabled = false;
                txtDetalhes.Enabled = false;
                txtNome.Enabled = false;
                txtEmail.Enabled = false;
                txtTelefone.Enabled = false;
                txtNIC.Enabled = false;
                dtpDataNasc.Enabled = false;
                txtRua.Enabled = false;
                txtCodigoPostal.Enabled = false;
                cmbLocalidade.Enabled = false;
                if (sender == null)
                    return;
                if (!Pessoa.IsValidNIC(txtNIC.Text))
                {
                    reporDados(NIC);
                    MessageBox.Show("O Número de Identificação Civíl (NIC) não é válido.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (Pessoa.NICs.Contains(txtNIC.Text) && txtNIC.Text != NIC)
                {
                    reporDados(NIC);
                    MessageBox.Show("O Número de Identificação Civíl (NIC) já é utilizado.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Salvar();
            }
        }

        private void Salvar()
        {
            Rececionista r = null;
            Medico m = null;
            r = Clinica.rececionistalist.FirstOrDefault(func => func.NIC == NIC);
            if (r == null)
                m = Clinica.medicolist.FirstOrDefault(func => func.NIC == NIC);
            if (r != null)
            {
                r.Nome = txtNome.Text;
                r.Data_Nasc = dtpDataNasc.Value;
                r.Nome = txtNome.Text;
                r.Email = txtEmail.Text;
                r.Telefone = txtTelefone.Text;
                r.NIC = txtNIC.Text;
                r.Data_Nasc = dtpDataNasc.Value;
                r.Morada.Rua = txtRua.Text;
                r.Morada.CodigoPostal = txtCodigoPostal.Text;
                if (cmbLocalidade.SelectedItem != null)
                    r.Morada.Localidade = cmbLocalidade.SelectedItem.ToString();
            }
            else
            {
                List<string> linhas = new List<string>();
                string[] linhasArray = txtDetalhes.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string linha in linhasArray)
                    linhas.Add(linha);
                m.Nome = txtNome.Text;
                m.Data_Nasc = dtpDataNasc.Value;
                m.Nome = txtNome.Text;
                m.Email = txtEmail.Text;
                m.Telefone = txtTelefone.Text;
                m.NIC = txtNIC.Text;
                m.Data_Nasc = dtpDataNasc.Value;
                m.Morada.Rua = txtRua.Text;
                m.Morada.CodigoPostal = txtCodigoPostal.Text;
                if (cmbLocalidade.SelectedItem != null)
                    m.Morada.Localidade = cmbLocalidade.SelectedItem.ToString();
                m.Especialidades = linhas;
                Clinica.TiposAnimais = linhas;
            }
        }

        private void dtpDataNasc_ValueChanged(object sender, EventArgs e)
        {
            txtIdade.Text = Pessoa.GetIdade(dtpDataNasc.Value).ToString();
        }

        private void cmbTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                lblEspecializacao.Visible = false;
                txtDetalhes.Visible = false;
            }
            else
            {
                lblEspecializacao.Visible = true;
                txtDetalhes.Visible = true;
            }
        }
    }
}
