namespace WinFormsApp5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double poper, teper, zina;
            poper = double.Parse(textBox1.Text);
            teper = double.Parse(textBox2.Text);
            zina = double.Parse(textBox3.Text);
            double result = (teper - poper) * zina;
            label7.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
