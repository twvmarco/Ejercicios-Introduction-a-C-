namespace TextBox_para_valores_numericos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblresultado.Text = "";
            txta.Text = "0";
            txtb.Text = "0";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);

            double r = a + b;
            lblresultado.Text = r.ToString();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);

            double r = a - b;
            lblresultado.Text = r.ToString();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);

            double r = a * b;
            lblresultado.Text = r.ToString();
        }

        private void btndif_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);

            double r = a / b;
            lblresultado.Text = r.ToString();
        }
    }
}
