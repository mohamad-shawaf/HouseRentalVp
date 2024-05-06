using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentalVp
{
    public partial class Tenants : Form
    {
        public Tenants()
        {
            InitializeComponent();
            ShowTenants();

            TenantsDGV.CellClick += dataGridView1_CellContentClick;

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\obada\OneDrive\Documents\HouseRent.mdf;Integrated Security=True;Connect Timeout=30;");
        private void ShowTenants()
        {
            Con.Open();
            String Query = "Select * from TenantTabl where TenId is not NULL";
            SqlDataAdapter sda = new SqlDataAdapter (Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TenantsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ResetData()
        {
            PhoneTb.Text = "";
            GenCb.SelectedIndex = -1;
            TNameTb.Text = "";
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox8_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || GenCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");

            }else
            {

                try
                {

                    string query = string.Empty;
                    query += "INSERT INTO TenantTabl (TenName, TenPhone, TenGender)";
                    query += "VALUES (@TenName,@TenPhone, @TenGender)";

                    using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\obada\OneDrive\Documents\HouseRent.mdf;Integrated Security=True;Connect Timeout=30;"))
                    {
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandType = CommandType.Text;
                            comm.CommandText = query;
                            comm.Parameters.AddWithValue("@TenName", TNameTb.Text);
                            comm.Parameters.AddWithValue("@TenPhone", PhoneTb.Text);
                            comm.Parameters.AddWithValue("@TenGender", GenCb.SelectedItem.ToString());


                            try
                            {
                                conn.Open();
                                comm.ExecuteNonQuery();
                                conn.Close();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message.ToString(), "Error Message");
                            }
                        }
                    }

                    //SqlCommand cmd = new SqlCommand("insert into TenantTabl(TenName,TenPhone,TenGen) values", Con);
                    //cmd.Parameters.AddWithValue("@TN", TNameTb.Text);
                    //cmd.Parameters.AddWithValue("@TP", PhoneTb.Text);
                    //cmd.Parameters.AddWithValue("@TG", GenCb.SelectedItem.ToString());
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Tenant Added!!");
                    ResetData();
                    ShowTenants();
                }
                catch (Exception ex) {
                
                MessageBox.Show(ex.Message);
                }
                
            }
        }
        int Key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TenantsDGV.SelectedRows.Count > 0 && TenantsDGV.SelectedRows[0].Cells.Count > 0)
            {

                TNameTb.Text = TenantsDGV.SelectedRows[0].Cells[1].Value?.ToString();
                PhoneTb.Text = TenantsDGV.SelectedRows[0].Cells[2].Value?.ToString();
                GenCb.Text = TenantsDGV.SelectedRows[0].Cells[3].Value?.ToString();
                if (TNameTb.Text == "")
                {
                    Key = 0;

                }
                else
                {
                    Key = Convert.ToInt32(TenantsDGV.SelectedRows[0].Cells[0].Value.ToString());
                }

            }else
            {
                Key = 0;
            }


            

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var x = TenantsDGV.SelectedRows[0].DataBoundItem as Tenants;

            if (TNameTb.Text == "" || GenCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update TenantTabl set TenName=@TN,TenPhone=@TP,TenGender=@TG where TenId=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TN", TNameTb.Text);
                    cmd.Parameters.AddWithValue("@TP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TG", GenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tenant Updated!!!");
                    Con.Close();
                    ResetData();
                    ShowTenants();

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Tenant!!!");
            }else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from TenantTabl where TenId=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    ResetData();
                    ShowTenants();
                    //helps to delete tenants
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }
    }
}
