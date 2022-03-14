using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace Employee_Payroll_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            BindGridview();
            Total_netSalary();
            Total_employee();
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




                   textBoxIncomeTax.Text = 0.ToString();

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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "insert into EmployeePayroll_Tbl values (@id,@name,@designation,@basicPay,@conveyance,@medical,@houseRent,@grossPay,@incomeTax,@netSalary)";
            SqlCommand cmd =  new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id",textBoxId.Text);
            cmd.Parameters.AddWithValue("@name",textBoxName.Text);
            cmd.Parameters.AddWithValue("@designation", textBoxDesignation.Text);
            cmd.Parameters.AddWithValue("@basicPay", textBoxBasicPay.Text);
            cmd.Parameters.AddWithValue("@conveyance", textBoxConveyance.Text);
            cmd.Parameters.AddWithValue("@medical", textBoxMedical.Text);
            cmd.Parameters.AddWithValue("@houseRent", textBoxHouseRent.Text);
            cmd.Parameters.AddWithValue("@grossPay", textBoxGrossPay.Text);
            cmd.Parameters.AddWithValue("@incomeTax", textBoxIncomeTax.Text);
            cmd.Parameters.AddWithValue("@netSalary", textBoxNetSalary.Text);

            con.Open();
         

           int value =  cmd.ExecuteNonQuery();

            if (value > 0)
            {
                MessageBox.Show("Inserted Successfuly!","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindGridview();
                Total_netSalary();
                Total_employee();
            }
            else
            {
                MessageBox.Show("Inserted Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            BindGridview();

        }

        void BindGridview()
        {
            SqlConnection con = new SqlConnection(cs);

            string querySelect = "select * from EmployeePayroll_Tbl";
            // SqlCommand cmd = new SqlCommand(querySelect, con);

            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridViewEmployeePayroll.DataSource = dataTable;
        }

        void Total_netSalary()
        {
            SqlConnection con = new SqlConnection(cs);

            string queryAggregetFunction = "select sum(NetSalary) from EmployeePayroll_Tbl";

            SqlCommand cmd  =  new SqlCommand(queryAggregetFunction, con);

            con.Open();
            int totalNetSaalry =Convert.ToInt32 ( cmd.ExecuteScalar());

            textBoxSalaryPaid.Text = totalNetSaalry.ToString();

            con.Close();


        }

        void Total_employee()
        {
            SqlConnection con = new SqlConnection(cs);

            string queryAggregetFunction = "select count(Id) from EmployeePayroll_Tbl";

            SqlCommand cmd = new SqlCommand(queryAggregetFunction, con);

            con.Open();
            int totalEmployee = Convert.ToInt32(cmd.ExecuteScalar());

            textBoxTotalEmp.Text = totalEmployee.ToString();

            con.Close();


        }
    }
}
