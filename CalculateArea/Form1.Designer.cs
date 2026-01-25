namespace CalculateArea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtWidth = new TextBox();
            lblWidth = new Label();
            lblHeight = new Label();
            txtHeight = new TextBox();
            btnCalculate = new Button();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(155, 9);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(106, 27);
            txtWidth.TabIndex = 0;
            txtWidth.Text = "0";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(99, 9);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(49, 20);
            lblWidth.TabIndex = 1;
            lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(98, 46);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(54, 20);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Height";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(154, 46);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(107, 27);
            txtHeight.TabIndex = 2;
            txtHeight.Text = "0";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(135, 176);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(204, 112);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(57, 20);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 247);
            Controls.Add(lblTotal);
            Controls.Add(btnCalculate);
            Controls.Add(lblHeight);
            Controls.Add(txtHeight);
            Controls.Add(lblWidth);
            Controls.Add(txtWidth);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWidth;
        private Label lblWidth;
        private Label lblHeight;
        private TextBox txtHeight;
        private Button btnCalculate;
        private Label lblTotal;
    }
}
