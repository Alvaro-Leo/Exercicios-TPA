namespace ExerciciosTPA
{
    partial class Form2
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
            this.txtlivros = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtlivros
            // 
            this.txtlivros.Location = new System.Drawing.Point(45, 85);
            this.txtlivros.Name = "txtlivros";
            this.txtlivros.Size = new System.Drawing.Size(100, 20);
            this.txtlivros.TabIndex = 0;
            this.txtlivros.Text = ".";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(45, 151);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 1;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(240, 131);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(84, 40);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "button1";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtlivros);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlivros;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Button btncalcular;
    }
}