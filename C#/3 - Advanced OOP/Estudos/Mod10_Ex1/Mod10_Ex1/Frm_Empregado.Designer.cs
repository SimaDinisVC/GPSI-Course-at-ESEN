
namespace Mod10_Ex1
{
    partial class Frm_Empregado
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_cargo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_especialidade = new System.Windows.Forms.TextBox();
            this.chk_editar = new System.Windows.Forms.CheckBox();
            this.grb_morada = new System.Windows.Forms.GroupBox();
            this.txt_localidade = new System.Windows.Forms.TextBox();
            this.txt_codpostal = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnl_programador = new System.Windows.Forms.Panel();
            this.pnl_analista = new System.Windows.Forms.Panel();
            this.grb_morada.SuspendLayout();
            this.pnl_analista.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargo";
            // 
            // Cmb_cargo
            // 
            this.Cmb_cargo.FormattingEnabled = true;
            this.Cmb_cargo.Location = new System.Drawing.Point(55, 24);
            this.Cmb_cargo.Name = "Cmb_cargo";
            this.Cmb_cargo.Size = new System.Drawing.Size(121, 21);
            this.Cmb_cargo.TabIndex = 1;
            this.Cmb_cargo.SelectedIndexChanged += new System.EventHandler(this.Cmb_cargo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(55, 60);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(398, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(55, 103);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(213, 20);
            this.txt_email.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 106);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 5;
            this.Email.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Nasc";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtp_data
            // 
            this.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data.Location = new System.Drawing.Point(329, 145);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(124, 20);
            this.dtp_data.TabIndex = 9;
            this.dtp_data.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Especialidade";
            // 
            // txt_especialidade
            // 
            this.txt_especialidade.Location = new System.Drawing.Point(133, 21);
            this.txt_especialidade.Name = "txt_especialidade";
            this.txt_especialidade.Size = new System.Drawing.Size(310, 20);
            this.txt_especialidade.TabIndex = 11;
            // 
            // chk_editar
            // 
            this.chk_editar.AutoSize = true;
            this.chk_editar.Location = new System.Drawing.Point(372, 19);
            this.chk_editar.Name = "chk_editar";
            this.chk_editar.Size = new System.Drawing.Size(53, 17);
            this.chk_editar.TabIndex = 12;
            this.chk_editar.Text = "Editar";
            this.chk_editar.UseVisualStyleBackColor = true;
            // 
            // grb_morada
            // 
            this.grb_morada.Controls.Add(this.txt_localidade);
            this.grb_morada.Controls.Add(this.txt_codpostal);
            this.grb_morada.Controls.Add(this.txt_rua);
            this.grb_morada.Location = new System.Drawing.Point(66, 246);
            this.grb_morada.Name = "grb_morada";
            this.grb_morada.Size = new System.Drawing.Size(387, 100);
            this.grb_morada.TabIndex = 13;
            this.grb_morada.TabStop = false;
            this.grb_morada.Text = "Morada";
            // 
            // txt_localidade
            // 
            this.txt_localidade.Location = new System.Drawing.Point(191, 61);
            this.txt_localidade.Name = "txt_localidade";
            this.txt_localidade.Size = new System.Drawing.Size(190, 20);
            this.txt_localidade.TabIndex = 2;
            // 
            // txt_codpostal
            // 
            this.txt_codpostal.Location = new System.Drawing.Point(7, 61);
            this.txt_codpostal.Name = "txt_codpostal";
            this.txt_codpostal.Size = new System.Drawing.Size(144, 20);
            this.txt_codpostal.TabIndex = 1;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(7, 20);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(374, 20);
            this.txt_rua.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(222, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(88, 20);
            this.txtID.TabIndex = 15;
            this.txtID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(371, 361);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(329, 361);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(36, 23);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // pnl_programador
            // 
            this.pnl_programador.Location = new System.Drawing.Point(45, 3);
            this.pnl_programador.Name = "pnl_programador";
            this.pnl_programador.Size = new System.Drawing.Size(398, 69);
            this.pnl_programador.TabIndex = 18;
            // 
            // pnl_analista
            // 
            this.pnl_analista.Controls.Add(this.pnl_programador);
            this.pnl_analista.Controls.Add(this.txt_especialidade);
            this.pnl_analista.Controls.Add(this.label5);
            this.pnl_analista.Location = new System.Drawing.Point(10, 168);
            this.pnl_analista.Name = "pnl_analista";
            this.pnl_analista.Size = new System.Drawing.Size(455, 78);
            this.pnl_analista.TabIndex = 19;
            // 
            // Frm_Empregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 396);
            this.Controls.Add(this.pnl_analista);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grb_morada);
            this.Controls.Add(this.chk_editar);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_cargo);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Empregado";
            this.Text = "Empregado";
            this.grb_morada.ResumeLayout(false);
            this.grb_morada.PerformLayout();
            this.pnl_analista.ResumeLayout(false);
            this.pnl_analista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_cargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_especialidade;
        private System.Windows.Forms.CheckBox chk_editar;
        private System.Windows.Forms.GroupBox grb_morada;
        private System.Windows.Forms.TextBox txt_localidade;
        private System.Windows.Forms.TextBox txt_codpostal;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnl_programador;
        private System.Windows.Forms.Panel pnl_analista;
    }
}