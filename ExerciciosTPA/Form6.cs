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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        double peso, altura, IMC, altura_quadrado;
           
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            altura_quadrado = altura * altura;
            IMC = peso / altura_quadrado;

            if (IMC < 17)
                txtIMC.Text = "Magreza severa";
            else if (IMC >= 17 && IMC < 18.5)
                txtIMC.Text = "Magreza leve";
            else if (IMC >= 18.5 && IMC < 25)
                txtIMC.Text = "Peso normal";
            else if (IMC >= 25 && IMC < 30)
                txtIMC.Text = "Sobrepeso";
            else if (IMC >= 30 && IMC < 35)
                txtIMC.Text = "Obesidade classe I";
            else if (IMC >= 35 && IMC < 40)
                txtIMC.Text = "Obesidade classe II";
            else if (IMC >= 40)
                txtIMC.Text = "Obesidade classe III";
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
