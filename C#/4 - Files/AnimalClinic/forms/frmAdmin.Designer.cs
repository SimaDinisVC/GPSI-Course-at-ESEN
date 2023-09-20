namespace AnimalClinic.forms
{
    partial class frmAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvRececionistas = new System.Windows.Forms.DataGridView();
            this.pnlbl1 = new System.Windows.Forms.Panel();
            this.lblRececionistas = new System.Windows.Forms.Label();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.pnlbl2 = new System.Windows.Forms.Panel();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRececionistas)).BeginInit();
            this.pnlbl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.pnlbl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 3;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp.Controls.Add(this.btnConsulta, 2, 0);
            this.tlp.Controls.Add(this.btnNovo, 1, 0);
            this.tlp.Controls.Add(this.btnRemover, 0, 0);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp.Location = new System.Drawing.Point(0, 360);
            this.tlp.Name = "tlp";
            this.tlp.Padding = new System.Windows.Forms.Padding(8, 0, 8, 5);
            this.tlp.RowCount = 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.Size = new System.Drawing.Size(800, 90);
            this.tlp.TabIndex = 18;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Montserrat SemiBold", 15F);
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(535, 3);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(254, 79);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consultar ficha";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
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
            this.btnNovo.Location = new System.Drawing.Point(274, 3);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(251, 79);
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
            this.btnRemover.Size = new System.Drawing.Size(253, 79);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvRececionistas);
            this.splitContainer.Panel1.Controls.Add(this.pnlbl1);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10, 7, 7, 7);
            this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dgvMedicos);
            this.splitContainer.Panel2.Controls.Add(this.pnlbl2);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(7, 7, 10, 7);
            this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer.Size = new System.Drawing.Size(800, 360);
            this.splitContainer.SplitterDistance = 400;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 19;
            // 
            // dgvRececionistas
            // 
            this.dgvRececionistas.AllowUserToAddRows = false;
            this.dgvRececionistas.AllowUserToDeleteRows = false;
            this.dgvRececionistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRececionistas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRececionistas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRececionistas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRececionistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRececionistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat Medium", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRececionistas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRececionistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRececionistas.Location = new System.Drawing.Point(10, 45);
            this.dgvRececionistas.MultiSelect = false;
            this.dgvRececionistas.Name = "dgvRececionistas";
            this.dgvRececionistas.ReadOnly = true;
            this.dgvRececionistas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRececionistas.RowHeadersVisible = false;
            this.dgvRececionistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRececionistas.Size = new System.Drawing.Size(383, 308);
            this.dgvRececionistas.TabIndex = 3;
            this.dgvRececionistas.SelectionChanged += new System.EventHandler(this.dgvRececionistas_SelectionChanged);
            // 
            // pnlbl1
            // 
            this.pnlbl1.Controls.Add(this.lblRececionistas);
            this.pnlbl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbl1.Location = new System.Drawing.Point(10, 7);
            this.pnlbl1.Name = "pnlbl1";
            this.pnlbl1.Size = new System.Drawing.Size(383, 38);
            this.pnlbl1.TabIndex = 4;
            // 
            // lblRececionistas
            // 
            this.lblRececionistas.AutoSize = true;
            this.lblRececionistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRececionistas.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRececionistas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRececionistas.Location = new System.Drawing.Point(0, 0);
            this.lblRececionistas.Name = "lblRececionistas";
            this.lblRececionistas.Size = new System.Drawing.Size(185, 33);
            this.lblRececionistas.TabIndex = 1;
            this.lblRececionistas.Text = "Rececionistas";
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat Medium", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicos.Location = new System.Drawing.Point(7, 45);
            this.dgvMedicos.MultiSelect = false;
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMedicos.RowHeadersVisible = false;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.Size = new System.Drawing.Size(382, 308);
            this.dgvMedicos.TabIndex = 0;
            this.dgvMedicos.SelectionChanged += new System.EventHandler(this.dgvMedicos_SelectionChanged);
            // 
            // pnlbl2
            // 
            this.pnlbl2.Controls.Add(this.lblMedicos);
            this.pnlbl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbl2.Location = new System.Drawing.Point(7, 7);
            this.pnlbl2.Name = "pnlbl2";
            this.pnlbl2.Size = new System.Drawing.Size(382, 38);
            this.pnlbl2.TabIndex = 2;
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMedicos.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMedicos.Location = new System.Drawing.Point(0, 0);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(117, 33);
            this.lblMedicos.TabIndex = 1;
            this.lblMedicos.Text = "Médicos";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.tlp);
            this.Name = "frmAdmin";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.VisibleChanged += new System.EventHandler(this.frmAdmin_VisibleChanged);
            this.tlp.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRececionistas)).EndInit();
            this.pnlbl1.ResumeLayout(false);
            this.pnlbl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.pnlbl2.ResumeLayout(false);
            this.pnlbl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgvRececionistas;
        private System.Windows.Forms.Panel pnlbl1;
        private System.Windows.Forms.Label lblRececionistas;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Panel pnlbl2;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnConsulta;
    }
}