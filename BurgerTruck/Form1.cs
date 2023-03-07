using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerTruck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Tyler Sanders
        COP 2360
        10/12/2022
        This program is a point of sale page for a burger truck 
        */
        double total;

        private void totalButton_Click(object sender, EventArgs e)
        {
            //when the total button is clicked it will add the prices from additional toppings to the variable total
            total = 4.99; //every time the button is clicked it will first set total to 4.99 before adding the toppings
            if (cheeseCheckBox.Checked)
                total += .99;
            if (friedEggCheckBox.Checked)
                total += 1.99;
            if (baconCheckBox.Checked)
                total += 1.99;
            if (avocadoCheckBox.Checked)
                total += .99;
            if (friesYesButton.Checked)
                total += 2.99;
            if (cashPaymentButton.Checked)
                total *= .90;

            totalOutputLabel.Text = total.ToString("c"); //displays the total variable in currency format
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            //on clear button click all check boxes are unchecked
            rareChoiceButton.Focus();   //puts the focus back at the top of the page         
            totalOutputLabel.Text = " ";
            cheeseCheckBox.Checked = false;
            baconCheckBox.Checked = false; 
            avocadoCheckBox.Checked = false;
            friedEggCheckBox.Checked = false;
            friesYesButton.Checked = false;
            friesNoButton.Checked = false;
            cashPaymentButton.Checked = false;
            creditPaymentButton.Checked = false;
            rareChoiceButton.Checked = false; //the rare choice button is initially checked by default, but after clearing it is unchecked to prevent mistakes

        }

        private void friedEggCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (friedEggCheckBox.Checked) //when the check box is checked will show the "Add -price-" label. If unchecked will stop showing the label
                additionLabel.Text = "Add $1.99";
            else
                additionLabel.Text = "";

        }

        private void cheeseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cheeseCheckBox.Checked)
                additionLabel.Text = "Add $.99";
            else
                additionLabel.Text = "";
        }

        private void baconCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (baconCheckBox.Checked)
                additionLabel.Text = "Add $1.99";
            else
                additionLabel.Text = "";
        }

        private void avocadoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (avocadoCheckBox.Checked)
                additionLabel.Text = "Add $.99";
            else
                additionLabel.Text = "";
        }

        private void friesYesButton_CheckedChanged(object sender, EventArgs e)
        {
            if (friesYesButton.Checked)
                additionLabel.Text = "Add $2.99";
            else
                additionLabel.Text = "";
        }

  
    }
}
