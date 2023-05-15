namespace Mod10_Ex1
{
    partial class Frm_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmpregados = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpregados
            // 
            this.dgvEmpregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpregados.Location = new System.Drawing.Point(13, 13);
            this.dgvEmpregados.Name = "dgvEmpregados";
            this.dgvEmpregados.Size = new System.Drawing.Size(555, 335);
            this.dgvEmpregados.TabIndex = 0;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(594, 32);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Ver/Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(594, 73);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 2;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(594, 116);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 22);
            this.btn_remover.TabIndex = 3;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(594, 325);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 385);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dgvEmpregados);
            this.Name = "Frm_principal";
            this.Text = "GestEmpresa";
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpregados;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_sair;
    }
}

