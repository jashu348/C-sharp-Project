using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tom;

public partial class ForgetPassword : System.Web.UI.Page
{
    int otp;
    String mono;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(IsPostBack))
        {
            DropDownList1.Items.Add("Select Account_Type");
            DropDownList1.Items.Add("Saving");
            DropDownList1.Items.Add("Current");
            
            
  
            
               

        }
    }
   
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            ForgetPasswordModel f = new ForgetPasswordModel();
            f.Accountno = int.Parse(TextBox1.Text);
            f.Accountype = DropDownList1.SelectedItem.Text;
            mono = ForgetPasswordHandler.FindMobileNo(f);

            if (long.Parse(mono) > 0)
            {

                Random r = new Random();
                int a = 9999;
                otp = r.Next(a);


                General p = new General();
                String st = p.SendSms("COM7," + mono + ",wow your's OTP:" + otp);


            }

            else
            {
                Label4.Text = "Not Match...";

            }
            


            MyController.get(mono, otp);

        }
        catch (Exception err)
        {

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {


        int otp = MyController.putotp();
        String mon = MyController.putmob();
        if (otp == int.Parse(TextBox2.Text))
        {
            Response.Redirect("FinalUpdate.aspx");
        }
        else
        {
            TextBox1.Text = " ";
            TextBox2.Text = "  ";

            Label4.Text = "Re-Enter UserName";
        }
       

            



    }
   
   
}