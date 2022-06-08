namespace FirstAPP
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.tbn_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Cota = new System.Windows.Forms.Label();
            this.tbn_Cota = new System.Windows.Forms.TextBox();
            this.chk_Sócio = new System.Windows.Forms.CheckBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Sobre = new System.Windows.Forms.Button();
            this.btn_Ajuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(106, 64);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(43, 15);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome:";
            // 
            // tbn_Nome
            // 
            this.tbn_Nome.Location = new System.Drawing.Point(170, 61);
            this.tbn_Nome.Name = "tbn_Nome";
            this.tbn_Nome.Size = new System.Drawing.Size(223, 23);
            this.tbn_Nome.TabIndex = 1;
            // 
            // lbl_Cota
            // 
            this.lbl_Cota.AutoSize = true;
            this.lbl_Cota.Location = new System.Drawing.Point(114, 107);
            this.lbl_Cota.Name = "lbl_Cota";
            this.lbl_Cota.Size = new System.Drawing.Size(35, 15);
            this.lbl_Cota.TabIndex = 2;
            this.lbl_Cota.Text = "Cota:";
            // 
            // tbn_Cota
            // 
            this.tbn_Cota.Location = new System.Drawing.Point(170, 104);
            this.tbn_Cota.Name = "tbn_Cota";
            this.tbn_Cota.Size = new System.Drawing.Size(100, 23);
            this.tbn_Cota.TabIndex = 3;
            // 
            // chk_Sócio
            // 
            this.chk_Sócio.AutoSize = true;
            this.chk_Sócio.Location = new System.Drawing.Point(338, 108);
            this.chk_Sócio.Name = "chk_Sócio";
            this.chk_Sócio.Size = new System.Drawing.Size(55, 19);
            this.chk_Sócio.TabIndex = 4;
            this.chk_Sócio.Text = "Sócio";
            this.chk_Sócio.UseVisualStyleBackColor = true;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(318, 187);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(237, 187);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "&Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            // 
            // btn_Sobre
            // 
            this.btn_Sobre.Location = new System.Drawing.Point(156, 187);
            this.btn_Sobre.Name = "btn_Sobre";
            this.btn_Sobre.Size = new System.Drawing.Size(75, 23);
            this.btn_Sobre.TabIndex = 7;
            this.btn_Sobre.Text = "Sobre";
            this.btn_Sobre.UseVisualStyleBackColor = true;
            this.btn_Sobre.Click += new System.EventHandler(this.btn_Sobre_Click);
            // 
            // btn_Ajuda
            // 
            this.btn_Ajuda.Location = new System.Drawing.Point(74, 187);
            this.btn_Ajuda.Name = "btn_Ajuda";
            this.btn_Ajuda.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajuda.TabIndex = 8;
            this.btn_Ajuda.Text = "&Ajuda";
            this.btn_Ajuda.UseVisualStyleBackColor = true;
            this.btn_Ajuda.Click += new System.EventHandler(this.btn_Ajuda_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 241);
            this.Controls.Add(this.btn_Ajuda);
            this.Controls.Add(this.btn_Sobre);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.chk_Sócio);
            this.Controls.Add(this.tbn_Cota);
            this.Controls.Add(this.lbl_Cota);
            this.Controls.Add(this.tbn_Nome);
            this.Controls.Add(this.lbl_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Nome;
        private TextBox tbn_Nome;
        private Label lbl_Cota;
        private TextBox tbn_Cota;
        private CheckBox chk_Sócio;
        private Button btn_Sair;
        private Button btn_Calcular;
        private Button btn_Sobre;
        private Button btn_Ajuda;
    }
}