using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web;
using System.Net;
using System.Net.Mail;

namespace Sending_Email_WithAttachment_WindowsFormsApp
{
    public partial class SendEmailForm : Form
    {
        public SendEmailForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // For sent mail use Generate a app password in sender email 
                // my password .......
                MailMessage mailMessage = new MailMessage(textBoxForm.Text, textBoxTo.Text, textBoxSubject.Text, textBoxBody.Text);
                mailMessage.Attachments.Add(new Attachment(textBoxAttachment.Text.ToString()));
                
                SmtpClient smtpClient = new SmtpClient(comboBoxSMTP.SelectedItem.ToString());

                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(textBoxUsername.Text, textBoxPassword.Text);

                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);

                MessageBox.Show("Sent email successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetControl();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select file";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*PNG|All files (*.*)|*.*";
            openFileDialog.ShowDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName.ToString();

                textBoxAttachment.Text = path;
            }
          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        void ResetControl()
        {
            textBoxForm.Clear();
            textBoxTo.Clear();
            textBoxSubject.Clear();
            comboBoxSMTP.SelectedItem = null;
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxBody.Clear();
            textBoxAttachment.Clear();
        }
    }
}
