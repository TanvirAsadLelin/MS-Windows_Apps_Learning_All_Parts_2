namespace Binding_OneCombobox_ToAnother_Combobox_WindowsFormsApp
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
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUpozila = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select District";
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Location = new System.Drawing.Point(211, 171);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(223, 24);
            this.comboBoxDistrict.TabIndex = 0;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistrict_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Upozila";
            // 
            // comboBoxUpozila
            // 
            this.comboBoxUpozila.FormattingEnabled = true;
            this.comboBoxUpozila.Location = new System.Drawing.Point(211, 286);
            this.comboBoxUpozila.Name = "comboBoxUpozila";
            this.comboBoxUpozila.Size = new System.Drawing.Size(223, 24);
            this.comboBoxUpozila.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(590, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "One Combobox data depends on previous combobox Or Data filtering";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxUpozila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDistrict);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "One ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUpozila;
        private System.Windows.Forms.Label label3;
    }
}

