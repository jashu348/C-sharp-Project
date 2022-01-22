using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class block : System.Web.UI.Page
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
            TextBox1.Text =blockhandler.GetBlocId().ToString();
            webcontrol.dropdown(DropDownList1, statehandler.GetStates(), "StateName", "StateId");
            webcontrol.dropdown(DropDownList2, cityhandler.GetCityByState(100), "CityName", "CityId");
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        webcontrol.dropdown(DropDownList2, cityhandler.GetCityByState(int.Parse(DropDownList1.SelectedValue)), "CityName", "CityId");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        blockmodules b = new blockmodules();
        b.Cityid = DropDownList2.SelectedValue;
        b.Blockid = int.Parse(TextBox1.Text).ToString();
        b.Blockname = TextBox2.Text;
        bool st = blockhandler.AddNewRecord(b);
        if (st)
        {
            Label5.Text = "Record Submitted...";
            TextBox1.Text = blockhandler.GetBlocId().ToString();
            TextBox2.Text = "";
        }
        else
        {
            Label5.Text = "Record Not Submitted....";
        }
        
    }
}