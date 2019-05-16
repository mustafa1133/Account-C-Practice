using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private static int currentAccountNumber = 1000;
        public readonly string Number;
        private const int TRANSIT_NUMBER = 314;
        private uint Position = 0;
        private string[] names = new string [100];
        public double Balance { get; private set; }
        public string[] Names { get { return names; } private set { names = value; } }

        static Account()
        {
            currentAccountNumber ++;
        }

        private Account(string aNumber, string aName, double aBalance)
        {
            Balance = aBalance;
            Number = aNumber;
            Names [Position++]= aName;
            
        }


        public  void AddName(string aName)
        {

                if (Names.Contains(aName))
                {
                    throw new Exception("Name Account Name already exists");
                }
                else
                {
                Names[Position++] = aName;

                }
            

        }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }


        public void Withdraw(double amount)
        {
            if (Balance-amount < 0)
            {
                throw new Exception("You do not have enough money to withdraw that amount");
            }

            else if(amount>250)
            {
                throw new Exception("Amount Withdrawn Exceeds $250.00");
            }
            else
            {
                Balance = Balance - amount;
            }
        }


        public string GetInfo()
        {
            string result;

            result = $"Account Number: {Number}\n Balance: {Balance:C}\n";

            foreach (string name in Names)
            {
                if(name != null)
                {
                    result += $"Name:{name}\n";
                }
            }
            return result;
        }
        public static Account CreateAccount(string aName, double aBalance=0)
        {
            string aCNumber = $"AC-{TRANSIT_NUMBER}--{currentAccountNumber}";
            Account aAccount = new Account(aCNumber, aName, aBalance);
            currentAccountNumber++;
            return aAccount;
        }
    }
}
