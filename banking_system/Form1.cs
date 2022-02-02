using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking_system
{
    public partial class Form1 : Form
    {
        List<Current_account> current_Accountslist = new List<Current_account>();
        List<Savings_account> savings_Accountslist = new List<Savings_account>();
        List<Loan_account> loan_Accountslist = new List<Loan_account>();
        List<Transactions> tran_slist = new List<Transactions>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        double account_id_no = 1;
        private void CreateOnClik(object sender, EventArgs e)
        {
            if (create_combo.Text == "Current")
            {
                string id = account_id_no.ToString() + Id_txt.Text + "300";
                account_id_no++;
                double amount = Convert.ToDouble(amounttxt.Text);
                string name = name_txt.Text;
                Current_account current_Account = new Current_account();
                current_Account.name = name;
                current_Account.id = id;
                current_Account.amount = amount;

                current_Accountslist.Add(current_Account);
                MessageBox.Show("Account has been created!\n" + "Account No. :" + id);

            }
            else if (create_combo.Text == "Savings")
            {
                if (Convert.ToDouble(amount_txt.Text) < 50000)
                {
                    MessageBox.Show("Insufficient Balance!");
                }

                else

                {
                    string id = account_id_no.ToString() + Id_txt.Text + "314";
                    account_id_no++;
                    double amount = Convert.ToDouble(amounttxt.Text);
                    string name = name_txt.Text;
                    Savings_account savings_Account = new Savings_account();
                    savings_Account.name = name;
                    savings_Account.id = id;
                    savings_Account.amount = amount;

                    savings_Accountslist.Add(savings_Account);
                    MessageBox.Show("Account has been created!\n" + "Account No. :" + id);

                }

            }
            else if (create_combo.Text == "Loan")
            {
                string id = account_id_no.ToString() + Id_txt.Text + "400";
                account_id_no++;
                double amount = Convert.ToDouble(amounttxt.Text);
                amount = amount + amount * 0.09;
                string name = name_txt.Text;
                Loan_account savings_Account = new Loan_account();
                savings_Account.name = name;
                savings_Account.id = id;
                savings_Account.interest(amount);
                savings_Account.amount = amount;

                loan_Accountslist.Add(savings_Account);
                MessageBox.Show("Account has been created!\n" + "Account No. :" + id);


            }
            else
            {
                MessageBox.Show("Check Given Informations!");
            }


        }

        private void Deposit_on_click(object sender, EventArgs e)
        {
            string deposit_id = deposit_txt.Text;
            double deposit = Convert.ToDouble(amount_deposite.Text);
            if (deposit < 0)
            {
                throw new ApplicationException("Negetive INput man !!");
            }
            bool errorexits = true;
            
                int i = 0;
            for (i = 0; i < current_Accountslist.Count; i++)
            {
                if (deposit_id == current_Accountslist[i].id)
                {
                    errorexits = false;
                    if (deposit > 100000)
                    {
                        MessageBox.Show("Ammount limit exceeded!");
                    }
                    else
                    {
                        Transactions transactions = new Transactions();
                        transactions.type = "Deposit";
                        transactions.amount = deposit;

                        current_Accountslist[i].tran_slist.Add(transactions);
                        current_Accountslist[i].amount += deposit;
                        MessageBox.Show("Ammount has been deposited");

                    }
                    break;
                }
            }
            for (i = 0; i < savings_Accountslist.Count; i++)
            {
                if (deposit_id == savings_Accountslist[i].id)
                {
                    errorexits = false;

                    if (savings_Accountslist[i].checkLimit() == true)
                    {
                        Transactions transactions = new Transactions();
                        transactions.type = "Deposit";
                        transactions.amount = deposit;

                        savings_Accountslist[i].tran_slist.Add(transactions);
                        savings_Accountslist[i].amount += deposit;
                        --savings_Accountslist[i].transLimit;
                        MessageBox.Show("Ammount has been deposited");

                    }
                    else
                    {
                        MessageBox.Show("Maximum Transactions (5) have been exceeded");
                    }
                    break;
                }
            }
            for (i = 0; i < loan_Accountslist.Count; i++)
            {
                if (deposit_id == loan_Accountslist[i].id)
                {
                    errorexits = false;

                    if (deposit>loan_Accountslist[i].amount)
                    {
                        MessageBox.Show("Ammount exceeds due ammount!");

                    }
                    else if(deposit==0)
                    {
                        MessageBox.Show("No more transactions can be made");
                    }
                    else
                    {
                        Transactions transactions = new Transactions();
                        transactions.type = "Deposit";
                        transactions.amount = deposit;

                        loan_Accountslist[i].tran_slist.Add(transactions);
                        loan_Accountslist[i].amount -= deposit;
                        
                        MessageBox.Show("Ammount has been deposited");
                    }
                    break;
                }
            }

            if (errorexits)
            {
                MessageBox.Show("Account Does Not Exist");
            }



        }

        private void withdraw_on_click(object sender, EventArgs e)
        {
            string with_id = deposit_txt.Text;
            double with = Convert.ToDouble(amount_deposite.Text);
            if (with < 0)
            {
                throw new ApplicationException("Negetive INput man !!");
            }
            bool errorexits = true;

            int i = 0;
            for (i = 0; i < current_Accountslist.Count; i++)
            {
                if (with_id == current_Accountslist[i].id)
                {
                    errorexits = false;
                    if (with > 100000)
                    {
                        MessageBox.Show("Ammount limit exceeded!");
                    }
                    else
                    {
                        if (with < current_Accountslist[i].amount)
                        {
                            Transactions transactions = new Transactions();
                            transactions.type = "Withdraw";
                            transactions.amount = with;

                            current_Accountslist[i].tran_slist.Add(transactions);
                            current_Accountslist[i].amount -= with;
                            MessageBox.Show("Ammount has been withdrawn");
                        }
                        else
                        {
                            MessageBox.Show("Amount Exceeds balance!");
                        }
                    }
                    break;
                }
            }
            for (i = 0; i < savings_Accountslist.Count; i++)
            {
                if (with_id == savings_Accountslist[i].id)
                {
                    errorexits = false;

                    if (savings_Accountslist[i].checkLimit() == true)
                    {
                        if (with < savings_Accountslist[i].amount)
                        { Transactions transactions = new Transactions();
                            transactions.type = "Withdraw";
                            transactions.amount = with;

                            savings_Accountslist[i].tran_slist.Add(transactions);
                            savings_Accountslist[i].amount -= with;
                            savings_Accountslist[i].amount -= 15;
                            --savings_Accountslist[i].transLimit;
                            MessageBox.Show("Ammount has been withdrawn");
                        }
                        else
                        {
                            MessageBox.Show("Amount Exceeds balance!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Maximum Transactions (5) have been exceeded");
                    }
                    break;
                }
            }
            for (i = 0; i < loan_Accountslist.Count; i++)
            {
                if (with_id == loan_Accountslist[i].id)
                {
                    errorexits = false;

                    MessageBox.Show("Can not withdraw from a Loan account");
                    break;
                }
            }

            if (errorexits)
            {
                MessageBox.Show("Account Does Not Exist");
            }

        }


        private void Check_balance_on_click(object sender, EventArgs e)
        {

            string account = id_check_history.Text;
            bool errorExists = true;

            int i = 0;
            for (i = 0; i < current_Accountslist.Count; i++)
            {
                if (account == current_Accountslist[i].id)
                {
                    errorExists = false;
                    check_balance_listBox.Items.Clear();
                    string s = current_Accountslist[i].name + " " + current_Accountslist[i].id + " " + current_Accountslist[i].amount.ToString();
                    check_balance_listBox.Items.Add(s);
                    break;
                }
            }
            for (i = 0; i < savings_Accountslist.Count; i++)
            {
                if (account == savings_Accountslist[i].id)
                {
                    errorExists = false;
                    check_balance_listBox.Items.Clear();
                    string s = savings_Accountslist[i].name + " " + savings_Accountslist[i].id + " " + savings_Accountslist[i].amount.ToString();
                    check_balance_listBox.Items.Add(s);
                    break;
                }
            }
            for (i = 0; i < loan_Accountslist.Count; i++)
            {
                if (account == loan_Accountslist[i].id)
                {
                    errorExists = false;
                    check_balance_listBox.Items.Clear();
                    string s = loan_Accountslist[i].name + " " + loan_Accountslist[i].id + " " + loan_Accountslist[i].amount.ToString();
                    check_balance_listBox.Items.Add(s);
                    break;
                }
            }
            if (errorExists)
            {
                MessageBox.Show("Account Does Not Exist");
            }

        }
        private void checkHistoryOnclick(object sender, EventArgs e)
        {
            string account = id_check_history.Text;
            bool errorExists = true;

            int i = 0;
            for (i = 0; i < current_Accountslist.Count; i++)
            {
                if (account == current_Accountslist[i].id)
                {
                    errorExists = false;
                    check_history_listbox.Items.Clear();

                    for (int j = 0; j < current_Accountslist[i].tran_slist.Count; j++)
                    {
                        check_history_listbox.Items.Add(current_Accountslist[i].tran_slist[j].getter());
                    }

                }
            }
            for (i = 0; i < savings_Accountslist.Count; i++)
            {
                if (account == savings_Accountslist[i].id)
                {
                    errorExists = false;
                    check_history_listbox.Items.Clear();

                    for (int j = 0; j < savings_Accountslist[i].tran_slist.Count; j++)
                    {
                        check_history_listbox.Items.Add(savings_Accountslist[i].tran_slist[j].getter());
                    }

                }
            }
            for (i = 0; i < loan_Accountslist.Count; i++)
            {
                if (account == loan_Accountslist[i].id)
                {
                    errorExists = false;
                    check_history_listbox.Items.Clear();

                    for (int j = 0; j < loan_Accountslist[i].tran_slist.Count; j++)
                    {
                        check_history_listbox.Items.Add(loan_Accountslist[i].tran_slist[j].getter());
                    }

                }
            }
            if (errorExists)
            {
                MessageBox.Show("Account Does Not Exist");
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
