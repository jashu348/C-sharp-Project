using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FixedDeposite : System.Web.UI.Page
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

            TextBox5.Text = DateTime.Now.ToShortDateString();
            DropDownList1.Items.Add("Saving");
            DropDownList1.Items.Add("Current");
            MyController.AddSpanTime(DropDownList2);



        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        FixedDepositeModel f = new FixedDepositeModel();
        f.Accountno = int.Parse(TextBox1.Text);
        f.Branchcode = TextBox2.Text;
        f.Depositername = TextBox3.Text;
        f.Account_type = DropDownList1.SelectedItem.Text;
        f.Timespan = DropDownList2.SelectedItem.Text;
        f.Roi = TextBox4.Text;
        f.Startdate = TextBox5.Text;
        f.Startamount = int.Parse(TextBox6.Text);
        bool check = FixedDepositeHandler.CheckAccountno(f);

        if (check)
        {
            bool st = FixedDepositeHandler.AddRecord(f);
            if (st)
            {
                Label9.Text = "Record Submitted.....";
            }
            else
            {
                Label9.Text = "Record Not Submitted....";
            }

        }
        else
        {

            Label9.Text = "Accountno or Account_Type Not Match....";

        }

    }
}