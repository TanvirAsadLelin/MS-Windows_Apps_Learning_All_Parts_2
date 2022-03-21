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

namespace FilteringDataUsingRadioButton_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            BindGridView();
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string querySelect = "select * from Employee_Tbl";

            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, con);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridViewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployee.DataSource = dataTable;



            // For specific Coloumn get in Data gridview


            //dataGridViewEmployee.Rows.Clear();
            //foreach(DataRow row in dataTable.Rows)
            //{
            //    int index  =  dataGridViewEmployee.Rows.Add();

            //    dataGridViewEmployee.Rows[index].Cells[0].Value = row["Id"].ToString();
            //    dataGridViewEmployee.Rows[index].Cells[1].Value = row["Name"].ToString();
            //}


        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string querySelect = "select * from Employee_Tbl where Gender = 'Male' ";

            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, con);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployee.DataSource = dataTable;
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string querySelect = "select * from Employee_Tbl where Gender = 'Female' ";

            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, con);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployee.DataSource = dataTable;
        }

        private void radioButtonBoth_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string querySelect = "select * from Employee_Tbl";

            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, con);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployee.DataSource = dataTable;
        }



    }
}
