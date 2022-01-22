using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Criminal : System.Web.UI.Page
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

            CheckBoxList1.Items.Add("Act_402");
            CheckBoxList1.Items.Add("Act_407");
            CheckBoxList1.Items.Add("Act_302");
            CheckBoxList1.Items.Add("Act_502");
            CheckBoxList1.Items.Add("Act_304");
            CheckBoxList1.Items.Add("Act_408");
            webcontrol.dropdown(DropDownList1, statehandler.GetStates(), "Statename", "StateId");
            webcontrol.dropdown(DropDownList2, cityhandler.GetCityByState(100), "CityName", "CityId");

            }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        webcontrol.dropdown(DropDownList2, cityhandler.GetCityByState(int.Parse(DropDownList1.SelectedValue)), "CityName", "CityId");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        CriminalModel c = new CriminalModel();
        c.Age = int.Parse(TextBox2.Text);
        c.Firno = int.Parse(TextBox3.Text);
        c.Criminalname = TextBox4.Text;
        c.Aliasname = TextBox5.Text;
        String g = "";
        if (RadioButton1.Checked)
        {
       
            g = "Male";
        }
        else
        {
            g = "Female";
        }
        c.Gender = g;
        c.Address = TextBox6.Text;
        c.State = int.Parse(DropDownList1.SelectedValue.ToString());
        c.City = DropDownList2.Text;
        c.Description = TextBox7.Text;
        String ct = "";
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected)
                ct = ct + CheckBoxList1.Items[i].Text + ",";
        }
        c.Crimetype = ct;
        c.Photograph = FileUpload1.FileName;
        bool st = CriminalHandler.AddNewRecord(c);
        if (st)
        {
            Label15.Text = "Record submitted...";
            FileUpload1.SaveAs(Server.MapPath("/Tipic" + FileUpload1.FileName));
           
        }
        else
        {
            Label15.Text = "Fail in record submitted...";
        }

    }
}