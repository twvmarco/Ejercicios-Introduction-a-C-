namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndespedida_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = "Adios!";
            this.Text = "bye";
        }

        private void btnsaludo_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = "Hola a todos!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblmensaje.Text = "";
        }
    }
}
