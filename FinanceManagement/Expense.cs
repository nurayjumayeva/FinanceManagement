using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManagement
{
    public partial class Expenses : Form
       
    {
        private BindingSource expenseList = new BindingSource();
        public Expenses()
        {
            InitializeComponent();
            InitializeExpenseList();
        }
        private void InitializeExpenseList()
        {
            lstExpenses.DataSource = expenseList;
        }



        private void btnAddExpense_Click(object sender, EventArgs e)
        {

            if
                (string.IsNullOrEmpty(txtExpenseName.Text) ||
                string.IsNullOrEmpty(txtExpenseAmount.Text) ||
                string.IsNullOrEmpty(txtExpenseCategory.Text) ||
                string.IsNullOrEmpty(txtExpenseDate.Text) ||
                string.IsNullOrEmpty(txtExpenseDescription.Text))
                {
                MessageBox.Show("Please fill in all fields before adding an expense", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            string expenseRecord = $"{txtExpenseName.Text} - {txtExpenseAmount.Text} - {txtExpenseCategory.Text} - {txtExpenseDate.Text}-{txtExpenseDescription.Text}";
            expenseList.Add(expenseRecord);

            ClearInputFields();

            MessageBox.Show("Expense added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void btnEditExpense_Click(object obj, EventArgs e)
        {
            if (lstExpenses.SelectedItem == null)
            {
                MessageBox.Show("Please select an expense to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedExpense = lstExpenses.SelectedItem.ToString();
            int selectedIndex = lstExpenses.SelectedIndex;
            string updatedExpense = $"{txtExpenseName.Text} - { txtExpenseAmount.Text} - { txtExpenseCategory.Text}- { txtExpenseDate.Text} -{ txtExpenseDescription.Text}";
                expenseList[selectedIndex] = updatedExpense;
            MessageBox.Show("Expense updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }





        private void iconIncome_Click(object sender, EventArgs e)
        {
            Incomes incomes = new Incomes();
            incomes.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        

      

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            if(lstExpenses.SelectedItem ==null)
            {
               
                MessageBox.Show("Please select an expense to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            expenseList.Remove(lstExpenses.SelectedItem);
            MessageBox.Show("Expense deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void ClearInputFields()
        {
            txtExpenseName.Clear();
            txtExpenseAmount.Clear();
            txtExpenseCategory.Clear();
            txtExpenseDate.Clear();
            txtExpenseDescription.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenIncomes_Click(object sender, EventArgs e)
        {
            Incomes incomes = new Incomes();
            incomes.Show();
            this.Hide();
        }

        private void btnOpenSavingGoals_Click(object sender, EventArgs e)
        {
            SavingGoals savingGoals = new SavingGoals();
            savingGoals.Show();
            this.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void txtExpenseAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

