namespace SignOut_Functionality_WindowsFormsApp
{
    partial class SignOutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignOutForm));
            this.btnSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.Location = new System.Drawing.Point(277, 130);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(185, 136);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // SignOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignOut);
            this.Name = "SignOutForm";
            this.Text = "Signout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignOut;
    }
}

