namespace AnimalClinic.forms
{
    partial class frmRececionistas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMessage = new AnimalClinic.CostumButton();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnLogout = new AnimalClinic.CostumButton();
            this.tglbtnStatus = new AnimalClinic.CostumToggleButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblNICs = new System.Windows.Forms.Label();
            this.cmbNICs = new System.Windows.Forms.ComboBox();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.flpnlAssuntos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTOP = new System.Windows.Forms.Panel();
            this.lblCaixaEntrada = new System.Windows.Forms.Label();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.grpbxDetalhes = new System.Windows.Forms.GroupBox();
            this.txtCorpo = new System.Windows.Forms.TextBox();
            this.lblRemetente = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.picbxLoading = new System.Windows.Forms.PictureBox();
            this.btnAutenticar = new AnimalClinic.CostumButton();
            this.panel1.SuspendLayout();
            this.tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.flpnlAssuntos.SuspendLayout();
            this.panelTOP.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.grpbxDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMessage);
            this.panel1.Controls.Add(this.btnEmail);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.tglbtnStatus);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 62);
            this.panel1.TabIndex = 61;
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMessage.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnMessage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMessage.BorderRadius = 14;
            this.btnMessage.BorderSize = 0;
            this.btnMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMessage.FlatAppearance.BorderSize = 0;
            this.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessage.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessage.ForeColor = System.Drawing.Color.White;
            this.btnMessage.Location = new System.Drawing.Point(106, 7);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(193, 47);
            this.btnMessage.TabIndex = 51;
            this.btnMessage.Text = "Nova mensagem";
            this.btnMessage.TextColor = System.Drawing.Color.White;
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Visible = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Image = global::AnimalClinic.Properties.Resources.email_white;
            this.btnEmail.Location = new System.Drawing.Point(12, 3);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(67, 55);
            this.btnEmail.TabIndex = 50;
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Visible = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(76)))), ((int)(((byte)(82)))));
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(76)))), ((int)(((byte)(82)))));
            this.btnLogout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogout.BorderRadius = 14;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(787, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(193, 47);
            this.btnLogout.TabIndex = 49;
            this.btnLogout.Text = "Terminar Sessão";
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tglbtnStatus
            // 
            this.tglbtnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tglbtnStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglbtnStatus.Location = new System.Drawing.Point(705, 16);
            this.tglbtnStatus.MinimumSize = new System.Drawing.Size(45, 22);
            this.tglbtnStatus.Name = "tglbtnStatus";
            this.tglbtnStatus.OffBackColor = System.Drawing.Color.Gray;
            this.tglbtnStatus.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tglbtnStatus.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tglbtnStatus.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tglbtnStatus.Size = new System.Drawing.Size(60, 30);
            this.tglbtnStatus.TabIndex = 46;
            this.tglbtnStatus.UseVisualStyleBackColor = true;
            this.tglbtnStatus.Visible = false;
            this.tglbtnStatus.CheckedChanged += new System.EventHandler(this.tglbtnStatus_CheckedChanged_1);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Montserrat SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.lblStatus.Location = new System.Drawing.Point(573, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(126, 29);
            this.lblStatus.TabIndex = 48;
            this.lblStatus.Text = "Ausente";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblStatus.Visible = false;
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblConsultas.Location = new System.Drawing.Point(6, 65);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(135, 33);
            this.lblConsultas.TabIndex = 64;
            this.lblConsultas.Text = "Consultas";
            this.lblConsultas.Visible = false;
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 2;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.Controls.Add(this.btnNovo, 1, 0);
            this.tlp.Controls.Add(this.btnRemover, 0, 0);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp.Location = new System.Drawing.Point(0, 447);
            this.tlp.Name = "tlp";
            this.tlp.Padding = new System.Windows.Forms.Padding(8, 0, 8, 5);
            this.tlp.RowCount = 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.Size = new System.Drawing.Size(992, 90);
            this.tlp.TabIndex = 62;
            this.tlp.Visible = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Montserrat SemiBold", 15F);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(501, 3);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(478, 79);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Montserrat SemiBold", 15F);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(11, 3);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(480, 79);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(297, 263);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(202, 22);
            this.lblPassword.TabIndex = 59;
            this.lblPassword.Text = "Palavra-passe do Email";
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(506, 259);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '⚫';
            this.txtpassword.Size = new System.Drawing.Size(215, 26);
            this.txtpassword.TabIndex = 58;
            // 
            // lblNICs
            // 
            this.lblNICs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNICs.AutoSize = true;
            this.lblNICs.BackColor = System.Drawing.Color.Transparent;
            this.lblNICs.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNICs.ForeColor = System.Drawing.Color.White;
            this.lblNICs.Location = new System.Drawing.Point(293, 209);
            this.lblNICs.Name = "lblNICs";
            this.lblNICs.Size = new System.Drawing.Size(207, 22);
            this.lblNICs.TabIndex = 57;
            this.lblNICs.Text = "Nº de Identificação Civíl";
            // 
            // cmbNICs
            // 
            this.cmbNICs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNICs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.cmbNICs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNICs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNICs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNICs.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.cmbNICs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbNICs.FormattingEnabled = true;
            this.cmbNICs.Location = new System.Drawing.Point(506, 206);
            this.cmbNICs.Name = "cmbNICs";
            this.cmbNICs.Size = new System.Drawing.Size(215, 30);
            this.cmbNICs.TabIndex = 56;
            this.cmbNICs.SelectedIndexChanged += new System.EventHandler(this.cmbNICs_SelectedIndexChanged_1);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(76)))), ((int)(((byte)(82)))));
            this.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat Medium", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultas.Location = new System.Drawing.Point(12, 102);
            this.dgvConsultas.MultiSelect = false;
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.RowHeadersWidth = 51;
            this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultas.Size = new System.Drawing.Size(968, 342);
            this.dgvConsultas.TabIndex = 65;
            this.dgvConsultas.Visible = false;
            // 
            // flpnlAssuntos
            // 
            this.flpnlAssuntos.AutoScroll = true;
            this.flpnlAssuntos.Controls.Add(this.panelTOP);
            this.flpnlAssuntos.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpnlAssuntos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnlAssuntos.Location = new System.Drawing.Point(0, 62);
            this.flpnlAssuntos.Name = "flpnlAssuntos";
            this.flpnlAssuntos.Size = new System.Drawing.Size(320, 385);
            this.flpnlAssuntos.TabIndex = 66;
            this.flpnlAssuntos.Visible = false;
            this.flpnlAssuntos.WrapContents = false;
            // 
            // panelTOP
            // 
            this.panelTOP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelTOP.Controls.Add(this.lblCaixaEntrada);
            this.panelTOP.Location = new System.Drawing.Point(3, 3);
            this.panelTOP.Name = "panelTOP";
            this.panelTOP.Size = new System.Drawing.Size(296, 30);
            this.panelTOP.TabIndex = 0;
            // 
            // lblCaixaEntrada
            // 
            this.lblCaixaEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaixaEntrada.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixaEntrada.Location = new System.Drawing.Point(3, 3);
            this.lblCaixaEntrada.Name = "lblCaixaEntrada";
            this.lblCaixaEntrada.Size = new System.Drawing.Size(189, 27);
            this.lblCaixaEntrada.TabIndex = 49;
            this.lblCaixaEntrada.Text = "Ausente";
            this.lblCaixaEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlEmail
            // 
            this.pnlEmail.Controls.Add(this.txtDestinatario);
            this.pnlEmail.Controls.Add(this.txtAssunto);
            this.pnlEmail.Controls.Add(this.grpbxDetalhes);
            this.pnlEmail.Controls.Add(this.lblRemetente);
            this.pnlEmail.Controls.Add(this.lblAssunto);
            this.pnlEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmail.Location = new System.Drawing.Point(320, 62);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(672, 385);
            this.pnlEmail.TabIndex = 67;
            this.pnlEmail.Visible = false;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinatario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestinatario.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinatario.ForeColor = System.Drawing.Color.White;
            this.txtDestinatario.Location = new System.Drawing.Point(456, 51);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(205, 24);
            this.txtDestinatario.TabIndex = 69;
            this.txtDestinatario.Visible = false;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtAssunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssunto.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.ForeColor = System.Drawing.Color.White;
            this.txtAssunto.Location = new System.Drawing.Point(419, 10);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(241, 24);
            this.txtAssunto.TabIndex = 68;
            this.txtAssunto.Visible = false;
            // 
            // grpbxDetalhes
            // 
            this.grpbxDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxDetalhes.Controls.Add(this.txtCorpo);
            this.grpbxDetalhes.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxDetalhes.Location = new System.Drawing.Point(336, 91);
            this.grpbxDetalhes.Name = "grpbxDetalhes";
            this.grpbxDetalhes.Size = new System.Drawing.Size(325, 288);
            this.grpbxDetalhes.TabIndex = 52;
            this.grpbxDetalhes.TabStop = false;
            this.grpbxDetalhes.Text = "Corpo";
            // 
            // txtCorpo
            // 
            this.txtCorpo.AcceptsReturn = true;
            this.txtCorpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtCorpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCorpo.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpo.ForeColor = System.Drawing.Color.White;
            this.txtCorpo.Location = new System.Drawing.Point(3, 23);
            this.txtCorpo.Multiline = true;
            this.txtCorpo.Name = "txtCorpo";
            this.txtCorpo.ReadOnly = true;
            this.txtCorpo.Size = new System.Drawing.Size(319, 262);
            this.txtCorpo.TabIndex = 18;
            // 
            // lblRemetente
            // 
            this.lblRemetente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemetente.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemetente.Location = new System.Drawing.Point(335, 48);
            this.lblRemetente.Name = "lblRemetente";
            this.lblRemetente.Size = new System.Drawing.Size(326, 27);
            this.lblRemetente.TabIndex = 54;
            this.lblRemetente.Text = "Remetente: ";
            this.lblRemetente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAssunto
            // 
            this.lblAssunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssunto.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.Location = new System.Drawing.Point(335, 10);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(326, 27);
            this.lblAssunto.TabIndex = 53;
            this.lblAssunto.Text = "Assunto: ";
            this.lblAssunto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picbxLoading
            // 
            this.picbxLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbxLoading.Image = global::AnimalClinic.Properties.Resources.spinner_gif;
            this.picbxLoading.ImageLocation = "";
            this.picbxLoading.InitialImage = global::AnimalClinic.Properties.Resources.spinner_gif;
            this.picbxLoading.Location = new System.Drawing.Point(480, 291);
            this.picbxLoading.Name = "picbxLoading";
            this.picbxLoading.Size = new System.Drawing.Size(36, 34);
            this.picbxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxLoading.TabIndex = 63;
            this.picbxLoading.TabStop = false;
            this.picbxLoading.Visible = false;
            // 
            // btnAutenticar
            // 
            this.btnAutenticar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAutenticar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAutenticar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAutenticar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAutenticar.BorderRadius = 10;
            this.btnAutenticar.BorderSize = 0;
            this.btnAutenticar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutenticar.FlatAppearance.BorderSize = 0;
            this.btnAutenticar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutenticar.Font = new System.Drawing.Font("Montserrat SemiBold", 12F);
            this.btnAutenticar.ForeColor = System.Drawing.Color.White;
            this.btnAutenticar.Location = new System.Drawing.Point(423, 328);
            this.btnAutenticar.Name = "btnAutenticar";
            this.btnAutenticar.Size = new System.Drawing.Size(150, 40);
            this.btnAutenticar.TabIndex = 60;
            this.btnAutenticar.Text = "Autenticar";
            this.btnAutenticar.TextColor = System.Drawing.Color.White;
            this.btnAutenticar.UseVisualStyleBackColor = false;
            this.btnAutenticar.Click += new System.EventHandler(this.btnAutenticar_Click);
            // 
            // frmRececionistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(992, 537);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.flpnlAssuntos);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblConsultas);
            this.Controls.Add(this.tlp);
            this.Controls.Add(this.btnAutenticar);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblNICs);
            this.Controls.Add(this.cmbNICs);
            this.Controls.Add(this.picbxLoading);
            this.Name = "frmRececionistas";
            this.Text = "Rececionistas";
            this.Load += new System.EventHandler(this.frmRececionistacs_Load);
            this.VisibleChanged += new System.EventHandler(this.frmRececionistas_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.tlp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.flpnlAssuntos.ResumeLayout(false);
            this.panelTOP.ResumeLayout(false);
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.grpbxDetalhes.ResumeLayout(false);
            this.grpbxDetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmail;
        private CostumButton btnLogout;
        private CostumToggleButton tglbtnStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnRemover;
        private CostumButton btnAutenticar;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblNICs;
        private System.Windows.Forms.ComboBox cmbNICs;
        private System.Windows.Forms.PictureBox picbxLoading;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.FlowLayoutPanel flpnlAssuntos;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Panel panelTOP;
        private System.Windows.Forms.Label lblCaixaEntrada;
        private System.Windows.Forms.GroupBox grpbxDetalhes;
        private System.Windows.Forms.TextBox txtCorpo;
        private System.Windows.Forms.Label lblRemetente;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtAssunto;
        private CostumButton btnMessage;
    }
}