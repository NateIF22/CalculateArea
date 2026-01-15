namespace CalculateArea
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // calculate the width x the height
            int total = (int.Parse(txtHeight.Text)) * (int.Parse(txtWidth.Text));

            // change the total lable to match.
            lblTotal.Text = "Total: " + total.ToString();
        }
    }
}
