namespace Employee_Payroll_WindowsFormsApp
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBasicPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxConveyance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMedical = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHouseRent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxGrossPay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxIncomeTax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNetSalary = new System.Windows.Forms.TextBox();
            this.errorProviderId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDesignation = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBasicPay = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDesignation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBasicPay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Payroll";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID: ";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(370, 109);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(231, 22);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.Leave += new System.EventHandler(this.textBoxId_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name: ";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(370, 158);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(231, 22);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Designation: ";
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(370, 212);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(231, 22);
            this.textBoxDesignation.TabIndex = 2;
            this.textBoxDesignation.Leave += new System.EventHandler(this.textBoxDesignation_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Basic Pay: ";
            // 
            // textBoxBasicPay
            // 
            this.textBoxBasicPay.Location = new System.Drawing.Point(370, 271);
            this.textBoxBasicPay.Name = "textBoxBasicPay";
            this.textBoxBasicPay.Size = new System.Drawing.Size(231, 22);
            this.textBoxBasicPay.TabIndex = 3;
            this.textBoxBasicPay.TextChanged += new System.EventHandler(this.textBoxBasicPay_TextChanged);
            this.textBoxBasicPay.Leave += new System.EventHandler(this.textBoxBasicPay_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Conveyance: ";
            // 
            // textBoxConveyance
            // 
            this.textBoxConveyance.Location = new System.Drawing.Point(370, 333);
            this.textBoxConveyance.Name = "textBoxConveyance";
            this.textBoxConveyance.ReadOnly = true;
            this.textBoxConveyance.Size = new System.Drawing.Size(231, 22);
            this.textBoxConveyance.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Medical: ";
            // 
            // textBoxMedical
            // 
            this.textBoxMedical.Location = new System.Drawing.Point(370, 389);
            this.textBoxMedical.Name = "textBoxMedical";
            this.textBoxMedical.ReadOnly = true;
            this.textBoxMedical.Size = new System.Drawing.Size(231, 22);
            this.textBoxMedical.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(159, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "House rent: ";
            // 
            // textBoxHouseRent
            // 
            this.textBoxHouseRent.Location = new System.Drawing.Point(370, 449);
            this.textBoxHouseRent.Name = "textBoxHouseRent";
            this.textBoxHouseRent.ReadOnly = true;
            this.textBoxHouseRent.Size = new System.Drawing.Size(231, 22);
            this.textBoxHouseRent.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(159, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Gross pay: ";
            // 
            // textBoxGrossPay
            // 
            this.textBoxGrossPay.Location = new System.Drawing.Point(370, 514);
            this.textBoxGrossPay.Name = "textBoxGrossPay";
            this.textBoxGrossPay.ReadOnly = true;
            this.textBoxGrossPay.Size = new System.Drawing.Size(231, 22);
            this.textBoxGrossPay.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(159, 566);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Income tax: ";
            // 
            // textBoxIncomeTax
            // 
            this.textBoxIncomeTax.Location = new System.Drawing.Point(370, 566);
            this.textBoxIncomeTax.Name = "textBoxIncomeTax";
            this.textBoxIncomeTax.ReadOnly = true;
            this.textBoxIncomeTax.Size = new System.Drawing.Size(231, 22);
            this.textBoxIncomeTax.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(159, 613);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Net Salary: ";
            // 
            // textBoxNetSalary
            // 
            this.textBoxNetSalary.Location = new System.Drawing.Point(370, 616);
            this.textBoxNetSalary.Name = "textBoxNetSalary";
            this.textBoxNetSalary.ReadOnly = true;
            this.textBoxNetSalary.Size = new System.Drawing.Size(231, 22);
            this.textBoxNetSalary.TabIndex = 9;
            // 
            // errorProviderId
            // 
            this.errorProviderId.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderDesignation
            // 
            this.errorProviderDesignation.ContainerControl = this;
            // 
            // errorProviderBasicPay
            // 
            this.errorProviderBasicPay.ContainerControl = this;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(348, 680);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 61);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.textBoxNetSalary);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxIncomeTax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxGrossPay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxHouseRent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxMedical);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxConveyance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxBasicPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Payroll";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDesignation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBasicPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBasicPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxConveyance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMedical;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxHouseRent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxGrossPay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxIncomeTax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNetSalary;
        private System.Windows.Forms.ErrorProvider errorProviderId;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderDesignation;
        private System.Windows.Forms.ErrorProvider errorProviderBasicPay;
        private System.Windows.Forms.Button btnReset;
    }
}

