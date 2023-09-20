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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace AnimalClinic.forms
{
    public partial class frmAnimais : Form
    {
        public frmAnimais()
        {
            InitializeComponent();
            dgvAnimais.DataSource = Clinica.animallist;
        }

        private void frmAnimais_Load(object sender, EventArgs e)
        {
            LoadTema();

            // Definições da datagridview
            dgvAnimais.Columns["ID"].Width = 40;
            dgvAnimais.Columns["ID"].Resizable = DataGridViewTriState.False;
            dgvAnimais.Columns["ID"].DefaultCellStyle.BackColor = Color.LightBlue;
            dgvAnimais.Columns["Tipo"].Width = 75;
            dgvAnimais.Columns["Tipo"].MinimumWidth = 40;
            dgvAnimais.Columns["Nome"].MinimumWidth = 50;
            dgvAnimais.Columns["Idade"].Width = 40;
            dgvAnimais.Columns["Idade"].Resizable = DataGridViewTriState.False;
            dgvAnimais.Columns["Raca"].HeaderText = "Raça";
            dgvAnimais.Columns["Raca"].Width = 80;
            dgvAnimais.Columns["Raca"].MinimumWidth = 40;
            dgvAnimais.Columns["Data_Nasc"].Width = 90;
            dgvAnimais.Columns["Data_Nasc"].MinimumWidth = 85;
            dgvAnimais.Columns["Dono_Nome"].MinimumWidth = 50;
            dgvAnimais.Columns["Dono_Nome"].HeaderText = "Dono";
            dgvAnimais.Columns["Data_Nasc"].HeaderText = "Data de Nascimento";
            dgvAnimais.Columns["Raca"].Width = 70;
            dgvAnimais.Columns["Raca"].MinimumWidth = 50;
            dgvAnimais.Columns["Detalhes"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void frmAnimais_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
                LoadTema();
        }

        public void LoadTema()
        {
            btnRemover.BackColor = Cores.CorDefenida;
            btnNovo.BackColor = Cores.CorDefenida;
            btnConsulta.BackColor = Cores.CorDefenida;
            txtPesquisar.ForeColor = Cores.CorDefenida;
            dgvAnimais.DefaultCellStyle.SelectionBackColor = Cores.CorDefenida;
            dgvAnimais.DefaultCellStyle.SelectionForeColor = Color.White;
            if (MainForm.TemaAtual == false)
            {
                BackColor = Color.FromArgb(46, 50, 58);
                txtPesquisar.BackColor = Color.FromArgb(61, 66, 77); 
                dgvAnimais.BackgroundColor = Color.FromArgb(72, 76, 82);
                dgvAnimais.DefaultCellStyle.BackColor = Color.FromArgb(197, 199, 201);
                dgvAnimais.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvAnimais.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                BackColor = Color.Gainsboro;
                txtPesquisar.BackColor = Color.FromArgb(229, 230, 220);
                dgvAnimais.BackgroundColor = Color.FromArgb(201, 201, 201);
                dgvAnimais.DefaultCellStyle.BackColor = Color.FromArgb(229, 230, 220);
                dgvAnimais.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvAnimais.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
        }

        // PlaceHolder da txtPesquisar

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == " Pesquisar")
            {
                txtPesquisar.Text = " ";
            }
        }

        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisar.Text))
            {
                txtPesquisar.Text = " Pesquisar";
            }
        }

        private void ResetDGV(bool resetxt) // Reset na DataGridView
        {
            if (resetxt)
                txtPesquisar.Text = " ";
            foreach (DataGridViewRow row in dgvAnimais.Rows)
            {
                row.Visible = true;
            }
            // Reset de Linha Selecionada
            dgvAnimais.CurrentCell = null;
            dgvAnimais.ClearSelection();
            if (dgvAnimais.Rows.Count > 0)
                dgvAnimais.Rows[0].Cells[0].Selected = true;
        }

        public static int LinhasVisiveis(DataGridView dgv) // verifica as linhas visiveis na dgv
        {
            int count = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Visible)
                    count++;
            }
            return count;
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e) // Rever Código necessário
        {
            if (e.KeyCode == Keys.Enter) // Clica Enter
            {
                string pesquisa = txtPesquisar.Text.Trim().ToLower(); // Recebe e trata os dados string

                if (pesquisa == "")
                {
                    ResetDGV(true); // Deixa tudo visivel
                }
                else
                {
                    ResetDGV(false); // Para que a pesquisa seja eficaz é necessário que a linha selecionada comece do inicio
                    foreach (DataGridViewRow row in dgvAnimais.Rows) // Itera todas as linhas da Dgv
                    {
                        bool verificacao = false; // quando a pesquisa é correspondente aos dados da linha passa a true;

                        foreach (DataGridViewCell cell in row.Cells) // Itera todas as células da linha para efeitos de pesquisa
                        {
                            if (cell.Value != null && pesquisa.Contains(cell.Value.ToString().ToLower()))
                            {
                                verificacao = true;
                                break; // dá break visto que esta linha já contem os dados de pesquisa
                            }
                        }

                        // Quando tentamos remover a linha que por default está selecionada gera um erro
                        // para isso verificamos se os index's são correpondentes
                        if (dgvAnimais.CurrentRow.Index == row.Index && verificacao == false)
                        {
                            int linhaselecionada = dgvAnimais.CurrentRow.Index;
                            if (LinhasVisiveis(dgvAnimais) > 1)
                            {
                                // Para que a pesquisa seja feita de forma eficaz temos de verificar temo de remover
                                // todas as linhas não correspondentes então vamos fazer com que a linha selecionada
                                // ande 1 index para a frente podendo depois remover a linha não verificada
                                dgvAnimais.CurrentCell = null;
                                dgvAnimais.ClearSelection();
                                dgvAnimais.Rows[linhaselecionada + 1].Cells[0].Selected = true;
                                row.Visible = verificacao;
                            }
                            else  
                            {
                                // quando entramos aqui é quando temos apenas uma linha na dgv e que não correponde á pesquisa
                                // nesse caso não existe resultados da pesquisa...
                                ResetDGV(true);
                                MessageBox.Show("A pesquisa não obteve resultados.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                            row.Visible = verificacao;
                    }
                }  
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvAnimais.Rows.Count > 0)
            {
                Animal animal = dgvAnimais.CurrentRow.DataBoundItem as Animal; // Obtem os dados da linha atual
                int i = Clinica.animallist.IndexOf(animal); // retorna -1 quando não encontra o animal
                if (i < 0)
                {
                    MessageBox.Show("Animal não encontrado na lista...", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string msg = "Deseja remover o " + animal.Tipo + " " + animal.Nome + "?";
                DialogResult resultado = MessageBox.Show(msg, Clinica.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (LinhasVisiveis(dgvAnimais) == 1)
                    ResetDGV(false);
                if (resultado == DialogResult.Yes) // Quando removemos a unica linha visivel na dgv
                {
                    if (animal.dono.Animais.Count == 1)
                    {
                        Pessoa.NICs.Remove(animal.dono.NIC);
                        Clinica.UpdateNIClistFiles();
                    }
                    Clinica.animallist.RemoveAt(i);
                    Clinica.UpdateAnimalistFiles();
                }
            }
            else
            {
                MessageBox.Show("Não pode remover animais inexistentes.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmEditAnimais form = new frmEditAnimais(true);
            form.ShowDialog();
            form.Dispose();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (dgvAnimais.Rows.Count > 0)
            {
                Animal anml = dgvAnimais.CurrentRow.DataBoundItem as Animal;
                frmEditAnimais form = new frmEditAnimais(false, anml.ID);
                form.ShowDialog();
                dgvAnimais.Refresh();
                form.Dispose();
            }
            else
            {
                MessageBox.Show("Não pode consultar animais inexistentes.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
