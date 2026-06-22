namespace algorithmic_calculator
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            this.Hide();
            m.Show();
        }
    }
}