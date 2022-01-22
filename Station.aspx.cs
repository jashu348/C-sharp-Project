using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Station : System.Web.UI.Page
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
            webcontrol.grid(GridView1, StationHandler.displayAllRecord());
            TextBox1.Text = StationHandler.GetStationId().ToString();
           webcontrol.dropdown(DropDownList1, statehandler.GetStates(), "StateName", "StateId");
            webcontrol.dropdown(DropDownList2, cityhandler.GetCityByState(100), "CItyName", "CityId");
            webcontrol.dropdown(DropDownList3, blockhandler.getBlockByCityId("0161"), "BlockName", "BlockId");
           
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        webcontrol.dropdown(DropDownList2, cityhandler.GetCityByState(int.Parse(DropDownList1.SelectedValue)), "CityName", "CityId");
        webcontrol.dropdown(DropDownList3, blockhandler.getBlockByCityId(DropDownList2.SelectedValue), "BlockName", "BlockId");
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        webcontrol.dropdown(DropDownList3, blockhandler.getBlockByCityId(DropDownList2.SelectedValue), "BlockName", "BlockId");

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        StationModel s = new StationModel();
        s.Station_id = int.Parse(TextBox1.Text);
        s.Station_name = TextBox2.Text;
        s.Address = TextBox3.Text;
        s.State_id =int.Parse(DropDownList1.SelectedValue);
        s.City_id =DropDownList2.SelectedValue;
        s.Block_id =int.Parse(DropDownList3.SelectedValue);
        s.Contact_no = TextBox4.Text;
        s.Email_id = TextBox5.Text;
        s.Ti_name = TextBox6.Text;
        s.Ti_mobileno = TextBox7.Text;
        s.Ti_photograph = FileUpload1.FileName;
        bool st = StationHandler.addNewRecord(s);
        if (st)
        {
           FileUpload1.SaveAs(Server.MapPath("/Tipic/" + FileUpload1.FileName));
            Label12.Text = "Record submitted....";
           TextBox1.Text = StationHandler.GetStationId().ToString();
           //  webcontrol.grid(GridView1, StationHandler.displayAllRecord());
        }
        else
        {
            Label12.Text = "Record not submitted...";
        }

    }
  
}