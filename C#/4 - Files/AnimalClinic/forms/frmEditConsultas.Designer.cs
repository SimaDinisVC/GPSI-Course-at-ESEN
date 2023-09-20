namespace AnimalClinic.forms
{
    partial class frmEditConsultas
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
            this.btnCriar = new AnimalClinic.CostumButton();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.dtpDataHora = new System.Windows.Forms.DateTimePicker();
            this.grpbxDetalhes = new System.Windows.Forms.GroupBox();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.grpbxDetalhes.SuspendLayout();
            this.SuspendLayout();
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
            this.btnCriar.Location = new System.Drawing.Point(519, 12);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(156, 42);
            this.btnCriar.TabIndex = 21;
            this.btnCriar.Text = "Criar";
            this.btnCriar.TextColor = System.Drawing.Color.White;
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtAnimal
            // 
            this.txtAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.txtAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnimal.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimal.Location = new System.Drawing.Point(104, 130);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.ReadOnly = true;
            this.txtAnimal.Size = new System.Drawing.Size(200, 24);
            this.txtAnimal.TabIndex = 30;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.ForeColor = System.Drawing.Color.White;
            this.lblAnimal.Location = new System.Drawing.Point(39, 132);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(59, 20);
            this.lblAnimal.TabIndex = 29;
            this.lblAnimal.Text = "Animal";
            // 
            // cmbID
            // 
            this.cmbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.cmbID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbID.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(146, 89);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(61, 24);
            this.cmbID.TabIndex = 28;
            this.cmbID.SelectedIndexChanged += new System.EventHandler(this.cmbID_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(39, 91);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(101, 20);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "ID do Animal";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.ForeColor = System.Drawing.Color.White;
            this.lblMedico.Location = new System.Drawing.Point(39, 181);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(60, 20);
            this.lblMedico.TabIndex = 32;
            this.lblMedico.Text = "Medico";
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.cmbMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMedicos.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new System.Drawing.Point(105, 178);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(199, 26);
            this.cmbMedicos.TabIndex = 31;
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.ForeColor = System.Drawing.Color.White;
            this.lblDataHora.Location = new System.Drawing.Point(39, 227);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(92, 20);
            this.lblDataHora.TabIndex = 37;
            this.lblDataHora.Text = "Data e Hora";
            // 
            // dtpDataHora
            // 
            this.dtpDataHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDataHora.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataHora.Location = new System.Drawing.Point(137, 228);
            this.dtpDataHora.Name = "dtpDataHora";
            this.dtpDataHora.Size = new System.Drawing.Size(167, 20);
            this.dtpDataHora.TabIndex = 36;
            this.dtpDataHora.ValueChanged += new System.EventHandler(this.dtpDataHora_ValueChanged);
            // 
            // grpbxDetalhes
            // 
            this.grpbxDetalhes.Controls.Add(this.txtDetalhes);
            this.grpbxDetalhes.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxDetalhes.Location = new System.Drawing.Point(345, 81);
            this.grpbxDetalhes.Name = "grpbxDetalhes";
            this.grpbxDetalhes.Size = new System.Drawing.Size(319, 184);
            this.grpbxDetalhes.TabIndex = 38;
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
            this.txtDetalhes.Size = new System.Drawing.Size(313, 158);
            this.txtDetalhes.TabIndex = 18;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.Color.Black;
            this.lblConsulta.Location = new System.Drawing.Point(37, 21);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(123, 33);
            this.lblConsulta.TabIndex = 65;
            this.lblConsulta.Text = "Consulta\r\n";
            // 
            // frmEditConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(687, 280);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.grpbxDetalhes);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.dtpDataHora);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.cmbMedicos);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.lblID);
            this.Name = "frmEditConsultas";
            this.Load += new System.EventHandler(this.frmEditConsultas_Load);
            this.grpbxDetalhes.ResumeLayout(false);
            this.grpbxDetalhes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CostumButton btnCriar;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbMedicos;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.DateTimePicker dtpDataHora;
        private System.Windows.Forms.GroupBox grpbxDetalhes;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.Label lblConsulta;
    }
}