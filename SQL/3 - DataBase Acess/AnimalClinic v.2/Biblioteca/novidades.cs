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

namespace Biblioteca
{
    public partial class novidades : Form
    {
        public novidades()
        {
            InitializeComponent();
        }

        private void novidades_Load(object sender, EventArgs e)
        {
            Base_Dados bd = new Base_Dados();

            // Pesquisar os livros que entraram no mês atual
            DataTable livros_recentes = bd.devolver_consulta("select isbn, autor,capa from livros where month(data_aquisicao)=month(getdate())");

            // Criar uma lista de objetos para mostrar os livros em forma de Card
            PictureBox[] img_capa = new PictureBox[livros_recentes.Rows.Count];
            Label[] lbl_autor = new Label[livros_recentes.Rows.Count];

            // Posição inicial dos cards no form
            int linha = 20;
            int coluna = 50;

            // adiconar os cards ao form
            for (int i = 0; i < livros_recentes.Rows.Count; i++)
            {

                // Foto da capa
                img_capa[i] = new PictureBox();
                img_capa[i].Location = new Point(coluna, linha);
                img_capa[i].Height = 200;
                img_capa[i].Width = 150;
                img_capa[i].SizeMode = PictureBoxSizeMode.StretchImage;
                try
                {
                    byte[] foto = (byte[])livros_recentes.Rows[0][2];
                    FileStream imagem = new FileStream("imagem_temp.jpg", FileMode.Create, FileAccess.Write);
                    imagem.Write(foto, 0, foto.GetUpperBound(0));
                    imagem.Close();
                    img_capa[i].Image = Image.FromFile("imagem_temp.jpg");
                }
                catch (Exception)
                {
                    img_capa[i].Image = Image.FromFile(Application.StartupPath + @"\capa_padrao.jpg"); 
                }

                // Nome do autor
                lbl_autor[i] = new Label();
                lbl_autor[i].Location = new Point(coluna, linha+220);
                lbl_autor[i].Height = 200;
                lbl_autor[i].Width = 150;
                lbl_autor[i].Text = livros_recentes.Rows[i][1].ToString();

                // Adiconar os objetos ao form
                this.Controls.Add(img_capa[i]);
                this.Controls.Add(lbl_autor[i]);

                coluna += 250;

                if (i+1 % 4 == 0) linha += 300;
            }
        }
    }
}
