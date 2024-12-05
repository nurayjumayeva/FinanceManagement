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
    public partial class SavingGoals : Form
    {
        private BindingSource savingGoalsList = new BindingSource();
       public SavingGoals()
        {
            InitializeComponent();
            InitializeSavingGoalsList();

        }

        private void InitializeSavingGoalsList()
        {
            lstSavingGoals.DataSource = savingGoalsList;
        }

        private void SavingGoals_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtExpenseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstGoals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtGoalName.Text) ||
                string.IsNullOrEmpty(txtAmountSaved.Text) ||
                string.IsNullOrEmpty(txtTotalGoalAmount.Text) )
            {
                MessageBox.Show("Please fill in all fields before adding a goal.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string goalRecord = $"{txtGoalName.Text}  - Saved: {txtAmountSaved.Text} - Total: {txtTotalGoalAmount.Text}";
            savingGoalsList.Add(goalRecord);
            ClearInputFields();
            MessageBox.Show("Goal added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnEditGoal_Click(object sender, EventArgs e)
        {
            if (lstSavingGoals.SelectedItem == null)
            {
                MessageBox.Show("Please select a goal to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string selectedGoal = lstSavingGoals.SelectedItem.ToString();
            int selectedIndex = lstSavingGoals.SelectedIndex;
            string updatedGoal = $"{txtGoalName.Text} - Saved: { txtAmountSaved.Text} -Total: { txtTotalGoalAmount.Text}";
            savingGoalsList[selectedIndex] = updatedGoal;
            MessageBox.Show("Goal updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
         
        }

        private void btnDeleteGoal_Click(object sender, EventArgs e)
        {
            if ( lstSavingGoals.SelectedItem ==  null)
            {
                MessageBox.Show("Please select a goal to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            savingGoalsList.Remove(lstSavingGoals.SelectedItem);
            MessageBox.Show("Goal deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private void ClearInputFields()
        {
            txtGoalName.Clear();
            txtAmountSaved.Clear();
            txtTotalGoalAmount.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Incomes incomes = new Incomes();
            incomes.Show();
            this.Hide();
        }

        private void iconExpense_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.Show();
            this.Hide();
        }
    }
}
