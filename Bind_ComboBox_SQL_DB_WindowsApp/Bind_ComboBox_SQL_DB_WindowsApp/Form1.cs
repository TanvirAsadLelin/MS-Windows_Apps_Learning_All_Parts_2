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

namespace Bind_ComboBox_SQL_DB_WindowsApp
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        void BindCombobox()
        {
            SqlConnection con =  new SqlConnection(cs);
            string query = "select * from Employee_Tbl";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string name = dr.GetString(1);
                comboBoxEmployeeName.Items.Add(name);
            }

            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindCombobox();
        }
    }
}
