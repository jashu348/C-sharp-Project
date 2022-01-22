<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Deposite.aspx.cs" Inherits="Deposite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 246px;
        }
    </style>
     <link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="AccountNo" CssClass="form-control"  BackColor ="Black" ForeColor ="Yellow" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control" BorderColor="White"  BackColor ="Black"   ForeColor="Yellow"   ></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="DepositerName" CssClass="form-control"  BackColor ="Black" ForeColor ="Yellow" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass ="form-control" BorderColor ="White" BackColor ="Black" ForeColor ="Yellow" ></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Account_Type" CssClass="form-control"  BackColor ="Black" ForeColor ="Yellow" ></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass ="form-control" BorderColor ="White" BackColor ="Black" ForeColor ="Yellow" >
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="DepositAmount" CssClass="form-control"  BackColor ="Black" ForeColor ="Yellow" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass ="form-control" BorderColor ="White" BackColor ="Black" ForeColor ="Yellow" ></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" Text="Date" CssClass="form-control"  BackColor ="Black" ForeColor ="Yellow" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass ="form-control" BackColor="Black"  ForeColor="Yellow" ></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submitt" CssClass ="btn" BackColor="YellowGreen"  Font-Bold ="true" />
                </td>
                <td>
                    <asp:Label ID="Label6" runat="server"></asp:Label>
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
