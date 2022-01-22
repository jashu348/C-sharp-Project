<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Widrowl.aspx.cs" Inherits="Widrowl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 224px;
        }
        .auto-style2 {
            width: 224px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
     <link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container" style="background-color:black !important">
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="AccountNo" CssClass ="form-control" BackColor="Black"   ForeColor="YellowGreen" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control" BackColor ="Teal" ForeColor ="Yellow"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Name" CssClass ="form-control" BackColor="Black"   ForeColor="YellowGreen" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass ="form-control" BackColor ="Teal" ForeColor ="Yellow" Font-Bold ="true"  ></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Account_Type" CssClass ="form-control" BackColor="Black"   ForeColor="YellowGreen"  ></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass ="form-control" BackColor ="Teal" ForeColor ="Yellow" Font-Bold="true"  >
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="WidrowAmount" CssClass ="form-control" BackColor="Black"   ForeColor="YellowGreen" ></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server" CssClass ="form-control" BackColor ="Teal" ForeColor ="Yellow"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" Text="Date" CssClass ="form-control" BackColor="Black"   ForeColor="YellowGreen" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass ="form-control" BackColor ="Teal" ForeColor ="Yellow"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" CssClass ="btn" BackColor ="Tomato" BorderColor ="Yellow" />
                </td>
                <td>
                    <asp:Label ID="Label6" runat="server" ></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
