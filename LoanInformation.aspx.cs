using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoanInformation : System.Web.UI.Page
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
            TextBox6.Text = DateTime.Now.ToShortDateString();
            DropDownList1.Items.Add("Saving");
            DropDownList1.Items.Add("Current");
            MyController.addLoanOption(DropDownList2);
            MyController.addLoanIntreste(DropDownList3, DropDownList2.SelectedItem.Text);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        LoanInformationModel l = new LoanInformationModel();
        l.Accountno = int.Parse(TextBox1.Text);
        l.Branchcode = TextBox2.Text;
        l.Name = TextBox3.Text;
        l.Account_type = DropDownList1.SelectedItem.Text;
        l.Loantype = DropDownList2.SelectedItem.Text;
        l.No_installment = TextBox4.Text;
        l.Amount = int.Parse(TextBox5.Text);
        l.Date = TextBox6.Text;
        l.Loanintreste = DropDownList3.SelectedItem.Text;
        bool check = LoanInformationHandler.CheckAccountno(l);

        if (check)
        {
            bool st = LoanInformationHandler.AddRecord(l);
            if (st)
            {
                Label12.Text = "Record Submitted.....";
            }
            else
            {
                Label12.Text = "Record Not Submitted....";
            }

        }
        else
        {

            Label12.Text = "Accountno or Account_Type Not Match....";

        }







    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        MyController.addLoanIntreste(DropDownList3, DropDownList2.SelectedItem.Text);
    }
}