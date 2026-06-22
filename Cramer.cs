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
    public partial class Cramer : Form
    {
        public Cramer()
        {
            InitializeComponent();
        }

        private void Cramer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void txt_c3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_33_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_32_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_31_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_c2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_23_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_22_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_21_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_c1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_13_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_11_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_11.Text = ""; txt_12.Text = ""; txt_13.Text = ""; txt_c1.Text = "";
            txt_21.Text = ""; txt_22.Text = ""; txt_23.Text = ""; txt_c2.Text = "";
            txt_31.Text = ""; txt_32.Text = ""; txt_33.Text = ""; txt_c3.Text = "";

            txt_d.Text = "";  txt_d1.Text = "";  txt_d2.Text = ""; txt_d3.Text = "";

            txt_x1.Text = "";  txt_x2.Text = ""; txt_x3.Text = "";
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double x00 = Convert.ToDouble(txt_11.Text);
            double x01 = Convert.ToDouble(txt_12.Text);
            double x02 = Convert.ToDouble(txt_13.Text);
            double x03 = Convert.ToDouble(txt_c1.Text);

            double x10 = Convert.ToDouble(txt_21.Text);
            double x11 = Convert.ToDouble(txt_22.Text);
            double x12 = Convert.ToDouble(txt_23.Text);
            double x13 = Convert.ToDouble(txt_c2.Text);

            double x20 = Convert.ToDouble(txt_31.Text);
            double x21 = Convert.ToDouble(txt_32.Text);
            double x22 = Convert.ToDouble(txt_33.Text);
            double x23 = Convert.ToDouble(txt_c3.Text);

            double x000 = x00, x001 = x01, x002 = x02, x003 = x03;
            double x110 = x10, x111 = x11, x112 = x12, x113 = x13;
            double x220 = x20, x221 = x21, x222 = x22, x223 = x23;

            // calculate deter A 
            double DA = (x00 * ((x11 * x22) - (x12 * x21))) - (x01 * ((x10 * x22) - (x12 * x20))) + (x02 * ((x10 * x21) - (x11 * x20)));
            txt_d.Text = DA.ToString();

            // calculate deter A1
            // replace the first col with result 
            x00 = x03; x10 = x13; x20 = x23;
            double DA1 = (x00 * ((x11 * x22) - (x12 * x21))) - (x01 * ((x10 * x22) - (x12 * x20))) + (x02 * ((x10 * x21) - (x11 * x20)));
            txt_d1.Text = DA1.ToString();

            // calculate deter A2
            // replace the second col with result 
            x00 = x000; x10 = x110; x20 = x220;
            x01 = x03; x11 = x13; x21 = x23;
            double DA2 = (x00 * ((x11 * x22) - (x12 * x21))) - (x01 * ((x10 * x22) - (x12 * x20))) + (x02 * ((x10 * x21) - (x11 * x20)));
            txt_d2.Text = DA2.ToString();

            // calculate deter A3
            // replace the third col with result 
            x01 = x001; x11 = x111; x21 = x221;
            x02 = x03; x12 = x13; x22 = x23;
            double DA3 = (x00 * ((x11 * x22) - (x12 * x21))) - (x01 * ((x10 * x22) - (x12 * x20))) + (x02 * ((x10 * x21) - (x11 * x20)));
            txt_d3.Text = DA3.ToString();

            //calculate x
            double x1 = DA1 / DA; double x2 = DA2 / DA; double x3 = DA3 / DA;
            txt_x1.Text = x1.ToString();
            txt_x2.Text = x2.ToString();
            txt_x3.Text = x3.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            this.Hide();
            m.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_d_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
