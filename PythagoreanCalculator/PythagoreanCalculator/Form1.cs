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
            double a, b;

            // Check if inputs are empty
            if (string.IsNullOrWhiteSpace(txtA.Text) || string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show("Please enter values for both A and B.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if inputs are valid numbers
            if (!double.TryParse(txtA.Text, out a) || !double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Only numeric values are allowed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for negative or zero values
            if (a <= 0 || b <= 0)
            {
                MessageBox.Show("Please enter positive values greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Perform calculation
            double c = Math.Sqrt(a * a + b * b);
            lblResult.Text = "Hypotenuse (C) = " + c.ToString("F2");

            string result = "A = " + a + ", B = " + b + ", C = " + c;


            // Add to history
            history.Add(result);
        }


        private List<string> history = new List<string>();

        private void btnHistory_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();

            if (history.Count == 0)
            {
                MessageBox.Show("No calculation history available.", "History", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (string item in history)
            {
                lstHistory.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            lblResult.Text = "";
        }
    }
}
