using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentalVp
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            Showcategories();
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\obada\OneDrive\Documents\HouseRent.mdf;Integrated Security=True;Connect Timeout=30;");

        private void Showcategories()
        {
            Con.Open();
            string Query = "Select * from categoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
           SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
           CategoriesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void ResetData()
        {
            CategoryTb.Text = "";
            Remarks.Text = "";
        }



        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (CategoryTb.Text == "" || Remarks.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CategoryTbl(Category,Remarks)values(@Cat,@Rem)", Con);
                    cmd.Parameters.AddWithValue("@Cat", CategoryTb.Text);
                    cmd.Parameters.AddWithValue("@Rem", Remarks.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Added!");
                    Con.Close();
                    ResetData();
                    Showcategories();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(Text, ex.Message);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void CategoryTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
