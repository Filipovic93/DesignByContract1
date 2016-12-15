using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignByContract1
{
    public partial class Form1 : Form
    {
        double currentBalance = 0;
        double amount;
        double newBalance;

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBoxAmount.Text, out amount))
            {
                Account currentAccount = new Account();

                currentAccount.Deposit(amount);
                newBalance = currentBalance += amount;

                textBoxBalance.Text = newBalance.ToString();
            };
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBoxAmount.Text, out amount))
            {
                Account currentAccount = new Account();

                currentAccount.Deposit(amount);
                if(amount > currentBalance)
                {
                    MessageBox.Show("Not possible to go in minus money");
                }
                else
                {
                    newBalance = currentBalance -= amount;
                    textBoxBalance.Text = newBalance.ToString();
                }
            }
        }
    }
}
