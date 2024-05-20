using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuadraticEquationSolver;
namespace QuadraticEquationSolver
{
    public partial class QudraticEquationForm : Form
    {
        public QudraticEquationForm()
        {
            InitializeComponent();
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);
                double c = double.Parse(cTextBox.Text);

                var (root1, root2) = QuadraticSolver.Solve(a, b, c);

                if (root1 == null && root2 == null)
                {
                    resultLabel.Text = "No real roots";
                }
                else
                {
                    resultLabel.Text = $"Root 1: {root1}, Root 2: {root2}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void QudraticEquationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
