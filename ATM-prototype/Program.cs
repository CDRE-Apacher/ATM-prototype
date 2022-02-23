using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_prototype
{
    public class Card
    {
        // Properties
        public long accountNumber { get; set; }
        public double accountBalance { get; set; }
        public int cvvNumber { get; set; }
        public string pinNumber { get; set; }

        // Methods
        public string getPinNumber()
        {
            return pinNumber;
        }

        public string getAccountNumber()
        {
            return accountNumber.ToString();
        }

        public double getBalance()
        {
            return accountBalance;
        }

        public void subtractBalance(int value)
        {
            accountBalance -= value;
        }

        public void addBalance(int value)
        {
            accountBalance += value;
        }

        // Constructor
        public Card()
        {
            accountNumber = 0000000000000000;
            accountBalance = 0.00d;
            cvvNumber = 000;
            pinNumber = "0000";
        }
    }

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //
            // Create Cards
            //
            Card card1 = new Card();
            card1.accountNumber = 1234123412341234;
            card1.accountBalance = 11340.00d;
            card1.cvvNumber = 661;
            card1.pinNumber = "1111";

            Card card2 = new Card();
            card2.accountNumber = 2345234523452345;
            card2.accountBalance = 10650.00d;
            card2.cvvNumber = 662;
            card2.pinNumber = "2222";

            Card card3 = new Card();
            card3.accountNumber = 3456345634563456;
            card3.accountBalance = 7340.00d;
            card3.cvvNumber = 663;
            card3.pinNumber = "3333";

            Card card4 = new Card();
            card4.accountNumber = 4567456745674567;
            card4.accountBalance = 4377.00d;
            card4.cvvNumber = 664;
            card4.pinNumber = "4444";

            Card card5 = new Card();
            card5.accountNumber = 5678567856785678;
            card5.accountBalance = 11695.00d;
            card5.cvvNumber = 665;
            card5.pinNumber = "5555";

            Card card6 = new Card();
            card6.accountNumber = 6789678967896789;
            card6.accountBalance = 25431.00d;
            card6.cvvNumber = 666;
            card6.pinNumber = "6666";
            //
            // End Create Cards
            //

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(card1, card2, card3, card4, card5, card6));
        }
    }
}
