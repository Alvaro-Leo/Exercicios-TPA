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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string nome, sexo;
            double idade, sal, NS;
            idade = Convert.ToDouble(txtidade.Text);
            nome = txtnome.Text;
            sexo = txtnome.Text;
            sal = Convert.ToDouble(txtsal.Text);
            if (idade >= 30)
            {
                if (sexo == "M")
                    NS = sal + 100;
                else
                    NS = sal + 200;
            }
            else
            {
                if (sexo == "M")
                    NS = sal + 50;
                else
                    NS = sal + 150;
            }
            txtnovosal.Text = NS.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
