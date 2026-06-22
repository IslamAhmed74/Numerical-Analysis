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
    public partial class Newton : Form
    {
        double Xnew = 0;
        double xi = 0;
        double error = 0;
        int counter = 0;
        public Newton()
        {
            InitializeComponent();
        }

        double f(double xx)
        {

            CalculationEngine engine = new CalculationEngine();

            Dictionary<string, double> variables = new Dictionary<string, double>();
            variables.Add("x", xx);
            string func = txt_fx.Text;
            double result = engine.Calculate(func, variables);
            return result;

        }
        double Fdash(double xx)
        {

            CalculationEngine engine = new CalculationEngine();

            Dictionary<string, double> variables = new Dictionary<string, double>();
            variables.Add("x", xx);
            string func = txt_fdx.Text;
            double result = engine.Calculate(func, variables);
            return result;

        }
        void Newto(double x)
        {
            if (counter == 0)
            {
                xi = x;
                dataGridView1.Rows.Add(counter.ToString(), Math.Round(xi, 4).ToString(), Math.Round(f(xi), 4).ToString(), Math.Round(Fdash(xi)).ToString(), "---");
                counter++;
                Newto(xi);
            }
            else
            {
                xi = x;
                Xnew = xi - (f(xi) / Fdash(xi));
                error = Math.Abs((Xnew - xi) / Xnew) * 100;

                dataGridView1.Rows.Add(counter.ToString(), Math.Round(Xnew, 4).ToString(), Math.Round(f(Xnew), 5).ToString(), Math.Round(Fdash(Xnew), 5).ToString(), Math.Round(error, 4).ToString());
                counter++;
                double Err = Convert.ToDouble(txt_err.Text);
                if (error > Err)
                    Newto(Xnew);
            }
            txt_root.Text = Math.Round(Xnew, 4).ToString();
            txt_ferr.Text = Math.Round(error, 4).ToString();
        }

        private void Newton_Load(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(txt_x0.Text);
            Newto(x0);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            this.Hide();
            m.Show();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_fx.Text = "";
            txt_x0.Text = "";
            txt_fdx.Text = "";
            txt_root.Text = "";
            txt_ferr.Text = "";
            txt_err.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void txt_fx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
