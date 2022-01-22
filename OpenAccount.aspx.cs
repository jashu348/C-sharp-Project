using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OpenAccount : System.Web.UI.Page
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
        if (!(IsPostBack))
        {
            MyController.AddOption(DropDownList8);
            DropDownList5.Items.Add("1000");
            DropDownList5.Items.Add("1500");
            DropDownList5.Items.Add("2000");
            DropDownList4.Items.Add("Father-Son");
            DropDownList4.Items.Add("Father-Daughter");
            DropDownList4.Items.Add("Husband-Wife");
            DropDownList4.Items.Add("Mother-Son");
            DropDownList4.Items.Add("Brother-Sister");
            DropDownList4.Items.Add("Other");
            MyController.fillyear(DropDownList1);
            MyController.fillmonth(DropDownList2);
            MyController.filldate(DropDownList3, int.Parse(DropDownList1.SelectedValue), DropDownList2.SelectedValue);
            MyController.fillstate(DropDownList6);
            MyController.fillcity(DropDownList7, "Punjab");
            TextBox8.Text = DateTime.Now.ToShortDateString();
        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MyController.fillmonth(DropDownList3);
        MyController.filldate(DropDownList3, int.Parse(DropDownList1.SelectedValue), DropDownList2.SelectedValue);
        
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        MyController.filldate(DropDownList3, int.Parse(DropDownList1.SelectedValue), DropDownList2.SelectedValue);
    }
    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        MyController.fillcity(DropDownList7, DropDownList6.SelectedItem.Text);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OpenAccountModel m = new OpenAccountModel();
        m.Name = TextBox1.Text;
        m.Branchcode = int.Parse(TextBox2.Text);
        String d = DropDownList1.SelectedItem.Text + "-" + DropDownList2.SelectedItem.Text + "-" + DropDownList3.SelectedItem.Text;
        m.Birthdate = d;
        String g = " ";
        if (RadioButton1.Checked)
            g = "Male";
        else
            g="Female";
        m.Gender = g;
        String a = " ";
        if (RadioButton3.Checked)
            a = "Saving";
        else
            a = "Current";
        m.Account_type = a;
        m.Gauranter_acno = TextBox3.Text;
        m.Gauranter_sign = FileUpload1.FileName;
        m.Nominee_relation = DropDownList4.SelectedItem.Text;
        m.Nominee_sign = FileUpload2.FileName;
        m.Balance = int.Parse(DropDownList5.SelectedItem.Text);
        m.Emailid = TextBox4.Text;
        m.Mono = TextBox5.Text;
        m.Photo = FileUpload3.FileName;
        m.Sign = FileUpload4.FileName;
        m.Identification = DropDownList8.SelectedItem.Text;
        m.Identification_no = TextBox6.Text;
        m.State = DropDownList6.SelectedItem.Text;
        m.City = DropDownList7.SelectedItem.Text;
        m.Address = TextBox7.Text;
        m.Date = TextBox8.Text;

        bool st = OpenAccountHandler.AddRecord(m);
        if (st)
        {
            Label17.Text = "Record submitted..and AccountNo Is:" + OpenAccountHandler.FindAccountNo();
         
        }
        else
            Label17.Text = "Record Not Submitted...";


    }
}