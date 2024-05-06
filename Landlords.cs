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
    public partial class Landlords : Form
    {
        public Landlords()
        {
            InitializeComponent();
            ShowLLords();
            LandlordsDGV.CellClick += bunifuDataGridView1_CellContentClick;

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\obada\OneDrive\Documents\HouseRent.mdf;Integrated Security=True;Connect Timeout=30;");
        private void ShowLLords()
        {
            Con.Open();
            String Query = "Select *from LandlordTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            LandlordsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ResetData()
        {
            PhoneTb.Text = "";
            GenCb.SelectedIndex = -1;
            LLNameTb.Text = "";
        }

        private void bunifuPictureBox8_Click(object sender, EventArgs e)
        {
            if (LLNameTb.Text == "" || GenCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else

            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into LandLordTbl(LLName,LLPhone,LLGender)values(@LLN,@LLP,@LLG)", Con);
                    cmd.Parameters.AddWithValue("@LLN", LLNameTb.Text);
                    cmd.Parameters.AddWithValue("@LLp", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@LLG", GenCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Landlord Added!!");
                    Con.Close();
                    ResetData();
                    ShowLLords();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        int Key = 0;
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LLNameTb.Text = LandlordsDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = LandlordsDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenCb.Text = LandlordsDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (LLNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(LandlordsDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (LLNameTb.Text == "" || GenCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update landlordTbl set LLName=@LLN,LLPhone=@LLP,LLgender=@LLG where LLId=@LLKey", Con);
                    cmd.Parameters.AddWithValue("@LLN", LLNameTb.Text);
                    cmd.Parameters.AddWithValue("@LLP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@LLG", GenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@LLKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("LandLord Updated");
                    Con.Close();
                    ResetData();
                    ShowLLords();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }









        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a LandLord!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from LandLordTbl where LLID=@LLKey", Con);
                    cmd.Parameters.AddWithValue("@LLKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Landlord Deleted!!!");
                    Con.Close();
                    ResetData();
                    ShowLLords();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Tenants Obj = new Tenants();    
            Obj.Show();
        }
    }
}
    


