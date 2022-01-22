using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class DepositeInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!(IsPostBack))
        {
            DropDownList1.Items.Add("Saving");
            DropDownList1.Items.Add("Current");

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DepositeInfoModel d = new DepositeInfoModel();
        d.Accountno = int.Parse(TextBox1.Text);
        d.Accountype = DropDownList1.SelectedItem.Text;
        d.Password = TextBox2.Text;
        bool st = DepositeInfoHandler.checAccountNoAndPassword(d);
        if (st)
        {

            DataTable dt = DepositeInfoHandler.showRecord(d);
            if(dt!=null)
            {    
                MyController.grid(GridView1, dt);
            }

            else

            {
                   Label4.Text="No One Recrod Found IN Data Base";

            }



        }
        else
        {
            Label4.Text = "Not Match";

        }
    }
}