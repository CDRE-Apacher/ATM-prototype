using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_prototype
{
    public partial class Form1 : Form
    {
        // Have to create them here as well as Program.cs
        Card card1 = new Card();
        Card card2 = new Card();
        Card card3 = new Card();
        Card card4 = new Card();
        Card card5 = new Card();
        Card card6 = new Card();

        public Form1(Card card1_, Card card2_, Card card3_, Card card4_, Card card5_, Card card6_)
        {
            // Get the cards from Program.cs and assign them here
            card1 = card1_;
            card2 = card2_;
            card3 = card3_;
            card4 = card4_;
            card5 = card5_;
            card6 = card6_;

            InitializeComponent();
        }

        string numPadNumbers = "";
        string chosenCardPin = "";
        Card chosenCard = new Card();
        bool enteringPin = false;
        bool pinCorrect = false;
        bool withdrawing = false;
        int withdrawAmmount = 0;
        bool customw = false;
        bool depositing = false;


        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if(enteringPin == true || withdrawing == true)
            {
                if (pinpadTextBox.Text.Length < 4)
                {
                    pinpadTextBox.Text += "0";
                }
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (enteringPin == true || withdrawing == true)
            {
                if (pinpadTextBox.Text.Length < 4)
                {
                    pinpadTextBox.Text += "1";
                }
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (enteringPin == true || withdrawing == true)
            {
                if (pinpadTextBox.Text.Length < 4)
                {
                    pinpadTextBox.Text += "2";
                }
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (enteringPin == true || withdrawing == true)
            {
                if (pinpadTextBox.Text.Length < 4)
                {
                    pinpadTextBox.Text += "3";
                }
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (enteringPin == true || withdrawing == true)
            {
                if (pinpadTextBox.Text.Length < 4)
                {
                    pinpadTextBox.Text += "4";
                }
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (enteringPin == true || withdrawing == true)
            {
                if (pinpadTextBox.Text.Length < 4)
                {
                    pinpadTextBox.Text += "5";
                }
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (enteringPin == true || withdrawing == true)
            {
                if (pinpadTextBox.Text.Length < 4)
                {
                    pinpadTextBox.Text += "6";
                }
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (enteringPin == true || withdrawing == true)
            {
                if (pinpadTextBox.Text.Length < 4)
                {
                    pinpadTextBox.Text += "7";
                }
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (enteringPin == true || withdrawing == true)
            {
                if (pinpadTextBox.Text.Length < 4)
                {
                    pinpadTextBox.Text += "8";
                }
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (enteringPin == true || withdrawing == true)
            {
                if (pinpadTextBox.Text.Length < 4)
                {
                    pinpadTextBox.Text += "9";
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pinpadTextBox.Clear(); // Clear the whole pin text box
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (pinpadTextBox.Text.Length > 0)
            {
                pinpadTextBox.Text = pinpadTextBox.Text.Remove(pinpadTextBox.Text.Length - 1, 1); // Clear the last number in the pin text box
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            numPadNumbers = pinpadTextBox.Text;
            chosenCardPin = chosenCard.getPinNumber();
            if (withdrawing)
            {

            }
            else
            {
                if (numPadNumbers == chosenCardPin) // Compare the pin numbers
                {
                    pinpadTextBox.Clear();
                    rtbAtmDisplay.Text = "What would you like to do?";
                    pinAccepted();
                }
                else
                {
                    pinpadTextBox.Clear();
                    rtbAtmDisplay.Text = "Wrong PIN number! Try Again";
                }
            }
        }

        // Pin Accepted
        void pinAccepted()
        {
            pinCorrect = true;
            rtbLeft1.Text = "Check account status";
            rtbLeft2.Text = "Withdraw money";
            rtbLeft3.Text = "Deposit money";
            rtbLeft4.Text = "TBD";
            rtbRight1.Text = "TBD";
            rtbRight2.Text = "TBD";
            rtbRight3.Text = "TBD";
            rtbRight4.Text = "TBD";
        }

        // Clear left and right buttons
        void clearLR()
        {
            rtbLeft1.Text = "";
            rtbLeft2.Text = "";
            rtbLeft3.Text = "";
            rtbLeft4.Text = "";
            rtbRight1.Text = "";
            rtbRight2.Text = "";
            rtbRight3.Text = "";
            rtbRight4.Text = "";
        }

        // Set leaft and right buttons to withdraw
        void withdrawLR()
        {
            rtbLeft1.Text = "10";
            rtbLeft2.Text = "20";
            rtbLeft3.Text = "50";
            rtbLeft4.Text = "100";
            rtbRight1.Text = "200";
            rtbRight2.Text = "Custom";
            rtbRight3.Text = "";
            rtbRight4.Text = "";
        }

        // Withdraw money
        void withdrawMoney(int ammount)
        {
            chosenCard.subtractBalance(ammount);
        }

        void depositMoney(int ammount)
        {
            chosenCard.addBalance(ammount);
        }

        // Choosing a card
        private void btnCard1_Click(object sender, EventArgs e)
        {
            clearLR();

            chosenCard = card1;
            rtbAtmDisplay.Text = chosenCard.getAccountNumber();
            enteringPin = true;
        }

        private void btnCard2_Click(object sender, EventArgs e)
        {
            clearLR();

            chosenCard = card2;
            rtbAtmDisplay.Text = chosenCard.getAccountNumber();
            enteringPin = true;
        }

        private void btnCard3_Click(object sender, EventArgs e)
        {
            clearLR();

            chosenCard = card3;
            rtbAtmDisplay.Text = chosenCard.getAccountNumber();
            enteringPin = true;
        }

        private void btnCard4_Click(object sender, EventArgs e)
        {
            clearLR();

            chosenCard = card4;
            rtbAtmDisplay.Text = chosenCard.getAccountNumber();
            enteringPin = true;
        }

        private void btnCard5_Click(object sender, EventArgs e)
        {
            clearLR();

            chosenCard = card5;
            rtbAtmDisplay.Text = chosenCard.getAccountNumber();
            enteringPin = true;
        }

        private void btnCard6_Click(object sender, EventArgs e)
        {
            clearLR();

            chosenCard = card6;
            rtbAtmDisplay.Text = chosenCard.getAccountNumber();
            enteringPin = true;
        }

        // Left screen buttons
        private void btnLeft1_Click(object sender, EventArgs e)
        {
            if (pinCorrect)  // Check account money
            {
                if (withdrawing) // Check if user wants to withdraw
                {
                    withdrawMoney(10);
                    withdrawing = false;
                    // Print out the withdrawl 
                    rtbAtmDisplay.Text = "Thank you for using the ATM. Your withdrawal of 10 PLN is being dispensed";
                    // Set all bool to false
                    pinCorrect = false;
                    // Clear buttons
                    clearLR();
                }
                else
                {
                    if (depositing)
                    {
                        depositMoney(10);
                        depositing = false;
                        pinCorrect = false;
                        clearLR();
                        rtbAtmDisplay.Text = "Thank you for using the ATM. Your deposit of 10 PLN is being accepted";
                    }
                    else
                    {
                        rtbAtmDisplay.Text = chosenCard.getBalance().ToString() + " PLN";
                    }
                }
            }
        }

        private void btnLeft2_Click(object sender, EventArgs e)
        {
            if (pinCorrect) // Withdraw money
            {
                if (withdrawing)
                {
                    withdrawMoney(20);
                    withdrawing = false;
                    // Print out the withdrawl 
                    rtbAtmDisplay.Text = "Thank you for using the ATM. Your withdrawal of 20 PLN is being dispensed";
                    // Set all bool to false
                    pinCorrect = false;
                    // Clear buttons
                    clearLR();
                }
                else
                {
                    if (depositing)
                    {
                        depositMoney(20);
                        depositing = false;
                        pinCorrect = false;
                        clearLR();
                        rtbAtmDisplay.Text = "Thank you for using the ATM. Your deposit of 20 PLN is being accepted";
                    }
                    else
                    {
                        rtbAtmDisplay.Text = "How much would you like to withdraw?";
                        withdrawLR();
                        withdrawing = true;
                    } 
                }

            }
        }

        private void btnLeft3_Click(object sender, EventArgs e)
        {
            if (pinCorrect) // Deposit money
            {
                if (withdrawing)
                {
                    withdrawMoney(50);
                    withdrawing = false;
                    // Print out the withdrawl 
                    rtbAtmDisplay.Text = "Thank you for using the ATM. Your withdrawal of 50 PLN is being dispensed";
                    // Set all bool to false
                    pinCorrect = false;
                    // Clear buttons
                    clearLR();
                }
                else
                {
                    if (depositing)
                    {
                        depositMoney(50);
                        depositing = false;
                        pinCorrect = false;
                        clearLR();
                        rtbAtmDisplay.Text = "Thank you for using the ATM. Your deposit of 50 PLN is being accepted";
                    }
                    else
                    {
                        rtbAtmDisplay.Text = "How much would you like to deposit?";
                        withdrawLR();
                        depositing = true;
                    }
                }
            }
        }

        private void btnLeft4_Click(object sender, EventArgs e)
        {
            if (pinCorrect)
            {
                if (withdrawing)
                {
                    withdrawMoney(100);
                    withdrawing = false;
                    // Print out the withdrawl 
                    rtbAtmDisplay.Text = "Thank you for using the ATM. Your withdrawal of 100 PLN is being dispensed";
                    // Set all bool to false
                    pinCorrect = false;
                    // Clear buttons
                    clearLR();
                }
                else
                {
                    if (depositing)
                    {
                        depositMoney(100);
                        depositing = false;
                        pinCorrect = false;
                        clearLR();
                        rtbAtmDisplay.Text = "Thank you for using the ATM. Your deposit of 100 PLN is being accepted";
                    }
                    else
                    {

                    }
                }
            }
        }

        // Right screen buttons
        private void btnRight1_Click(object sender, EventArgs e)
        {
            if (pinCorrect) 
            {
                if (withdrawing)
                {
                    withdrawMoney(200);
                    withdrawing = false;
                    // Print out the withdrawl 
                    rtbAtmDisplay.Text = "Thank you for using the ATM. Your withdrawal of 200 PLN is being dispensed";
                    // Set all bool to false
                    pinCorrect = false;
                    // Clear buttons
                    clearLR();
                }
                else
                {
                    if (depositing)
                    {
                        depositMoney(200);
                        depositing = false;
                        pinCorrect = false;
                        clearLR();
                        rtbAtmDisplay.Text = "Thank you for using the ATM. Your deposit of 200 PLN is being accepted";
                    }
                    else
                    {

                    }
                }
            }
        }

        private void btnRight2_Click(object sender, EventArgs e)
        {
            if (pinCorrect)
            {
                if (withdrawing)
                {
                    rtbAtmDisplay.Text = "Please specify how much you would like to withdraw";
                    //withdrawAmmount = 0;
                    customw = true;
                    rtbRight4.Text = "confirm";
                }
                else
                {

                }
            }
        }

        private void btnRight3_Click(object sender, EventArgs e)
        {
            if (pinCorrect)
            {

            }
        }

        private void btnRight4_Click(object sender, EventArgs e)
        {
            if (pinCorrect)
            {
                if (customw)
                {
                    numPadNumbers = pinpadTextBox.Text;
                    withdrawAmmount = Int32.Parse(numPadNumbers);
                    withdrawMoney(withdrawAmmount);
                    withdrawing = false;
                    rtbAtmDisplay.Text = "Thank you for using the ATM. Your withdrawal of " + withdrawAmmount +" PLN is being dispensed";
                    pinCorrect = false;
                    clearLR();
                    pinpadTextBox.Clear();
                }
            }
        }
    }

}
