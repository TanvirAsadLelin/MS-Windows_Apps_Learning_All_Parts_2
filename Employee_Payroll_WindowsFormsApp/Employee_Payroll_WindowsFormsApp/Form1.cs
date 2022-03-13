using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Payroll_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                textBoxId.Focus();
                errorProviderId.SetError(this.textBoxId, "Please insert id!");
            }
            else
            {
                errorProviderId.Clear();
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                textBoxName.Focus();
                errorProviderName.SetError(this.textBoxName, "Please insert Name!");
            }
            else
            {
                errorProviderName.Clear();
            }
        }

        private void textBoxDesignation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDesignation.Text))
            {
                textBoxDesignation.Focus();
                errorProviderDesignation.SetError(this.textBoxDesignation, "Please insert Designation!");
            }
            else
            {
                errorProviderDesignation.Clear();
            }
        }

        private void textBoxBasicPay_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBasicPay.Text))
            {
                textBoxBasicPay.Focus();
                errorProviderBasicPay.SetError(this.textBoxBasicPay, "Please insert basic pay!");
            }
            else
            {
                errorProviderBasicPay.Clear();
            }
        }

        private void textBoxBasicPay_TextChanged(object sender, EventArgs e)
        {

            int convenceAllowance, medicalAllowance, houseRentAllowance,grossPay,incomeTax,netSalary;
            int basicPay = 0;

            if (string.IsNullOrEmpty(textBoxBasicPay.Text))
            {
                textBoxBasicPay.Focus();
                errorProviderBasicPay.SetError(this.textBoxBasicPay, "Insert basic pay !");

            }

            else
            {
                errorProviderBasicPay.Clear();

               basicPay= Convert.ToInt32(textBoxBasicPay.Text);

            }
                

            if (basicPay >= 40000)
            {
                convenceAllowance = (int)(basicPay * 0.40);

                textBoxConveyance.Text = convenceAllowance.ToString();

                medicalAllowance = (int)(basicPay * 0.30);
                textBoxMedical.Text = medicalAllowance.ToString(); 
                
                houseRentAllowance = (int)(basicPay * 0.20);
                textBoxHouseRent.Text = houseRentAllowance.ToString();

                grossPay = basicPay+convenceAllowance+medicalAllowance+houseRentAllowance;

                textBoxGrossPay.Text = grossPay.ToString();

                if(grossPay >= 60000)
                {
                    incomeTax = (int)(grossPay * 0.03);

                    textBoxIncomeTax.Text = incomeTax.ToString();

                    netSalary = grossPay - incomeTax;

                    textBoxNetSalary.Text = netSalary.ToString();


                }
                else if (grossPay >= 50000)
                {
                    incomeTax = (int)(grossPay * 0.02);

                    textBoxIncomeTax.Text = incomeTax.ToString();

                    netSalary = grossPay - incomeTax;

                    textBoxNetSalary.Text = netSalary.ToString();


                }



            }

            else if (basicPay >= 30000)
            {
                convenceAllowance = (int)(basicPay * 0.30);

                textBoxConveyance.Text = convenceAllowance.ToString();

                medicalAllowance = (int)(basicPay * 0.20);
                textBoxMedical.Text = medicalAllowance.ToString();

                houseRentAllowance = (int)(basicPay * 0.10);
                textBoxHouseRent.Text = houseRentAllowance.ToString();

                grossPay = basicPay + convenceAllowance + medicalAllowance + houseRentAllowance;

                textBoxGrossPay.Text = grossPay.ToString();

                if (grossPay >= 60000)
                {
                    incomeTax = (int)(grossPay * 0.02);

                    textBoxIncomeTax.Text = incomeTax.ToString();

                    netSalary = grossPay - incomeTax;

                    textBoxNetSalary.Text = netSalary.ToString();


                }
                else if (grossPay >= 50000)
                {
                    incomeTax = (int)(grossPay * 0.01);

                    textBoxIncomeTax.Text = incomeTax.ToString();

                    netSalary = grossPay - incomeTax;

                    textBoxNetSalary.Text = netSalary.ToString();


                }



            }

            else
            {
                convenceAllowance = 3000;

                textBoxConveyance.Text = convenceAllowance.ToString();

                medicalAllowance = 2000;
                textBoxMedical.Text = medicalAllowance.ToString();

                houseRentAllowance = 1000;
                textBoxHouseRent.Text = houseRentAllowance.ToString();

                grossPay = basicPay + convenceAllowance + medicalAllowance + houseRentAllowance;

                textBoxGrossPay.Text = grossPay.ToString();




                   textBoxIncomeTax.Text = "No need income tax";

                    netSalary = grossPay;

                    textBoxNetSalary.Text = netSalary.ToString();



            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxDesignation.Clear();
            textBoxBasicPay.Clear();
            textBoxConveyance.Clear();
            textBoxMedical.Clear();
            textBoxHouseRent.Clear();
            textBoxGrossPay.Clear();
            textBoxIncomeTax.Clear();
            textBoxNetSalary.Clear();

        }
    }
}
