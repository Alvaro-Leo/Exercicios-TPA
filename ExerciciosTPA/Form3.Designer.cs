namespace ExerciciosTPA
{
    partial class Form3
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
            this.txtarquibancada = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtTOT = new System.Windows.Forms.TextBox();
            this.lblArquibancada = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtarquibancada
            // 
            this.txtarquibancada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarquibancada.Location = new System.Drawing.Point(458, 77);
            this.txtarquibancada.Name = "txtarquibancada";
            this.txtarquibancada.Size = new System.Drawing.Size(153, 38);
            this.txtarquibancada.TabIndex = 0;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(462, 295);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(145, 43);
            this.btncalcular.TabIndex = 1;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtTOT
            // 
            this.txtTOT.Enabled = false;
            this.txtTOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOT.Location = new System.Drawing.Point(458, 164);
            this.txtTOT.Name = "txtTOT";
            this.txtTOT.Size = new System.Drawing.Size(153, 38);
            this.txtTOT.TabIndex = 2;
            // 
            // lblArquibancada
            // 
            this.lblArquibancada.AutoSize = true;
            this.lblArquibancada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquibancada.Location = new System.Drawing.Point(93, 80);
            this.lblArquibancada.Name = "lblArquibancada";
            this.lblArquibancada.Size = new System.Drawing.Size(292, 31);
            this.lblArquibancada.TabIndex = 3;
            this.lblArquibancada.Text = "Quantidade do público:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(93, 167);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(235, 31);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Arrecadação total:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(168, 295);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(145, 43);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblArquibancada);
            this.Controls.Add(this.txtTOT);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtarquibancada);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtarquibancada;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtTOT;
        private System.Windows.Forms.Label lblArquibancada;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnVoltar;
    }
}