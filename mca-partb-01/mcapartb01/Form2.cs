/* 
 * FileName: Form2.cs
 * Author:  Hemasagar
 * Email:   toktok420@gmail.com
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mcapartb01
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hemasagar\Documents\Visual Studio 2010\Projects\mca-partb-01\mcapartb01\Student.mdf;Integrated Security=True;User Instance=True");  //Adjust this line according to your MSSQL server setup.
        SqlCommand cmd = new SqlCommand();
        public Form2()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmd.Connection = conn;
        }

        private void courseTabSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CourseID1Txt.Text == "" || CourseNameTxt.Text == "")
                {
                    MessageBox.Show("Course Id or CourseName is empty please fill up", "Error");
                }
                else
                {
                    conn.Open();
                    cmd.CommandText = "insert into tbl_Course(CourseId,CourseName) values('" + CourseID1Txt.Text + "','" + CourseNameTxt.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record inserted SuccessFully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
            }
            finally
            {
                resetTextBoxes();
                conn.Close();
            }
         }

        private void studentTabSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (USNTxt.Text == "" || StudNameTxt.Text == "" || AddressTxt.Text == "" || CourseID2Txt.Text == "" || YrOfAdmsnTxt.Text == "")
                {
                    MessageBox.Show("please fill up all the fields", "Error");
                }
                else
                {
                    conn.Open();
                    cmd.CommandText = "insert into tbl_Student(USN,StudName,Address,CourseID,YrOfAdmsn) values ('" + USNTxt.Text + "','" + StudNameTxt.Text + "','" + AddressTxt.Text + "','" + CourseID2Txt.Text + "','" + YrOfAdmsnTxt.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record inserted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                resetTextBoxes();
                conn.Close();
            }
        }

        private void courseTabResetBtn_Click(object sender, EventArgs e)
        {
            resetTextBoxes();
        }

        private void studentTabCancelBtn_Click(object sender, EventArgs e)
        {
            resetTextBoxes();
        }

        private void resetTextBoxes()
        {
            CourseID1Txt.Text = "";
            CourseNameTxt.Text = "";
            USNTxt.Text = "";
            StudNameTxt.Text = "";
            AddressTxt.Text = "";
            CourseID2Txt.Text = "";
            YrOfAdmsnTxt.Text = "";
        }
    }
}
