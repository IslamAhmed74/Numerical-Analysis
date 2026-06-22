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
    public partial class gauss : Form
    {
        double m21 = 0, m31 = 0, m32 = 0;
        double x1 = 0, x2 = 0, x3 = 0;
        public gauss()
        {
            InitializeComponent();
        }

        private void gauss_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Methods m = new Methods();
            this.Hide();
            m.Show();
        }

        
        private void btn_clr_Click(object sender, EventArgs e)
        {

            txt_11.Text = "";  txt_12.Text = "";  txt_13.Text = "";  txt_c1.Text = "";

            txt_21.Text = "";  txt_22.Text = "";  txt_23.Text = "";  txt_c2.Text = "";

            txt_31.Text = "";  txt_32.Text = "";  txt_33.Text = "";  txt_c3.Text = "";
        


            txt_r11.Text = "";  txt_r12.Text = "";  txt_r13.Text = "";  txt_rb1.Text = "";

            txt_r21.Text = "";  txt_r22.Text = "";  txt_r23.Text = "";  txt_rb2.Text = "";

            txt_r31.Text = "";  txt_r32.Text = "";  txt_r33.Text = "";  txt_rb3.Text = "";


            txt_x1.Text = ""; txt_x2.Text = ""; txt_x3.Text = "";
            txt_m21.Text = ""; txt_m31.Text = ""; txt_m32.Text = "";


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

            m21 = x10 / x00;
            m31 = x20 / x00;


            x10 = x10 - (m21 * x00);
            x11 = x11 - (m21 * x01);
            x12 = x12 - (m21 * x02);
            x13 = x13 - (m21 * x03);

            x20 = x20 - (m31 * x00);
            x21 = x21 - (m31 * x01);
            x22 = x22 - (m31 * x02);
            x23 = x23 - (m31 * x03);

            m32 = x21 / x11;

            x20 = x20 - (m32 * x10);
            x21 = x21 - (m32 * x11);
            x22 = x22 - (m32 * x12);
            x23 = x23 - (m32 * x13);

            txt_r11.Text = x00.ToString();
            txt_r12.Text = x01.ToString();
            txt_r13.Text = x02.ToString();
            txt_rb1.Text = x03.ToString();

            txt_r21.Text = x10.ToString();
            txt_r22.Text = x11.ToString();
            txt_r23.Text = x12.ToString();
            txt_rb2.Text = x13.ToString();

            txt_r31.Text = x20.ToString();
            txt_r32.Text = x21.ToString();
            txt_r33.Text = x22.ToString();
            txt_rb3.Text = x23.ToString();

            x3 = x23 / x22;
            x2 = (x13 - (x12 * x3)) / x11;
            x1 = (x03 - (x01 * x2) - (x02 * x3)) / x00;

            txt_x1.Text = x1.ToString();
            txt_x2.Text = x2.ToString();
            txt_x3.Text = x3.ToString();

            txt_m21.Text = m21.ToString();
            txt_m31.Text = m31.ToString();
            txt_m32.Text = m32.ToString();
        }
    }
}
