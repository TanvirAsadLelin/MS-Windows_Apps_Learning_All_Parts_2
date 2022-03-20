using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;


namespace Create_SplashScreen_WithProgressBar_WindowsFormsApp
{
    public partial class WellcomePageForm : Form
    {
        public WellcomePageForm()
        {
            Thread thread = new Thread(new ThreadStart(SplashStart));
            thread.Start();
            Thread.Sleep(11600);

            InitializeComponent();

            thread.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new SplashPageForm());
        }
    }
}
