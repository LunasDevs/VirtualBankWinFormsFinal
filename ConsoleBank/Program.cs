﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ConsoleBank.Managers;
using ConsoleBank.Models;

namespace ConsoleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Customer
            var customer = new Customer();
            customer.SetId(4);
            customer.SetName("Lina");
            customer.SetLastName("Silva");
            customer.CheckingAccounts.Add(new CheckingAccount(421, 4000));
            var tstAccount = customer.CheckingAccounts[0].GetBalance();
            var txtWelcome = string.Concat("Welcome, " + customer.GetName() + " " + customer.GetLastName() + "!");

            /*
            //Exchange Rates Definition:
            List<ExchangeRate> ExchangeRates = new List<ExchangeRate>();
            var usd = new ExchangeRate("USD",0.50f);
            ExchangeRates.Add(usd);
            var mxn = new ExchangeRate("MXN",10.0f);
            ExchangeRates.Add(mxn);
            var eur = new ExchangeRate("EUR",0.25f);
            ExchangeRates.Add(eur);
            var cad = new ExchangeRate("CAD",1.00f);
            ExchangeRates.Add(cad); 

            //Print Rates
            var i = 0;
            Console.WriteLine("Rates:");
            while (i < ExchangeRates.Count)
            {
                Console.WriteLine($"{Environment.NewLine} {ExchangeRates[i].GetCurrencyId()} {ExchangeRates[i].GetRateValue()}");
                i++;
            }
            */
            //Tests:
            Console.WriteLine("Original balance in CAD: ");
            Console.WriteLine(tstAccount);
            Console.WriteLine("Updated balance in CAD: ");
            var newBalance = customer.CheckingAccounts[0].Withdraw(100.00f, "USB");
            Console.WriteLine(newBalance);
            var newBalance1 = customer.CheckingAccounts[0].Withdraw(100.00f, "MXN");
            Console.WriteLine(newBalance1);
            var newBalance2 = customer.CheckingAccounts[0].Withdraw(100.00f, "EUR");
            Console.WriteLine(newBalance);
            var newBalance3 = customer.CheckingAccounts[0].Withdraw(1.00f, "CAD");
            Console.WriteLine(newBalance3);
        }
    }
}