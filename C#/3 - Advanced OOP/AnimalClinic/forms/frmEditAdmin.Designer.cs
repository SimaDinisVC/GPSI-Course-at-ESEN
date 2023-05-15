namespace AnimalClinic.forms
{
    partial class frmEditAdmin
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
            this.cmbLocalidade = new System.Windows.Forms.ComboBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.grpbxMorada = new System.Windows.Forms.GroupBox();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEditar = new System.Windows.Forms.Label();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEspecializacao = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.btnCriar = new AnimalClinic.CostumButton();
            this.tglbtnEditar = new AnimalClinic.CostumToggleButton();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.grpbxMorada.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLocalidade
            // 
            this.cmbLocalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.cmbLocalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbLocalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLocalidade.ForeColor = System.Drawing.Color.White;
            this.cmbLocalidade.FormattingEnabled = true;
            this.cmbLocalidade.Items.AddRange(new object[] {
            "Aveiro",
            "Açores",
            "Beja",
            "Braga",
            "Bragança",
            "Castelo Branco",
            "Coimbra",
            "Évora",
            "Faro",
            "Guarda",
            "Leiria",
            "Lisboa",
            "Madeira",
            "Portalegre",
            "Porto",
            "Santarém",
            "Setúbal",
            "Viana do Castelo",
            "Vila Real",
            "Viseu"});
            this.cmbLocalidade.Location = new System.Drawing.Point(177, 120);
            this.cmbLocalidade.Name = "cmbLocalidade";
            this.cmbLocalidade.Size = new System.Drawing.Size(126, 30);
            this.cmbLocalidade.TabIndex = 23;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtCodigoPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoPostal.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.Location = new System.Drawing.Point(188, 80);
            this.txtCodigoPostal.MaxLength = 14;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(125, 24);
            this.txtCodigoPostal.TabIndex = 22;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.ForeColor = System.Drawing.Color.White;
            this.lblCodigoPostal.Location = new System.Drawing.Point(80, 82);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(108, 20);
            this.lblCodigoPostal.TabIndex = 21;
            this.lblCodigoPostal.Text = "Código Postal";
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(63, 38);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(295, 24);
            this.txtRua.TabIndex = 18;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.ForeColor = System.Drawing.Color.White;
            this.lblRua.Location = new System.Drawing.Point(29, 40);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(36, 20);
            this.lblRua.TabIndex = 17;
            this.lblRua.Text = "Rua";
            // 
            // grpbxMorada
            // 
            this.grpbxMorada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxMorada.Controls.Add(this.cmbLocalidade);
            this.grpbxMorada.Controls.Add(this.txtCodigoPostal);
            this.grpbxMorada.Controls.Add(this.lblCodigoPostal);
            this.grpbxMorada.Controls.Add(this.lblLocalidade);
            this.grpbxMorada.Controls.Add(this.txtRua);
            this.grpbxMorada.Controls.Add(this.lblRua);
            this.grpbxMorada.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxMorada.Location = new System.Drawing.Point(9, 307);
            this.grpbxMorada.Name = "grpbxMorada";
            this.grpbxMorada.Size = new System.Drawing.Size(384, 176);
            this.grpbxMorada.TabIndex = 29;
            this.grpbxMorada.TabStop = false;
            this.grpbxMorada.Text = "Morada";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidade.ForeColor = System.Drawing.Color.White;
            this.lblLocalidade.Location = new System.Drawing.Point(93, 127);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(84, 20);
            this.lblLocalidade.TabIndex = 19;
            this.lblLocalidade.Text = "Localidade";
            // 
            // txtNIC
            // 
            this.txtNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIC.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(242, 238);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(151, 24);
            this.txtNIC.TabIndex = 28;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIC.ForeColor = System.Drawing.Color.White;
            this.lblNIC.Location = new System.Drawing.Point(208, 240);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(34, 20);
            this.lblNIC.TabIndex = 27;
            this.lblNIC.Text = "NIC";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.Color.White;
            this.lblDataNasc.Location = new System.Drawing.Point(9, 279);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(132, 20);
            this.lblDataNasc.TabIndex = 26;
            this.lblDataNasc.Text = "Data Nascimento";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDataNasc.Location = new System.Drawing.Point(141, 279);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(155, 20);
            this.dtpDataNasc.TabIndex = 25;
            this.dtpDataNasc.ValueChanged += new System.EventHandler(this.dtpDataNasc_ValueChanged);
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdade.Enabled = false;
            this.txtIdade.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(349, 277);
            this.txtIdade.MaxLength = 14;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(44, 24);
            this.txtIdade.TabIndex = 24;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(302, 279);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(47, 20);
            this.lblIdade.TabIndex = 23;
            this.lblIdade.Text = "Idade";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(77, 238);
            this.txtTelefone.MaxLength = 14;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(125, 24);
            this.txtTelefone.TabIndex = 22;
            this.txtTelefone.Text = "+351 ";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(10, 240);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(67, 20);
            this.lblTelefone.TabIndex = 21;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(59, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 24);
            this.txtEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(9, 196);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(59, 148);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(334, 24);
            this.txtNome.TabIndex = 18;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(10, 150);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 20);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "Nome";
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.ForeColor = System.Drawing.Color.White;
            this.lblEditar.Location = new System.Drawing.Point(290, 12);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(53, 20);
            this.lblEditar.TabIndex = 31;
            this.lblEditar.Text = "Editar";
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.AcceptsReturn = true;
            this.txtDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalhes.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalhes.Location = new System.Drawing.Point(276, 66);
            this.txtDetalhes.Multiline = true;
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(117, 64);
            this.txtDetalhes.TabIndex = 33;
            this.txtDetalhes.Visible = false;
            this.txtDetalhes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDetalhes_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(10, 106);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 34;
            this.lblTipo.Text = "Tipo";
            // 
            // lblEspecializacao
            // 
            this.lblEspecializacao.AutoSize = true;
            this.lblEspecializacao.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecializacao.ForeColor = System.Drawing.Color.White;
            this.lblEspecializacao.Location = new System.Drawing.Point(10, 67);
            this.lblEspecializacao.Name = "lblEspecializacao";
            this.lblEspecializacao.Size = new System.Drawing.Size(266, 20);
            this.lblEspecializacao.TabIndex = 36;
            this.lblEspecializacao.Text = "Tipos de animais com especialização";
            this.lblEspecializacao.Visible = false;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFuncionario.Font = new System.Drawing.Font("Montserrat SemiBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(6, 12);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(180, 37);
            this.lblFuncionario.TabIndex = 37;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCriar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCriar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCriar.BorderRadius = 15;
            this.btnCriar.BorderSize = 0;
            this.btnCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriar.FlatAppearance.BorderSize = 0;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.Color.White;
            this.btnCriar.Location = new System.Drawing.Point(238, 12);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(156, 42);
            this.btnCriar.TabIndex = 32;
            this.btnCriar.Text = "Criar";
            this.btnCriar.TextColor = System.Drawing.Color.White;
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // tglbtnEditar
            // 
            this.tglbtnEditar.AutoSize = true;
            this.tglbtnEditar.Location = new System.Drawing.Point(348, 12);
            this.tglbtnEditar.MinimumSize = new System.Drawing.Size(45, 22);
            this.tglbtnEditar.Name = "tglbtnEditar";
            this.tglbtnEditar.OffBackColor = System.Drawing.Color.Gray;
            this.tglbtnEditar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tglbtnEditar.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tglbtnEditar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tglbtnEditar.Size = new System.Drawing.Size(45, 22);
            this.tglbtnEditar.TabIndex = 30;
            this.tglbtnEditar.UseVisualStyleBackColor = true;
            this.tglbtnEditar.CheckedChanged += new System.EventHandler(this.tglbtnEditar_CheckedChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.cmbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.cmbTipo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Aveiro",
            "Açores",
            "Beja",
            "Braga",
            "Bragança",
            "Castelo Branco",
            "Coimbra",
            "Évora",
            "Faro",
            "Guarda",
            "Leiria",
            "Lisboa",
            "Madeira",
            "Portalegre",
            "Porto",
            "Santarém",
            "Setúbal",
            "Viana do Castelo",
            "Vila Real",
            "Viseu"});
            this.cmbTipo.Location = new System.Drawing.Point(55, 103);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(215, 26);
            this.cmbTipo.TabIndex = 38;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged_1);
            // 
            // frmEditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(405, 495);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblEspecializacao);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtDetalhes);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.lblEditar);
            this.Controls.Add(this.tglbtnEditar);
            this.Controls.Add(this.grpbxMorada);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.lblNIC);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmEditAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditAdmin";
            this.grpbxMorada.ResumeLayout(false);
            this.grpbxMorada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLocalidade;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.GroupBox grpbxMorada;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private CostumButton btnCriar;
        private System.Windows.Forms.Label lblEditar;
        private CostumToggleButton tglbtnEditar;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEspecializacao;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}