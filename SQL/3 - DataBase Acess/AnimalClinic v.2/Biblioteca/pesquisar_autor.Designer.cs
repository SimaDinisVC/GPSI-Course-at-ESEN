
namespace Biblioteca
{
    partial class pesquisar_autor
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
            this.CB_Autor = new System.Windows.Forms.ComboBox();
            this.DGV_Livros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Livros)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Autor
            // 
            this.CB_Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Autor.FormattingEnabled = true;
            this.CB_Autor.Location = new System.Drawing.Point(36, 24);
            this.CB_Autor.Name = "CB_Autor";
            this.CB_Autor.Size = new System.Drawing.Size(266, 28);
            this.CB_Autor.TabIndex = 0;
            this.CB_Autor.SelectedIndexChanged += new System.EventHandler(this.CB_Autor_SelectedIndexChanged);
            // 
            // DGV_Livros
            // 
            this.DGV_Livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Livros.Location = new System.Drawing.Point(36, 78);
            this.DGV_Livros.Name = "DGV_Livros";
            this.DGV_Livros.Size = new System.Drawing.Size(637, 293);
            this.DGV_Livros.TabIndex = 1;
            // 
            // pesquisar_autor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 399);
            this.Controls.Add(this.DGV_Livros);
            this.Controls.Add(this.CB_Autor);
            this.Name = "pesquisar_autor";
            this.Text = "pesquisar_autor";
            this.Load += new System.EventHandler(this.pesquisar_autor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Livros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Autor;
        private System.Windows.Forms.DataGridView DGV_Livros;
    }
}