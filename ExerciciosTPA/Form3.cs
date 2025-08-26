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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double PUB, CAD, POP, GER, ARQ, RARQ, RCAD, RPOP, RGER, TOT;
        private void btncalcular_Click(object sender, EventArgs e)
        {
          
            PUB = Convert.ToDouble(txtarquibancada.Text);
            POP = PUB * 0.1;
            GER = PUB * 0.5;
            CAD = PUB * 0.3;
            ARQ = PUB * 0.1;
            if (POP > 0)
                RPOP = POP * 5;
            if (GER > 0)
                RGER = GER * 10;
            if (ARQ > 0)
                RARQ = ARQ * 20;
            if (CAD > 0)
                RCAD = CAD * 30;

            TOT = RCAD + RGER + RPOP + RARQ;
            txtTOT.Text = TOT.ToString();


        }
    }
}
