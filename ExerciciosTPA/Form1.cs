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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmiLivros_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 livro = new Form2();
            livro.Show();
        }

        private void tsmiarquibancada_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 arquibancada = new Form3();
            arquibancada.Show();
        }

        private void tsmisalario_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 salario = new Form4();
            salario.Show();
        }

        private void tsmiRestaurante_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 restaurante = new Form5();
            restaurante.Show();
        }

        private void tsmiIMC_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 IMC = new Form6();
            IMC.Show();
        }
    }
}
