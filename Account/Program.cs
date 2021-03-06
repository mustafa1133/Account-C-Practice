﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {

            //The following code might break, you will have to modify it so that it terminates gracefully
            Account[] accounts = new Account[6];
            Random rand = new Random();
            //to get started create some accounts
            for (int i = 0; i < 6; i++)
            {
                accounts[i] = Account.CreateAccount("Name" + i, rand.Next(10, 100));
            }


            //at least one of the name addition will cause an exception
            accounts[0].AddName("Justin Trudeau");
            accounts[1].AddName("Donald Trump");
            accounts[2].AddName("Narendra Pershad");
            accounts[3].AddName("Theresa May");
            accounts[4].AddName("Donald Trump");
            accounts[5].AddName("Andrea Merkel");
            accounts[0].AddName("Sophie Trudeau");
            accounts[1].AddName("Ivanka Trump");
            accounts[1].AddName("Ivana Trump");
            accounts[2].AddName("Siddarth Pandya");
            accounts[3].AddName("Philip May");
            accounts[4].AddName("Melanie Trump");
            try
            {
                accounts[4].AddName("Donald Trump");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


            Console.WriteLine("\n\nAll accounts");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account.GetInfo());
            }


            foreach (Account account in accounts)
            {
                account.Deposit(1.11);
            }


            Console.WriteLine("\n\nAfter $1.11 deposit ");



            foreach (Account account in accounts)
            {
                Console.WriteLine(account.GetInfo());
            }




            // this loop can cause exception, so it is good practice to surround it with a try-catch block
            try
            {
                foreach (Account account in accounts)
                {
                    account.Withdraw(rand.Next(100, 300));
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }




            Console.WriteLine("\n\nAfter withdrawal.");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account.GetInfo());
            }
        }


    }
}
