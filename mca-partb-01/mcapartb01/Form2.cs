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
            courseAddPanel.Hide();
            studentAddPanel.Hide();
        }

        private void addCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addCombo.Text == "New Course")
            {
                studentAddPanel.Hide();
                courseAddPanel.Show();
            }
            else if (addCombo.Text == "New Student")
            {
                courseAddPanel.Hide();
                studentAddPanel.Show();
            }
            else
            {
                MessageBox.Show("An Error Occurred Please reselect");
            }
        }

        private void studentPanelCancelBtn_Click(object sender, EventArgs e)
        {
            studentAddPanel.Hide();
        }

        private void coursePanelSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CourseID1.Text == "" || CourseName.Text == "")
                {
                    MessageBox.Show("Course Id or CourseName is empty please fill up", "Error");
                }
                else
                {
                    conn.Open();
                    cmd.CommandText = "insert into tbl_Course(CourseId,CourseName) values('" + CourseID1.Text + "','" + CourseName.Text + "')";
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
                CourseID1.Text = "";
                CourseName.Text = "";
                conn.Close();
            }
         }

        private void coursePanelCancelBtn_Click(object sender, EventArgs e)
        {
            courseAddPanel.Hide();
        }

        private void studentPanelSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (USN.Text == "" || StudName.Text == "" || Address.Text == "" || CourseID2.Text == "" || YrOfAdmsn.Text == "")
                {
                    MessageBox.Show("please fill up all the fields", "Error");
                }
                else
                {
                    conn.Open();
                    cmd.CommandText = "insert into tbl_Student(USN,StudName,Address,CourseID,YrOfAdmsn) values ('" + USN.Text + "','" + StudName.Text + "','" + Address.Text + "','" + CourseID2.Text + "','" + YrOfAdmsn.Text + "')";
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
                USN.Text = "";
                StudName.Text = "";
                Address.Text = "";
                CourseID2.Text = "";
                YrOfAdmsn.Text = "";
                conn.Close();
            }
         }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmd.Connection = conn;
        }
    }
}
