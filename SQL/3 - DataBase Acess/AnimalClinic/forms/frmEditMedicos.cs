using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AnimalClinic.forms
{
    public partial class frmEditMedicos : Form
    {
        private string NIC;
        private BaseDados bd = new BaseDados();

        public frmEditMedicos(bool frm_criar, string NIC = "0")
        {
            InitializeComponent();
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
                txtNIC.Text = NIC;
                reporDados(NIC);
                
                tglbtnEditar_CheckedChanged(null, EventArgs.Empty); // Desabilita os Controls
            }
            this.NIC = NIC;
            LoadTema();
        }

        private void LoadTema()
        {
            lblFuncionario.ForeColor = Cores.CorDefenida;
            txtNome.ForeColor = Cores.CorDefenida;
            txtEmail.ForeColor = Cores.CorDefenida;
            txtTelefone.ForeColor = Cores.CorDefenida;
            txtNIC.ForeColor = Cores.CorDefenida;
            txtIdade.ForeColor = Cores.CorDefenida;

            if (MainForm.TemaAtual == true)
            {
                btnCriar.BackColor = Color.FromArgb(167, 189, 201);
                BackColor = Color.FromArgb(168, 168, 168);
                txtNome.BackColor = Color.FromArgb(229, 230, 220);
                txtIdade.BackColor = Color.FromArgb(229, 230, 220);
                txtEmail.BackColor = Color.FromArgb(229, 230, 220);
                txtTelefone.BackColor = Color.FromArgb(229, 230, 220);
                txtNIC.BackColor = Color.FromArgb(229, 230, 220);
                lblNome.ForeColor = Color.Black;
                lblEmail.ForeColor = Color.Black;
                lblTelefone.ForeColor = Color.Black;
                lblNIC.ForeColor = Color.Black;
                lblDataNasc.ForeColor = Color.Black;
                lblIdade.ForeColor = Color.Black;
            }
        }

        private void reporDados(string NIC)
        {
            DataTable data = bd.executeReturnDataQuery("SELECT * FROM Medicos WHERE NIC = " + NIC);

            txtNome.Text = data.Rows[0][1].ToString();
            txtEmail.Text = data.Rows[0][2].ToString();
            txtTelefone.Text = data.Rows[0][3].ToString();
            dtpDataNasc.Value = DateTime.Parse(data.Rows[0][4].ToString());
        }



        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) // Se os dados não estiverem validados
                return;

            string sql = "INSERT INTO Medicos(NIC, nome, email, telefone, DataNasc) VALUES (@NIC, @nome, @email, @telefone, @data_nasc)";

            // Associar os parametros aos valores inseridos pelo utilizador
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@NIC", Convert.ToInt32(txtNIC.Text)));
            parametros.Add(new SqlParameter("@nome", txtNome.Text));
            parametros.Add(new SqlParameter("@email", txtEmail.Text));
            parametros.Add(new SqlParameter("@telefone", txtTelefone.Text));
            parametros.Add(new SqlParameter("@data_nasc", DateTime.Parse(dtpDataNasc.Text)));

            // executar o método da classe Basa_Dados para guardar os dados na BD
            bd.executeParametersQuery(sql, parametros);

            Close();
        }

        private void tglbtnEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (tglbtnEditar.Checked)
            {
                lblEditar.Text = "Salvar";
                txtNome.Enabled = true;
                dtpDataNasc.Enabled = true;
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                txtTelefone.Enabled = true;
                dtpDataNasc.Enabled = true;
            }
            else
            {
                lblEditar.Text = "Editar";
                btnCriar.Visible = false;
                txtNome.Enabled = false;
                dtpDataNasc.Enabled = false;
                txtNome.Enabled = false;
                txtEmail.Enabled = false;
                txtTelefone.Enabled = false;
                txtNIC.Enabled = false;
                dtpDataNasc.Enabled = false;
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

            string sql = "UPDATE Medicos SET nome = @Nome, email = @Email, telefone = @Telefone, DataNasc = @Data_Nasc WHERE NIC = " + Convert.ToInt32(txtNIC.Text);

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nome", txtNome.Text));
            parametros.Add(new SqlParameter("@Email", txtEmail.Text));
            parametros.Add(new SqlParameter("@Telefone", txtTelefone.Text));
            parametros.Add(new SqlParameter("@Data_Nasc", DateTime.Parse(dtpDataNasc.Text)));

            // executar o método da classe Basa_Dados para guardar os dados na BD
            bd.executeParametersQuery(sql, parametros);
        }

        private void dtpDataNasc_ValueChanged(object sender, EventArgs e)
        {
            DateTime data_atual = DateTime.Today;

            // Calcular a idade subtraindo o ano de nascimento do ano atual
            int idade = data_atual.Year - dtpDataNasc.Value.Year;

            // Se a data atual for anterior ao dia do aniversário do ano corrente, subtrair um ano da idade
            if (data_atual < dtpDataNasc.Value.AddYears(idade))
                idade--;

            txtIdade.Text = idade.ToString();
        }

        private void txtNIC_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^\d{8}$";
            string sql = "SELECT NIC FROM Medicos WHERE NIC = " + txtNIC.Text;

            if (NIC != "0")
                sql += " AND NIC != " + NIC;

            if (!Regex.IsMatch(txtNIC.Text, pattern)) //*** verifying condition
            {
                e.Cancel = true;
                errorProvider.SetError(txtNIC, "É necessário um NIC válido de 8 dígitos.");
            }
            else if (bd.executeReturnDataQuery(sql).Rows.Count > 0) //*** verifying condition
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
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(txtEmail.Text, pattern)) //*** verifying condition
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "É necessário um Email válido.");
            }
            else
                errorProvider.SetError(txtEmail, "");
        }

        private void txtTelefone_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^(\+?351)?\s*9\d{8}$";

            if (!Regex.IsMatch(txtTelefone.Text, pattern)) //*** verifying condition
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefone, "É necessário um Telefone válido.");
            }
            else
                errorProvider.SetError(txtTelefone, "");
        }


    }
}
