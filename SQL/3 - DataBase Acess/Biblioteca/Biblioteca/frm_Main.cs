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

namespace Biblioteca
{
    public partial class frm_Main : Form
    {
        Base_Dados bd = new Base_Dados();

        public frm_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //bd.executar_sql("insert into Leitores(N_processo, Nome, CC, Email, Telemovel, Cod_Postal) values('a2277','Crazy Nando', '15146728', 'a22777@esenviseu.net', '962302300', '3500-132')");
           
            /*string sqlquery = "insert into Livros(ISBN, Titulo, Autor) values(@ISBN, @Titulo, @Autor)";
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@ISBN", "333-1-4444-4444-1"));
            parametros.Add(new SqlParameter("@Titulo", "Os Maias"));
            parametros.Add(new SqlParameter("@Autor", "Luis Vaz de Camões"));*/

            //bd.executar_sql(sqlquery, parametros);

            //dataGridView1.DataSource = bd.devolver_consulta("select * from Leitores");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bd.fechar_bd();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void autorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Livro frm = new Frm_Livro(null);
            frm.MdiParent = this;
            frm.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Leitores frm = new Frm_Leitores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listar_livros frm = new frm_listar_livros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frm_listar_livros frm = new frm_listar_livros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nomeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Mostrar_Leitores frm = new Mostrar_Leitores("Nome");
            frm.MdiParent = this;
            frm.Show();
        }

        private void cCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mostrar_Leitores frm = new Mostrar_Leitores("CC");
            frm.MdiParent = this;
            frm.Show();
        }

        private void nºProcessoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mostrar_Leitores frm = new Mostrar_Leitores("N_Processo");
            frm.MdiParent = this;
            frm.Show();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisar_autor frm = new pesquisar_autor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void palavraChaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesaquisa_palavrachave frm = new pesaquisa_palavrachave();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mais_lidos frm = new mais_lidos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void iBSNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novidades frm = new novidades();
            frm.MdiParent = this;
            frm.Show();
        }

        private void requisitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_requesitar frm = new frm_requesitar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void devolverLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_entregar frm = new frm_entregar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void históricoMovimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_historcomovimentos frm = new frm_historcomovimentos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void maisLidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mais_lidos frm = new mais_lidos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void porLeitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Por_Leitor frm = new Por_Leitor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void porLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Por_Livro frm = new Por_Livro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void porEntregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Por_Entregar frm = new Por_Entregar();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
