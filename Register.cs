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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            
                hidePassImage.Visible = false;
                showPassImage.Visible = false;
            showPassImage2.Visible = false;
            hidePassImage2.Visible=false;

            
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

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
                passwordTextBox.UseSystemPasswordChar= false;
            }
        }

        private void confirmPassTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (confirmPassTextBox1.Text.Length != 0)
            {
                showPassImage2.Visible = true;
                confirmPassTextBox1.UseSystemPasswordChar = true;
            }
            else
            {
                showPassImage2.Visible = false;
                confirmPassTextBox1.UseSystemPasswordChar = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            String name = nameTextBox.Text;
            String email = emailTextBox.Text;
            String pass = passwordTextBox.Text;
            String confirmPass = confirmPassTextBox1.Text;
            if (name.Length.Equals(0) || email.Length.Equals(0) || pass.Length.Equals(0) || confirmPass.Length.Equals(0))
            {
                MessageBox.Show("Please fill in all fields");
            }
            else if ( pass != confirmPass )
            {
                MessageBox.Show("Your passwords does not match, check and try again");
            }
        }

        private void existingAccount_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void hidePassImage_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            showPassImage.Visible = true;
            hidePassImage.Visible= false;

        }

        private void showPassImage_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = false;
            showPassImage.Visible = false;
            hidePassImage.Visible = true;
        }

        private void showPassImage2_Click(object sender, EventArgs e)
        {
            confirmPassTextBox1.UseSystemPasswordChar = false;
            showPassImage2.Visible = false;
            hidePassImage2.Visible = true;
        }

        private void hidePassImage2_Click(object sender, EventArgs e)
        {
            confirmPassTextBox1.UseSystemPasswordChar = true;
            showPassImage2.Visible = true;
            hidePassImage2.Visible = false;
        }

        private void roleDropDown_MouseHover(object sender, EventArgs e)
        {
            roleDropDown.BorderColor = Color.Brown;
        }

        private void roleDropDown_MouseLeave(object sender, EventArgs e)
        {
            roleDropDown.BorderColor = Color.White;
        }
    }
}
