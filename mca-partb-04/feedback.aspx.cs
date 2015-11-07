using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class feedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["feedbackconnectionstring"].ConnectionString);
            conn.Open();
            string insertQuery = "insert into userform values (@name,@address,@messages)";
            SqlCommand com = new SqlCommand(insertQuery, conn);

            com.Parameters.AddWithValue("@name", txtBoxName.Text);
            com.Parameters.AddWithValue("@address", txtBoxAddr.Text);
            com.Parameters.AddWithValue("@messages", txtBoxMsg.Text);
            com.ExecuteNonQuery();

            Response.Write("<script>alert('Feedback sent');</script>");
            Response.Redirect("acknowledgement.aspx");
            conn.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error:" + ex.ToString());
        }
    }
}