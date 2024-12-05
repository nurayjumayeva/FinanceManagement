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
    public partial class Incomes : Form
    {
        private BindingSource incomeList = new BindingSource();
        public Incomes()
        {
            InitializeComponent();
            InitializeIncomeList();
        }
        private void InitializeIncomeList()
        {
            lstIncomes.DataSource = incomeList;
        }

        private void iconExpense_Click(object sender, EventArgs e)

        {
            Expenses expense = new Expenses();
            expense.Show();
            this.Hide();

        }

        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
            DashBoard Obj = new DashBoard();
            Obj.Show();
            this.Hide();
        }

       

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIncomeName.Text) ||
              string.IsNullOrEmpty(txtIncomeAmount.Text) ||
              string.IsNullOrEmpty(txtIncomeCategory.Text) ||
            string.IsNullOrEmpty(txtIncomeDate.Text) ||
                string.IsNullOrEmpty(txtIncomeDescription.Text))
            {
                MessageBox.Show("Please fill in all fields before adding an income.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            }
            string incomeRecord = $"{txtIncomeName.Text} - {txtIncomeAmount.Text} - {txtIncomeCategory.Text} - {txtIncomeDate.Text}-{txtIncomeDescription.Text}";
            incomeList.Add(incomeRecord);
            ClearInputFields();

            MessageBox.Show("Income added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnEditIncome_Click(object sender, EventArgs e)
        {
            if (lstIncomes.SelectedItem == null)
            {

                MessageBox.Show("Please select an income to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string selectedIncome = lstIncomes.SelectedItem.ToString();
            int selectedIndex = lstIncomes.SelectedIndex;
            string updatedIncome = $"{txtIncomeName.Text} -{txtIncomeAmount.Text} - {txtIncomeCategory.Text} - {txtIncomeDate.Text} - {txtIncomeDescription.Text}";
            incomeList[selectedIndex] = updatedIncome;
            MessageBox.Show("Income updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnDeleteIncome_Click(object sender, EventArgs e)
        {
            if (lstIncomes.SelectedItem == null)
            {
                MessageBox.Show("Please select an income to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            incomeList.Remove(lstIncomes.SelectedItem);
            MessageBox.Show("Income deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearInputFields()
        {
            txtIncomeName.Clear();
            txtIncomeAmount.Clear();
            txtIncomeCategory.Clear();
            txtIncomeDate.Clear();
            txtIncomeDescription.Clear();

        }

        private void btnForSavingGoals_Click(object sender, EventArgs e)
        {
            SavingGoals savingGoals = new SavingGoals();
            savingGoals.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtIncomeName_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }
