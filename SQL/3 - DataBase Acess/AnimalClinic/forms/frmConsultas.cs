using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using MailKit.Net.Smtp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AnimalClinic.forms
{
    public partial class frmConsultas : Form
    {
        BaseDados bd = new BaseDados();
        public frmConsultas()
        {
            InitializeComponent();
        }

        public void LoadTema()
        {
            dgvConsultas.DefaultCellStyle.SelectionBackColor = Cores.CorDefenida;
            btnRemover.BackColor = Cores.CorDefenida;
            btnNovo.BackColor = Cores.CorDefenida;
            lblConsultas.ForeColor = Cores.CorDefenida;
            if (MainForm.TemaAtual)
            {
                BackColor = Color.Gainsboro;
                dgvConsultas.BackgroundColor = Color.FromArgb(201, 201, 201);
                dgvConsultas.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvConsultas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.FromArgb(46, 50, 58);
                dgvConsultas.BackgroundColor = Color.FromArgb(72, 76, 82);
                dgvConsultas.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvConsultas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void frmRececionistacs_Load(object sender, EventArgs e)
        {
            LoadTema();
            dgvConsultas.DataSource = bd.executeReturnDataQuery("SELECT * FROM Consultas");
        }

        private void frmRececionistas_VisibleChanged(object sender, EventArgs e)
        {
            frmRececionistacs_Load(sender, e);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmEditConsultas form = new frmEditConsultas();
            form.ShowDialog();
            frmRececionistacs_Load(sender, e);
            form.Dispose();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvConsultas.Rows.Count > 0)
            {
                DataRowView consultasRowView = dgvConsultas.CurrentRow.DataBoundItem as DataRowView; // Obtem os dados da linha atual

                DataRow consulta = consultasRowView.Row;

                string msg = "Deseja remover a consulta selecionada?";
                DialogResult resultado = MessageBox.Show(msg, Clinica.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes) // Quando removemos a unica linha visivel na dgv
                {
                    bd.executeQuery("DELETE FROM Consultas WHERE id = " + consulta["id"].ToString());
                    frmRececionistacs_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Não pode remover consultas inexistentes.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}