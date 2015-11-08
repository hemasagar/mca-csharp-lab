/* 
 * FileName: Branch.aspx.cs
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

public partial class Branch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString);
        conn.Open();
        if (!Page.IsPostBack)                                               //Used to avoid resetting combobox selected value by wrapping inside IsPostBack
        {
            string selectQuery = "select BankID,BankName from tbl_Bank";
            SqlCommand com = new SqlCommand(selectQuery, conn);
            DropDownListBank.DataSource = com.ExecuteReader();
            DropDownListBank.DataTextField = "BankName";
            DropDownListBank.DataValueField = "BankID";
            DropDownListBank.DataBind();
            DropDownListBank.Items.Insert(0, new ListItem("Select a Bank", ""));  //Default heading for Dropdownlist.
        }
        conn.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString);
            conn.Open();
            string insertQuery = "insert into tbl_Branch (BranchID,BankID,BranchName) values (@BranchID,@BankID,@BranchName)";
            SqlCommand com = new SqlCommand(insertQuery, conn);
            com.Parameters.AddWithValue("@BranchID", txtBoxBranchid.Text);
            com.Parameters.AddWithValue("@BankID", DropDownListBank.SelectedValue);
            com.Parameters.AddWithValue("@BranchName", txtBoxBranchname.Text);
            com.ExecuteNonQuery();
            Label3.Text = "Branch data added";
            conn.Close();
        }
        catch (Exception ex)
        {
            //Response.Write("Error:" + ex.ToString());
            Label3.Text = "Error has occured while inserting";
        }
    }
}