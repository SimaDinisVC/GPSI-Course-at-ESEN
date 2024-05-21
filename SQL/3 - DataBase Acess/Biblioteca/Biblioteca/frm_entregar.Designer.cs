
namespace Biblioteca
{
    partial class frm_entregar
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
            this.txt_nmovimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idlivro = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.btn_Devolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_idlivro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nmovimento);
            this.groupBox1.Location = new System.Drawing.Point(52, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Requisição";
            // 
            // txt_nmovimento
            // 
            this.txt_nmovimento.Location = new System.Drawing.Point(206, 44);
            this.txt_nmovimento.Name = "txt_nmovimento";
            this.txt_nmovimento.Size = new System.Drawing.Size(100, 20);
            this.txt_nmovimento.TabIndex = 0;
            this.txt_nmovimento.TextChanged += new System.EventHandler(this.txt_nmovimento_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Movimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "id Livro";
            // 
            // txt_idlivro
            // 
            this.txt_idlivro.Location = new System.Drawing.Point(444, 43);
            this.txt_idlivro.Name = "txt_idlivro";
            this.txt_idlivro.Size = new System.Drawing.Size(100, 20);
            this.txt_idlivro.TabIndex = 2;
            this.txt_idlivro.TextChanged += new System.EventHandler(this.txt_idlivro_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_data);
            this.groupBox2.Controls.Add(this.lbl_Titulo);
            this.groupBox2.Controls.Add(this.lbl_ISBN);
            this.groupBox2.Location = new System.Drawing.Point(52, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Livro";
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ISBN.Location = new System.Drawing.Point(22, 44);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(46, 18);
            this.lbl_ISBN.TabIndex = 1;
            this.lbl_ISBN.Text = "ISBN:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(303, 44);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(48, 18);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Titulo:";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(22, 94);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(121, 18);
            this.lbl_data.TabIndex = 3;
            this.lbl_data.Text = "Data Requisicão:";
            // 
            // btn_Devolver
            // 
            this.btn_Devolver.Enabled = false;
            this.btn_Devolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Devolver.Location = new System.Drawing.Point(52, 333);
            this.btn_Devolver.Name = "btn_Devolver";
            this.btn_Devolver.Size = new System.Drawing.Size(704, 43);
            this.btn_Devolver.TabIndex = 2;
            this.btn_Devolver.Text = "Devolver";
            this.btn_Devolver.UseVisualStyleBackColor = true;
            this.btn_Devolver.Click += new System.EventHandler(this.btn_Devolver_Click);
            // 
            // frm_entregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 423);
            this.Controls.Add(this.btn_Devolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_entregar";
            this.Text = "frm_entregar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idlivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nmovimento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Button btn_Devolver;
    }
}