using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class city : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            String said = Session["said"].ToString();
            String logintime = Session["logintime"].ToString();
        }
        catch(Exception n)
        {
            Response.Redirect("AdminLogin.aspx");
        }
    {if(!IsPostBack)
        webcontrol.dropdown(DropDownList1,statehandler.GetStates(),"StateName","StateId");
    }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        citymodules c = new citymodules();
        c.Stateid = int.Parse(DropDownList1.SelectedValue);
        c.Cityid = TextBox1.Text;
        c.Cityname = TextBox2.Text;
        bool st = cityhandler.AddNewRecord(c);
        if (st)
        {
            Label8.Text = "Record submitted...";
        }
        else
        {
            Label8.Text = "Record not submitted..";
        }
    }
}