using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Biblioteca
{
    public partial class Frm_Livro : Form
    {
        string Id_livro;
        Base_Dados bd = new Base_Dados();
        public Frm_Livro(string id_livro)
        {
            InitializeComponent();
            Id_livro = id_livro;
        }

        private void Frm_Livro_Load(object sender, EventArgs e)
        {
            // Testar se o utilizador quer editar ou inserir um livro
            if(Id_livro!=null)
            {
               DataTable dados_livro= bd.devolver_consulta("select * from livros where id=" + Id_livro);
                // preencher os campos do livro
                txt_autor.Text = dados_livro.Rows[0][3].ToString();
                txt_cota.Text = dados_livro.Rows[0][8].ToString();
                txt_titulo.Text= dados_livro.Rows[0][2].ToString();

                // carregar a foto da capa do livro

                try
                {
                    byte[] foto = (byte[])dados_livro.Rows[0][13];
                    FileStream imagem = new FileStream("imagem_temp.jpg", FileMode.Create, FileAccess.Write);
                    imagem.Write(foto, 0, foto.GetUpperBound(0));
                    imagem.Close();
                    pictureBox1.Image = Image.FromFile("imagem_temp.jpg");
                }
                catch (Exception)
                {
                    pictureBox1.Load(Application.StartupPath + @"\capa_padrao.jpg");
                }
               

                //...
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Load(openFileDialog1.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Testar se o utilizador quer inserir ou editar o livro
            if (Id_livro == null)
            {
                /* Testar se o livro já está guardado na BD
                DataTable dados = bd.devolver_consulta("select count(ISBN) from livros where ISBN = '" + txt_isbn.Text + "'");
                if (dados.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("O Livro já existe", "Biblioteca Escolar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }*/

                ok_mano.Dispose();
                bool erro = false;

                // Testar as restrições

                if (txt_titulo.Text == "")
                {
                    ok_mano.SetError(txt_titulo, "O Titulo é obrigatório");
                    erro = true;
                }

                if (erro) return;

                // Gravar os dados do leitor na BD

                // Copiar a foto para a tabela em formato binário
                FileStream imagem = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                byte[] dados_img = new byte[imagem.Length];
                imagem.Read(dados_img, 0, (int)imagem.Length);
                imagem.Close();

                // Instrução de SQL com os valores a inserir na tabela
                string dados_sql = "Insert into Livros(ISBN, Titulo, Autor, Sinopese, Idioma, Genero, Editora, Cota, KeyWords, Ano_edicao, Data_aquisicao, Capa, Braille)";
                dados_sql += "values (@ISBN, @Titulo, @Autor, @Sinopese, @Idioma, @Genero, @Editora, @Cota, @KeyWords, @Ano_edicao, @Data_aquisicao, @Capa, @Braille)";

                // Associar os parametros aos valores inseridos pelo utilizador
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@ISBN", txt_isbn.Text));
                parametros.Add(new SqlParameter("@Titulo", txt_titulo.Text));
                parametros.Add(new SqlParameter("@Autor", txt_autor.Text));
                parametros.Add(new SqlParameter("@Sinopese", txt_sinopese.Text));
                parametros.Add(new SqlParameter("@Idioma", cmb_idioma.SelectedItem.ToString()));
                parametros.Add(new SqlParameter("@Genero", cmb_genero.SelectedItem.ToString()));
                parametros.Add(new SqlParameter("@Editora", txt_editora.Text));
                parametros.Add(new SqlParameter("@Cota", txt_cota.Text));
                parametros.Add(new SqlParameter("@KeyWords", txt_keywords.Text));
                parametros.Add(new SqlParameter("@Ano_edicao", maskedTextBox2.Text));
                parametros.Add(new SqlParameter("@Data_aquisicao", DateTime.Parse(dateTimePicker1.Text)));
                parametros.Add(new SqlParameter("@Capa", dados_img));
                parametros.Add(new SqlParameter("@Braille", chb_braille.Checked.ToString()));


                /*String dados_sql = "Insert into Livros(ISBN, Titulo, Capa) values('@ISBN,@titulo,@capa)";
                parametros.Add(new SqlParameter("@ISBN", "123-2-3445-4566-5"));
                parametros.Add(new SqlParameter("@titulo", "O Miranha"));
                parametros.Add(new SqlParameter("@capa", dados_img));*/

                // executar o método da classe Basa_Dados para guardar os dados na BD
                bd.executar_sql(dados_sql, parametros);
            }

            else
            {
                // Copiar a foto para a tabela em formato binário
                byte[] dados_img=null;
                try
                {
                    FileStream imagem = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    dados_img = new byte[imagem.Length];
                    imagem.Read(dados_img, 0, (int)imagem.Length);
                    imagem.Close();
                }
                catch (Exception)
                {

                }
               
                // Instrução de SQL com os valores a inserir na tabela
                string dados_sql = "update Livros set ISBN=@ISBN, Titulo=@Titulo, Autor=@Autor, Sinopese=@Sinopese, Idioma= @Idioma, Genero=@Genero, Editora=@Editora, Cota=@Cota, KeyWords=Keywords, Ano_edicao=@ano_edicao, Data_aquisicao=@data_aquisicao, Capa=@capa, braille=@Braille where id=" + Id_livro;
              

                // Associar os parametros aos valores inseridos pelo utilizador
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@ISBN", txt_isbn.Text));
                parametros.Add(new SqlParameter("@Titulo", txt_titulo.Text));
                parametros.Add(new SqlParameter("@Autor", txt_autor.Text));
                parametros.Add(new SqlParameter("@Sinopese", txt_sinopese.Text));
                parametros.Add(new SqlParameter("@Idioma", cmb_idioma.SelectedItem.ToString()));
                parametros.Add(new SqlParameter("@Genero", cmb_genero.SelectedItem.ToString()));
                parametros.Add(new SqlParameter("@Editora", txt_editora.Text));
                parametros.Add(new SqlParameter("@Cota", txt_cota.Text));
                parametros.Add(new SqlParameter("@KeyWords", txt_keywords.Text));
                parametros.Add(new SqlParameter("@Ano_edicao", maskedTextBox2.Text));
                parametros.Add(new SqlParameter("@Data_aquisicao", DateTime.Parse(dateTimePicker1.Text)));
                parametros.Add(new SqlParameter("@Capa", dados_img));
                parametros.Add(new SqlParameter("@Braille", chb_braille.Checked.ToString()));


                /*String dados_sql = "Insert into Livros(ISBN, Titulo, Capa) values('@ISBN,@titulo,@capa)";
                parametros.Add(new SqlParameter("@ISBN", "123-2-3445-4566-5"));
                parametros.Add(new SqlParameter("@titulo", "O Miranha"));
                parametros.Add(new SqlParameter("@capa", dados_img));*/

                // executar o método da classe Basa_Dados para guardar os dados na BD
                bd.executar_sql(dados_sql, parametros);

                MessageBox.Show("Os dados do Livro foram atualizados com sucesso", "Editar Livro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
