
namespace Biblioteca
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iBSNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palavraChaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maisLidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leitoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nºProcessoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requisitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoMovimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarMovimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porLeitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porEntregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem,
            this.leitoresToolStripMenuItem,
            this.movimentosToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.maisLidosToolStripMenuItem});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.livrosToolStripMenuItem.Text = "&Livros";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.livrosToolStripMenuItem_Click);
            // 
            // nomeToolStripMenuItem
            // 
            this.nomeToolStripMenuItem.Image = global::Biblioteca.Properties.Resources.pergunta;
            this.nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            this.nomeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nomeToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.nomeToolStripMenuItem.Text = "Novo";
            this.nomeToolStripMenuItem.Click += new System.EventHandler(this.nomeToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Image = global::Biblioteca.Properties.Resources.ok;
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tituloToolStripMenuItem,
            this.autorToolStripMenuItem,
            this.iBSNToolStripMenuItem,
            this.palavraChaveToolStripMenuItem});
            this.pesquisarToolStripMenuItem.Image = global::Biblioteca.Properties.Resources.os_valores;
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // tituloToolStripMenuItem
            // 
            this.tituloToolStripMenuItem.Name = "tituloToolStripMenuItem";
            this.tituloToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.tituloToolStripMenuItem.Text = "Mais Lidos";
            this.tituloToolStripMenuItem.Click += new System.EventHandler(this.tituloToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // iBSNToolStripMenuItem
            // 
            this.iBSNToolStripMenuItem.Name = "iBSNToolStripMenuItem";
            this.iBSNToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.iBSNToolStripMenuItem.Text = "Novidades";
            this.iBSNToolStripMenuItem.Click += new System.EventHandler(this.iBSNToolStripMenuItem_Click);
            // 
            // palavraChaveToolStripMenuItem
            // 
            this.palavraChaveToolStripMenuItem.Name = "palavraChaveToolStripMenuItem";
            this.palavraChaveToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.palavraChaveToolStripMenuItem.Text = "Palavra Chave";
            this.palavraChaveToolStripMenuItem.Click += new System.EventHandler(this.palavraChaveToolStripMenuItem_Click);
            // 
            // maisLidosToolStripMenuItem
            // 
            this.maisLidosToolStripMenuItem.Image = global::Biblioteca.Properties.Resources.pergunta;
            this.maisLidosToolStripMenuItem.Name = "maisLidosToolStripMenuItem";
            this.maisLidosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.maisLidosToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.maisLidosToolStripMenuItem.Text = "Mais Lidos";
            this.maisLidosToolStripMenuItem.Click += new System.EventHandler(this.maisLidosToolStripMenuItem_Click);
            // 
            // leitoresToolStripMenuItem
            // 
            this.leitoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.pesquisarToolStripMenuItem2});
            this.leitoresToolStripMenuItem.Name = "leitoresToolStripMenuItem";
            this.leitoresToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.leitoresToolStripMenuItem.Text = "&Leitores";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem2
            // 
            this.pesquisarToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeToolStripMenuItem2,
            this.cCToolStripMenuItem1,
            this.nºProcessoToolStripMenuItem1});
            this.pesquisarToolStripMenuItem2.Name = "pesquisarToolStripMenuItem2";
            this.pesquisarToolStripMenuItem2.Size = new System.Drawing.Size(153, 26);
            this.pesquisarToolStripMenuItem2.Text = "Pesquisar";
            // 
            // nomeToolStripMenuItem2
            // 
            this.nomeToolStripMenuItem2.Name = "nomeToolStripMenuItem2";
            this.nomeToolStripMenuItem2.Size = new System.Drawing.Size(171, 26);
            this.nomeToolStripMenuItem2.Text = "Nome";
            this.nomeToolStripMenuItem2.Click += new System.EventHandler(this.nomeToolStripMenuItem2_Click);
            // 
            // cCToolStripMenuItem1
            // 
            this.cCToolStripMenuItem1.Name = "cCToolStripMenuItem1";
            this.cCToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.cCToolStripMenuItem1.Text = "CC";
            this.cCToolStripMenuItem1.Click += new System.EventHandler(this.cCToolStripMenuItem1_Click);
            // 
            // nºProcessoToolStripMenuItem1
            // 
            this.nºProcessoToolStripMenuItem1.Name = "nºProcessoToolStripMenuItem1";
            this.nºProcessoToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.nºProcessoToolStripMenuItem1.Text = "Nº Processo";
            this.nºProcessoToolStripMenuItem1.Click += new System.EventHandler(this.nºProcessoToolStripMenuItem1_Click);
            // 
            // movimentosToolStripMenuItem
            // 
            this.movimentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requisitarToolStripMenuItem,
            this.devolverLivroToolStripMenuItem,
            this.históricoMovimentosToolStripMenuItem,
            this.pesquisarMovimentosToolStripMenuItem});
            this.movimentosToolStripMenuItem.Name = "movimentosToolStripMenuItem";
            this.movimentosToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.movimentosToolStripMenuItem.Text = "&Movimentos";
            // 
            // requisitarToolStripMenuItem
            // 
            this.requisitarToolStripMenuItem.Name = "requisitarToolStripMenuItem";
            this.requisitarToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.requisitarToolStripMenuItem.Text = "Requisitar Livro";
            this.requisitarToolStripMenuItem.Click += new System.EventHandler(this.requisitarToolStripMenuItem_Click);
            // 
            // devolverLivroToolStripMenuItem
            // 
            this.devolverLivroToolStripMenuItem.Name = "devolverLivroToolStripMenuItem";
            this.devolverLivroToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.devolverLivroToolStripMenuItem.Text = "Devolver Livro";
            this.devolverLivroToolStripMenuItem.Click += new System.EventHandler(this.devolverLivroToolStripMenuItem_Click);
            // 
            // históricoMovimentosToolStripMenuItem
            // 
            this.históricoMovimentosToolStripMenuItem.Name = "históricoMovimentosToolStripMenuItem";
            this.históricoMovimentosToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.históricoMovimentosToolStripMenuItem.Text = "Histórico Movimentos";
            this.históricoMovimentosToolStripMenuItem.Click += new System.EventHandler(this.históricoMovimentosToolStripMenuItem_Click);
            // 
            // pesquisarMovimentosToolStripMenuItem
            // 
            this.pesquisarMovimentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porLeitorToolStripMenuItem,
            this.porLivroToolStripMenuItem,
            this.porEntregarToolStripMenuItem});
            this.pesquisarMovimentosToolStripMenuItem.Name = "pesquisarMovimentosToolStripMenuItem";
            this.pesquisarMovimentosToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.pesquisarMovimentosToolStripMenuItem.Text = "Pesquisar Movimentos";
            // 
            // porLeitorToolStripMenuItem
            // 
            this.porLeitorToolStripMenuItem.Name = "porLeitorToolStripMenuItem";
            this.porLeitorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.porLeitorToolStripMenuItem.Text = "Por Leitor";
            this.porLeitorToolStripMenuItem.Click += new System.EventHandler(this.porLeitorToolStripMenuItem_Click);
            // 
            // porLivroToolStripMenuItem
            // 
            this.porLivroToolStripMenuItem.Name = "porLivroToolStripMenuItem";
            this.porLivroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.porLivroToolStripMenuItem.Text = "Por Livro";
            this.porLivroToolStripMenuItem.Click += new System.EventHandler(this.porLivroToolStripMenuItem_Click);
            // 
            // porEntregarToolStripMenuItem
            // 
            this.porEntregarToolStripMenuItem.Name = "porEntregarToolStripMenuItem";
            this.porEntregarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.porEntregarToolStripMenuItem.Text = "Por Entregar";
            this.porEntregarToolStripMenuItem.Click += new System.EventHandler(this.porEntregarToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem1});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem1
            // 
            this.autorToolStripMenuItem1.Name = "autorToolStripMenuItem1";
            this.autorToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.autorToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.autorToolStripMenuItem1.Text = "Autor";
            this.autorToolStripMenuItem1.Click += new System.EventHandler(this.autorToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1063, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Biblioteca.Properties.Resources.pergunta;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Novo Livro";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Biblioteca.Properties.Resources.ok;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Listar Livros";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Biblioteca.Properties.Resources.os_valores;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Pesquisar Livros";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Biblioteca.Properties.Resources.lups;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "Procurar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(741, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 22);
            this.textBox1.TabIndex = 4;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biblioteca.Properties.Resources.nao_perguntei;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 645);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iBSNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palavraChaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem leitoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentosToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem requisitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoMovimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarMovimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porLeitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porEntregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nºProcessoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maisLidosToolStripMenuItem;
    }
}

