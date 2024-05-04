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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = bunifuTextBox1.Text;
            dataGridView1.Rows[n].Cells[1].Value = bunifuTextBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = bunifuTextBox3.Text;
            dataGridView1.Rows[n].Cells[3].Value = bunifuTextBox4.Text;

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
    }
}
