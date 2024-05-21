using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private BaseDados bd = new BaseDados();
        public frmEditAnimais(bool frm_criar, int id = 0)
        {
            InitializeComponent();

            cmbTipo.DataSource = new List<string> { "cão", "gato", "tartaruga", "cobra", "peixe", "passaro" };
            if (frm_criar == true)
            {
                Text = "Novo Cliente";
                lblEditar.Visible = false;
                tglbtnEditar.Visible = false;
                cmbID.Enabled = false;

                string idTest = bd.executeReturnDataQuery("SELECT MAX(id) FROM Animais").Rows[0][0].ToString();
                int idseguinte;
                if (idTest == "")
                    idseguinte = 1;
                else
                    idseguinte = int.Parse(idTest) + 1;
                cmbID.Text = idseguinte.ToString();
            }
            else
            {
                cmbID.DataSource = bd.executeReturnDataQuery("SELECT id FROM Animais");
                cmbID.DisplayMember = "id";
                cmbID.ValueMember = "id";
                cmbID.SelectedValue = id;
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
            grpbxDetalhes.ForeColor = Cores.CorDefenida;
            txtNome.ForeColor = Cores.CorDefenida;
            cmbTipo.ForeColor = Cores.CorDefenida;
            txtRaca.ForeColor = Cores.CorDefenida;
            txtIdade.ForeColor = Cores.CorDefenida;
            cmbID.ForeColor = Cores.CorDefenida;

            if (MainForm.TemaAtual == false)
            {
                txtDetalhes.ForeColor = Color.White;
                BackColor = Color.FromArgb(46, 50, 58);
            }
            else
            {
                btnCriar.BackColor = Color.FromArgb(167, 189, 201);
                txtDetalhes.ForeColor = Color.Black;

                BackColor = Color.FromArgb(168, 168, 168); 
                cmbID.BackColor = Color.FromArgb(229, 230, 220);
                txtNome.BackColor = Color.FromArgb(229, 230, 220);
                cmbTipo.BackColor = Color.FromArgb(229, 230, 220);
                txtRaca.BackColor = Color.FromArgb(229, 230, 220);
                txtIdade.BackColor = Color.FromArgb(229, 230, 220);
                txtDetalhes.BackColor = Color.FromArgb(229, 230, 220);
                lblID.ForeColor = Color.Black;
                lblTipo.ForeColor = Color.Black;
                lblNome.ForeColor = Color.Black;
                lblRaca.ForeColor = Color.Black;
                lblDataNasc.ForeColor = Color.Black;

            }
        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblEditar.Visible == true)
                reporDados(int.Parse(cmbID.Text));
        }

        private void reporDados(int id)
        {
            DataTable data;
            if (id == 0)
            {
                data = bd.executeReturnDataQuery("SELECT * FROM Animais WHERE id = " + id);
            }
            else
            {
                data = bd.executeReturnDataQuery("SELECT * FROM Animais WHERE id = " + id);
                cmbID.SelectedItem = id.ToString();
            }

            txtNome.Text = data.Rows[0][1].ToString();
            cmbTipo.SelectedItem = data.Rows[0][2].ToString();
            txtRaca.Text = data.Rows[0][3].ToString();
            dtpDataNasc.Value = DateTime.Parse(data.Rows[0][5].ToString());
            txtDetalhes.Text = data.Rows[0][4].ToString();
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
            if (!ValidateChildren())
                return;

            int IDselecionado = Convert.ToInt32(cmbID.Text);

            string sql = "UPDATE Animais SET nome = @Nome, tipo = @Tipo, raca = @Raca, Detalhes = @Detalhes, data_nasc = @Data_Nasc WHERE id = " + IDselecionado;

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nome", txtNome.Text));
            parametros.Add(new SqlParameter("@Tipo", cmbTipo.SelectedItem.ToString()));
            parametros.Add(new SqlParameter("@Raca", txtRaca.Text));
            parametros.Add(new SqlParameter("@Detalhes", txtDetalhes.Text));
            parametros.Add(new SqlParameter("@Data_Nasc", DateTime.Parse(dtpDataNasc.Text)));

            // executar o método da classe Basa_Dados para guardar os dados na BD
            bd.executeParametersQuery(sql, parametros);
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
                if (sender == null)
                    return;
                if (!ValidateChildren())
                {
                    reporDados(0);
                    return;
                }
                Salvar();
            }
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


        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            string sql = "INSERT INTO Animais(id, nome, tipo, raca, Detalhes, data_nasc) VALUES (@id, @nome, @tipo, @raca, @Detalhes, CONVERT(DATE, @data_nasc, 103))";

            // Associar os parametros aos valores inseridos pelo utilizador
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id", Convert.ToInt32(cmbID.Text)));
            parametros.Add(new SqlParameter("@nome", txtNome.Text));
            parametros.Add(new SqlParameter("@tipo", cmbTipo.SelectedItem.ToString()));
            parametros.Add(new SqlParameter("@raca", txtRaca.Text));
            parametros.Add(new SqlParameter("@Detalhes", txtDetalhes.Text));
            parametros.Add(new SqlParameter("@data_nasc", dtpDataNasc.Value.ToString("dd/MM/yyyy")));

            // executar o método da classe Basa_Dados para guardar os dados na BD
            bd.executeParametersQuery(sql, parametros);

            Close();
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

        private void txtRaca_Validating(object sender, CancelEventArgs e)
        {
            if (txtRaca.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider.SetError(txtRaca, "É necessário preencher este campo.");
            }
            else if (txtRaca.Text.Length <= 2)
            {
                e.Cancel = true;
                errorProvider.SetError(txtRaca, "É necessário uma Raça com pelo menos 3 dígitos.");
            }
            else
                errorProvider.SetError(txtRaca, "");
        }

    }
}
