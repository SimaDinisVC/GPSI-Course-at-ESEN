using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class frmEditConsultas : Form
    {
        private Animal animalatual;
        private List<Medico> mdcs;
        private Consulta consulta = null;

        public frmEditConsultas(bool consultar = false, Consulta consulta = null)
        {
            InitializeComponent();
            if (consultar)
            {
                this.consulta = consulta;
                Text = "Consulta";
                btnCriar.Text = "Finalizar";
                grpbxDetalhes.Text = "Relatório Final";
                cmbID.Enabled = false;
                cmbMedicos.Enabled = false;
                dtpDataHora.Enabled = false;
                cmbID.Text = consulta.Animal.ID.ToString();
                txtAnimal.Text = consulta.Animal.Nome;
                cmbMedicos.Text = Clinica.medicolist.FirstOrDefault(medico => medico.Consultas.Contains(consulta)).Nome;
                dtpDataHora.Value = consulta.DataeHora;
            }
            else
            {
                Text = "Nova Consulta";
            }
        }

        private void frmEditConsultas_Load(object sender, EventArgs e)
        {
            lblConsulta.ForeColor = Cores.CorDefenida;
            cmbMedicos.ForeColor = Cores.CorDefenida;
            grpbxDetalhes.ForeColor = Cores.CorDefenida;
            txtAnimal.ForeColor = Cores.CorDefenida;
            cmbID.DataSource = Clinica.IDAnimais;
            mdcs = mdcsDiposniveis();
            cmbMedicos.DataSource = mdcsNomes(mdcsDiposniveis());
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
            animalatual = Clinica.animallist.FirstOrDefault(anml => anml.ID == int.Parse(cmbID.SelectedItem.ToString()));
            txtAnimal.Text = animalatual.Nome.ToString();


            mdcs = mdcsDiposniveis();
            cmbMedicos.DataSource = mdcsNomes(mdcsDiposniveis());
        }

        private void dtpDataHora_ValueChanged(object sender, EventArgs e)
        {
            if (consulta == null)
            {
                Medico medicoanterior = mdcs[cmbMedicos.SelectedIndex];
                mdcs = mdcsDiposniveis();
                cmbMedicos.DataSource = mdcsNomes(mdcsDiposniveis());
                if (mdcs.Contains(medicoanterior))
                    cmbMedicos.SelectedIndex = mdcs.IndexOf(medicoanterior);
            }
        }

        private List<string> mdcsNomes(List<Medico> medicos)
        {
            if (medicos == null)
                return null;
            List<string> result = new List<string>();
            foreach (Medico m in medicos)
            {
                result.Add(m.Nome);
            }
            return result;
        }

        private List<Medico> mdcsDiposniveis()
        {
            List<Medico> filtradoTipo = Clinica.medicolist.Where(mdc => mdc.Especialidades.Contains(animalatual.Tipo)).ToList();
            List<Medico> mdcs = new List<Medico>();
            foreach (Medico medico in filtradoTipo)
            {
                bool ocupado = false;
                foreach (Consulta c in medico.Consultas)
                {
                    if (c.DataeHora == dtpDataHora.Value)
                        ocupado = true;
                }
                if (!ocupado)
                    mdcs.Add(medico);
            }
            if (mdcs.Count == 0)
                return null;
            return mdcs;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (Text == "Consulta")
            {
                consulta.Detalhes = txtDetalhes.Text;
                Clinica.medicolist.FirstOrDefault(medico => medico.Consultas.Contains(consulta)).Consultas.Remove(consulta);
                Close();
            }
            else
            {
                if (Clinica.IDAnimais.Count > 0 && cmbMedicos.DataSource != null)
                {
                    Consulta cnslt = new Consulta(animalatual, mdcs[cmbMedicos.SelectedIndex], dtpDataHora.Value);
                    cnslt.Detalhes = txtDetalhes.Text;
                    mdcs[cmbMedicos.SelectedIndex].Consultas.Add(cnslt);
                    Clinica.consultalist.Add(cnslt);
                    Clinica.UpdateConsultalistFiles();
                    Close();
                }
                else
                {
                    MessageBox.Show("Desculpe mas não é possivel criar a consulta.\nVerifique todos os campos.", Clinica.appname, MessageBoxButtons.OK); ;
                }
            }
        }
    }
}
