﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_console.Entites
{
    class BusinessAccount: Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }
    
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

        public override void Withhdraw(double amount)
        {
            base.Withhdraw(amount);
            Balance -= 5;
        }


    }
}
