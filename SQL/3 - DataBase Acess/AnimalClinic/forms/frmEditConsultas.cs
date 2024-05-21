using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalClinic.forms
{
    public partial class frmEditConsultas : Form
    {
        private int consulta;
        private BaseDados bd = new BaseDados();

        public frmEditConsultas()
        {
            InitializeComponent();
                Text = "Nova Consulta";
                cmbID.DataSource = bd.executeReturnDataQuery("SELECT id FROM Animais");
                cmbID.DisplayMember = "id";
                cmbID.ValueMember = "id";
                cmbMedicos.DataSource = bd.executeReturnDataQuery("SELECT NIC FROM Medicos");
                cmbMedicos.DisplayMember = "NIC";
                cmbMedicos.ValueMember = "NIC";
                string idTest = bd.executeReturnDataQuery("SELECT MAX(id) FROM Consultas").Rows[0][0].ToString();
                int idseguinte;
                if (idTest == "")
                    idseguinte = 1;
                else
                    idseguinte = int.Parse(idTest) + 1;
                consulta = idseguinte;
            
        }

        private void frmEditConsultas_Load(object sender, EventArgs e)
        {
            lblConsulta.ForeColor = Cores.CorDefenida;
            cmbMedicos.ForeColor = Cores.CorDefenida;
            grpbxDetalhes.ForeColor = Cores.CorDefenida;
            txtAnimal.ForeColor = Cores.CorDefenida;
            dtpDataHora.MinDate = DateTime.Now;
            if (MainForm.TemaAtual)
            {
                BackColor = Color.FromArgb(168, 168, 168);
                btnCriar.BackColor = Color.FromArgb(167, 189, 201);
                lblID.ForeColor = Color.Black;
                lblAnimal.ForeColor = Color.Black;
                lblMedico.ForeColor = Color.Black;
                lblDataHora.ForeColor = Color.Black;
                cmbID.BackColor = Color.FromArgb(229, 230, 220);
                cmbMedicos.BackColor = Color.FromArgb(229, 230, 220);
                txtAnimal.BackColor = Color.FromArgb(229, 230, 220);
                txtDetalhes.BackColor = Color.FromArgb(229, 230, 220);
            }
        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAnimal.Text = bd.executeReturnDataQuery("SELECT nome FROM Animais WHERE id = " + cmbID.Text).Rows[0][0].ToString();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Consultas(dataHora, relatorio, Animal, Medico) VALUES (CONVERT(DATE, @dataHora, 103), @relatorio, @Animal, @Medico)";

            // Associar os parametros aos valores inseridos pelo utilizador
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@dataHora", dtpDataHora.Value.ToString("dd/MM/yyyy")));
            parametros.Add(new SqlParameter("@relatorio", txtDetalhes.Text));
            parametros.Add(new SqlParameter("@Animal", int.Parse(cmbID.Text)));
            parametros.Add(new SqlParameter("@Medico", int.Parse(cmbMedicos.Text)));

            // executar o método da classe Basa_Dados para guardar os dados na BD
            bd.executeParametersQuery(sql, parametros);

            Close();
        }
    }
}
