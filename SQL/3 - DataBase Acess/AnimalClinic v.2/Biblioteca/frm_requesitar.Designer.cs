
namespace Biblioteca
{
    partial class frm_requesitar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_idLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_autor = new System.Windows.Forms.Label();
            this.lbl_turma = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_CC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nprocesso = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_autor);
            this.groupBox1.Controls.Add(this.lbl_Titulo);
            this.groupBox1.Controls.Add(this.lbl_ISBN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_idLivro);
            this.groupBox1.Location = new System.Drawing.Point(51, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Livro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_turma);
            this.groupBox2.Controls.Add(this.lbl_nome);
            this.groupBox2.Controls.Add(this.lbl_CC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_nprocesso);
            this.groupBox2.Location = new System.Drawing.Point(51, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Aluno";
            // 
            // txt_idLivro
            // 
            this.txt_idLivro.Location = new System.Drawing.Point(96, 43);
            this.txt_idLivro.Name = "txt_idLivro";
            this.txt_idLivro.Size = new System.Drawing.Size(116, 20);
            this.txt_idLivro.TabIndex = 0;
            this.txt_idLivro.TextChanged += new System.EventHandler(this.txt_idLivro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id_Livro";
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ISBN.Location = new System.Drawing.Point(21, 88);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(46, 18);
            this.lbl_ISBN.TabIndex = 2;
            this.lbl_ISBN.Text = "ISBN:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(211, 88);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(45, 18);
            this.lbl_Titulo.TabIndex = 3;
            this.lbl_Titulo.Text = "Tituo:";
            // 
            // lbl_autor
            // 
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_autor.Location = new System.Drawing.Point(424, 88);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(47, 18);
            this.lbl_autor.TabIndex = 4;
            this.lbl_autor.Text = "Autor:";
            // 
            // lbl_turma
            // 
            this.lbl_turma.AutoSize = true;
            this.lbl_turma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turma.Location = new System.Drawing.Point(424, 94);
            this.lbl_turma.Name = "lbl_turma";
            this.lbl_turma.Size = new System.Drawing.Size(49, 18);
            this.lbl_turma.TabIndex = 9;
            this.lbl_turma.Text = "Email:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(203, 94);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(53, 18);
            this.lbl_nome.TabIndex = 8;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_CC
            // 
            this.lbl_CC.AutoSize = true;
            this.lbl_CC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CC.Location = new System.Drawing.Point(22, 94);
            this.lbl_CC.Name = "lbl_CC";
            this.lbl_CC.Size = new System.Drawing.Size(34, 18);
            this.lbl_CC.TabIndex = 7;
            this.lbl_CC.Text = "CC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nº Processo";
            // 
            // txt_nprocesso
            // 
            this.txt_nprocesso.Location = new System.Drawing.Point(121, 46);
            this.txt_nprocesso.Name = "txt_nprocesso";
            this.txt_nprocesso.Size = new System.Drawing.Size(116, 20);
            this.txt_nprocesso.TabIndex = 5;
            this.txt_nprocesso.TextChanged += new System.EventHandler(this.txt_nprocesso_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(656, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Requisitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_requesitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_requesitar";
            this.Text = "frm_requesitar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idLivro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_turma;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_CC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nprocesso;
        private System.Windows.Forms.Button button1;
    }
}