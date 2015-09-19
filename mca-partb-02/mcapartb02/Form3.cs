/* 
 * FileName: Form3.cs
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
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hemasagar\documents\visual studio 2010\Projects\mca-partb-02\mcapartb02\Bloodbank.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        
        public Form3()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            detailsPanel.Hide();
            bloodGroupRadio.CheckedChanged += new EventHandler(selectRadioButtons_CheckedChanged);
            genderRadio.CheckedChanged += new EventHandler(selectRadioButtons_CheckedChanged);
            customResultRadio.CheckedChanged += new EventHandler(selectRadioButtons_CheckedChanged);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmd.Connection = conn;
        }

        private void selectRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = sender as RadioButton;
            detailsListBox.Items.Clear();
            conn.Open();
            try
            {
                detailsPanel.Show();
                if (bloodGroupRadio.Checked)
                {       
                    cmd.CommandText = "select BloodGroup from tbl_Bloodgroup";
                    showInListBoxValues(cmd);
                }
                else if (genderRadio.Checked || customResultRadio.Checked)
                {
                    cmd.CommandText = "select DISTINCT Gender from tbl_Donor";
                    showInListBoxValues(cmd);
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

        private void showInListBoxValues(SqlCommand cmd)
        {
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    detailsListBox.Items.Add(dr[0].ToString());
                }
            }
        }

        private void detailsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            string text = detailsListBox.GetItemText(detailsListBox.SelectedItem);
            try
            {
                if (bloodGroupRadio.Checked && text != "")
                {
                    cmd.CommandText = "select c.DonorID,c.DonorName,c.Address,c.ContactNo,c.DOB,c.Gender,c.Weight,c.BloodID from tbl_donor c inner join tbl_BloodGroup o on c.BloodID = o.BloodID and o.BloodGroup in ('" + text + "')";
                }
                else if (genderRadio.Checked && text != "")
                {
                    cmd.CommandText = "select * from tbl_Donor where Gender='" + text + "'";
                }
                else if (customResultRadio.Checked && text != "")
                {
                    int weight = 45;
                    cmd.CommandText = "select * from tbl_Donor where Gender='" + text + "' AND Weight > '"+weight+"' AND FLOOR(DATEDIFF(day, DOB, GETDATE()) / 365.25) > 18";
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
