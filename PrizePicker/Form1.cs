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
 * Module 3 Assignment
 * This program allows the user to select from 3 curtains, giving them a prize associated with each, alerts them if they try to select more than one curtain.
 * 9/17/2022
 */
namespace Module3Assignment
{
    public partial class Form1 : Form
    {
        bool chose1, chose2, chose3;
        public Form1()
        {
            InitializeComponent();
            //I used 3 variables instead of the one here because I didn't want the error message to show if they clicked on the same curtain twice. -
            //A better way to do this?
            chose1 = false;
            chose2 = false;
            chose3 = false;
        }

        private void curtain5PictureBox_Click(object sender, EventArgs e) //Each curtain click will set a chose variable to true
                                                                          //and check if the other chose variables are set to true
                                                                          //to choose which message to display.
        {
            if (chose2 == false && chose3 == false)
            {
                resultLabel.Text = "You have chosen curtain 5. You win a whole buncha money, congrats";
            }
            else
            {
                resultLabel.Text = "Your greed is your demise. You win nothing.";
            }
            chose1 = true;
            
        }

        private void curtain7PictureBox_Click(object sender, EventArgs e)
        {
            if (chose1 == false && chose3 == false)
            {
                resultLabel.Text = "You have chosen curtain 7. You win one get out of jail free card.";
            }
            else
            {
                resultLabel.Text = "Your greed is your demise. You win nothing.";
            }
            chose2 = true;
        }

        private void curtain9PictureBox_Click(object sender, EventArgs e)
        {
           if (chose1 == false && chose2 == false)
            {
                resultLabel.Text = "You have chosen curtain 9. You win an Applebees franchise location. Good luck.";
            }
            else
            {
                resultLabel.Text = "Your greed is your demise. You win nothing.";
            }
            chose3 = true;
        }
 
    }
}
