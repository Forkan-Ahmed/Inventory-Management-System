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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-12UDCUG\SQLEXPRESS;Initial Catalog=ManageUser;Integrated Security=True");

        void populate()
        {
            try
            {

                Con.Open();
                String Myquery = "select * from CustomerTb";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                //SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomerGV.DataSource = ds.Tables[0];

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

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTb values('" + CustomerId.Text + "','" + CustomerName.Text + "','" + CustomerPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added Successfully.");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void CustomerGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerId.Text = CustomerGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerName.Text = CustomerGV.SelectedRows[0].Cells[1].Value.ToString();
            CustomerPhone.Text = CustomerGV.SelectedRows[0].Cells[2].Value.ToString();
           // populate();
            Con.Open();
                 SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from OrderTb where CustomerId= " + CustomerId.Text + "", Con);
              DataTable dt = new DataTable();
              sda.Fill(dt);
            //dt.Rows[0][0].ToString()
            OrderLabel.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select Sum(totalAmnt) from OrderTb where CustomerId= " + CustomerId.Text + "", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLabel.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select Max(orderDate) from OrderTb where CustomerId= " + CustomerId.Text + "", Con);
           DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            DateLabel.Text = dt2.Rows[0][0].ToString();
            Con.Close();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (CustomerId.Text == "")
            {

                MessageBox.Show("Enter customer Id");
            }
            else
            {
                Con.Open();

                string myquery = "delete from CustomerTb where CustomerId = '" +CustomerId.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Con.Close();
                populate();

            }
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTb set CustomerName='" + CustomerName.Text + "',CustomerPhone='" + CustomerPhone.Text + "' where CustomerId='" + CustomerId.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated.");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void CustomerId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {

            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void ManageCustomers_FormClosing(object sender, FormClosingEventArgs e)
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

        private void CustomerId_KeyDown(object sender, KeyEventArgs e)
        {
            if (CustomerId.Text == "")
            {
                CustomerId.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    CustomerName.Focus();
                }
            }
        }

        private void CustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (CustomerName.Text == "")
            {
                CustomerName.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    CustomerPhone.Focus();
                }
            }
        }
    }
}
