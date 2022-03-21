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

namespace AutoIncrementTextboxValue_WithDB_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            BindGridview();
        }

        void GetIncrementId()
        {
            SqlConnection con =  new SqlConnection(cs);

            string querySelect = "select Id from List_Tbl";

            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, con);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count < 1)
            {
                textBoxID.Text = "1";
            }
            else
            {
                SqlConnection con1 = new SqlConnection(cs);
                string querySelect_1 = "select max(Id) from List_Tbl";

                SqlCommand cmd = new SqlCommand(querySelect_1, con1);
                con1.Open();
                int value =  Convert.ToInt32(cmd.ExecuteScalar());
                con1.Close();

                value = value + 1;
                textBoxID.Text = value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetIncrementId();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(cs);
            string queryInsert = "insert into List_Tbl values (@id,@name,@age)"; 

            SqlCommand cmd = new SqlCommand(queryInsert, con2);
            cmd.Parameters.AddWithValue("@id", textBoxID.Text);
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@age", textBoxAge.Text);
            
            con2.Open();
            int value = cmd.ExecuteNonQuery();
            if(value > 0)
            {
                MessageBox.Show("Inserted");
                GetIncrementId();
                textBoxName.Text = "";
                textBoxAge.Text = "";
                BindGridview();
            }
            else
            {
                MessageBox.Show("Failed");
            }
            con2.Close();
        }


        void BindGridview()
        {
            SqlConnection con = new SqlConnection(cs);

            string querySelect = "select * from List_Tbl ";

            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, con);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridViewList.DataSource = dataTable;
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridViewList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxID.Text = dataGridViewList.SelectedRows[0].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewList.SelectedRows[0].Cells[1].Value.ToString();
            textBoxAge.Text = dataGridViewList.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(cs);
            string queryInsert = "update List_Tbl set Name=@name,Age = @age where Id=@id";

            SqlCommand cmd = new SqlCommand(queryInsert, con2);
            cmd.Parameters.AddWithValue("@id", textBoxID.Text);
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@age", textBoxAge.Text);

            con2.Open();
            int value = cmd.ExecuteNonQuery();
            if (value > 0)
            {
                MessageBox.Show("Updated");
                GetIncrementId();
                textBoxName.Text = "";
                textBoxAge.Text = "";
                BindGridview();
            }
            else
            {
                MessageBox.Show("Update fail");
            }
            con2.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(cs);
            string queryInsert = "delete from List_Tbl where Id=@id";

            SqlCommand cmd = new SqlCommand(queryInsert, con2);
            cmd.Parameters.AddWithValue("@id", textBoxID.Text);
            con2.Open();
            int value = cmd.ExecuteNonQuery();
            if (value > 0)
            {
                MessageBox.Show("Deleted");
                GetIncrementId();
                textBoxName.Text = "";
                textBoxAge.Text = "";
                BindGridview();
            }
            else
            {
                MessageBox.Show("Delete fail");
            }
            con2.Close();
        }
    }
}
