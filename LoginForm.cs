using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentalVp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            hidePassImage.Visible = false;
            showPassImage.Visible = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void no_account(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length != 0)
            {
                showPassImage.Visible = true;
                passwordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                showPassImage.Visible = false;
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void hidePassImage_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            showPassImage.Visible = true;
            hidePassImage.Visible = false;

        }

        private void showPassImage_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = false;
            showPassImage.Visible = false;
            hidePassImage.Visible = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Tenants tenants = new Tenants();
            tenants.Show();
            this.Hide();
        }
    }
}
