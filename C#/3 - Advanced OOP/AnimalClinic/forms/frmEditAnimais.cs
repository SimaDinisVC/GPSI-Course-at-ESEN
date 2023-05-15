using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalClinic.forms
{
    public partial class frmEditAnimais : Form
    {

        public frmEditAnimais(bool frm_criar, int id = 0)
        {
            InitializeComponent();

            cmbTipo.DataSource = Clinica.TiposAnimais;
            if (frm_criar == true)
            {
                Text = "Novo Cliente";
                lblEditar.Visible = false;
                tglbtnEditar.Visible = false;
                cmbID.Enabled = false;
                cmbID.DataSource = new List<int>() { (Animal.autoID + 1) };            }
            else
            {
                cmbID.DataSource = Clinica.IDAnimais;
                Text = "Consulta da ficha";
                btnCriar.Visible = false;
                reporDados(id);
                tglbtnEditar_CheckedChanged(null, EventArgs.Empty); // Desabilita os Controls
            }
            LoadTema();
        }

        private void LoadTema()
        {
            lblAnimais.ForeColor = Cores.CorDefenida;
            lblTutor.ForeColor = Cores.CorDefenida;
            grpbxDetalhes.ForeColor = Cores.CorDefenida;
            grpbxMorada.ForeColor = Cores.CorDefenida;
            txtNome.ForeColor = Cores.CorDefenida;
            cmbTipo.ForeColor = Cores.CorDefenida;
            txtRaca.ForeColor = Cores.CorDefenida;
            txtIdade.ForeColor = Cores.CorDefenida;
            txtNomeTtr.ForeColor = Cores.CorDefenida;
            txtEmail.ForeColor = Cores.CorDefenida;
            txtTelefone.ForeColor = Cores.CorDefenida;
            txtNIC.ForeColor = Cores.CorDefenida;
            txtIdadeTtr.ForeColor = Cores.CorDefenida;
            cmbID.ForeColor = Cores.CorDefenida;

            if (MainForm.TemaAtual == false)
            {
                txtDetalhes.ForeColor = Color.White;
                txtRua.ForeColor = Color.White;
                txtCodigoPostal.ForeColor = Color.White;
                cmbLocalidade.ForeColor = Color.White;
                BackColor = Color.FromArgb(46, 50, 58);
            }
            else
            {
                btnCriar.BackColor = Color.FromArgb(167, 189, 201);
                txtDetalhes.ForeColor = Color.Black;
                txtRua.ForeColor = Color.Black;
                txtCodigoPostal.ForeColor = Color.Black;
                cmbLocalidade.ForeColor = Color.Black;
                BackColor = Color.FromArgb(168, 168, 168); 
                cmbID.BackColor = Color.FromArgb(229, 230, 220);
                txtNome.BackColor = Color.FromArgb(229, 230, 220);
                cmbTipo.BackColor = Color.FromArgb(229, 230, 220);
                txtRaca.BackColor = Color.FromArgb(229, 230, 220);
                txtIdade.BackColor = Color.FromArgb(229, 230, 220);
                txtNomeTtr.BackColor = Color.FromArgb(229, 230, 220);
                txtEmail.BackColor = Color.FromArgb(229, 230, 220);
                txtTelefone.BackColor = Color.FromArgb(229, 230, 220);
                txtNIC.BackColor = Color.FromArgb(229, 230, 220);
                txtIdadeTtr.BackColor = Color.FromArgb(229, 230, 220);
                txtDetalhes.BackColor = Color.FromArgb(229, 230, 220);
                txtRua.BackColor = Color.FromArgb(229, 230, 220);
                txtCodigoPostal.BackColor = Color.FromArgb(229, 230, 220);
                cmbLocalidade.BackColor = Color.FromArgb(229, 230, 220);
                lblID.ForeColor = Color.Black;
                lblTipo.ForeColor = Color.Black;
                lblNome.ForeColor = Color.Black;
                lblRaca.ForeColor = Color.Black;
                lblDataNasc.ForeColor = Color.Black;
                lblNomeTtr.ForeColor = Color.Black;
                lblEmail.ForeColor = Color.Black;
                lblTelefone.ForeColor = Color.Black;
                lblNIC.ForeColor = Color.Black;
                lblDataNascTtr.ForeColor = Color.Black;
                lblIdadeTtr.ForeColor = Color.Black;
                lblRua.ForeColor = Color.Black;
                lblCodigoPostal.ForeColor = Color.Black;
                lblLocalidade.ForeColor = Color.Black;

            }
        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblEditar.Visible == true)
                reporDados(0);
        }

        private void reporDados(int id)
        {
            Animal animal;
            if (id == 0)
            {
                int IDselecionado = Convert.ToInt32(cmbID.SelectedItem);
                animal = Clinica.animallist.FirstOrDefault(anml => anml.ID == IDselecionado);
            }
            else
            {
                int IDselecionado = id;
                animal = Clinica.animallist.FirstOrDefault(anml => anml.ID == IDselecionado);
                cmbID.SelectedItem = id.ToString();
            }

            txtNome.Text = animal.Nome;
            cmbTipo.SelectedItem = animal.Tipo;
            txtRaca.Text = animal.Raca;
            dtpDataNasc.Value = animal.Data_Nasc;
            txtDetalhes.Text = animal.Detalhes;
            txtNomeTtr.Text = animal.dono.Nome;
            txtEmail.Text = animal.dono.Email;
            txtTelefone.Text = animal.dono.Telefone;
            txtNIC.Text = animal.dono.NIC;
            dtpDataNascTtr.Value = animal.dono.Data_Nasc;
            txtRua.Text = animal.dono.Morada.Rua;
            txtCodigoPostal.Text = animal.dono.Morada.CodigoPostal;
            int index = cmbLocalidade.FindStringExact(animal.dono.Morada.Localidade);
            cmbLocalidade.SelectedIndex = index;
        }

        private void txtDetalhes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDetalhes.AppendText(Environment.NewLine); // adiciona a quebra de linha
                e.Handled = true; // define como manipulado para evitar que o Enter seja inserido na TextBox
            }
        }

        private void Salvar()
        {
            int IDselecionado = Convert.ToInt32(cmbID.SelectedItem);
            Animal animal = Clinica.animallist.FirstOrDefault(anml => anml.ID == IDselecionado);
            animal.Nome = txtNome.Text;
            animal.Tipo = cmbTipo.SelectedItem.ToString();
            animal.Raca = txtRaca.Text;
            animal.Data_Nasc = dtpDataNasc.Value;
            animal.Detalhes = txtDetalhes.Text;
            animal.dono.Nome = txtNomeTtr.Text;
            animal.dono.Email = txtEmail.Text;
            animal.dono.Telefone = txtTelefone.Text;
            animal.dono.NIC = txtNIC.Text;
            animal.dono.Data_Nasc = dtpDataNascTtr.Value;
            animal.dono.Morada.Rua = txtRua.Text;
            animal.dono.Morada.CodigoPostal = txtCodigoPostal.Text;
            if (cmbLocalidade.SelectedItem != null)
                animal.dono.Morada.Localidade = cmbLocalidade.SelectedItem.ToString();
        }

        private void tglbtnEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (tglbtnEditar.Checked)
            {
                lblEditar.Text = "Salvar";
                txtNome.Enabled = true;
                cmbTipo.Enabled = true;
                txtRaca.Enabled = true;
                dtpDataNasc.Enabled = true;
                txtDetalhes.Enabled = true;
                txtNomeTtr.Enabled = true;
                txtEmail.Enabled = true;
                txtTelefone.Enabled = true;
                txtNIC.Enabled = true;
                dtpDataNascTtr.Enabled = true;
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
                txtRaca.Enabled = false;
                dtpDataNasc.Enabled = false;
                txtDetalhes.Enabled = false;
                txtNomeTtr.Enabled = false;
                txtEmail.Enabled = false;
                txtTelefone.Enabled = false;
                txtNIC.Enabled = false;
                dtpDataNascTtr.Enabled = false;
                txtRua.Enabled = false;
                txtCodigoPostal.Enabled = false;
                cmbLocalidade.Enabled = false;
                if (sender == null)
                    return;
                if (!Pessoa.IsValidNIC(txtNIC.Text))
                {
                    reporDados(0);
                    MessageBox.Show("O Número de Identificação Civíl (NIC) não é válido.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if ((Pessoa.NICs.Contains(txtNIC.Text) && Clinica.animallist.FirstOrDefault(anml => anml.dono.NIC == txtNIC.Text).ID != Clinica.animallist.FirstOrDefault(anml => anml.ID == Convert.ToInt32(cmbID.SelectedItem)).ID))
                {
                    reporDados(0);
                    MessageBox.Show("O Número de Identificação Civíl (NIC) já é utilizado.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Salvar();
            }
        }

        private void dtpDataNasc_ValueChanged(object sender, EventArgs e)
        {
            txtIdade.Text = Pessoa.GetIdade(dtpDataNasc.Value).ToString();
        }

        private void dtpDataNascTtr_ValueChanged(object sender, EventArgs e)
        {
            txtIdadeTtr.Text = Pessoa.GetIdade(dtpDataNascTtr.Value).ToString();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (!Pessoa.IsValidNIC(txtNIC.Text.Trim()))
            {
                MessageBox.Show("O Número de Identificação Civíl (NIC) não é válido.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Pessoa.NICs.Contains(txtNIC.Text))
            {
                MessageBox.Show("O Número de Identificação Civíl (NIC) já é utilizado.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string msgAviso = "É necessário dados válidos para:"; // Mensagem de erro caso exista

            Cliente dono = new Cliente(txtNIC.Text, new List<Animal>()); // Dono Padrão
            dono.Nome = txtNomeTtr.Text;
            dono.Email = txtEmail.Text;
            dono.Telefone = txtTelefone.Text;
            dono.Data_Nasc = dtpDataNascTtr.Value;
            dono.Morada = new Morada();
            dono.Morada.Rua = txtRua.Text;
            dono.Morada.CodigoPostal = txtCodigoPostal.Text;
            if (cmbLocalidade.SelectedItem != null)
                dono.Morada.Localidade = cmbLocalidade.SelectedItem.ToString();
            if (dono.Nome == "(Por defenir)")
                msgAviso += "\n* Nome do Tutor";
            if (dono.Email == "(Por defenir)")
                msgAviso += "\n* Email";
            if (dono.Telefone == "(Por defenir)")
                msgAviso += "\n* Telefone";
            if (dono.Data_Nasc.ToString() == "01/01/0001 00:00:00")
                msgAviso += "\n* Data de Nascimento do Tutor";
            if (dono.Morada.Rua == "(Por defenir)")
                msgAviso += "\n* Rua";
            if (dono.Morada.CodigoPostal == "(Por defenir)")
                msgAviso += "\n* Código Postal";
            if (dono.Morada.Localidade == "(Por defenir)")
                msgAviso += "\n* Localidade";

            Animal novoAnimal = new Animal(dono);

            novoAnimal.Nome = txtNome.Text;
            if (cmbTipo.SelectedItem != null)
                novoAnimal.Tipo = cmbTipo.SelectedItem.ToString();
            novoAnimal.Raca = txtRaca.Text;
            novoAnimal.Data_Nasc = new DateTime(dtpDataNasc.Value.Year, dtpDataNasc.Value.Month, dtpDataNasc.Value.Day);
            novoAnimal.Detalhes = txtDetalhes.Text;

            if (novoAnimal.Nome == "(Por defenir)")
                msgAviso += "\n* Nome do Animal";
            if (novoAnimal.Tipo == "(Por defenir)")
                msgAviso += "\n* Tipo";
            if (novoAnimal.Raca == "(Por defenir)")
                msgAviso += "\n* Raca";
            if (novoAnimal.Data_Nasc.ToString() == "01/01/0001")
                msgAviso += "\n* Data de Nascimento do Animal";

            if (msgAviso != "É necessário dados válidos para:")
            {
                msgAviso += "\n Deseja continuar?";
                DialogResult result = MessageBox.Show(msgAviso, Clinica.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    Clinica.animallist.Add(novoAnimal);
                else
                {
                    dono = null;
                    novoAnimal = null;
                    Animal.DesicrementaAutoID();
                    return;
                }
            }
            else
                Clinica.animallist.Add(novoAnimal);
            Close();
        }
    }
}
