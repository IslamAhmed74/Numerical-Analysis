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
    public partial class LU : Form
    {
        double m21 = 0, m31 = 0, m32 = 0;
        double x1 = 0, x2 = 0, x3 = 0;
        public LU()
        {
            InitializeComponent();
        }

        private void LU_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_rb3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txt_r11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_r33_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_r12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_r13_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_r32_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_rb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_r21_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_r31_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_r22_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_r23_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_rb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
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

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_11.Text = "";  txt_12.Text = "";  txt_13.Text = ""; txt_c1.Text = "";
            txt_21.Text = "";  txt_22.Text = "";  txt_23.Text = ""; txt_c2.Text = "";
            txt_31.Text = "";  txt_32.Text = "";  txt_33.Text = ""; txt_c3.Text = "";

            txt_r11.Text = ""; txt_r12.Text = ""; txt_r13.Text = ""; txt_rb1.Text = "";
            txt_r21.Text = ""; txt_r22.Text = ""; txt_r23.Text = ""; txt_rb2.Text = "";
            txt_r31.Text = ""; txt_r32.Text = ""; txt_r33.Text = ""; txt_rb3.Text = "";

            txt_u11.Text = ""; txt_u12.Text = ""; txt_u13.Text = "";   
            txt_u21.Text = ""; txt_u22.Text = ""; txt_u23.Text = "";   
            txt_u31.Text = ""; txt_u32.Text = ""; txt_u33.Text = "";   

            txt_l11.Text = ""; txt_l12.Text = ""; txt_l13.Text = "";
            txt_l21.Text = ""; txt_l22.Text = ""; txt_l23.Text = "";
            txt_l31.Text = ""; txt_l32.Text = ""; txt_l33.Text = "";

            txt_b11.Text = ""; txt_b21.Text = ""; txt_b31.Text = "";

            txt_ll11.Text = ""; txt_ll12.Text = ""; txt_ll13.Text = "";
            txt_ll21.Text = ""; txt_ll22.Text = ""; txt_ll23.Text = "";
            txt_ll31.Text = ""; txt_ll32.Text = ""; txt_ll33.Text = "";

            txt_bb1.Text = ""; txt_bb2.Text = ""; txt_bb3.Text = "";

            txt__c1.Text = ""; txt__c2.Text = ""; txt__c3.Text = "";

            txt_cc1.Text = ""; txt_cc2.Text = ""; txt_cc3.Text = "";

            txt_x1.Text = ""; txt_x2.Text = ""; txt_x3.Text = "";
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

            double b03 = x03; double b13 = x13; double b23 = x23;

            m21 = x10 / x00;
            m31 = x20 / x00;

            x10 = x10 - (m21 * x00); x11 = x11 - (m21 * x01);
            x12 = x12 - (m21 * x02); x13 = x13 - (m21 * x03);

            x20 = x20 - (m31 * x00); x21 = x21 - (m31 * x01);
            x22 = x22 - (m31 * x02); x23 = x23 - (m31 * x03);

            m32 = x21 / x11;

            x20 = x20 - (m32 * x10); x21 = x21 - (m32 * x11);
            x22 = x22 - (m32 * x12); x23 = x23 - (m32 * x13);

            txt_r11.Text = x00.ToString(); txt_r12.Text = x01.ToString();
            txt_r13.Text = x02.ToString(); txt_rb1.Text = x03.ToString();

            txt_r21.Text = x10.ToString(); txt_r22.Text = x11.ToString();
            txt_r23.Text = x12.ToString(); txt_rb2.Text = x13.ToString();

            txt_r31.Text = x20.ToString(); txt_r32.Text = x21.ToString();
            txt_r33.Text = x22.ToString(); txt_rb3.Text = x23.ToString();

            double u00 = x00; double u01 = x01; double u02 = x02;
            double u10 = x10; double u11 = x11; double u12 = x12;
            double u20 = x20; double u21 = x21; double u22 = x22;

            double l00 = 1; double l01 = 0; double l02 = 0;
            double l10 = m21; double l11 = 1; double l12 = 0;
            double l20 = m31; double l21 = m32; double l22 = 1;

            txt_u11.Text = u00.ToString(); txt_u12.Text = u01.ToString(); txt_u13.Text = u02.ToString();
            txt_u21.Text = u10.ToString(); txt_u22.Text = u11.ToString(); txt_u23.Text = u12.ToString();
            txt_u31.Text = u20.ToString(); txt_u32.Text = u21.ToString(); txt_u33.Text = u22.ToString();

            txt_l11.Text = l00.ToString(); txt_l12.Text = l01.ToString(); txt_l13.Text = l02.ToString();
            txt_l21.Text = l10.ToString(); txt_l22.Text = l11.ToString(); txt_l23.Text = l12.ToString();
            txt_l31.Text = l20.ToString(); txt_l32.Text = l21.ToString(); txt_l33.Text = l22.ToString();

            txt_b11.Text = b03.ToString(); txt_b21.Text = b13.ToString(); txt_b31.Text = b23.ToString();

            txt_ll11.Text = l00.ToString(); txt_ll12.Text = l01.ToString(); txt_ll13.Text = l02.ToString();
            txt_ll21.Text = l10.ToString(); txt_ll22.Text = l11.ToString(); txt_ll23.Text = l12.ToString();
            txt_ll31.Text = l20.ToString(); txt_ll32.Text = l21.ToString(); txt_ll33.Text = l22.ToString();

            txt_bb1.Text = b03.ToString(); txt_bb2.Text = b13.ToString(); txt_bb3.Text = b23.ToString();

            double c1 = b03 / l00;
            double c2 = (b13 - (l10) * c1) / l11;
            double c3 = (b23 - ((l20 * c1) + (l21 * c2))) / l22;

            txt__c1.Text = c1.ToString();
            txt__c2.Text = c2.ToString();
            txt__c3.Text = c3.ToString();

         

            txt_uu11.Text = u00.ToString(); txt_uu12.Text = u01.ToString(); txt_uu13.Text = u02.ToString();
            txt_uu21.Text = u10.ToString(); txt_uu22.Text = u11.ToString(); txt_uu23.Text = u12.ToString();
            txt_uu31.Text = u20.ToString(); txt_uu32.Text = u21.ToString(); txt_uu33.Text = u22.ToString();

            txt_cc1.Text = c1.ToString();
            txt_cc2.Text = c2.ToString();
            txt_cc3.Text = c3.ToString();

            double x3 = c3 / u22;
            double x2 = (c2 - (u12 * x3)) / u11;
            double x1 = (c1 - (u01 * x2) - (u02 * x3)) / u00;

            txt_x1.Text = x1.ToString();
            txt_x2.Text = x2.ToString();
            txt_x3.Text = x3.ToString();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void txt_u11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_u12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_u13_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_u21_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_u22_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_u23_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_u31_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_u32_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_u33_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void txt_l22_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_l31_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_l21_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_l32_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_l13_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_l12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_l33_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_l11_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void txt_b11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_b12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_b13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_ll11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox16_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
               
        }

        private void txt__x1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt__x2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt__x3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void txt_bb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_ll11_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            this.Hide();
            m.Show();
        }
    }
}
