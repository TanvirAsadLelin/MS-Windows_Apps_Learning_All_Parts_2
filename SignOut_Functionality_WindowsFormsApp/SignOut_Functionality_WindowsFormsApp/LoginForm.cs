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


namespace SignOut_Functionality_WindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabelForRegistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);

            string querySelectEmailPass = "select * from SignUp_Tbl where Email = @email and Password = @pass ";

            SqlCommand cmd = new SqlCommand(querySelectEmailPass, con);
            cmd.Parameters.AddWithValue("@email", textBoxUsername.Text);
            cmd.Parameters.AddWithValue("@pass", textBoxPassword.Text);

            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == true)
            {
                MessageBox.Show("Login Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SignOutForm signOutForm = new SignOutForm();
                this.Hide();
                signOutForm.Show();
            }

            else
            {
                MessageBox.Show("Login fail", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        private void checkBoxShowPass_Click(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUsername.Focus();
        }
    }
}
