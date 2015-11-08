/* 
 * FileName: ReportAccno.aspx.cs
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
using System.Data;

public partial class ReportAccno : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Visible = false;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString);
        conn.Open();

        if (!Page.IsPostBack)                                               //Used to avoid resetting combobox selected value by wrapping inside IsPostBack.
        {
            string selectQuery = "select BankID,BankName from tbl_Bank";
            SqlCommand com = new SqlCommand(selectQuery, conn);
            DropDownListBank.DataSource = com.ExecuteReader();
            DropDownListBank.DataTextField = "BankName";
            DropDownListBank.DataValueField = "BankID";
            DropDownListBank.DataBind();
            DropDownListBank.Items.Insert(0, new ListItem("Select a Bank", ""));
        }
        conn.Close();
    }
    protected void DropDownListBank_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString);
        conn.Open();
        string selectQuery = "select br.BranchID,br.BranchName from tbl_Branch br where br.BankID='" + DropDownListBank.SelectedValue + "'";
        SqlCommand com = new SqlCommand(selectQuery, conn);
        DropDownListBranch.DataSource = com.ExecuteReader();
        DropDownListBranch.DataTextField = "BranchName";
        DropDownListBranch.DataValueField = "BranchID";
        DropDownListBranch.DataBind();
        DropDownListBranch.Items.Insert(0, new ListItem("Select a Branch", ""));
        conn.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString);
        conn.Open();
        string checkAccnoQuery = "select count(*) from tbl_Account where BankID='" + DropDownListBank.SelectedValue + "' AND BranchID='" + DropDownListBranch.SelectedValue + "' AND AccountNo='"+Convert.ToInt32(txtBoxAccno.Text)+"'";
        SqlCommand com = new SqlCommand(checkAccnoQuery, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        if (temp == 0)
        {
            Label2.Visible = true;
            Label2.Text= "Sorry that accountno does not exist with our bank branch";
        }
        else
        {
            string getBalanceQuery = "select Balance from tbl_Account where AccountNo='" + Convert.ToInt32(txtBoxAccno.Text) + "'";
            SqlCommand com1 = new SqlCommand(getBalanceQuery, conn);
            string bal= com1.ExecuteScalar().ToString();
            Label2.Visible = true;
            Label2.Text = bal;
        }
        conn.Close();
    }
}