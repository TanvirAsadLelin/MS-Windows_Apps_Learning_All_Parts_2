namespace Sending_Email_WithAttachment_WindowsFormsApp
{
    partial class SendEmailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxForm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAttachment = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.comboBoxSMTP = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Send Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Form: ";
            // 
            // textBoxForm
            // 
            this.textBoxForm.Location = new System.Drawing.Point(350, 60);
            this.textBoxForm.Name = "textBoxForm";
            this.textBoxForm.Size = new System.Drawing.Size(288, 22);
            this.textBoxForm.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "To: ";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(350, 102);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(288, 22);
            this.textBoxTo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Subject: ";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(350, 137);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(288, 22);
            this.textBoxSubject.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "SMTP: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Username: ";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(350, 220);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(288, 22);
            this.textBoxUsername.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(195, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Password: ";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(350, 262);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(288, 22);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(195, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Body: ";
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(350, 303);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(288, 178);
            this.textBoxBody.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Attachment: ";
            // 
            // textBoxAttachment
            // 
            this.textBoxAttachment.Location = new System.Drawing.Point(350, 510);
            this.textBoxAttachment.Name = "textBoxAttachment";
            this.textBoxAttachment.Size = new System.Drawing.Size(288, 22);
            this.textBoxAttachment.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(348, 545);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(585, 607);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(102, 48);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // comboBoxSMTP
            // 
            this.comboBoxSMTP.FormattingEnabled = true;
            this.comboBoxSMTP.Items.AddRange(new object[] {
            "smtp.gmail.com",
            "smtp.outlook.com",
            "smtp.yahoo.com"});
            this.comboBoxSMTP.Location = new System.Drawing.Point(350, 178);
            this.comboBoxSMTP.Name = "comboBoxSMTP";
            this.comboBoxSMTP.Size = new System.Drawing.Size(288, 24);
            this.comboBoxSMTP.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(66, 595);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 48);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SendEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 690);
            this.Controls.Add(this.comboBoxSMTP);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.textBoxAttachment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Email Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAttachment;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox comboBoxSMTP;
        private System.Windows.Forms.Button btnReset;
    }
}

