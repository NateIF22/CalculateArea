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
            if (!Validators.IsMinimumLength(txtWidth.Text, 1)||
                !Validators.IsMinimumLength(txtHeight.Text, 1))
            {
                MessageBox.Show("Your values are not long enough.");
                return;
            }
            if (!Validators.IsInteger(txtWidth.Text)||
                !Validators.IsInteger(txtHeight.Text))
            {
                MessageBox.Show("Please enter an integer");
                return;
            }

            // calculate the width x the height
            int total = (int.Parse(txtHeight.Text)) * (int.Parse(txtWidth.Text));

            // change the total lable to match.
            lblTotal.Text = "Total: " + total.ToString();
        }
    }
}
