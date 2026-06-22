using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithmic_calculator
{
    public partial class Methods : Form
    {
        public Methods()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LU l = new LU();
            this.Hide();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home h = new home();
            this.Hide();
            h.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bisection b = new bisection();
            this.Hide();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            falsep f = new falsep();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fixedPoint f = new fixedPoint();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Newton n = new Newton();
            this.Hide();
            n.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            secant s = new secant();
            this.Hide();
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gauss g = new gauss();
            this.Hide();
            g.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cramer c = new Cramer();
            this.Hide();
            c.Show();
        }
    }
}
