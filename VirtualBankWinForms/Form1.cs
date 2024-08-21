using VirtualBankWinForms.Properties;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using ConsoleBank.Managers;
using ConsoleBank.Models;

namespace VirtualBankWinForms
{
    public partial class Form1 : Form
    {
        //Global variables:
        public int accountId = 421;
        public float amount = 5000;
        public string firstName = "Lina";
        public string lastName = "Silva";

        public Form1()
        {
            InitializeComponent();

        }

        //Function
        public string SetFullName(Customer customer)
        {
            customer.SetName(firstName);
            customer.SetLastName(lastName);
            return string.Concat("Welcome, " + customer.GetName() + " " + customer.GetLastName() + "!");
        }

        private void textBox1_Welcome(object sender, EventArgs e)
        {
            var customer = new Customer();
            var customer1 = SetFullName(customer);
            txt_welcome.Text = customer1;
        }

        private void txt_balance_TextChanged(object sender, EventArgs e)
        {
            var customer = new Customer();
            customer.CheckingAccounts.Add(new CheckingAccount(accountId, amount));
            var balance = customer.CheckingAccounts[0].GetBalance();
            txt_balance.Text = "$ " + amount.ToString() + " (CAD)";
        }

        private void cbb_account_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customer = new Customer();
            customer.CheckingAccounts.Add(new CheckingAccount(accountId, amount));
            List<CheckingAccount> customerAccounts = new List<CheckingAccount>();
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            float amount = 0;
            try
            {
                amount = float.Parse(txt_amount.Text);
            }
            catch
            {
                MessageBox.Show("This field must be a number. Format: 1,234.50");
            }

        }

        private void cbb_currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The currency choiced is: " + cbb_currency.SelectedItem.ToString());

        }

        private void cbb_currency_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbb_currency.SelectedItem.ToString();
        }


        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            if (cbb_currency.SelectedItem == null)
            {
                MessageBox.Show("Please select currency ");
                return;
            }
            var selectedCurrency = cbb_currency.SelectedItem.ToString();
            var customer = new Customer();
            customer.CheckingAccounts.Add(new CheckingAccount(accountId, amount));
            var transactionValue = customer.CheckingAccounts[0].Withdraw(float.Parse(txt_amount.Text), selectedCurrency);
            if (transactionValue < 0)
            {
                MessageBox.Show("Your current balance does not allow you to perform the transaction: " + txt_amount.Text);
            }
            else
            {
                amount = transactionValue;
                txt_balance.Text = amount.ToString();
                MessageBox.Show("Your new Balance is: " + transactionValue.ToString() + " CAD");
            }
        }

        private void btn_load_customer_Click(object sender, EventArgs e)
        {
            textBox1_Welcome(txt_welcome, e);
            txt_balance_TextChanged(txt_balance, e);
            cbb_account_SelectedIndexChanged(cbb_account, e);

        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            if (cbb_currency.SelectedItem == null)
            {
                MessageBox.Show("Please select currency ");
                return;
            }
            var selectedCurrency = cbb_currency.SelectedItem.ToString();
            var customer = new Customer();
            customer.CheckingAccounts.Add(new CheckingAccount(accountId, amount));
            var transactionValue = customer.CheckingAccounts[0].Deposit(float.Parse(txt_amount.Text), selectedCurrency);
            amount = transactionValue;
            txt_balance.Text = amount.ToString();
            MessageBox.Show("Your new Balance is: " + transactionValue.ToString() + " CAD");
        }
    }
}