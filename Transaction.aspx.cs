using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Transaction : System.Web.UI.Page
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
        bool st = TransactionHandler.CheckAccountno(int.Parse(TextBox1.Text), DropDownList1.SelectedItem.Text);

        if (st)
        {
            String totalbalance = TransactionHandler.FindBalance(int.Parse(TextBox1.Text));
            String recieverbal = TransactionHandler.FindBalance(int.Parse(TextBox2.Text));
            if (int.Parse(recieverbal)>0)
            {
                int trbal = int.Parse(TextBox3.Text);

                int availablebal = int.Parse(totalbalance) - trbal;
                if (availablebal >= 0)
                {
                    TransactionModel t = new TransactionModel();
                    t.Accountno = int.Parse(TextBox1.Text);
                    t.Account_type = DropDownList1.SelectedItem.Text;
                    t.Accountno1 = int.Parse(TextBox2.Text);
                    t.Amount = int.Parse(TextBox3.Text);
                    t.Date = TextBox4.Text;
                    int recevertotalbal = int.Parse(TextBox3.Text) + int.Parse(recieverbal);
                    bool addrecord = TransactionHandler.AddRecord(t);

                    if (addrecord)
                    {
                        bool update1=TransactionHandler.UpdateBalance(availablebal,int.Parse(TextBox1.Text));
                        bool  update2=TransactionHandler.UpdateBalance(recevertotalbal,int.Parse(TextBox2.Text));
                        Label6.Text = "Transaction Is Successful......";
                      
                    }
                    else
                    {
                        Label6.Text = "Transaction Is Not Successful......";
                    }

                }
                else
                {
                    Label6.Text = "Balance Is Not Sufficient......";

                }


            }
            else
            {
                Label6.Text = "Receiver AccountNo Not Match......";
            }



        }
        else
        {
            Label6.Text = "AccountNo or Account_Type Not Match.....";
        }


    }
}