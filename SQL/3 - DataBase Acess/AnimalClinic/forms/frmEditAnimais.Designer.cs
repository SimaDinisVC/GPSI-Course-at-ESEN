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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAnimais));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCriar = new AnimalClinic.CostumButton();
            this.lblEditar = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.tglbtnEditar = new AnimalClinic.CostumToggleButton();
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.grpbxDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCriar);
            this.panel1.Controls.Add(this.lblEditar);
            this.panel1.Controls.Add(this.lblDataNasc);
            this.panel1.Controls.Add(this.tglbtnEditar);
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
            this.btnCriar.Location = new System.Drawing.Point(226, 20);
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
            this.lblEditar.Location = new System.Drawing.Point(279, 20);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(53, 20);
            this.lblEditar.TabIndex = 19;
            this.lblEditar.Text = "Editar";
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
            // tglbtnEditar
            // 
            this.tglbtnEditar.AutoSize = true;
            this.tglbtnEditar.Location = new System.Drawing.Point(337, 20);
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
            // dtpDataNasc
            // 
            this.dtpDataNasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDataNasc.Location = new System.Drawing.Point(152, 224);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(141, 20);
            this.dtpDataNasc.TabIndex = 34;
            this.dtpDataNasc.Value = new System.DateTime(2023, 5, 30, 0, 0, 0, 0);
            this.dtpDataNasc.ValueChanged += new System.EventHandler(this.dtpDataNasc_ValueChanged);
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdade.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(352, 222);
            this.txtIdade.MaxLength = 14;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.ReadOnly = true;
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
            this.txtRaca.Size = new System.Drawing.Size(130, 24);
            this.txtRaca.TabIndex = 30;
            this.txtRaca.Validating += new System.ComponentModel.CancelEventHandler(this.txtRaca_Validating);
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
            this.txtNome.Location = new System.Drawing.Point(171, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(194, 24);
            this.txtNome.TabIndex = 26;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(118, 87);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 20);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Nome";
            // 
            // cmbID
            // 
            this.cmbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.cmbID.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // frmEditAnimais
            // 
            this.AcceptButton = this.btnCriar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(394, 438);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAnimais;
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
        private System.Windows.Forms.ErrorProvider errorProvider;
        private CostumButton btnCriar;
        private System.Windows.Forms.Label lblEditar;
        private CostumToggleButton tglbtnEditar;
    }
}