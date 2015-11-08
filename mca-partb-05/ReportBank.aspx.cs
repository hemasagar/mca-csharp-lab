/* 
 * FileName: ReportBank.aspx.cs
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

public partial class Reports : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString);
        conn.Open();
        if (!Page.IsPostBack)                                               //Used to avoid resetting combobox selected value by wrapping inside IsPostBack
        {
            string insertQuery = "select BankID,BankName from tbl_Bank";
            SqlCommand com = new SqlCommand(insertQuery, conn);

            DropDownListBank.DataSource = com.ExecuteReader();
            DropDownListBank.DataTextField = "BankName";
            DropDownListBank.DataValueField = "BankID";
            DropDownListBank.DataBind();
            DropDownListBank.Items.Insert(0, new ListItem("Select a Bank", ""));  //Default heading for Dropdownlist.
            
        }
        conn.Close();
        
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Account", conn);
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        DataTable newTable = new DataTable();
        foreach (DataRow dr in dt.Rows)             //To manually fetch data to our Data grid view.
        {
            DataRow newRow = newTable.NewRow();
            newTable.Rows.Add (newRow);
        }
        GridView1.DataSource = newTable;
        GridView1.DataBind();
        conn.Close();
    }

    protected void DropDownListBank_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString);
        conn.Open();
        string insertQuery = "select * from tbl_Account where BankID='"+DropDownListBank.SelectedValue+"'";
        SqlCommand com = new SqlCommand(insertQuery, conn);
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(com);
        com.ExecuteNonQuery();
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        conn.Close();
    }
}