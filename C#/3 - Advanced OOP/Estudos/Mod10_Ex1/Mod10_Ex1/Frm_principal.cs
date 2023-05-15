using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod10_Ex1
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
            Text = Empresa.appNome + " " + Empresa.versao;
        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {
            // Associar os dados na DataGridView

            dgvEmpregados.DataSource = Empresa.empList;
            dgvEmpregados.MultiSelect = false;
            dgvEmpregados.RowHeadersVisible = false;
            dgvEmpregados.ReadOnly = true;
            dgvEmpregados.AllowUserToAddRows = false;
            dgvEmpregados.AllowUserToDeleteRows = false;
            dgvEmpregados.AllowUserToResizeColumns = false;
            dgvEmpregados.AllowUserToResizeRows = false;
            dgvEmpregados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            for (int i = 4; i < dgvEmpregados.ColumnCount; i++)
            {
                dgvEmpregados.Columns[i].Visible = false;
            }

            // mostrar id, nome, cargo e localidade

            dgvEmpregados.Columns["valorID"].HeaderText = "ID";
            dgvEmpregados.Columns["valorID"].Width = 40;
            dgvEmpregados.Columns["valorID"].DefaultCellStyle.BackColor = Color.LightBlue;
            dgvEmpregados.Columns["NomeAbreviado"].HeaderText = "Nome";
            dgvEmpregados.Columns["NomeAbreviado"].Width = 150;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            // Como queremos adicionar um novo empregado basta indicar null ao empregado
            Frm_Empregado form = new Frm_Empregado(null);

            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                Empresa.empList.Add(form.emp);
                MessageBox.Show("Novo empregado adicionado com sucesso.", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Empregado GetCurrentDataRow()
        {
            if (dgvEmpregados.Rows.Count > 0)
                //aceder aos dados associados à linha selecionada e converter esses dados para empregado
                return dgvEmpregados.CurrentRow.DataBoundItem as Empregado;
            else
                return null;
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (dgvEmpregados.Rows.Count > 0)
            {
                Empregado dados = GetCurrentDataRow();
                int i = Empresa.empList.IndexOf(dados); // retorna -1 quando não encontra o empregado...
                if (i < 0)
                {
                    MessageBox.Show("Empregado não encontrado na lista...", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string msg = "Remover o " + dados.getCargo() + " " + dados.Nome + "?";
                DialogResult resultado = MessageBox.Show(msg, Empresa.appNome, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                    Empresa.empList.RemoveAt(i);
            }
            else
                MessageBox.Show("Não existem empregados na lista", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
