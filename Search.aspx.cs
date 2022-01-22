using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Search : System.Web.UI.Page
{
    public String provider = "server=localhost;initial catalog=crime;trusted_connection=true";
    SqlConnection cn;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(provider);
        cn.Open();
     /*   try
        {
            String said = Session["said"].ToString();
            String logintime = Session["logintime"].ToString();
        }
        catch
        {
            Response.Redirect("AdminLogin.aspx");
        }*/
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            String q = String.Format("select c.CriminalId,c.Age,c.FirNo, c.CriminalName,c.AliasName,c.Gender,c.Address,c.State,c.City,c.Description,c.CrimeType,c.Photograph from Criminal c where c.CriminalName like'%{0}%' or c.Description like '%{0}%' or c.CrimeType like '%{0}%' or c.AliasName like '%{0}%'or c.Age like'%{0}%'", TextBox1.Text);
            SqlCommand cmd = new SqlCommand(q, cn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            webcontrol.grid(GridView1, dt);
        }
        catch (Exception err)
        {
            HttpContext.Current.Response.Write(err);
        }


    }
}