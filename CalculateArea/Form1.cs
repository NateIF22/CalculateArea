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
            //if (!Validators.IsMinimumLength(txtWidth.Text, 1)||
            //    !Validators.IsMinimumLength(txtHeight.Text, 1))
            //{
            //    var result = MessageBox.Show(
            //        "Your values are not long enough.", //Message
            //        "Error", //Title Message
            //        MessageBoxButtons.OKCancel); //Button


            //    if (result == DialogResult.OK)
            //    {
            //        MessageBox.Show("Glad you are OK with it.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Canciling...");
            //    }
            //        return;
            //}
            //if (!Validators.IsInteger(txtWidth.Text)||
            //    !Validators.IsInteger(txtHeight.Text))
            //{
            //    MessageBox.Show("Please enter an integer", "Error");
            //    return;
            //}

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
