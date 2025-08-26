namespace ExerciciosTPA
{
    partial class Form4
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtnovosal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(50, 35);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 0;
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(50, 85);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(100, 20);
            this.txtsexo.TabIndex = 1;
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(50, 138);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(100, 20);
            this.txtsal.TabIndex = 2;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(50, 188);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(100, 20);
            this.txtidade.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(399, 185);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "button1";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtnovosal
            // 
            this.txtnovosal.Location = new System.Drawing.Point(50, 237);
            this.txtnovosal.Name = "txtnovosal";
            this.txtnovosal.Size = new System.Drawing.Size(100, 20);
            this.txtnovosal.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnovosal);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.txtnome);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtnovosal;
    }
}