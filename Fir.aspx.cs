using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Fir : System.Web.UI.Page
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
            TextBox2.Text = DateTime.Now.ToShortDateString();
            DropDownList1.Items.Add("Adhar Card");
            DropDownList1.Items.Add("Pan Card");
            DropDownList1.Items.Add("Voter Card");
            DropDownList1.Items.Add("Driving License");
            DropDownList1.Items.Add("Passport");
            DropDownList1.Items.Add("Rashan Card");




        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        FirModel f = new FirModel();
        f.Employeeid = int.Parse(TextBox1.Text);
        f.Date = Convert.ToDateTime(TextBox2.Text);
        f.Name = TextBox4.Text;
        f.Address = TextBox5.Text;
        f.Phone = TextBox6.Text;
        f.Identitytype = DropDownList1.Text;
        f.Identityidno = TextBox7.Text;
        f.Description = TextBox8.Text;
        f.Photograph = FileUpload1.FileName;
        bool st = FirHandler.AddNewRecord(f);
        if (st)
        {
            Label11.Text = "Record submitted..." + "FirNoIs" + FirHandler.findFirNo();
            FileUpload1.SaveAs(Server.MapPath("/Tipic/" + FileUpload1.FileName));
        }
        else
        {
            Label11.Text = "Fail in record submit...";
        }


    }
}