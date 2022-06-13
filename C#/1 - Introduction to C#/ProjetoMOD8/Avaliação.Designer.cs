namespace ProjetoMOD8
{
    partial class lblAvaliação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblAvaliação));
            this.lblApresentação = new System.Windows.Forms.Label();
            this.lblConcelho = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblApresentação
            // 
            this.lblApresentação.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApresentação.Location = new System.Drawing.Point(12, 29);
            this.lblApresentação.Name = "lblApresentação";
            this.lblApresentação.Size = new System.Drawing.Size(440, 93);
            this.lblApresentação.TabIndex = 0;
            this.lblApresentação.Text = "\r\n\r\n\r\n\r\n\r\n ";
            // 
            // lblConcelho
            // 
            this.lblConcelho.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConcelho.Location = new System.Drawing.Point(12, 192);
            this.lblConcelho.Name = "lblConcelho";
            this.lblConcelho.Size = new System.Drawing.Size(440, 23);
            this.lblConcelho.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(180, 140);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(100, 23);
            this.lblResultado.TabIndex = 2;
            // 
            // lblAvaliação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 252);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblConcelho);
            this.Controls.Add(this.lblApresentação);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lblAvaliação";
            this.Text = "Avaliação";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblApresentação;
        private Label lblConcelho;
        private Label lblResultado;
    }
}