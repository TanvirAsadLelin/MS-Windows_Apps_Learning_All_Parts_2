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


namespace CRUD_DateTimePicker_WithDB_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            BindGridview();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con =  new SqlConnection(cs);
            string queryInsert = "insert into DateTimePicker_Tbl values(@id, @name,@doj,@toj,@dob)";

            SqlCommand cmd =  new SqlCommand(queryInsert, con);

            cmd.Parameters.AddWithValue("@id", textBoxId.Text);
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@doj", dateTimePickerDOJ.Value);
            cmd.Parameters.AddWithValue("@toj", dateTimePickerTOJ.Value);
            cmd.Parameters.AddWithValue("@dob", dateTimePickerDOB.Value);

            con.Open();
            int value =  cmd.ExecuteNonQuery();

            if (value > 0)
            {
                MessageBox.Show("Success");

                BindGridview();

            }
            else
            {
                MessageBox.Show("Failed");
            }
            con.Close();
        }


        void BindGridview()
        {
            SqlConnection con = new SqlConnection(cs);

            string querySelect = "Select * from DateTimePicker_Tbl ";

            SqlDataAdapter adapter =  new SqlDataAdapter(querySelect, con);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataGridViewDateTimeShowList.DataSource = dataTable; 


        }

        private void dataGridViewDateTimeShowList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxId.Text =  dataGridViewDateTimeShowList.SelectedRows[0].Cells[0].Value.ToString();
            textBoxName.Text =  dataGridViewDateTimeShowList.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePickerDOJ.Value =Convert.ToDateTime( dataGridViewDateTimeShowList.SelectedRows[0].Cells[2].Value);
            dateTimePickerTOJ.Value =Convert.ToDateTime( dataGridViewDateTimeShowList.SelectedRows[0].Cells[3].Value);
            dateTimePickerDOB.Value =Convert.ToDateTime( dataGridViewDateTimeShowList.SelectedRows[0].Cells[4].Value);
        }
    }
}
