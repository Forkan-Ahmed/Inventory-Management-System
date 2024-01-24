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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
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
             //   SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomerGV.DataSource = ds.Tables[0];

                Con.Close();
            }
            catch
            {

            }
        }
        void populateproducts()
        {
            try
            {

                Con.Open();
                String Myquery = "select * from ProductTb";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
              //  SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];

                Con.Close();
            }
            catch
            {

            }
        }
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
                //CatagoryCombo.ValueMember = "CategoryName";
                //CatagoryCombo.DataSource = dt; 
                SearchCombo.ValueMember = "CategoryName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {


            }
        }
        int num = 0, uprice, totprice, qty;
        string product;
        DataTable table = new DataTable();
        void updateproduct()
        {
         
            int id=Convert.ToInt32(ProductGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(Qty.Text);
           if (newQty < 0)
            {
                MessageBox.Show("Operation Failed");
            }
           else
            {
                Con.Open();
                string query = "update ProductTb set ProductQuantity =" + newQty + "where ProductId=" + id + ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery(); 
            Con.Close();
            populateproducts(); 
            }
            }
              
        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateproducts();
            fillcategory();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UPrice", typeof(int));
            table.Columns.Add("TotPrice", typeof(int));
            OrderGV.DataSource = table;
        }
        int flag = 0,stock;
        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
            //qty = Convert.ToInt32(Qty.Text);
            stock= Convert.ToInt32(ProductGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(ProductGV.SelectedRows[0].Cells[3].Value.ToString());
            //totprice = qty * uprice;
            flag = 1;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InsertOrder_Click(object sender, EventArgs e)
        {
            if(OrderId.Text == "" || CustomerId.Text == ""  || CustomerName.Text == "" || totalAmnt.Text == "")
            {
                MessageBox.Show("Fill The data Correctly");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into OrderTb values(" + OrderId.Text + "," + CustomerId.Text + ",'" + CustomerName.Text + "','" + orderDate.Value + "'," + totalAmnt.Text + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully.");
                Con.Close();
                try
                {
                }
                catch
                {

                }
            }

        }

        private void totalAmnt_Click(object sender, EventArgs e)
        {

        }



        private void orderDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ManageOrders_FormClosing(object sender, FormClosingEventArgs e)
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

        private void OrderId_KeyDown(object sender, KeyEventArgs e)
        {
            if (OrderId.Text == "")
            {
                OrderId.Focus();
            }
            else
            {
                if (e.KeyData == Keys.Enter)
                {
                    CustomerId.Focus();
                }
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

        private void showAmount_Click(object sender, EventArgs e)
        {

        }

        int sum = 0;
        private void addButton_Click(object sender, EventArgs e)
        {
            if (Qty.Text == "")
                MessageBox.Show("Enter the Quantity of Product");
            else if (flag == 0)
                MessageBox.Show("Select the Product");
            else if (Convert.ToInt32(Qty.Text) > stock)
            {
                MessageBox.Show("No Enough Stock Avalable");
                return;
            }
               
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(Qty.Text);
                totprice = qty * uprice;
                table.Rows.Add(num, product, qty, uprice, totprice);
                OrderGV.DataSource = table;
                flag = 0;
            }
            sum = sum + totprice;
            totalAmnt.Text =sum.ToString();
            updateproduct();
        }

        private void CustomerGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CustomerId.Text = CustomerGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerName.Text = CustomerGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void SearchCombo_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            try
            {

                Con.Open();
                String Myquery = "select * from ProductTb where ProductCat = '" + SearchCombo.SelectedValue.ToString() + "'";
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
        /*private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                Con.Open();
                String Myquery = "select * from ProductTb where ProductCat = '" + SearchCombo.SelectedValue.ToString() + "'";
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

        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductGV.SelectedRows[0].Cells[0].Value.ToString();
            qty = Convert.ToInt32(Qty.Text);
            uprice= Convert.ToInt32(ProductGV.SelectedRows[0].Cells[0].Value.ToString());
            totprice = qty * uprice;
        }
        private void CustomerGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        CustomerId.Text = CustomerGV.SelectedRows[0].Cells[0].Value.ToString();
        }*/
    }
}
