using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class PasswordUpdate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        PasswordUpdateModel p = new PasswordUpdateModel();
        p.Accountno = int.Parse(TextBox1.Text);
        p.Password = TextBox2.Text;
        p.Newpassword = TextBox3.Text;
        p.Confirmpassword = TextBox4.Text;
        bool st = PasswordUpdateHandler.checAccountNoAndPassword(p);
        if (st)
        {

            bool psd = PasswordUpdateHandler.UpdatePassword(p);

            if (psd)
            {
                Label6.Text = "Password  Updated...";
            }

            else
            {



            }

            
        }

        else
        {
            Label6.Text = "Not Match....";

        }
    }
}