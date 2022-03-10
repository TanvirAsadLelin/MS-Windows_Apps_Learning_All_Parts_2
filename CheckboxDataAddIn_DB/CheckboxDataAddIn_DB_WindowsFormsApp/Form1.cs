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

namespace CheckboxDataAddIn_DB_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
        
            SqlCommand cmd = new SqlCommand("proc_Insert_MyHobbies_Tbl", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", textBoxName);
            cmd.Parameters.AddWithValue("@reading", checkBoxReading.Checked);
            cmd.Parameters.AddWithValue("@writing", checkBoxWriting.Checked);
            cmd.Parameters.AddWithValue("@walking", checkBoxWalking.Checked);
            cmd.Parameters.AddWithValue("@sleeping", checkBoxSleeping.Checked);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Inserted Successfuly!");
            }
            else
            {
                MessageBox.Show("Inserted Faild");
            }




        }
    }
}
