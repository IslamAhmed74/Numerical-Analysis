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
    public partial class secant : Form
    {
        double Xold = 0;
        double xi = 0;
        double error = 0;
        int counter = 0;
        double xnew = 0;
        public secant()
        {
            InitializeComponent();
        }
        double f(double x)
        {

            CalculationEngine engine = new CalculationEngine();

            Dictionary<string, double> variables = new Dictionary<string, double>();
            variables.Add("x", x);
            string func = txt_fx.Text;
            double result = engine.Calculate(func, variables);
            return result;

        }
        void Secan(double xol, double x0)
        {

            if (counter == 0)
            {
                Xold = xol;
                xi = x0;
                dataGridView1.Rows.Add(counter.ToString(), Math.Round(Xold, 4).ToString(), Math.Round(f(Xold), 4).ToString(), Math.Round(xi, 4).ToString(), Math.Round(f(xi), 4).ToString(), "---");
                counter++; Secan(Xold, xi);
            }
            else
            {
                Xold = xol;
                xi = x0;
                xnew = xi - ((f(xi) * (Xold - xi)) / (f(Xold) - f(xi)));
                error = Math.Abs((xnew - xi) / xnew) * 100;

               
                dataGridView1.Rows.Add(counter.ToString(), Math.Round(xi, 4).ToString(), Math.Round(f(xi), 4).ToString(), Math.Round(xnew, 4).ToString(), Math.Round(f(xnew), 4).ToString(), Math.Round(error, 4).ToString()); 
                counter++;
                double Err = Convert.ToDouble(txt_err.Text);
                if (error > Err)
                    Secan(xi, xnew);
            }
            txt_root.Text = Math.Round(xnew, 4).ToString();
            txt_ferr.Text = Math.Round(error, 4).ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_fx.Text = "";
            txt_x0.Text = "";
            txt_xold.Text = "";
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

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double xol = Convert.ToDouble(txt_xold.Text);
            double x0 = Convert.ToDouble(txt_x0.Text);
            Secan(xol, x0);
        }
    }
}
