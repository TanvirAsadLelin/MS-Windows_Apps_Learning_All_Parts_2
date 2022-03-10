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
using System.IO;
using Insert_Update_Delete_ImageFromDB_WindowsFormsApp.Properties;

namespace Insert_Update_Delete_ImageFromDB_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
         
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select image";
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*PNG|All files (*.*)|*.*";
           if( ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImage.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string queryInsert = "insert into StudentDetails_Tbl values(@id,@name,@class,@image)";
            SqlCommand cmd =  new SqlCommand(queryInsert, con);

            cmd.Parameters.AddWithValue("@id", textBoxId.Text);
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@class", numericUpDownClass.Value);
            cmd.Parameters.AddWithValue("@image", SaveImage());

            con.Open();

            int value = cmd.ExecuteNonQuery();

            if (value > 0)
            {
                MessageBox.Show("Successfuly Inserted");
                BindGridView();
                ResetControl();

            }
            else
            {
                MessageBox.Show("Failed Insertion");
            }

            con.Close();

        }

        private byte[] SaveImage()
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBoxImage.Image.Save(memoryStream, pictureBoxImage.Image.RawFormat);
            
            return memoryStream.GetBuffer();
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string querySelect = "select * from StudentDetails_Tbl";
           // SqlCommand cmd =  new SqlCommand(querySelect, con);
           SqlDataAdapter adapter = new SqlDataAdapter(querySelect, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewStudentDetails.DataSource = dataTable;
            //For Show real image in datagridview
            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
            dataGridViewImageColumn = (DataGridViewImageColumn)dataGridViewStudentDetails.Columns[3];
            dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;



            //End

            //Adjusting all column in one data grid view

            dataGridViewStudentDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Increasing the height of Row


            dataGridViewStudentDetails.RowTemplate.Height = 100;


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        void ResetControl()
        {
            textBoxId.Clear();
            textBoxName.Clear();
            numericUpDownClass.Value = 0;
            pictureBoxImage.Image = Resources.Image_not_available;
        }

        private void dataGridViewStudentDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           textBoxId.Text = dataGridViewStudentDetails.SelectedRows[0].Cells[0].Value.ToString();   
           textBoxName.Text = dataGridViewStudentDetails.SelectedRows[0].Cells[1].Value.ToString();
            numericUpDownClass.Value = Convert.ToInt32(dataGridViewStudentDetails.SelectedRows[0].Cells[2].Value);
            pictureBoxImage.Image = GetImage ((byte[]) dataGridViewStudentDetails.SelectedRows[0].Cells[3].Value);
        }

        private Image GetImage(byte[] image)
        {
           MemoryStream memoryStream = new MemoryStream(image);

            return Image.FromStream(memoryStream);  
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string queryUpdate = "update StudentDetails_Tbl set Id=@id,Name=@name,Class=@class,Picture=@image where Id = @id";
            SqlCommand cmd = new SqlCommand(queryUpdate, con);

            cmd.Parameters.AddWithValue("@id", textBoxId.Text);
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@class", numericUpDownClass.Value);
            cmd.Parameters.AddWithValue("@image", SaveImage());

            con.Open();

            int value = cmd.ExecuteNonQuery();

            if (value > 0)
            {
                MessageBox.Show("Successfuly Updated");
                BindGridView();
                ResetControl();

            }
            else
            {
                MessageBox.Show("Failed Update");
            }

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string queryDelete = "delete from StudentDetails_Tbl where Id = @id";
            SqlCommand cmd = new SqlCommand(queryDelete, con);
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);

            con.Open();

            int value = cmd.ExecuteNonQuery();

            if (value > 0)
            {
                MessageBox.Show("Successfuly Deleted");
                BindGridView();
                ResetControl();

            }
            else
            {
                MessageBox.Show("Failed Deleted");
            }

            con.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            BindGridView();
        }
    }
}
