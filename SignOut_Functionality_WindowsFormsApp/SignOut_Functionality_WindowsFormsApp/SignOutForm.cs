using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignOut_Functionality_WindowsFormsApp
{
    public partial class SignOutForm : Form
    {
        public SignOutForm()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.loginForm.Show();

        }
    }
}
