using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_progetto
{
    public class Account
    {
        public decimal balance;
        public Account() //costruttore di default 
        {

        }
        public Account(decimal initialBalance)
        {
            balance = initialBalance;
        }
    }
}
