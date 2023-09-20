using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            grpbxMorada.ForeColor = Cores.CorDefenida;

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
                cmbLocalidade.Text = string.Empty;
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
                cmbLocalidade.Text = string.Empty;
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
            if (!ValidateChildren()) // Se os dados não estiverem validados
                return;

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
                Clinica.rececionistalist.Add(func);
                Clinica.UpdateRececionistalistFiles();
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
                Clinica.medicolist.Add(func);
                Clinica.UpdateMedicolistFiles();
            }
            Close();
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
                if (sender == null)
                    return;
                if (!ValidateChildren()) // Se os dados não estiverem validados
                {
                    reporDados(NIC);
                    return;
                }
                Salvar();
            }
        }

        private void Salvar()
        {
            if (!ValidateChildren()) // Se os dados não estiverem validados
                return;

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

        private void txtCodigoPostal_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            cmbLocalidade.Text = Morada.ObterLocalidade(txtCodigoPostal.Text);
        }

        private void txtNIC_Validating(object sender, CancelEventArgs e)
        {
            if (!Pessoa.IsValidNIC(txtNIC.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNIC, "É necessário um NIC válido de 8 dígitos.");
            }
            else if (Pessoa.NICs.Contains(txtNIC.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNIC, "O NIC insiro já está a ser utilizado no sistema.");
            }
            else
                errorProvider.SetError(txtNIC, "");
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNome, "É necessário preencher este campo.");
            }
            else if (txtNome.Text.Length <= 2)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNome, "É necessário um Nome com pelo menos 3 dígitos.");
            }
            else
                errorProvider.SetError(txtNome, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!Pessoa.IsValidEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "É necessário um Email válido.");
            }
            else
                errorProvider.SetError(txtEmail, "");
        }

        private void txtTelefone_Validating(object sender, CancelEventArgs e)
        {
            if (!Pessoa.IsValidTelefone(txtTelefone.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefone, "É necessário um Telefone válido.");
            }
            else
                errorProvider.SetError(txtTelefone, "");
        }

        private void txtRua_Validating(object sender, CancelEventArgs e)
        {
            if (txtRua.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider.SetError(txtRua, "É necessário preencher este campo.");
            }
            else if (txtRua.Text.Length <= 5)
            {
                e.Cancel = true;
                errorProvider.SetError(txtRua, "É necessário um Nome com pelo menos 5 dígitos.");
            }
            else
                errorProvider.SetError(txtRua, "");
        }

        private void txtCodigoPostal_Validating(object sender, CancelEventArgs e)
        {
            if (!Morada.IsValidCodigoPostal(txtCodigoPostal.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCodigoPostal, "É necessário um código válido.");
            }
            else
                errorProvider.SetError(txtCodigoPostal, "");
        }
    }
}
