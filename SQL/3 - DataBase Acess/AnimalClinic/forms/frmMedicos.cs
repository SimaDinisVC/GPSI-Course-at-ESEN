using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using MailKit.Net.Smtp;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace AnimalClinic.forms
{
    public partial class frmMedicos : Form
    {
        BaseDados bd = new BaseDados();
        public frmMedicos()
        {
            InitializeComponent();
        }

        public void LoadTema()
        {
            btnRemover.BackColor = Cores.CorDefenida;
            btnNovo.BackColor = Cores.CorDefenida;
            btnConsulta.BackColor = Cores.CorDefenida;
            dgvMedicos.DefaultCellStyle.SelectionBackColor = Cores.CorDefenida;
            lblMedicos.ForeColor = Cores.CorDefenida;

            if (MainForm.TemaAtual)
            {
                BackColor = Color.Gainsboro;
                dgvMedicos.BackgroundColor = Color.FromArgb(201, 201, 201);
                dgvMedicos.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvMedicos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.FromArgb(46, 50, 58);
                dgvMedicos.BackgroundColor = Color.FromArgb(72, 76, 82);
                dgvMedicos.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvMedicos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            dgvMedicos.DataSource = bd.executeReturnDataQuery("SELECT * FROM Medicos");
            LoadTema();
        }

        private void frmMedicos_VisibleChanged(object sender, EventArgs e)
        {
            LoadTema();
            frmMedicos_Load(sender, e);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmEditMedicos form = new frmEditMedicos(true);
            form.ShowDialog();
            frmMedicos_Load(sender, e);
            form.Dispose();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.Rows.Count > 0)
            {
                DataRowView medicoRowView = dgvMedicos.CurrentRow.DataBoundItem as DataRowView; // Obtem os dados da linha atual

                DataRow medico = medicoRowView.Row;

                string msg = "Deseja remover o médico " + medico["nome"].ToString() + "?";
                DialogResult resultado = MessageBox.Show(msg, Clinica.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (resultado == DialogResult.Yes) // Quando removemos a unica linha visivel na dgv
                {

                    bd.executeQuery("DELETE FROM Medicos WHERE NIC = " + Convert.ToInt32(medico["NIC"].ToString()));
                    frmMedicos_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Não pode remover animais inexistentes.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.Rows.Count > 0)
            {
                DataRowView medicoRowView = dgvMedicos.CurrentRow.DataBoundItem as DataRowView; // Obtem os dados da linha atual

                DataRow medico = medicoRowView.Row;

                frmEditMedicos form = new frmEditMedicos(false, medico["NIC"].ToString());
                form.ShowDialog();
                frmMedicos_Load(sender, e);
                form.Dispose();
            }
            else
            {
                MessageBox.Show("Não pode consultar animais inexistentes.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
