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
 * Tyler Sanders
 * Module 4 Assignment
 * This program is a simple calculator with exception handlers
 * 9/28/2022
 */
namespace Module4Assignment
{
    public partial class CalcForm : Form
    {
        double num1, num2, result;
        public CalcForm()
        {
            InitializeComponent();

        }

        //I think ideally the only action that would be happening in these 4 click event handlers would be the result = num (operator) num;
        //I couldn't figure out how put them in one block or call them without an error regarding the text boxes. This is why I have 4 different
        //try/catch statements instead of just one that should be around num1=; num2=; and outputLabel.Text =;
        
        
            private void addButton_Click(object sender, EventArgs e) 
            {
                try
                {
                    num1 = double.Parse(tbNum1.Text); //because anything entered in the text box is a string, have to double.Parse(string) to convert it to double.
                    num2 = double.Parse(tbNum2.Text);
                    result = num1 + num2;
                    outputLabel.Text = result.ToString(); //converts the result variable back into a string in order to show it on the label text.
                }
                catch
                {
                    MessageBox.Show("You must enter digits in both boxes before I can calculate"); //shows an error messagebox for exceptions instead of crashing
                }
            }

            private void subtractButton_Click(object sender, EventArgs e)
            {
                try
                {
                    num1 = double.Parse(tbNum1.Text);
                    num2 = double.Parse(tbNum2.Text);
                    result = num1 - num2;
                    outputLabel.Text = result.ToString();
                }
                catch
                {
                    MessageBox.Show("You must enter digits in both boxes before I can calculate");
                }
            }

            private void multiplyButton_Click(object sender, EventArgs e)
            {
            try
                {
                    num1 = double.Parse(tbNum1.Text);
                    num2 = double.Parse(tbNum2.Text);
                    result = num1 * num2;
                    outputLabel.Text = result.ToString();
                }
                catch
                {
                    MessageBox.Show("You must enter digits in both boxes before I can calculate");
                }
            }

            private void divideButton_Click(object sender, EventArgs e)
            {               
                try
                {
                    num1 = double.Parse(tbNum1.Text);
                    num2 = double.Parse(tbNum2.Text);
                    result = num1 / num2;
                    outputLabel.Text = result.ToString("n");
                }
                catch
                {
                    MessageBox.Show("You must enter digits in both boxes before I can calculate");
                }
            }






    }

}


