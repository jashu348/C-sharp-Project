using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class AdminLogin : System.Web.UI.Page
{
     
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String provider = "server=localhost;initial catalog=Bank;trusted_connection=true";
        SqlConnection cn;
        cn = new SqlConnection(provider);
        cn.Open();
        String q = String.Format("select AdminId,Password from Admin where AdminId='{0}' and Password='{1}'", TextBox1.Text, TextBox2.Text);
        SqlCommand cmd = new SqlCommand(q, cn);
        SqlDataReader rec = cmd.ExecuteReader();
        if (rec.Read())
        {
            Session["said"] = TextBox1.Text;
            Session["logintime"] = DateTime.Now.ToLongDateString();
            Response.Redirect("AdminHome.aspx");
            cn.Close();
        }
        else
        {

            Label3.Text = "Invalid Id And Password....";
            cn.Close();
        }
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}