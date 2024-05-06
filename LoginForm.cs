using Amazon.Auth.AccessControlPolicy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
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
            emailTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;

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
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\obada\OneDrive\Documents\HouseRent.mdf;Integrated Security=True;Connect Timeout=30;");


            string hash = string.Empty;

            using (SHA256 sha256Hash = SHA256.Create())
            {
                 hash = GetHash(sha256Hash, passwordTextBox.Text);

                Con.Open();
                String Query = $"Select * from Customer  where Email= \'{emailTextBox.Text}\' AND  Password = \'{hash}\'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                Con.Close();
                if (ds.Tables[0].Rows.Count>0) {
                    Tenants tenants = new Tenants();

                    tenants.Show();
                    this.Hide();
                }
                else
                {
                    //handle error
                }
              

            }
            
            
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
