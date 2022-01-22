using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class AdminLogin : System.Web.UI.Page
{
  static String provider = "server=localhost;initial catalog=crime;trusted_connection=true";
    SqlConnection cn;
    protected void Page_Load(object sender, EventArgs e)
    {

        cn = new SqlConnection(provider);
        cn.Open();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String q = String.Format("select * from Admin where AdminId='{0}'and AdminPassword='{1}'", TextBox1.Text, TextBox2.Text);
        SqlCommand cmd = new SqlCommand(q, cn);
          SqlDataReader rec = cmd.ExecuteReader();
        if (rec.Read())
        { Session["said"]=TextBox1.Text;
            Session["logintime"]=DateTime.Now.ToLongDateString();
        Response.Redirect("AdminHome.aspx");
        
        }
        else
        {
            Label3.Text = "Invalid User ID & Password.....";
        }
        rec.Close();
    }
    }
    
