using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsForm
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        int sum;
        int choice;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumberOne_Click(object sender, EventArgs e)
        {
            txtInputField.AppendText("1");
        }

        private void btnNumberTwo_Click(object sender, EventArgs e)
        {
            txtInputField.AppendText("2");
        }

        private void btnNumberThree_Click(object sender, EventArgs e)
        {
            txtInputField.AppendText("3");
        }

        private void btnNumberFour_Click(object sender, EventArgs e)
        {
            txtInputField.AppendText("4");
        }

        private void btnNumberFive_Click(object sender, EventArgs e)
        {
            txtInputField.AppendText("5");
        }

        private void btnNumberSix_Click(object sender, EventArgs e)
        {
            txtInputField.AppendText("6");
        }

        private void btnNumberSeven_Click(object sender, EventArgs e)
        {
            txtInputField.AppendText("7");
        }

        private void btnNumberEight_Click(object sender, EventArgs e)
        {
            txtInputField.AppendText("8");
        }

        private void btnNumberNine_Click(object sender, EventArgs e)
        {
            txtInputField.AppendText("9");
        }

        private void btnNumberZero_Click(object sender, EventArgs e)
        {
            txtInputField.AppendText("0");
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            //txtInputField.AppendText("+");
            num1 = Convert.ToInt32(txtInputField.Text);
            choice = 1;
            txtInputField.Clear();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            //txtInputField.AppendText("-");
            num1 = Convert.ToInt32(txtInputField.Text);
            choice = 2;
            txtInputField.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            //txtInputField.AppendText("*");
            choice = 3;
            num1 = Convert.ToInt32(txtInputField.Text);
            txtInputField.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //txtInputField.AppendText("/");
            choice = 4;
            num1 = Convert.ToInt32(txtInputField.Text);
            txtInputField.Clear();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txtInputField.Text);
            
            switch (choice)
            {
                case 1:
                    sum = num1 + num2;
                    break;
                case 2:
                    sum = num1 - num2;
                    break;
                case 3:
                    sum = num1 * num2;
                    break;
                case 4:
                    sum = num1 / num2;
                    break;
            }
            txtInputField.Text = sum.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInputField.Clear();
        }
    }
}
