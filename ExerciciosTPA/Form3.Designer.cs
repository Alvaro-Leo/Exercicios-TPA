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
            this.SuspendLayout();
            // 
            // txtarquibancada
            // 
            this.txtarquibancada.Location = new System.Drawing.Point(44, 35);
            this.txtarquibancada.Name = "txtarquibancada";
            this.txtarquibancada.Size = new System.Drawing.Size(100, 20);
            this.txtarquibancada.TabIndex = 0;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(266, 55);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 1;
            this.btncalcular.Text = "button1";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtTOT
            // 
            this.txtTOT.Location = new System.Drawing.Point(44, 99);
            this.txtTOT.Name = "txtTOT";
            this.txtTOT.Size = new System.Drawing.Size(100, 20);
            this.txtTOT.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}