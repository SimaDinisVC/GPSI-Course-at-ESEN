
namespace Biblioteca
{
    partial class Mostrar_Leitores
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
            this.dgv_leitores = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_parametro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leitores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_leitores
            // 
            this.dgv_leitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_leitores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_leitores.Location = new System.Drawing.Point(0, 71);
            this.dgv_leitores.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_leitores.Name = "dgv_leitores";
            this.dgv_leitores.RowHeadersWidth = 62;
            this.dgv_leitores.Size = new System.Drawing.Size(959, 466);
            this.dgv_leitores.TabIndex = 0;
            this.dgv_leitores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_leitores_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_parametro
            // 
            this.lbl_parametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parametro.Location = new System.Drawing.Point(13, 23);
            this.lbl_parametro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_parametro.Name = "lbl_parametro";
            this.lbl_parametro.Size = new System.Drawing.Size(144, 25);
            this.lbl_parametro.TabIndex = 3;
            this.lbl_parametro.Text = "label1";
            this.lbl_parametro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Mostrar_Leitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 537);
            this.Controls.Add(this.lbl_parametro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgv_leitores);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mostrar_Leitores";
            this.Text = "Mostrar_Leitores";
            this.Load += new System.EventHandler(this.Mostrar_Leitores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leitores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_leitores;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_parametro;
    }
}