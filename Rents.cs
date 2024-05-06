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
using static Bunifu.UI.WinForms.BunifuPictureBox;

namespace HouseRentalVp
{
    public partial class Rents : Form
    {
        public Rents()
        {
            InitializeComponent();
            GetApart();
            GetTenant();
            ShowRents();
            RentDGV.CellClick += dataGridView1_CellContentClick;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\obada\OneDrive\Documents\HouseRent.mdf;Integrated Security=True;Connect Timeout=30;");

        private void GetApart()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select ANum from ApartmentTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ANum", typeof(int));
            dt.Load(Rdr);
            ApartCb.ValueMember = "ANum";
            ApartCb.DataSource = dt;
            Con.Close();

        }

        private void GetTenant()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select TenId from TenantTabl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TenId", typeof(int));
            dt.Load(Rdr);
            TenantCb.ValueMember = "TenId";
            TenantCb.DataSource = dt;
            Con.Close();

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowRents()
        {
            Con.Open();
            String Query = "Select * from RentTabl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            RentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ResetData()
        {
            AmountTb.Text = "";

        }
        private void GetCost()
        {
            Con.Open();
            string Query = "select * from ApartTbl where ANum=" + ApartCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                AmountTb.Text = dr["ACost"].ToString();
            }
            Con.Close();
        }
        private void bunifuPictureBox8_Click(object sender, EventArgs e)
        {
            if (ApartCb.SelectedIndex == -1 || TenantCb.SelectedIndex == -1 || AmountTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    string Period = RDate.Value.Date.Month + "-" + RDate.Value.Date.Year;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into RentTabl  (Apartment, Tenant, Period, Amount)values(@RA,@RT,@RP,@RAm)", Con);
                    cmd.Parameters.AddWithValue("@RA", ApartCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@RT", TenantCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@RP", Period);
                    cmd.Parameters.AddWithValue("@RAm", AmountTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Apartment Rented!!!");
                    Con.Close();
                    ResetData();
                    ShowRents();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ApartCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCost();
        }

        private void label7_Click(object sender, EventArgs e)
        {


        }
        int Key = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RentDGV.SelectedRows.Count > 0 && RentDGV.SelectedRows[0].Cells.Count > 0)
            {

                ApartCb.Text = RentDGV.SelectedRows[0].Cells[1].Value?.ToString();
                TenantCb.Text = RentDGV.SelectedRows[0].Cells[2].Value?.ToString();
                if (ApartCb.Text == "")
                {
                    Key = 0;

                }
                else
                {
                    Key = Convert.ToInt32(RentDGV.SelectedRows[0].Cells[0].Value.ToString());
                }

            }
            else
            {
                Key = 0;
            }




        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Tenant!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from RentTabl where RCode=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    ResetData();
                    ShowRents();
                    //helps to delete tenants
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string Period = RDate.Value.Date.Month + "-" + RDate.Value.Date.Year;

            var x = RentDGV.SelectedRows[0].DataBoundItem as Rents;

            if (ApartCb.Text == "" || TenantCb.SelectedIndex == -1 || Period== "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update RentTabl set Apartment=@RA,Tenant=@TP,Period=@TG, Amount=@RAm where RCode=@TKey", Con);
                    cmd.Parameters.AddWithValue("@RA", int.Parse(ApartCb.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@TP", int.Parse(TenantCb.SelectedValue.ToString())); 
                    cmd.Parameters.AddWithValue("@TG", Period);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.Parameters.AddWithValue("@RAm", int.Parse(AmountTb.Text.ToString())); 

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rent Updated!!!");
                    Con.Close();
                    ResetData();
                    ShowRents();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
