namespace CalculateArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateField(txtWidth.Text, "The width property is too short."))
            {
                return;
            }

            if (!Validators.ContainsInteger(txtWidth.Text, out int width))
            {
                MessageBox.Show("Width does not contain a number.", "Please try again.");
                return;
            }

            // De Morgan's Law:
            //!(p && x)  ==> !p || !x

            if (ValidateField(txtHeight.Text, "The height property is too short."))
            {
                return;
            }

            if (!Validators.ContainsInteger(txtHeight.Text, out int height))
            {
                MessageBox.Show("Height does not contain a number.", "Please try again.");
                return;
            }

            // calculate the width x the height
            int total = (height) * (width);

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
