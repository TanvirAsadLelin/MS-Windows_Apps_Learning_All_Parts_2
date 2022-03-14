using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Configuration;
using System.Data.SqlClient;

namespace CRUD_InIdentityColumn_DB_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        int id;
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString; 
        public Form1()
        {
            InitializeComponent();
            BindGridView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string queryInsert = "insert into Product_Tbl values(@name, @company, @category,@price,@stock)";

            SqlCommand cmd = new SqlCommand(queryInsert, con);

            cmd.Parameters.AddWithValue("@name",textBoxName.Text);
            cmd.Parameters.AddWithValue("@company", textBoxCompany.Text);
            cmd.Parameters.AddWithValue("@category", textBoxCategory.Text);
            cmd.Parameters.AddWithValue("@price",textBoxPrice.Text);
            cmd.Parameters.AddWithValue("@stock", textBoxStock.Text);

            con.Open();

            int value =  cmd.ExecuteNonQuery();

            if (value> 0)
            {
                MessageBox.Show("Inserted successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindGridView();
            }

            else
            {
                MessageBox.Show("Inserted failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            con.Close();

        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);

            string querySelect = "select * from Product_Tbl";

            // SqlCommand cmd = new SqlCommand(querySelect, con);

            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, con);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataGridViewProductDeatils.DataSource = dataTable;

            dataGridViewProductDeatils.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string queryInsert = "update Product_Tbl set Product_Name = @name, Product_Company = @company, Product_Category = @category, Product_Price = @price, Product_Stock = @stock where Product_Id = @productId";

            SqlCommand cmd = new SqlCommand(queryInsert, con);

            cmd.Parameters.AddWithValue("@productId", id);
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@company", textBoxCompany.Text);
            cmd.Parameters.AddWithValue("@category", textBoxCategory.Text);
            cmd.Parameters.AddWithValue("@price", textBoxPrice.Text);
            cmd.Parameters.AddWithValue("@stock", textBoxStock.Text);

            con.Open();

            int value = cmd.ExecuteNonQuery();

            if (value > 0)
            {
                MessageBox.Show("Updated successfuly", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindGridView();
            }

            else
            {
                MessageBox.Show("Updated failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            con.Close();
        }

        private void dataGridViewProductDeatils_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id =Convert.ToInt32 ( dataGridViewProductDeatils.SelectedRows[0].Cells[0].Value);
            textBoxName.Text = dataGridViewProductDeatils.SelectedRows[0].Cells[1].Value.ToString();
            textBoxCompany.Text = dataGridViewProductDeatils.SelectedRows[0].Cells[2].Value.ToString();
            textBoxCategory.Text = dataGridViewProductDeatils.SelectedRows[0].Cells[3].Value.ToString();
            textBoxPrice.Text = dataGridViewProductDeatils.SelectedRows[0].Cells[4].Value.ToString();
            textBoxStock.Text = dataGridViewProductDeatils.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string queryInsert = "delete from Product_Tbl where Product_Id = @productId";

            SqlCommand cmd = new SqlCommand(queryInsert, con);

            cmd.Parameters.AddWithValue("@productId", id);
         

            con.Open();

            int value = cmd.ExecuteNonQuery();

            if (value > 0)
            {
                MessageBox.Show("Deleted successfuly", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindGridView();
            }

            else
            {
                MessageBox.Show("Deleted failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            con.Close();
        }
    }
}
