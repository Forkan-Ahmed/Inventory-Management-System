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
    public partial class ss : Form
    {
        public ss()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-12UDCUG\SQLEXPRESS;Initial Catalog=ManageUser;Integrated Security=True");
        void fillcategory()
        {
            string query = "select * from CategoryTb";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;

            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CatagoryCombo.ValueMember = "CategoryName";
                CatagoryCombo.DataSource = dt; 
                SearchCombo.ValueMember = "CategoryName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {


            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CategoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();

        }

        void populate()
        {
            try
            {

                Con.Open();
                String Myquery = "select * from ProductTb";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];

                Con.Close();
            }
            catch
            {

            }
        }


        void filterbycategory()
        {
            try
            {

                Con.Open();
                String Myquery = "select * from ProductTb where ProductCat = '"+SearchCombo.SelectedValue.ToString()+"'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            //   SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];

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
                SqlCommand cmd = new SqlCommand("insert into ProductTb values('" + ProductId.Text + "','" + ProductName.Text + "','" + ProductQuantity.Text + "','" + ProductPrice.Text + "','" + ProductDesc.Text + "','" + CatagoryCombo.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully.");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void CatagoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ProductId.Text == "")
            {

                MessageBox.Show("Enter Product Id");
            }
            else
            {
                Con.Open();

                string myquery = "delete from ProductTb where ProductId = '" + ProductId.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                populate();

            }
        }

        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductId.Text = ProductGV.SelectedRows[0].Cells[0].Value.ToString();
            ProductName.Text = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
            ProductQuantity.Text = ProductGV.SelectedRows[0].Cells[2].Value.ToString();
            ProductPrice.Text = ProductGV.SelectedRows[0].Cells[3].Value.ToString();
            ProductDesc.Text = ProductGV.SelectedRows[0].Cells[4].Value.ToString();
            CatagoryCombo.SelectedValue = ProductGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTb set ProductName='" + ProductName.Text + "',ProductQuantity='" + ProductQuantity.Text + "',ProductPrice='" + ProductPrice.Text + "',ProductDesc='" + ProductDesc.Text + "',ProductCat='" + CatagoryCombo.SelectedValue.ToString() + "' where ProductId=" + ProductId.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product  Successfully Updated.");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {

            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void ss_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ProductId_Leave(object sender, EventArgs e)
        {
            if(ProductId.Text == "")
            {
                ProductId.Focus();
            }
        }

        private void ProductId_KeyDown(object sender, KeyEventArgs e)
        {
            if (ProductId.Text == "")
            {
                ProductId.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    ProductName.Focus();
                }
            }
        }

        private void ProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (ProductName.Text == "")
            {
                ProductName.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    ProductQuantity.Focus();
                }
            }
        }

        private void ProductQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (ProductQuantity.Text == "")
            {
                ProductQuantity.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    ProductPrice.Focus();
                }
            }
        }

        private void ProductPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (ProductPrice.Text == "")
            {
                ProductPrice.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    ProductDesc.Focus();
                }
            }
        }

        private void CatagoryCombo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ProductDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (ProductDesc.Text == "")
            {
                ProductDesc.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    CatagoryCombo.Focus();
                }
            }
        }
    }
}
