/* 
 * FileName: Form3.cs
 * Author:  Hemasagar
 * email:   toktok420@gmail.com
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
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hemasagar\Documents\Visual Studio 2010\Projects\mca-partb-01\mcapartb01\Student.mdf;Integrated Security=True;User Instance=True"); //Adjust this line according to your MSSQL server setup.
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            detailsPanel.Hide();
            courseRadio.CheckedChanged += new EventHandler(selectRadioButtons_CheckChanged);     //RadioButtons tied to one common custom event handler.
            yrOfAdmsnRadio.CheckedChanged += new EventHandler(selectRadioButtons_CheckChanged);
        }
        
        //Triggers the CheckChanged event when user clicks different radiobuttons.
        private void selectRadioButtons_CheckChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = sender as RadioButton;
            detailsListBox.Items.Clear();
            try
            {
                if (courseRadio.Checked)
                {
                    detailsPanel.Show();
                    conn.Open();
                    cmd.CommandText = "select CourseName from tbl_Course";
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            detailsListBox.Items.Add(dr[0].ToString());
                        }
                    }
                }
                else if (yrOfAdmsnRadio.Checked)
                {
                    detailsPanel.Show();
                    conn.Open();
                    cmd.CommandText = "select DISTINCT YrOfAdmsn from tbl_Student";
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            detailsListBox.Items.Add(dr[0].ToString());
                        }
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmd.Connection = conn;
        }

        //Triggers the SelectedIndexChanged event when user clicks items in listbox.
        private void detailsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            string text = detailsListBox.GetItemText(detailsListBox.SelectedItem);
            try
            {
                if (courseRadio.Checked && text != "")
                {
                    cmd.CommandText = "select c.USN,c.StudName,c.Address,c.CourseID,c.YrOfAdmsn from tbl_Student c inner join tbl_Course o on c.CourseID = o.CourseID and o.CourseName in('" + text + "')";
                }
                else if (yrOfAdmsnRadio.Checked && text != "")
                {
                    cmd.CommandText = "select * from tbl_Student where YrOfAdmsn = '" + text + "' order by CourseID";
                }
                cmd.ExecuteNonQuery();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
