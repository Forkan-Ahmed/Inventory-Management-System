using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inventory
{
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-12UDCUG\SQLEXPRESS;Initial Catalog=ManageUser;Integrated Security=True");

        void populate()
        {
            try
            {

                Con.Open();
                String Myquery = "select * from CategoryTb";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                //SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoryGV.DataSource = ds.Tables[0];

                Con.Close();
            }
            catch
            {

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CategoryTb values('" + CategoryId.Text + "','" + CategoryName.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully.");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (CategoryId.Text == "")
            {

                MessageBox.Show("Enter category Id");
            }
            else
            {
                Con.Open();

                string myquery = "delete from CategoryTb where CategoryId = '" + CategoryId.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Deleted");
                Con.Close();
                populate();

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CategoryTb set CategoryName='" + CategoryName.Text + "' where CategoryId='" + CategoryId.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category  Successfully Updated.");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        //private void CategoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    CategoryId.Text = CategoryGV.SelectedRows[0].Cells[0].Value.ToString();
        //    CategoryName.Text = CategoryGV .SelectedRows[0].Cells[1].Value.ToString();
        //}

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void CustomerGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryId.Text = CategoryGV.SelectedRows[0].Cells[0].Value.ToString();
            CategoryName.Text = CategoryGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void ManageCategories_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void CategoryId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CategoryId_KeyDown(object sender, KeyEventArgs e)
        {
            if (CategoryId.Text == "")
            {
                CategoryId.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    CategoryName.Focus();
                }
            }
        }
    }
}
