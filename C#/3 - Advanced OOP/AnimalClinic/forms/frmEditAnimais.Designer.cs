namespace AnimalClinic.forms
{
    partial class frmEditAnimais
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.grpbxDetalhes = new System.Windows.Forms.GroupBox();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAnimais = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCriar = new AnimalClinic.CostumButton();
            this.lblEditar = new System.Windows.Forms.Label();
            this.tglbtnEditar = new AnimalClinic.CostumToggleButton();
            this.grpbxMorada = new System.Windows.Forms.GroupBox();
            this.cmbLocalidade = new System.Windows.Forms.ComboBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblDataNascTtr = new System.Windows.Forms.Label();
            this.dtpDataNascTtr = new System.Windows.Forms.DateTimePicker();
            this.txtIdadeTtr = new System.Windows.Forms.TextBox();
            this.lblIdadeTtr = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNomeTtr = new System.Windows.Forms.TextBox();
            this.lblNomeTtr = new System.Windows.Forms.Label();
            this.lblTutor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpbxDetalhes.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpbxMorada.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDataNasc);
            this.panel1.Controls.Add(this.dtpDataNasc);
            this.panel1.Controls.Add(this.txtIdade);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.grpbxDetalhes);
            this.panel1.Controls.Add(this.txtRaca);
            this.panel1.Controls.Add(this.lblRaca);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.cmbID);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblAnimais);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 438);
            this.panel1.TabIndex = 0;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.Color.White;
            this.lblDataNasc.Location = new System.Drawing.Point(15, 224);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(132, 20);
            this.lblDataNasc.TabIndex = 35;
            this.lblDataNasc.Text = "Data Nascimento";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDataNasc.Location = new System.Drawing.Point(152, 224);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(141, 20);
            this.dtpDataNasc.TabIndex = 34;
            this.dtpDataNasc.ValueChanged += new System.EventHandler(this.dtpDataNasc_ValueChanged);
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdade.Enabled = false;
            this.txtIdade.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(352, 222);
            this.txtIdade.MaxLength = 14;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(33, 24);
            this.txtIdade.TabIndex = 33;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(299, 224);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(47, 20);
            this.lblIdade.TabIndex = 32;
            this.lblIdade.Text = "Idade";
            // 
            // grpbxDetalhes
            // 
            this.grpbxDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpbxDetalhes.Controls.Add(this.txtDetalhes);
            this.grpbxDetalhes.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxDetalhes.Location = new System.Drawing.Point(9, 255);
            this.grpbxDetalhes.Name = "grpbxDetalhes";
            this.grpbxDetalhes.Size = new System.Drawing.Size(376, 176);
            this.grpbxDetalhes.TabIndex = 31;
            this.grpbxDetalhes.TabStop = false;
            this.grpbxDetalhes.Text = "Detalhes";
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.AcceptsReturn = true;
            this.txtDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetalhes.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalhes.Location = new System.Drawing.Point(3, 23);
            this.txtDetalhes.Multiline = true;
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(370, 150);
            this.txtDetalhes.TabIndex = 18;
            this.txtDetalhes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDetalhes_KeyPress);
            // 
            // txtRaca
            // 
            this.txtRaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtRaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRaca.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaca.Location = new System.Drawing.Point(235, 156);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(150, 24);
            this.txtRaca.TabIndex = 30;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaca.ForeColor = System.Drawing.Color.White;
            this.lblRaca.Location = new System.Drawing.Point(186, 158);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(43, 20);
            this.lblRaca.TabIndex = 29;
            this.lblRaca.Text = "Raça";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(15, 158);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 28;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.cmbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(60, 155);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(112, 26);
            this.cmbTipo.TabIndex = 27;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(175, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(210, 24);
            this.txtNome.TabIndex = 26;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(120, 87);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 20);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Nome";
            // 
            // cmbID
            // 
            this.cmbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.cmbID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbID.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(46, 85);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(61, 24);
            this.cmbID.TabIndex = 24;
            this.cmbID.SelectedIndexChanged += new System.EventHandler(this.cmbID_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(15, 87);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 20);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "ID";
            // 
            // lblAnimais
            // 
            this.lblAnimais.AutoSize = true;
            this.lblAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAnimais.Font = new System.Drawing.Font("Montserrat SemiBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimais.Location = new System.Drawing.Point(13, 20);
            this.lblAnimais.Name = "lblAnimais";
            this.lblAnimais.Size = new System.Drawing.Size(115, 37);
            this.lblAnimais.TabIndex = 0;
            this.lblAnimais.Text = "Animal";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCriar);
            this.panel2.Controls.Add(this.lblEditar);
            this.panel2.Controls.Add(this.tglbtnEditar);
            this.panel2.Controls.Add(this.grpbxMorada);
            this.panel2.Controls.Add(this.txtNIC);
            this.panel2.Controls.Add(this.lblNIC);
            this.panel2.Controls.Add(this.lblDataNascTtr);
            this.panel2.Controls.Add(this.dtpDataNascTtr);
            this.panel2.Controls.Add(this.txtIdadeTtr);
            this.panel2.Controls.Add(this.lblIdadeTtr);
            this.panel2.Controls.Add(this.txtTelefone);
            this.panel2.Controls.Add(this.lblTelefone);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.txtNomeTtr);
            this.panel2.Controls.Add(this.lblNomeTtr);
            this.panel2.Controls.Add(this.lblTutor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(394, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 438);
            this.panel2.TabIndex = 1;
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
            this.btnCriar.TabIndex = 20;
            this.btnCriar.Text = "Criar";
            this.btnCriar.TextColor = System.Drawing.Color.White;
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.ForeColor = System.Drawing.Color.White;
            this.lblEditar.Location = new System.Drawing.Point(291, 12);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(53, 20);
            this.lblEditar.TabIndex = 19;
            this.lblEditar.Text = "Editar";
            // 
            // tglbtnEditar
            // 
            this.tglbtnEditar.AutoSize = true;
            this.tglbtnEditar.Location = new System.Drawing.Point(349, 12);
            this.tglbtnEditar.MinimumSize = new System.Drawing.Size(45, 22);
            this.tglbtnEditar.Name = "tglbtnEditar";
            this.tglbtnEditar.OffBackColor = System.Drawing.Color.Gray;
            this.tglbtnEditar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tglbtnEditar.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tglbtnEditar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tglbtnEditar.Size = new System.Drawing.Size(45, 22);
            this.tglbtnEditar.TabIndex = 17;
            this.tglbtnEditar.UseVisualStyleBackColor = true;
            this.tglbtnEditar.CheckedChanged += new System.EventHandler(this.tglbtnEditar_CheckedChanged);
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
            this.grpbxMorada.Location = new System.Drawing.Point(15, 255);
            this.grpbxMorada.Name = "grpbxMorada";
            this.grpbxMorada.Size = new System.Drawing.Size(379, 176);
            this.grpbxMorada.TabIndex = 16;
            this.grpbxMorada.TabStop = false;
            this.grpbxMorada.Text = "Morada";
            // 
            // cmbLocalidade
            // 
            this.cmbLocalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.cmbLocalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbLocalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.cmbLocalidade.Location = new System.Drawing.Point(183, 120);
            this.cmbLocalidade.Name = "cmbLocalidade";
            this.cmbLocalidade.Size = new System.Drawing.Size(120, 30);
            this.cmbLocalidade.TabIndex = 23;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtCodigoPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoPostal.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.Location = new System.Drawing.Point(194, 80);
            this.txtCodigoPostal.MaxLength = 14;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(119, 24);
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
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(69, 38);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(289, 24);
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
            // txtNIC
            // 
            this.txtNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIC.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(245, 180);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(145, 24);
            this.txtNIC.TabIndex = 15;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIC.ForeColor = System.Drawing.Color.White;
            this.lblNIC.Location = new System.Drawing.Point(205, 182);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(34, 20);
            this.lblNIC.TabIndex = 14;
            this.lblNIC.Text = "NIC";
            // 
            // lblDataNascTtr
            // 
            this.lblDataNascTtr.AutoSize = true;
            this.lblDataNascTtr.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascTtr.ForeColor = System.Drawing.Color.White;
            this.lblDataNascTtr.Location = new System.Drawing.Point(6, 224);
            this.lblDataNascTtr.Name = "lblDataNascTtr";
            this.lblDataNascTtr.Size = new System.Drawing.Size(132, 20);
            this.lblDataNascTtr.TabIndex = 13;
            this.lblDataNascTtr.Text = "Data Nascimento";
            // 
            // dtpDataNascTtr
            // 
            this.dtpDataNascTtr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDataNascTtr.Location = new System.Drawing.Point(144, 224);
            this.dtpDataNascTtr.Name = "dtpDataNascTtr";
            this.dtpDataNascTtr.Size = new System.Drawing.Size(149, 20);
            this.dtpDataNascTtr.TabIndex = 12;
            this.dtpDataNascTtr.ValueChanged += new System.EventHandler(this.dtpDataNascTtr_ValueChanged);
            // 
            // txtIdadeTtr
            // 
            this.txtIdadeTtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtIdadeTtr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdadeTtr.Enabled = false;
            this.txtIdadeTtr.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdadeTtr.Location = new System.Drawing.Point(352, 222);
            this.txtIdadeTtr.MaxLength = 14;
            this.txtIdadeTtr.Name = "txtIdadeTtr";
            this.txtIdadeTtr.Size = new System.Drawing.Size(38, 24);
            this.txtIdadeTtr.TabIndex = 11;
            // 
            // lblIdadeTtr
            // 
            this.lblIdadeTtr.AutoSize = true;
            this.lblIdadeTtr.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadeTtr.ForeColor = System.Drawing.Color.White;
            this.lblIdadeTtr.Location = new System.Drawing.Point(299, 224);
            this.lblIdadeTtr.Name = "lblIdadeTtr";
            this.lblIdadeTtr.Size = new System.Drawing.Size(47, 20);
            this.lblIdadeTtr.TabIndex = 10;
            this.lblIdadeTtr.Text = "Idade";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(80, 180);
            this.txtTelefone.MaxLength = 14;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(119, 24);
            this.txtTelefone.TabIndex = 9;
            this.txtTelefone.Text = "+351 ";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(7, 182);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(67, 20);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(62, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 24);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(6, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtNomeTtr
            // 
            this.txtNomeTtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtNomeTtr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeTtr.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTtr.Location = new System.Drawing.Point(62, 85);
            this.txtNomeTtr.Name = "txtNomeTtr";
            this.txtNomeTtr.Size = new System.Drawing.Size(328, 24);
            this.txtNomeTtr.TabIndex = 5;
            // 
            // lblNomeTtr
            // 
            this.lblNomeTtr.AutoSize = true;
            this.lblNomeTtr.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTtr.ForeColor = System.Drawing.Color.White;
            this.lblNomeTtr.Location = new System.Drawing.Point(7, 87);
            this.lblNomeTtr.Name = "lblNomeTtr";
            this.lblNomeTtr.Size = new System.Drawing.Size(52, 20);
            this.lblNomeTtr.TabIndex = 3;
            this.lblNomeTtr.Text = "Nome";
            // 
            // lblTutor
            // 
            this.lblTutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTutor.AutoSize = true;
            this.lblTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTutor.Font = new System.Drawing.Font("Montserrat SemiBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutor.Location = new System.Drawing.Point(3, 20);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(89, 37);
            this.lblTutor.TabIndex = 1;
            this.lblTutor.Text = "Tutor";
            // 
            // frmEditAnimais
            // 
            this.AcceptButton = this.btnCriar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmEditAnimais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditAnimais";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpbxDetalhes.ResumeLayout(false);
            this.grpbxDetalhes.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpbxMorada.ResumeLayout(false);
            this.grpbxMorada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAnimais;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTutor;
        private System.Windows.Forms.Label lblNomeTtr;
        private System.Windows.Forms.TextBox txtNomeTtr;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblIdadeTtr;
        private System.Windows.Forms.TextBox txtIdadeTtr;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblDataNascTtr;
        private System.Windows.Forms.DateTimePicker dtpDataNascTtr;
        private System.Windows.Forms.GroupBox grpbxMorada;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.ComboBox cmbLocalidade;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.GroupBox grpbxDetalhes;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private CostumButton btnCriar;
        private System.Windows.Forms.Label lblEditar;
        private CostumToggleButton tglbtnEditar;
    }
}