using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Biblioteca
{
    public partial class Frm_Leitores : Form
    {
        public Frm_Leitores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
            catch (Exception)
            {

            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Base_Dados bd = new Base_Dados();

            // testar se o leitor já está guardado na BD
            DataTable dados = bd.devolver_consulta("select count(N_processo) from leitores where N_processo = '" + txt_n_processo.Text + "'");
            if (dados.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("O Aluno já existe", "Biblioteca Escolar",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            errorProvider1.Dispose();
            bool erro = false;

            // testar as restrições
            if(txt_nome.Text == "")
            {
                errorProvider1.SetError(txt_nome, "O nome é obrigatório");
                erro = true;    
            }
            if(txt_cc.Text.Length != 8)
            {
                errorProvider1.SetError(txt_cc, "O CC tem que ter 8 digitos");
                erro = true;
            }
            if (txt_email.Text.Contains('@') == false || txt_email.Text.Contains('.') == false || !(txt_email.Text.IndexOf('@') < txt_email.Text.IndexOf('.'))) 
            {
                errorProvider1.SetError(txt_email, "O Email tem que ter '@' e um '.' a seguir");
                erro = true;
            }
            string telefone = txt_telefone.Text;
            if (telefone[0] != '9' || (telefone[1] != '1' && telefone[1] != '2' && telefone[1] != '3' && telefone[1] != '6'))
            {
                errorProvider1.SetError(txt_telefone, "O número de telefone está incorreto");
                erro = true;
            }
            if(txt_n_processo.Text.IndexOf('a') != 0)
            {
                errorProvider1.SetError(txt_n_processo, "O número do processo do aluno tem que começar por 'a'");
                erro = true;
            }

            if (erro) return;

            // Gravar os dados do leitor na BD

            // Copiar a foto do leitor para a pasta
            File.Copy(openFileDialog1.FileName, Application.StartupPath + @"\Fotos_Leitores\" + txt_n_processo.Text + "." +openFileDialog1.FileName.Split('.')[1]);

            // Instrução de SQL com os valores a inserir na tabela
            string sql_text = "Insert into Leitores(N_processo,Nome,CC,Email,Telemovel,Data_nascimento,Nome_foto,morada,cod_postal)";
            sql_text += "values (@N_processo,@Nome,@CC,@Email,@Telemovel,@Data_nascimento,@Nome_foto,@morada,@cod_postal)";

            // Associar os parametros aos valores inseridos pelo utilizador
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@N_processo", txt_n_processo.Text));
            parametros.Add(new SqlParameter("@Nome", txt_nome.Text));
            parametros.Add(new SqlParameter("@CC", txt_cc.Text));
            parametros.Add(new SqlParameter("@Email", txt_email.Text));
            parametros.Add(new SqlParameter("@Telemovel", txt_telefone.Text));
            parametros.Add(new SqlParameter("@Data_nascimento", DateTime.Parse(dateTimePicker1.Text)));
            parametros.Add(new SqlParameter("@Nome_foto", txt_n_processo.Text +"."+ openFileDialog1.FileName.Split('.')[1]));
            parametros.Add(new SqlParameter("@Morada", txt_morada.Text));
            parametros.Add(new SqlParameter("@Cod_postal", maskedTextBox1.Text));

            // executar o método da classe Basa_Dados para guardar os dados na BD
            bd.executar_sql(sql_text, parametros);
        }

        private void Frm_Leitores_Load(object sender, EventArgs e)
        {

        }
    }
}
