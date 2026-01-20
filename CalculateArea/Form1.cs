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
            if (ValidateField(txtWidth.Text, "The width property is too short."))
            {
                return;
            }

            if (ValidateField(txtHeight.Text, "The height property is too short."))
            {
                return;
            }

            // calculate the width x the height
            int total = (int.Parse(txtHeight.Text)) * (int.Parse(txtWidth.Text));

            // change the total lable to match.
            lblTotal.Text = "Total: " + total.ToString();
        }

        private bool ValidateField(string field, string errorMessage) 
        {
            var result = !Validators.IsMinimumLength(field, 1);

            if (result)
            {
                var dialogResult = MessageBox.Show(
                    errorMessage,
                    "Error"
                    );
            }

            return result;
        }
    }
}
