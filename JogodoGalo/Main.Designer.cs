namespace JogodoGalo
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoJogoToolStripMenuItem,
            this.fecharJogoToolStripMenuItem,
            this.scoreBoardToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoJogoToolStripMenuItem
            // 
            this.novoJogoToolStripMenuItem.Name = "novoJogoToolStripMenuItem";
            this.novoJogoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.novoJogoToolStripMenuItem.Text = "Novo jogo";
            this.novoJogoToolStripMenuItem.Click += new System.EventHandler(this.novoJogoToolStripMenuItem_Click);
            // 
            // fecharJogoToolStripMenuItem
            // 
            this.fecharJogoToolStripMenuItem.Name = "fecharJogoToolStripMenuItem";
            this.fecharJogoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.fecharJogoToolStripMenuItem.Text = "Fechar Jogo";
            this.fecharJogoToolStripMenuItem.Click += new System.EventHandler(this.fecharJogoToolStripMenuItem_Click);
            // 
            // scoreBoardToolStripMenuItem
            // 
            this.scoreBoardToolStripMenuItem.Name = "scoreBoardToolStripMenuItem";
            this.scoreBoardToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.scoreBoardToolStripMenuItem.Text = "ScoreBoard";
            this.scoreBoardToolStripMenuItem.Click += new System.EventHandler(this.scoreBoardToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}