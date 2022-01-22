using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Employee : System.Web.UI.Page
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
            webcontrol.dropdown(DropDownList1, statehandler.GetStates(), "StateName", "StateId");
            webcontrol.dropdown(DropDownList2, cityhandler.GetCityByState(100), "CityName", "CityId");
            webcontrol.dropdown(DropDownList3, blockhandler.getBlockByCityId("0161"), "BlockName", "BlockId");
            webcontrol.dropdown(DropDownList4, EmployeeHandler.getStionByBlockId(201), "StationName", "StationId");
            webcontrol.fillyear(DropDownList5);
            webcontrol.fillmonth(DropDownList6);
            webcontrol.filldate(DropDownList7, int.Parse(DropDownList5.SelectedValue), DropDownList6.Text);
        }

    }
    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        webcontrol.fillmonth(DropDownList5);
        webcontrol.filldate(DropDownList7, int.Parse(DropDownList5.SelectedValue), DropDownList6.Text);
    }
    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        webcontrol.filldate(DropDownList7, int.Parse(DropDownList5.SelectedValue), DropDownList6.Text);
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        webcontrol.dropdown(DropDownList2, cityhandler.GetCityByState(int.Parse(DropDownList1.SelectedValue)), "CityName", "CityId");
        webcontrol.dropdown(DropDownList3, blockhandler.getBlockByCityId(DropDownList2.SelectedValue.ToString()), "BlockName", "BlockId");
        webcontrol.dropdown(DropDownList4, EmployeeHandler.getStionByBlockId(int.Parse(DropDownList3.SelectedValue)), "StationName", "StationId");
    }
    
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        webcontrol.dropdown(DropDownList3, blockhandler.getBlockByCityId(DropDownList2.SelectedValue.ToString()), "BlockName", "BlockId");
        webcontrol.dropdown(DropDownList4, EmployeeHandler.getStionByBlockId(int.Parse(DropDownList3.SelectedValue)), "StationName", "StationId");
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        webcontrol.dropdown(DropDownList4, EmployeeHandler.getStionByBlockId(int.Parse(DropDownList3.SelectedValue)), "StationName", "StationId");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        EmployeeModel E = new EmployeeModel();
        E.Stationid = int.Parse(DropDownList4.SelectedValue);
        E.Employeeid = int.Parse(TextBox4.Text);
        E.Firstname = TextBox5.Text;
        E.Lastname = TextBox6.Text;
        String dob = DropDownList7.Text + "," + DropDownList6.Text + "," + DropDownList5.Text;
        E.Dob = dob;
        String g = "";
        if (RadioButton1.Checked)
        {
            g = "Male";
        }
        else
        {
            g = "Female";
        }
        E.Gender = g;
        E.Paddress = TextBox7.Text;
        E.Caddress = TextBox8.Text;
        E.Contactno = TextBox9.Text;
        E.Emailid = TextBox10.Text;
        E.Designation = TextBox11.Text;
        E.Picture = FileUpload1.FileName;
        E.Password = TextBox12.Text;
        bool st = EmployeeHandler.addNewRecord(E);
        if (st)
        {
            Label16.Text = "Record submitted....";
            FileUpload1.SaveAs(Server.MapPath("/Tipic" + FileUpload1.FileName));
        }
        else
        {
            Label16.Text = "Record not submitted...";
        }

        


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        webcontrol.grid(GridView1, EmployeeHandler.displayAllRecord());
    }
}