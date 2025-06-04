using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
namespace PythagoreanCalculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double a, b;

            if (string.IsNullOrWhiteSpace(txtA.Text) || string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show("Please enter values for both A and B.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtA.Text, out a) || !double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Only numeric values are allowed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (a <= 0 || b <= 0)
            {
                MessageBox.Show("Please enter positive values greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double c = Math.Sqrt(a * a + b * b);
            string result = "A = "+a+", B = "+b+", C = "+c;
            lblResult.Text = "Hypotenuse (C) = " + c.ToString("F2");

            // Add to history
            history.Add(result);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            
        }
    }

*/

namespace PythagoreanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double c = Math.Sqrt(a * a + b * b);
            lblResult.Text = "Hypotenuse (C) = " + c.ToString("F2");
        }
    }
}
