using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManagement
{
    public partial class Login : Form
    {
        private const string ValidUsername = "nuray";
        private const string ValidPassword = "nuray123";
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Missing data. Please enter both username and password.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (username == ValidUsername && password == ValidPassword)
            {
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DashBoard dashBoard = new DashBoard();
                dashBoard.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("wrong username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
