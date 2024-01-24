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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-12UDCUG\SQLEXPRESS;Initial Catalog=ManageUser;Integrated Security=True");
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into userTb values('" + UserName.Text + "','" + UserFullName.Text + "','" + UserPassword.Text + "','" + UserPhone.Text + "')",Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully.");
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

        void populate()
        {
            try
            {

            Con.Open();
                String Myquery = "select * from userTb";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                //SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                userGV.DataSource = ds.Tables[0];

            Con.Close();
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populate();
        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(UserPhone.Text == "")
            {

                MessageBox.Show("Enter User Phone Number");
            }
            else
            {
                Con.Open();

                string myquery = "delete from userTb where UserPhone = '" + UserPhone.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted Successfully");
                Con.Close();
                populate();

            }
        }

        private void userGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserName.Text = userGV.SelectedRows[0].Cells[0].Value.ToString();
            UserFullName.Text = userGV.SelectedRows[0].Cells[1].Value.ToString();
            UserPassword.Text = userGV.SelectedRows[0].Cells[2].Value.ToString();
            UserPhone.Text = userGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update userTb set UserName='" + UserName.Text + "',UserFullName='" + UserFullName.Text + "',UserPassword='" + UserPassword.Text + "' where UserPhone='" + UserPhone.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Updated.");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {

            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (UserName.Text == "")
            {
                UserName.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    UserFullName.Focus();
                }
            }
        }

        private void UserFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (UserFullName.Text == "")
            {
                UserFullName.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    UserPassword.Focus();
                }
            }
        }

        private void UserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (UserPassword.Text == "")
            {
                UserPassword.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    UserPhone.Focus();
                }
            }
        }
    }
}
