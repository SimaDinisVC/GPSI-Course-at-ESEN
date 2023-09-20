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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            dgvRececionistas.DataSource = Clinica.rececionistalist;
            dgvMedicos.DataSource = Clinica.medicolist;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

            LoadTema();

            // Definições da datagridview Rececionistas
            dgvRececionistas.Columns["NIC"].Width = 56;
            dgvRececionistas.Columns["NIC"].Resizable = DataGridViewTriState.False;
            dgvRececionistas.Columns["NIC"].DefaultCellStyle.BackColor = Color.LightBlue;
            dgvRececionistas.Columns["Nome"].MinimumWidth = 73;
            dgvRececionistas.Columns["Idade"].Width = 30;
            dgvRececionistas.Columns["Idade"].MinimumWidth = 50;
            dgvRececionistas.Columns["Idade"].Resizable = DataGridViewTriState.False;
            dgvRececionistas.Columns["Data_Nasc"].Visible = false;
            dgvRececionistas.Columns["Morada"].Visible = false;
            dgvRececionistas.Columns["Password"].Visible = false;
            dgvRececionistas.Columns["Status"].Visible = false;
            dgvRececionistas.Columns.RemoveAt(0); // esconde a coluna status

            // Definições da datagridview Médicos
            dgvMedicos.Columns["NIC"].Width = 56;
            dgvMedicos.Columns["NIC"].Resizable = DataGridViewTriState.False;
            dgvMedicos.Columns["NIC"].DefaultCellStyle.BackColor = Color.LightBlue;
            dgvMedicos.Columns["Nome"].MinimumWidth = 73;
            dgvMedicos.Columns["Idade"].Width = 30;
            dgvMedicos.Columns["Idade"].MinimumWidth = 50;
            dgvMedicos.Columns["Idade"].Resizable = DataGridViewTriState.False;
            dgvMedicos.Columns["Data_Nasc"].Visible = false;
            dgvMedicos.Columns["Morada"].Visible = false;
            dgvMedicos.Columns["Password"].Visible = false;
            dgvMedicos.Columns["Status"].Visible = false;
            dgvMedicos.Columns.RemoveAt(0); // esconde a coluna status
        }

        public void LoadTema()
        {
            lblMedicos.ForeColor = Cores.CorDefenida;
            lblRececionistas.ForeColor = Cores.CorDefenida;
            btnRemover.BackColor = Cores.CorDefenida;
            btnNovo.BackColor = Cores.CorDefenida;
            btnConsulta.BackColor = Cores.CorDefenida;
            dgvRececionistas.DefaultCellStyle.SelectionBackColor = Cores.CorDefenida;
            dgvRececionistas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMedicos.DefaultCellStyle.SelectionBackColor = Cores.CorDefenida;
            dgvMedicos.DefaultCellStyle.SelectionForeColor = Color.White;

            if (MainForm.TemaAtual == false)
            {
                BackColor = Color.FromArgb(46, 50, 58);
                dgvRececionistas.BackgroundColor = Color.FromArgb(72, 76, 82);
                dgvRececionistas.DefaultCellStyle.BackColor = Color.FromArgb(197, 199, 201);
                dgvRececionistas.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvRececionistas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvMedicos.BackgroundColor = Color.FromArgb(72, 76, 82);
                dgvMedicos.DefaultCellStyle.BackColor = Color.FromArgb(197, 199, 201);
                dgvMedicos.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvMedicos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                BackColor = Color.Gainsboro;
                dgvRececionistas.BackgroundColor = Color.FromArgb(201, 201, 201);
                dgvRececionistas.DefaultCellStyle.BackColor = Color.FromArgb(229, 230, 220);
                dgvRececionistas.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvRececionistas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvMedicos.BackgroundColor = Color.FromArgb(201, 201, 201);
                dgvMedicos.DefaultCellStyle.BackColor = Color.FromArgb(229, 230, 220);
                dgvMedicos.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvMedicos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void frmAdmin_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
                LoadTema();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvRececionistas.Rows.Count > 0 || dgvMedicos.Rows.Count > 0)
            {
                Rececionista rececionista;
                Medico medico;
                if (dgvRececionistas.CurrentRow != null && dgvMedicos.CurrentRow == null)
                {
                    rececionista = dgvRececionistas.CurrentRow.DataBoundItem as Rececionista;
                    int i = Clinica.rececionistalist.IndexOf(rececionista); // retorna -1 quando não encontra o funcionário
                    if (i < 0)
                    {
                        MessageBox.Show("Rececionista não encontrado na lista...", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string msg = "Deseja remover o Rececionista " + rececionista.Nome + "?";
                    DialogResult resultado = MessageBox.Show(msg, Clinica.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes) // Quando removemos a unica linha visivel na dgv
                    {
                        if (dgvRececionistas.Rows.Count == 1 && dgvMedicos.Rows.Count > 0)
                            dgvMedicos.Rows[0].Cells[0].Selected = true;
                        else if (dgvRececionistas.Rows.Count == 1 && dgvMedicos.Rows.Count == 0)
                        {
                            dgvMedicos.CurrentCell = null;
                            dgvMedicos.ClearSelection();
                            dgvRececionistas.CurrentCell = null;
                            dgvRececionistas.ClearSelection();
                        }
                        Pessoa.NICs.Remove(rececionista.NIC);
                        Clinica.rececionistalist.RemoveAt(i);
                    }
                }
                else if (dgvRececionistas.CurrentRow == null && dgvMedicos.CurrentRow != null)
                {
                    medico = dgvMedicos.CurrentRow.DataBoundItem as Medico;
                    int i = Clinica.medicolist.IndexOf(medico); // retorna -1 quando não encontra o funcionário
                    if (i < 0)
                    {
                        MessageBox.Show("Médico não encontrado na lista...", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string msg = "Deseja remover o Dr. " + medico.Nome + "?";
                    DialogResult resultado = MessageBox.Show(msg, Clinica.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes) // Quando removemos a unica linha visivel na dgv
                    {
                        if (dgvMedicos.Rows.Count == 1 && dgvRececionistas.Rows.Count > 0)
                            dgvRececionistas.Rows[0].Cells[0].Selected = true;
                        else if (dgvMedicos.Rows.Count == 1 && dgvRececionistas.Rows.Count == 0)
                        {
                            dgvMedicos.CurrentCell = null;
                            dgvMedicos.ClearSelection();
                            dgvRececionistas.CurrentCell = null;
                            dgvRececionistas.ClearSelection();
                        }
                        Pessoa.NICs.Remove(medico.NIC);
                        Clinica.medicolist.RemoveAt(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não pode remover funcionários inexistentes.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmEditAdmin frm = new frmEditAdmin(true);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (dgvRececionistas.Rows.Count > 0 || dgvMedicos.Rows.Count > 0)
            {
                int index = 0;
                string NIC;
                if (dgvRececionistas.CurrentRow != null)
                    NIC = ((Pessoa)dgvRececionistas.CurrentRow.DataBoundItem).NIC;
                else if (dgvMedicos.CurrentRow != null)
                {
                    index = 1;
                    NIC = ((Pessoa)dgvMedicos.CurrentRow.DataBoundItem).NIC;
                }
                else
                {
                    MessageBox.Show("Selecione uma pessoa.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frmEditAdmin frm = new frmEditAdmin(false, NIC, index);
                frm.ShowDialog();
                dgvRececionistas.Refresh();
                dgvMedicos.Refresh();
                frm.Dispose();
            }
            else
            {
                MessageBox.Show("Não pode consultar funcionários inexistentes.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Seleção entre dgv's

        private void dgvRececionistas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRececionistas.SelectedRows.Count > 0)
            {
                dgvMedicos.CurrentCell = null;
                dgvMedicos.ClearSelection();
            }
        }

        private void dgvMedicos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count > 0)
            {
                dgvRececionistas.CurrentCell = null;
                dgvRececionistas.ClearSelection();
            }
        }
    }
}
