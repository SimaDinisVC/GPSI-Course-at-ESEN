namespace AnimalClinic
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnRececionistas = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.Button();
            this.lblIcons = new System.Windows.Forms.Label();
            this.tgbIcons = new AnimalClinic.CostumToggleButton();
            this.lblTema = new System.Windows.Forms.Label();
            this.tgbTema = new AnimalClinic.CostumToggleButton();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.pnlMenu.Controls.Add(this.btnRececionistas);
            this.pnlMenu.Controls.Add(this.btnMedicos);
            this.pnlMenu.Controls.Add(this.btnAnimais);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlMenu.Name = "pnlMenu";
            // 
            // btnRececionistas
            // 
            this.btnRececionistas.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnRececionistas, "btnRececionistas");
            this.btnRececionistas.FlatAppearance.BorderSize = 0;
            this.btnRececionistas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRececionistas.Image = global::AnimalClinic.Properties.Resources.receptionist_white;
            this.btnRececionistas.Name = "btnRececionistas";
            this.btnRececionistas.UseVisualStyleBackColor = true;
            this.btnRececionistas.Click += new System.EventHandler(this.btnRececionista_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnMedicos, "btnMedicos");
            this.btnMedicos.FlatAppearance.BorderSize = 0;
            this.btnMedicos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMedicos.Image = global::AnimalClinic.Properties.Resources.doctor_white;
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnAnimais
            // 
            this.btnAnimais.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAnimais, "btnAnimais");
            this.btnAnimais.FlatAppearance.BorderSize = 0;
            this.btnAnimais.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAnimais.Image = global::AnimalClinic.Properties.Resources.paw_white;
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.UseVisualStyleBackColor = true;
            this.btnAnimais.Click += new System.EventHandler(this.btnAnimais_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.Controls.Add(this.btnLogo);
            this.pnlLogo.Controls.Add(this.lblIcons);
            this.pnlLogo.Controls.Add(this.tgbIcons);
            this.pnlLogo.Controls.Add(this.lblTema);
            this.pnlLogo.Controls.Add(this.tgbTema);
            resources.ApplyResources(this.pnlLogo, "pnlLogo");
            this.pnlLogo.Name = "pnlLogo";
            // 
            // btnLogo
            // 
            this.btnLogo.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnLogo, "btnLogo");
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // lblIcons
            // 
            resources.ApplyResources(this.lblIcons, "lblIcons");
            this.lblIcons.ForeColor = System.Drawing.Color.White;
            this.lblIcons.Name = "lblIcons";
            // 
            // tgbIcons
            // 
            resources.ApplyResources(this.tgbIcons, "tgbIcons");
            this.tgbIcons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgbIcons.Name = "tgbIcons";
            this.tgbIcons.OffBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tgbIcons.OffToggleColor = System.Drawing.SystemColors.ControlLight;
            this.tgbIcons.OnBackColor = System.Drawing.Color.LightGreen;
            this.tgbIcons.OnToggleColor = System.Drawing.Color.Goldenrod;
            this.tgbIcons.UseVisualStyleBackColor = true;
            this.tgbIcons.CheckedChanged += new System.EventHandler(this.tgbIcons_CheckedChanged);
            // 
            // lblTema
            // 
            resources.ApplyResources(this.lblTema, "lblTema");
            this.lblTema.ForeColor = System.Drawing.Color.White;
            this.lblTema.Name = "lblTema";
            // 
            // tgbTema
            // 
            resources.ApplyResources(this.tgbTema, "tgbTema");
            this.tgbTema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgbTema.Name = "tgbTema";
            this.tgbTema.OffBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tgbTema.OffToggleColor = System.Drawing.SystemColors.ControlLight;
            this.tgbTema.OnBackColor = System.Drawing.SystemColors.ControlLight;
            this.tgbTema.OnToggleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tgbTema.UseVisualStyleBackColor = true;
            this.tgbTema.CheckedChanged += new System.EventHandler(this.tgbTema_CheckedChanged);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.pnlTitleBar, "pnlTitleBar");
            this.pnlTitleBar.Name = "pnlTitleBar";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            resources.ApplyResources(this.pnlPrincipal, "pnlPrincipal");
            this.pnlPrincipal.Name = "pnlPrincipal";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "MainForm";
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnRececionistas;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnAnimais;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlPrincipal;
        private CostumToggleButton tgbTema;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblIcons;
        private CostumToggleButton tgbIcons;
        private System.Windows.Forms.Button btnLogo;
    }
}

