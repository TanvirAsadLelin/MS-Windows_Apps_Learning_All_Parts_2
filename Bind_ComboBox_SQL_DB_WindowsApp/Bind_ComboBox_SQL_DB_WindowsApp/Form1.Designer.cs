﻿namespace Bind_ComboBox_SQL_DB_WindowsApp
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
            this.comboBoxEmployeeName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxEmployeeName
            // 
            this.comboBoxEmployeeName.FormattingEnabled = true;
            this.comboBoxEmployeeName.Location = new System.Drawing.Point(85, 174);
            this.comboBoxEmployeeName.Name = "comboBoxEmployeeName";
            this.comboBoxEmployeeName.Size = new System.Drawing.Size(270, 24);
            this.comboBoxEmployeeName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEmployeeName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEmployeeName;
        private System.Windows.Forms.Label label1;
    }
}

