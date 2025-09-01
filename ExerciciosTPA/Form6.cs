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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, IMC;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            IMC = peso * (altura * altura);

            if (IMC < 17.0)
                txtIMC.Text = "Magreza severa";
            if (IMC >= 17 && IMC < 18.5)
                txtIMC.Text = "Magreza leve";
            if (IMC >= 18.5 && IMC < 25.0)
                txtIMC.Text = "Peso normal";
            if (IMC >= 25 && IMC < 30)
                txtIMC.Text = "Sobrepeso";
            if (IMC >= 30 && IMC < 35)
                txtIMC.Text = "Obesidade classe I";
            if (IMC >= 35 && IMC < 40)
                txtIMC.Text = "Obesidade classe II";
            if (IMC >= 40)
                txtIMC.Text = "Obesidade classe III";
            
        }
    }
}
