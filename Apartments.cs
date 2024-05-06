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


    public partial class Apartments : Form
    {
        public Apartments()
        {
            InitializeComponent();
            GetCategories();
            GetOwner();
            ShowAparts();
            ApartmentDGV.CellClick += ApartmentDGV_CellContentClick;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\obada\OneDrive\Documents\HouseRent.mdf;Integrated Security=True;Connect Timeout=30;");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GetCategories()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CNum from categoryTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable(); 
            dt.Columns.Add ("CNum",  typeof (int));
            dt.Load(Rdr);
            TypeCb.ValueMember = "CNum";
            TypeCb.DataSource = dt; 
            Con.Close();

        }

        private void GetOwner()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select LLID from LandLordTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("LLID", typeof(int));
            dt.Load(Rdr);
            LLcb.ValueMember = "LLID";
            LLcb.DataSource = dt;
            Con.Close();

        }

        private void ShowAparts()
        {
            Con.Open();
            String Query = "Select *from ApartmentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ApartmentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ResetData()
        {
           ApNameTb.Text = "";
            LLcb.SelectedIndex = -1;
            CostTb.Text = "";
            TypeCb.SelectedIndex = -1;
            AddressTb.Text = "";

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ApNameTb.Text == "" || LLcb.SelectedIndex == -1 || CostTb.Text == "" || TypeCb.SelectedIndex== -1 || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try


                {
                    


                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ApartmentTbl  (AName, AAddress, AType, ACost, Owner) values (@AN,@AAdd,@AT,@AC,@AO)", Con);
                    cmd.Parameters.AddWithValue("@AN", ApNameTb.Text);
                    cmd.Parameters.AddWithValue("@AAdd", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@AT", int.Parse(TypeCb.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@AC", CostTb.Text);
                    cmd.Parameters.AddWithValue("@AO",int.Parse( LLcb.SelectedValue.ToString()));

                    cmd.ExecuteNonQuery();
                    Con.Close();

                    MessageBox.Show("LandLord Updated");
                    ResetData();
                    ShowAparts();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void LLcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int Key = 0;
        private void ApartmentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ApNameTb.Text = ApartmentDGV.SelectedRows[0].Cells[1].Value.ToString();
            AddressTb.Text = ApartmentDGV.SelectedRows[0].Cells[2].Value.ToString();
            TypeCb.Text = ApartmentDGV.SelectedRows[0].Cells[3].Value.ToString();
            CostTb.Text = ApartmentDGV.SelectedRows[0].Cells[4].Value.ToString();
            LLcb.Text = ApartmentDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (ApNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ApartmentDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (ApNameTb.Text == "" || LLcb.SelectedIndex == -1 || CostTb.Text == "" || TypeCb.SelectedIndex == -1 || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ApartmentTbl set AName=@AN, AAddress=@aaDD, Atype= @AT, ACost= @AC, Owner= @AO where Anum=@AKey ", Con);
                    cmd.Parameters.AddWithValue("@AN", ApNameTb.Text);
                    cmd.Parameters.AddWithValue("@AAdd", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@AT", int.Parse(TypeCb.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@AC", CostTb.Text);
                    cmd.Parameters.AddWithValue("@AO", int.Parse(LLcb.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@AKey", Key);

                    cmd.ExecuteNonQuery();
                    Con.Close();

                    MessageBox.Show("LandLord Updated");
                    ResetData();
                    ShowAparts();

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
                MessageBox.Show("Select a Tenant!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ApartmentTbl where Anum=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Apartment Deleted!");
                    Con.Close();
                    ResetData();
                    ShowAparts();
                    //helps to delete tenants
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    
}
