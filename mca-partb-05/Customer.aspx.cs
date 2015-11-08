/* 
 * FileName: Customer.aspx.cs
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

public partial class Customer : System.Web.UI.Page
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
            Response.Write(DropDownListBank.SelectedValue);
            DropDownListBank.DataBind();
            DropDownListBank.Items.Insert(0, new ListItem("Select a Bank", ""));  //Default heading for Dropdownlist.
        }
        conn.Close();
        
    }
    protected void DropDownListBank_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString);
        conn.Open();
        string selectQuery = "select br.BranchID,br.BranchName from tbl_Branch br where br.BankID='" + DropDownListBank.SelectedValue + "'";
        SqlCommand com1 = new SqlCommand(selectQuery, conn);
        DropDownListBranch.DataSource = com1.ExecuteReader();
        DropDownListBranch.DataTextField = "BranchName";
        DropDownListBranch.DataValueField = "BranchID";
        DropDownListBranch.DataBind();
        conn.Close();   
    }
   
    protected void btnSubmitCustomer_Click(object sender, EventArgs e)
    {
        try
        {          
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString);
            conn.Open();
            string insertQuery = "insert into tbl_Account (AccountNo,BankID,BranchID,CustomerName,Address,ContactNo,Balance) values (@AccountNo,@BankID,@BranchID,@CustomerName,@Address,@ContactNo,@Balance)";
            SqlCommand com = new SqlCommand(insertQuery, conn);
            com.Parameters.AddWithValue("@AccountNo", Convert.ToInt32(txtBoxAccno.Text));
            com.Parameters.AddWithValue("@BankID", DropDownListBank.SelectedValue);
            com.Parameters.AddWithValue("@BranchID", DropDownListBranch.SelectedValue);
            com.Parameters.AddWithValue("@CustomerName", txtBoxCustomerName.Text);
            com.Parameters.AddWithValue("@Address", txtBoxAddress.Text);
            com.Parameters.AddWithValue("@ContactNo", Convert.ToInt32(txtBoxContact.Text));
            com.Parameters.AddWithValue("@Balance", Convert.ToDecimal(txtBoxBalance.Text));
            com.ExecuteNonQuery();

            Label3.Text = "Customer added successfully";
            conn.Close();
        }
        catch (Exception ex)
        {
            //Response.Write("Error:" + ex.ToString());
            Label3.Text = "Error has occured while inserting";
        }
    }
}