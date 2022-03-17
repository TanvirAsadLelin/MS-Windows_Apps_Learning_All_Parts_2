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



namespace RetrievingData_UsingCombobox_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString; 
        public Form1()
        {
            InitializeComponent();
            BindCombobox();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string queryInsert = "insert into EmployeeInfo_Tbl values(@id,@name,@contactNo ,@address,@age, @designation,@salary)";

            SqlCommand cmd = new SqlCommand(queryInsert, con);  

            cmd.Parameters.AddWithValue("@id",textBoxID.Text);
            cmd.Parameters.AddWithValue("@name",textBoxName.Text);
            cmd.Parameters.AddWithValue("@contactNo", textBoxContactNo.Text);
            cmd.Parameters.AddWithValue("@address",textBoxAddress.Text);
            cmd.Parameters.AddWithValue("@age",numericUpDownAge.Value);
            cmd.Parameters.AddWithValue("@designation", textBoxDesignation.Text);
            cmd.Parameters.AddWithValue("@salary", textBoxSalary.Text);

            con.Open();
            int value = cmd.ExecuteNonQuery();
            if (value > 0)
            {
                MessageBox.Show("Inserted");
                ClearInsertData();
                BindCombobox();
            }
            else
            {
                MessageBox.Show("failed");
            }

            con.Close();

            
        }

        void BindCombobox()
        {   
            comboBoxId.Items.Clear();   
            SqlConnection con = new SqlConnection(cs);
            string querySelect = "select * from EmployeeInfo_Tbl";

            SqlCommand cmd =  new SqlCommand(querySelect, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                int id =  reader.GetInt32(0);

                comboBoxId.Items.Add(id);
            }

            con.Close();
        }

        private void comboBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxId.SelectedItem.ToString() != null)
            {
                int id =Convert.ToInt32( comboBoxId.SelectedItem.ToString());
                SqlConnection con = new SqlConnection(cs);
                string querySelect = "select * from EmployeeInfo_Tbl where Id=@id ";

                SqlDataAdapter adapter = new SqlDataAdapter(querySelect, con);
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if(dataTable.Rows.Count > 0)
                {
                    textBoxCName.Text = dataTable.Rows[0]["Name"].ToString();
                    textBoxCContactNo.Text = dataTable.Rows[0]["ContactNo"].ToString();
                    textBoxCAddress.Text = dataTable.Rows[0]["Address"].ToString();
                    textBoxCAge.Text = dataTable.Rows[0]["Age"].ToString();
                    textBoxCDesignation.Text = dataTable.Rows[0]["Designation"].ToString();
                    textBoxCSalary.Text = dataTable.Rows[0]["Salary"].ToString();


                }


            }
        }

        void ClearInsertData()
        {
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxContactNo.Clear();
            textBoxAddress.Clear();
            numericUpDownAge.Value = 0;
            textBoxDesignation.Clear();
            textBoxSalary.Clear();
        }


    }
}
