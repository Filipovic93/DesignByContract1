 Contract.Requires<ArgumentNullException>(balance > 0, "Precondition failed, exception thrown");# DesignByContract1

Its made with Design by Contract 

The Account.cs class has been made with Design by Contract in mind, and it can be seen in the lines
First of all, you need to import the using System.Diagnostics.Contracts;
There is a Deposit and a Withdraw method, both using double amount. 
Contract.Requires that the balance MUST be over 0. That is a pre condition

 Contract.Requires<ArgumentNullException>(balance > 0, "Precondition failed, exception thrown");
 is wroten if the precondition has failed, and in one way or another, and throws an exception. 
