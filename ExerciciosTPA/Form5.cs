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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int COD;
            COD = Convert.ToInt32(txtCod.Text);

            switch(COD)
            {
                case 100:
                    txtNome.Text = "Cachorro Quente";
                    txtPreco.Text = "R$25,00";
                    break;
                case 101:
                    txtNome.Text = "Bauru";
                    txtPreco.Text = "R$15,00";
                    break;
                case 102:
                    txtNome.Text = "X-Burguer";
                    txtPreco.Text = "R$35,00";
                    break;
                case 103:
                    txtNome.Text = "Triplo";
                    txtPreco.Text = "R$47,00";
                    break;
                default:
                    txtNome.Text = "Não existe";
                    txtPreco.Text = "----------";
                    break;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
