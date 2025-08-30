namespace ExerciciosTPA
{
    partial class Form1
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
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLivros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiarquibancada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisalario = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCriadores = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercíciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLivros,
            this.tsmiarquibancada,
            this.tsmisalario});
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // tsmiLivros
            // 
            this.tsmiLivros.Name = "tsmiLivros";
            this.tsmiLivros.Size = new System.Drawing.Size(180, 22);
            this.tsmiLivros.Text = "Livros";
            this.tsmiLivros.Click += new System.EventHandler(this.tsmiLivros_Click);
            // 
            // tsmiarquibancada
            // 
            this.tsmiarquibancada.Name = "tsmiarquibancada";
            this.tsmiarquibancada.Size = new System.Drawing.Size(180, 22);
            this.tsmiarquibancada.Text = "arquibancada";
            this.tsmiarquibancada.Click += new System.EventHandler(this.tsmiarquibancada_Click);
            // 
            // tsmisalario
            // 
            this.tsmisalario.Name = "tsmisalario";
            this.tsmisalario.Size = new System.Drawing.Size(180, 22);
            this.tsmisalario.Text = "Salário";
            this.tsmisalario.Click += new System.EventHandler(this.tsmisalario_Click);
            // 
            // lblCriadores
            // 
            this.lblCriadores.AutoSize = true;
            this.lblCriadores.Location = new System.Drawing.Point(12, 428);
            this.lblCriadores.Name = "lblCriadores";
            this.lblCriadores.Size = new System.Drawing.Size(341, 13);
            this.lblCriadores.TabIndex = 1;
            this.lblCriadores.Text = "Projeto realizado por Alvaro Andrade Santos e Leonardo Souza Novais";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCriadores);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLivros;
        private System.Windows.Forms.ToolStripMenuItem tsmiarquibancada;
        private System.Windows.Forms.ToolStripMenuItem tsmisalario;
        private System.Windows.Forms.Label lblCriadores;
    }
}

