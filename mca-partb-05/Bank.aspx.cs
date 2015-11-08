/* 
 * FileName: Bank.aspx.cs
 * Author:  Hemasagar
 * Course:  MCA
 * College: Bangalore Institute Of Technology
 * Email:   toktok420@gmail.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class bank : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString);
            conn.Open();
            string insertQuery = "insert into tbl_Bank (BankID,BankName) values (@BankID,@BankName)";
            SqlCommand com = new SqlCommand(insertQuery, conn);        
            com.Parameters.AddWithValue("@BankID",txtBoxBankid.Text);
            com.Parameters.AddWithValue("@BankName", txtBoxBankname.Text);
            com.ExecuteNonQuery();
            Label3.Text = "Bank data added";
            conn.Close();
        }
        catch (Exception ex)
        {
            //Response.Write("Error:" + ex.ToString());
            Label3.Text = "Error has occured while inserting";
        }
    }
}