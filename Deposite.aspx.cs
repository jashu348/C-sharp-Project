using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Deposite : System.Web.UI.Page
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

            TextBox4.Text = DateTime.Now.ToShortDateString();
            DropDownList1.Items.Add("Saving");
            DropDownList1.Items.Add("Current");

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String b = DepositeHandler.FindBalance(int.Parse(TextBox1.Text));
        int totalbalance = int.Parse(TextBox3.Text) + int.Parse(b); 
        DepositeModel m = new DepositeModel();
        m.Accountno = int.Parse(TextBox1.Text);
        m.Depositername = TextBox2.Text;
        m.Account_type = DropDownList1.SelectedItem.Text;
        m.Balance = totalbalance;
        m.Date = TextBox4.Text;
        bool check = DepositeHandler.CheckAccountno(int.Parse(TextBox1.Text), DropDownList1.SelectedItem.Text);
        if (check)
        {
            bool st = DepositeHandler.UpdateBalance(int.Parse(TextBox1.Text), totalbalance);
            if (st)
            {
                m.Balance = int.Parse(TextBox3.Text);

                bool a = DepositeHandler.AddRecord(m);
                if (a)
                {
                    Label6.Text = "Record Submitted. and Total Amount Is:" + totalbalance;
                }
                else
                {
                    Label6.Text = "Record Not Submitted..";
                }
            }
            else
            {
                Label6.Text = "Account Not Match....";
            }
        }
        else
        {
            Label6.Text = "Account Not Match....";
        }
    }
}