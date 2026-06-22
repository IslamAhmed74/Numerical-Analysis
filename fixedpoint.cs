using Jace;
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
    public partial class fixedPoint : Form
    {

        double Xnew = 0;
        double xi = 0;
        double error = 0;
        int counter = 0;
        public fixedPoint()
        {
            InitializeComponent();
        }

        double f(double x)
        {

            CalculationEngine engine = new CalculationEngine();

            Dictionary<string, double> variables = new Dictionary<string, double>();
            variables.Add("x", x);
            string func = txt_fx.Text;
            double result =Math.Sqrt(engine.Calculate(func, variables));
            return result;
        }

        void Fixedpoint(double x)
        {
            
       
            xi = x;
            Xnew = f(xi);
            if (counter == 0)
            {
                dataGridView1.Rows.Add(counter.ToString(), Math.Round(xi, 4).ToString(), Math.Round(f(xi), 4), "----");
                counter++;
                Fixedpoint(Xnew);
            }
            else
            {

                error = Math.Abs((Xnew - xi) / Xnew) * 100;

                dataGridView1.Rows.Add(counter.ToString(), Math.Round(Xnew, 4).ToString(), Math.Round(f(Xnew), 4).ToString(), Math.Round(error, 4).ToString());
                counter++;
                double Err = Convert.ToDouble(txt_err.Text);
                if (error > Err)
                {
                    Fixedpoint(Xnew);
                }



                txt_root.Text = Math.Round(Xnew, 4).ToString();
                txt_ferr.Text = Math.Round(error, 4).ToString();
            }
        }

        private void fixedPoint_Load(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(txt_x0.Text);
            Fixedpoint(x0);
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_fx.Text = "";
            txt_x0.Text = "";
            txt_root.Text = "";
            txt_ferr.Text = "";
            txt_err.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            this.Hide();
            m.Show();
        }
    }
}