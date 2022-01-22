using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class state: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            String said = Session["said"].ToString();
            String logintime = Session["logintime"].ToString();
        }
        catch
        {
            Response.Redirect("AdminLogin.aspx");
        }
        if (!IsPostBack)
        {
            TextBox1.Text = statehandler.GetStateID().ToString();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        statemodules p = new statemodules();
        p.Stateid =int.Parse( TextBox1.Text);
        p.Statename = TextBox2.Text;
       bool a= statehandler.AddNewRecord(p);
       if (a)
       {
           Label3.Text = "Record Submitted...";
           TextBox1.Text = statehandler.GetStateID().ToString();
           TextBox2.Text = "";
       }
       else
       {
           Label3.Text = "Record not submitted..";
       }
    }
}