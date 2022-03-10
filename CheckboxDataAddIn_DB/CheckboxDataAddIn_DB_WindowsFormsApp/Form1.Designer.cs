namespace CheckboxDataAddIn_DB_WindowsFormsApp
{
    partial class Form1
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxReading = new System.Windows.Forms.CheckBox();
            this.checkBoxWriting = new System.Windows.Forms.CheckBox();
            this.checkBoxWalking = new System.Windows.Forms.CheckBox();
            this.checkBoxSleeping = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(277, 107);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(247, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hobbies";
            // 
            // checkBoxReading
            // 
            this.checkBoxReading.AutoSize = true;
            this.checkBoxReading.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReading.Location = new System.Drawing.Point(307, 183);
            this.checkBoxReading.Name = "checkBoxReading";
            this.checkBoxReading.Size = new System.Drawing.Size(97, 26);
            this.checkBoxReading.TabIndex = 2;
            this.checkBoxReading.Text = "Reading";
            this.checkBoxReading.UseVisualStyleBackColor = true;
            // 
            // checkBoxWriting
            // 
            this.checkBoxWriting.AutoSize = true;
            this.checkBoxWriting.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWriting.Location = new System.Drawing.Point(437, 183);
            this.checkBoxWriting.Name = "checkBoxWriting";
            this.checkBoxWriting.Size = new System.Drawing.Size(91, 26);
            this.checkBoxWriting.TabIndex = 2;
            this.checkBoxWriting.Text = "Writing";
            this.checkBoxWriting.UseVisualStyleBackColor = true;
            // 
            // checkBoxWalking
            // 
            this.checkBoxWalking.AutoSize = true;
            this.checkBoxWalking.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWalking.Location = new System.Drawing.Point(307, 238);
            this.checkBoxWalking.Name = "checkBoxWalking";
            this.checkBoxWalking.Size = new System.Drawing.Size(96, 26);
            this.checkBoxWalking.TabIndex = 2;
            this.checkBoxWalking.Text = "Walking";
            this.checkBoxWalking.UseVisualStyleBackColor = true;
            // 
            // checkBoxSleeping
            // 
            this.checkBoxSleeping.AutoSize = true;
            this.checkBoxSleeping.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSleeping.Location = new System.Drawing.Point(437, 238);
            this.checkBoxSleeping.Name = "checkBoxSleeping";
            this.checkBoxSleeping.Size = new System.Drawing.Size(101, 26);
            this.checkBoxSleeping.TabIndex = 2;
            this.checkBoxSleeping.Text = "Sleeping";
            this.checkBoxSleeping.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(369, 312);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 46);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.checkBoxSleeping);
            this.Controls.Add(this.checkBoxWalking);
            this.Controls.Add(this.checkBoxWriting);
            this.Controls.Add(this.checkBoxReading);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding Checkbox value into DB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxReading;
        private System.Windows.Forms.CheckBox checkBoxWriting;
        private System.Windows.Forms.CheckBox checkBoxWalking;
        private System.Windows.Forms.CheckBox checkBoxSleeping;
        private System.Windows.Forms.Button btnSubmit;
    }
}

