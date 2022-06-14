namespace ProjetoMOD8
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCarreira = new System.Windows.Forms.Label();
            this.dtpCarreira = new System.Windows.Forms.DateTimePicker();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.lblSalário = new System.Windows.Forms.Label();
            this.btnAvaliar = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.nud_SalárioM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SalárioM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Location = new System.Drawing.Point(39, 66);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(85, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(190, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblCarreira
            // 
            this.lblCarreira.AutoSize = true;
            this.lblCarreira.BackColor = System.Drawing.Color.Transparent;
            this.lblCarreira.Location = new System.Drawing.Point(39, 108);
            this.lblCarreira.Name = "lblCarreira";
            this.lblCarreira.Size = new System.Drawing.Size(112, 15);
            this.lblCarreira.TabIndex = 2;
            this.lblCarreira.Text = "Começo de Carreira";
            // 
            // dtpCarreira
            // 
            this.dtpCarreira.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCarreira.Location = new System.Drawing.Point(159, 102);
            this.dtpCarreira.MaxDate = new System.DateTime(2022, 6, 13, 0, 0, 0, 0);
            this.dtpCarreira.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpCarreira.Name = "dtpCarreira";
            this.dtpCarreira.Size = new System.Drawing.Size(116, 23);
            this.dtpCarreira.TabIndex = 3;
            this.dtpCarreira.Value = new System.DateTime(2022, 6, 13, 0, 0, 0, 0);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Location = new System.Drawing.Point(39, 149);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(44, 15);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade";
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Items.AddRange(new object[] {
            "Lisboa",
            "Porto",
            "Viseu",
            "Leiria"});
            this.cbxCidade.Location = new System.Drawing.Point(89, 146);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(186, 23);
            this.cbxCidade.TabIndex = 5;
            // 
            // lblSalário
            // 
            this.lblSalário.AutoSize = true;
            this.lblSalário.BackColor = System.Drawing.Color.Transparent;
            this.lblSalário.Location = new System.Drawing.Point(39, 188);
            this.lblSalário.Name = "lblSalário";
            this.lblSalário.Size = new System.Drawing.Size(83, 15);
            this.lblSalário.TabIndex = 6;
            this.lblSalário.Text = "Salário Mensal";
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAvaliar.Location = new System.Drawing.Point(331, 62);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(85, 23);
            this.btnAvaliar.TabIndex = 8;
            this.btnAvaliar.Text = "&Avaliar";
            this.btnAvaliar.UseVisualStyleBackColor = false;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculadora.Location = new System.Drawing.Point(331, 123);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(85, 23);
            this.btnCalculadora.TabIndex = 9;
            this.btnCalculadora.Text = "&Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = false;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(331, 186);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWelcome.Location = new System.Drawing.Point(39, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(377, 37);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Bem-Vindo(a) ";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.BackColor = System.Drawing.Color.Transparent;
            this.rdbMasculino.Location = new System.Drawing.Point(60, 221);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdbMasculino.TabIndex = 12;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = false;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.rdbMasculino_CheckedChanged);
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.BackColor = System.Drawing.Color.Transparent;
            this.rdbFeminino.Location = new System.Drawing.Point(169, 221);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(75, 19);
            this.rdbFeminino.TabIndex = 13;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = false;
            this.rdbFeminino.CheckedChanged += new System.EventHandler(this.rdbFeminino_CheckedChanged);
            // 
            // nud_SalárioM
            // 
            this.nud_SalárioM.Location = new System.Drawing.Point(124, 186);
            this.nud_SalárioM.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nud_SalárioM.Name = "nud_SalárioM";
            this.nud_SalárioM.Size = new System.Drawing.Size(151, 23);
            this.nud_SalárioM.TabIndex = 14;
            this.nud_SalárioM.Tag = "";
            this.nud_SalárioM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(464, 252);
            this.Controls.Add(this.nud_SalárioM);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.btnAvaliar);
            this.Controls.Add(this.lblSalário);
            this.Controls.Add(this.cbxCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.dtpCarreira);
            this.Controls.Add(this.lblCarreira);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avalidador de Salário do Programador";
            ((System.ComponentModel.ISupportInitialize)(this.nud_SalárioM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblCarreira;
        private DateTimePicker dtpCarreira;
        private Label lblCidade;
        private ComboBox cbxCidade;
        private Label lblSalário;
        private Button btnAvaliar;
        private Button btnCalculadora;
        private Button btnSair;
        private Label lblWelcome;
        private RadioButton rdbMasculino;
        private RadioButton rdbFeminino;
        private NumericUpDown nud_SalárioM;
    }
}