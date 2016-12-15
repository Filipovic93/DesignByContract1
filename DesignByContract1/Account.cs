using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//making it possible to use Design by Contract 
using System.Diagnostics.Contracts;

namespace DesignByContract1
{
    class Account
    {
        public double balance;

        public double Deposit(double amount)
        {
            Contract.Requires(balance > 0);
            balance += amount;
            return balance;
            Contract.Requires(this.balance < 0);
            if(balance < 0)
            {
                Contract.Requires<ArgumentNullException>(balance > 0, "Precondition failed, exception thrown");
                throw (new Exception());
            }          
        }
       
        public double Withdraw(double amount)
        {
            double moneyAfterWithdraw = balance -= amount;
            Contract.Requires(balance < amount);
            Contract.Ensures(this.balance > 0);
            if(moneyAfterWithdraw > 0)
            {
                balance = moneyAfterWithdraw;
                return balance;
            }
             Contract.Requires<ArgumentNullException>(balance > 0, "Precondition failed, exception thrown");
                throw (new Exception());
        }

    }
}
