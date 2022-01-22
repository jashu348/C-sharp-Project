using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Widrowl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(IsPostBack))
        {
            TextBox4.Text = DateTime.Now.ToShortDateString();
            DropDownList1.Items.Add("Saving");
            DropDownList1.Items.Add("Current");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        WidrowlModel w = new WidrowlModel();
        bool st = WidrowlDal.CheckAccountno(int.Parse(TextBox1.Text), DropDownList1.SelectedItem.Text);
        if (st)
        {
            String totalbalance = WidrowlDal.FindBalance(int.Parse(TextBox1.Text));
            int widrowlamount = int.Parse(TextBox3.Text);
            int savingbalance = int.Parse(totalbalance) - widrowlamount;
            if (savingbalance >= 0)
            {
                bool update = WidrowlHandler.UpdateBalance(int.Parse(TextBox1.Text), savingbalance);
                if (update)
                {
                    w.Accountno = int.Parse(TextBox1.Text);
                    w.Name = TextBox2.Text;
                    w.Account_type = DropDownList1.SelectedItem.Text;
                    w.Widrowlamount = int.Parse(TextBox3.Text);
                    w.Date = TextBox4.Text;
                    bool addrecord = WidrowlHandler.AddRecord(w);
                    if (addrecord)
                    {
                        Label6.Text = "Widrowl Is Successful...And Current Balance Is:" + savingbalance;
                    }
                    else
                    {
                        Label6.Text = "Widrowl Is Not Successful...";
                    }
                }
            }
            else
            {
                Label6.Text = "Not Sufficient Amount....";
            }
        }
        else
        {
            Label6.Text = "AccountNo or Account_Type Not Match...";
        }

    }
}