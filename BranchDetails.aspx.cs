using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BranchDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            String said = Session["said"].ToString();
            String logintime = Session["logintime"].ToString();
        }
        catch (Exception n)
        {
            Response.Redirect("AdminLogin.aspx");
        }
        if ((!IsPostBack))
        {
            MyController.fillstate(DropDownList1);
            MyController.fillcity(DropDownList2, "Punjab");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        BranchDetailsModel m = new BranchDetailsModel();
        m.Branchname = TextBox1.Text;
        m.Branchid = int.Parse(TextBox2.Text);
        m.Ifsccode = TextBox5.Text;
        m.Micrcode = long.Parse(TextBox6.Text);
        m.State = DropDownList1.SelectedItem.Text;
        m.City = DropDownList2.SelectedItem.Text;
        m.Address = TextBox3.Text;
        m.Phno = long.Parse(TextBox4.Text);
        bool st = BranchDetailsHandler.AddRecord(m);
        if (st)
        {
            Label5.Text = "Record Submitted...";
        }
        else
        {
            Label5.Text = "Record Not Submitted....";
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MyController.fillcity(DropDownList2, DropDownList1.SelectedItem.Text);
    }
}