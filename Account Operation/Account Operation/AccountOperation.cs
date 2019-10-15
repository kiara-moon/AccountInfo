using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Account account = new Account();

        private void createButton_Click(object sender, EventArgs e)
        {
            account.AccountNumber = accountNumberTextBox.Text;
            account.CustomerName = customerNameTextBox.Text;
            //account.balance = Convert.ToDouble(amountTextBox.Text);

            accountNumberTextBox.Clear();
            customerNameTextBox.Clear();
            //amountTextBox.Clear();

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            account.Deposit(Convert.ToDouble(amountTextBox.Text));
            MessageBox.Show("Deposit successful");
            amountTextBox.Clear();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            account.Withdrow(Convert.ToDouble(amountTextBox.Text));
            MessageBox.Show("Withdrow successful");
            amountTextBox.Clear();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(account.GetReport());
        }
    }
}
