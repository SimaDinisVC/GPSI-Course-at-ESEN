
namespace GestEmpresa
{
    partial class frmEmpregado
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
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkEditar = new System.Windows.Forms.CheckBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.pnlProgramador = new System.Windows.Forms.Panel();
            this.txtEspecialidade = new System.Windows.Forms.TextBox();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.pnlAnalista = new System.Windows.Forms.Panel();
            this.txtProjeto = new System.Windows.Forms.TextBox();
            this.lblProjeto = new System.Windows.Forms.Label();
            this.grpMorada = new System.Windows.Forms.GroupBox();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlProgramador.SuspendLayout();
            this.pnlAnalista.SuspendLayout();
            this.grpMorada.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(25, 27);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(46, 17);
            this.lblCargo.TabIndex = 0;
            this.lblCargo.Text = "Cargo";
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(88, 27);
            this.cmbCargo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(160, 24);
            this.cmbCargo.TabIndex = 1;
            this.cmbCargo.SelectedIndexChanged += new System.EventHandler(this.cmbCargo_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(328, 27);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(357, 28);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(76, 22);
            this.txtID.TabIndex = 3;
            // 
            // chkEditar
            // 
            this.chkEditar.AutoSize = true;
            this.chkEditar.Location = new System.Drawing.Point(511, 29);
            this.chkEditar.Margin = new System.Windows.Forms.Padding(4);
            this.chkEditar.Name = "chkEditar";
            this.chkEditar.Size = new System.Drawing.Size(67, 21);
            this.chkEditar.TabIndex = 4;
            this.chkEditar.Text = "Editar";
            this.chkEditar.UseVisualStyleBackColor = true;
            this.chkEditar.CheckedChanged += new System.EventHandler(this.chkEditar_CheckedChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 59);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 59);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(487, 22);
            this.txtNome.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 93);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(88, 91);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(337, 93);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 17);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(405, 93);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(170, 22);
            this.txtTelefone.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Nascimento";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(451, 131);
            this.dtpDataNasc.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(124, 22);
            this.dtpDataNasc.TabIndex = 12;
            // 
            // pnlProgramador
            // 
            this.pnlProgramador.Controls.Add(this.txtEspecialidade);
            this.pnlProgramador.Controls.Add(this.lblEspecialidade);
            this.pnlProgramador.Location = new System.Drawing.Point(94, 170);
            this.pnlProgramador.Margin = new System.Windows.Forms.Padding(4);
            this.pnlProgramador.Name = "pnlProgramador";
            this.pnlProgramador.Size = new System.Drawing.Size(485, 58);
            this.pnlProgramador.TabIndex = 13;
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.Location = new System.Drawing.Point(127, 20);
            this.txtEspecialidade.Margin = new System.Windows.Forms.Padding(1);
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.Size = new System.Drawing.Size(346, 22);
            this.txtEspecialidade.TabIndex = 1;
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(16, 23);
            this.lblEspecialidade.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(96, 17);
            this.lblEspecialidade.TabIndex = 0;
            this.lblEspecialidade.Text = "Especialidade";
            // 
            // pnlAnalista
            // 
            this.pnlAnalista.Controls.Add(this.txtProjeto);
            this.pnlAnalista.Controls.Add(this.lblProjeto);
            this.pnlAnalista.Location = new System.Drawing.Point(93, 170);
            this.pnlAnalista.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAnalista.Name = "pnlAnalista";
            this.pnlAnalista.Size = new System.Drawing.Size(485, 58);
            this.pnlAnalista.TabIndex = 14;
            // 
            // txtProjeto
            // 
            this.txtProjeto.Location = new System.Drawing.Point(80, 18);
            this.txtProjeto.Margin = new System.Windows.Forms.Padding(1);
            this.txtProjeto.Name = "txtProjeto";
            this.txtProjeto.Size = new System.Drawing.Size(385, 22);
            this.txtProjeto.TabIndex = 1;
            // 
            // lblProjeto
            // 
            this.lblProjeto.AutoSize = true;
            this.lblProjeto.Location = new System.Drawing.Point(16, 23);
            this.lblProjeto.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(53, 17);
            this.lblProjeto.TabIndex = 0;
            this.lblProjeto.Text = "Projeto";
            // 
            // grpMorada
            // 
            this.grpMorada.BackColor = System.Drawing.SystemColors.Control;
            this.grpMorada.Controls.Add(this.txtLocalidade);
            this.grpMorada.Controls.Add(this.txtCodPostal);
            this.grpMorada.Controls.Add(this.txtRua);
            this.grpMorada.Location = new System.Drawing.Point(94, 248);
            this.grpMorada.Margin = new System.Windows.Forms.Padding(4);
            this.grpMorada.Name = "grpMorada";
            this.grpMorada.Padding = new System.Windows.Forms.Padding(4);
            this.grpMorada.Size = new System.Drawing.Size(485, 103);
            this.grpMorada.TabIndex = 15;
            this.grpMorada.TabStop = false;
            this.grpMorada.Text = "Morada";
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(178, 58);
            this.txtLocalidade.Margin = new System.Windows.Forms.Padding(1);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(286, 22);
            this.txtLocalidade.TabIndex = 2;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(37, 58);
            this.txtCodPostal.Margin = new System.Windows.Forms.Padding(1);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(117, 22);
            this.txtCodPostal.TabIndex = 1;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(37, 27);
            this.txtRua.Margin = new System.Windows.Forms.Padding(1);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(427, 22);
            this.txtRua.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(376, 368);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 32);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(485, 368);
            this.btnOk.Margin = new System.Windows.Forms.Padding(1);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 32);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmEmpregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 419);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlAnalista);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpMorada);
            this.Controls.Add(this.pnlProgramador);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.chkEditar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.lblCargo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmpregado";
            this.Text = "Empregado";
            this.Load += new System.EventHandler(this.frmEmpregado_Load);
            this.pnlProgramador.ResumeLayout(false);
            this.pnlProgramador.PerformLayout();
            this.pnlAnalista.ResumeLayout(false);
            this.pnlAnalista.PerformLayout();
            this.grpMorada.ResumeLayout(false);
            this.grpMorada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkEditar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Panel pnlProgramador;
        private System.Windows.Forms.GroupBox grpMorada;
        private System.Windows.Forms.TextBox txtEspecialidade;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Panel pnlAnalista;
        private System.Windows.Forms.TextBox txtProjeto;
        private System.Windows.Forms.Label lblProjeto;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}