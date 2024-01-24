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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-12UDCUG\SQLEXPRESS;Initial Catalog=ManageUser;Integrated Security=True");

        void populateorders()
        {
            try
            {

                Con.Open();
                String Myquery = "select * from OrderTb";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
       //         SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrdersGV.DataSource = ds.Tables[0];

                Con.Close();
            }
            catch
            {

            }
        }


        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateorders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewOrders_FormClosing(object sender, FormClosingEventArgs e)
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
    }  
}
