namespace ProjetoMOD8
{
    partial class FrmAvaliação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAvaliação));
            this.lblApresentação = new System.Windows.Forms.Label();
            this.lblConcelho = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblApresentação
            // 
            this.lblApresentação.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApresentação.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblApresentação.Location = new System.Drawing.Point(12, 19);
            this.lblApresentação.Name = "lblApresentação";
            this.lblApresentação.Size = new System.Drawing.Size(440, 93);
            this.lblApresentação.TabIndex = 0;
            this.lblApresentação.Text = "\r\n\r\n\r\n\r\n\r\n ";
            this.lblApresentação.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblConcelho
            // 
            this.lblConcelho.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblConcelho.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConcelho.Location = new System.Drawing.Point(12, 175);
            this.lblConcelho.Name = "lblConcelho";
            this.lblConcelho.Size = new System.Drawing.Size(440, 68);
            this.lblConcelho.TabIndex = 1;
            this.lblConcelho.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(107, 124);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(250, 33);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmAvaliação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 252);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblConcelho);
            this.Controls.Add(this.lblApresentação);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAvaliação";
            this.Text = "Avaliação";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblApresentação;
        private Label lblConcelho;
        private Label lblResultado;
    }
}