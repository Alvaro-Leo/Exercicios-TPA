using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosTPA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double livros, TOT;
            livros = Convert.ToDouble(txtlivros.Text);
            if (livros > 10)
                TOT = livros * 8;
            else
                TOT = livros * 12;
            txtpreco.Text = TOT.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
