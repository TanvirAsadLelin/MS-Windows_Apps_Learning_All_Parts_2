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
using System.Configuration;

namespace Binding_OneCombobox_ToAnother_Combobox_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;

        DataRow dataRow;
        public Form1()
        {
            InitializeComponent();
            BindComboboxDistrict();
        }

        void BindComboboxDistrict()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from District_Tbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

          
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataRow =  dataTable.NewRow();
            dataRow.ItemArray = new object[] { 0, "Slect your district" };
            dataTable.Rows.InsertAt(dataRow,0);

            comboBoxDistrict.DisplayMember = "District_Name";
            comboBoxDistrict.ValueMember = "District_ID";
            comboBoxDistrict.DataSource = dataTable;


        }

        void BindComboboxUpozila(int districtID)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Upozila_Tbl where District_ID = @D_id";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.SelectCommand.Parameters.AddWithValue("@D_id",districtID);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataRow = dataTable.NewRow();
            dataRow.ItemArray = new object[] { 0, "Slect your upozila" };
            dataTable.Rows.InsertAt(dataRow, 0);

            comboBoxUpozila.DisplayMember = "Upozila_Name";
            comboBoxUpozila.ValueMember = "Upozila_ID";
            comboBoxUpozila.DataSource = dataTable;


        }

        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxDistrict.SelectedValue.ToString() != null)
            {
                int country_id =Convert.ToInt32( comboBoxDistrict.SelectedValue.ToString());
                BindComboboxUpozila(country_id);
            }
        }
    }
}
