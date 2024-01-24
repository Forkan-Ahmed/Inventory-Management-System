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
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-12UDCUG\SQLEXPRESS;Initial Catalog=ManageUser;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(gunaCheckBox1.Checked == false)
            {
                PasswordTb.isPassword = true;
            }
            else 
                PasswordTb.isPassword = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }
        public static int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //
            if (UnameTb.Text == "Admin" || UnameTb.Text == "admin" && PasswordTb.Text == "12345") 
            flag =1;


            //log lc = new log();
            //logGatway lg = new logGatway();
            //lc.UserName = UnameTb.Text;
            //lc.Pw = PasswordTb.Text;
            //if (lg.checkadmin(lc))
            //{
            //    HomeForm cust = new HomeForm();
            //    cust.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid!");
            //}
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from userTb where UserName = '" + UnameTb.Text + "' and UserPassword = '" + PasswordTb.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

               
                HomeForm cust = new HomeForm();
                cust.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Usersname Or Password");
            }
            Con.Close();


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void UnameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void UnameTb_Click(object sender, EventArgs e)
        {
            

        }

        private void UnameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (UnameTb.Text == "")
            {
                UnameTb.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    PasswordTb.Focus();
                }
            }
        }

        private void UnameTb_Enter(object sender, EventArgs e)
        {
           
        }

        private void UnameTb_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void UnameTb_SystemColorsChanged(object sender, EventArgs e)
        {

        }

        private void UnameTb_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void PasswordTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (PasswordTb.Text == "")
            {
                PasswordTb.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    button1.Focus();
                }
            }
        }

        private void UnameTb_Leave(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
