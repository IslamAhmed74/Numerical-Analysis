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
    public partial class falsep : Form
    {
        
        double xolder = 0;
        double xr = 0;
        double error = 0;
        int counter = 1;
        public falsep()
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

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double xl = Convert.ToDouble(txt_xl.Text);
            double xu = Convert.ToDouble(txt_xu.Text);
            double Err = Convert.ToDouble(txt_err.Text);

            if (f(xl) * f(xu) < 0)
            {
                do
                {
                    xr = Math.Round(xu - ((f(xu) * (xl - xu)) / (f(xl) - f(xu))), 4);
                    
                    error = Math.Abs((xr - xolder) / xr) * 100;
                    xolder = xr;
                   

                    // Now you can add rows to the DataGridView
                    dataGridView1.Rows.Add(counter.ToString(), Math.Round(xl, 4).ToString(), Math.Round(f(xl), 4).ToString(), Math.Round(xu, 4).ToString(), Math.Round(f(xu), 4).ToString(), Math.Round(xr, 4).ToString(), Math.Round(f(xr), 4).ToString(), Math.Round(error, 4).ToString());
          
                    counter++;

                    if (f(xl) * f(xr) < 0)
                    {
                        xu = xr;
                    }
                    else if (f(xl) * f(xr) > 0)
                    {
                        xl = xr;
                    }
                } while (error > (Err / 100) * 100);

                txt_root.Text = Math.Round(xr,4).ToString();
                txt_ferr.Text = Math.Round(error,4).ToString();
            }
            else
                MessageBox.Show("No solution", "Warnning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_fx.Text = "";
            txt_xu.Text = "";
            txt_xl.Text = "";
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

        private void falsep_Load(object sender, EventArgs e)
        {

        }
    }
}
