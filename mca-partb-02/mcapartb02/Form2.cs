/* 
 * FileName: Form2.cs
 * Author:  Hemasagar
 * Course:  MCA
 * College: Bangalore Institute Of Technology
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

namespace mca_partb_02
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hemasagar\documents\visual studio 2010\Projects\mca-partb-02\mcapartb02\Bloodbank.mdf;Integrated Security=True;User Instance=True");
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

        private void bloodSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bloodID1Txt.Text == "" || bloodGroupTxt.Text == "")
                {
                    MessageBox.Show("Empty text boxes are empty please fill up");
                }
                else
                {
                    conn.Open();
                    cmd.CommandText = "insert into tbl_BloodGroup(BloodID,BloodGroup) values('" + bloodID1Txt.Text + "','" + bloodGroupTxt.Text + "')";
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

        private void donorSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (donorIDTxt.Text == "" || donorNameTxt.Text == "" || addressTxt.Text == "" || contactTxt.Text == "" || dobPicker.Value.ToString() == "" || (!maleRadio.Checked && !femaleRadio.Checked) || weightTxt.Text == "" || bloodID2Txt.Text == "")
                {
                    MessageBox.Show("Some of the fields are left empty please correct it");
                }
                else
                {
                    conn.Open();
                    string gender;
                    if (maleRadio.Checked)
                        gender = maleRadio.Text;
                    else
                        gender = femaleRadio.Text;

                    cmd.CommandText = "insert into tbl_Donor(DonorID,DonorName,Address,ContactNo,DOB,Gender,Weight,BloodID) values ('" + donorIDTxt.Text + "','" + donorNameTxt.Text + "','" + addressTxt.Text + "','" + contactTxt.Text + "','" + dobPicker.Value.Date + "','" + gender + "','" + weightTxt.Text + "','" + bloodID2Txt.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted Successfully");
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

        private void bloodResetBtn_Click(object sender, EventArgs e)
        {
            resetTextBoxes();
        }

        private void donorResetBtn_Click(object sender, EventArgs e)
        {
            resetTextBoxes();
        }

        private void resetTextBoxes()
        {
            bloodID1Txt.Text = "";
            bloodGroupTxt.Text = "";
            donorIDTxt.Text = "";
            donorNameTxt.Text = "";
            addressTxt.Text = "";
            contactTxt.Text = "";
            dobPicker.ResetText();
            weightTxt.Text = "";
            bloodID2Txt.Text = "";
        }
    }
}
