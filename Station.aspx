<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Station.aspx.cs" Inherits="Station" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            width: 131px;
        }
        .auto-style5 {
            width: 131px;
        }
        .auto-style6 {
            height: 23px;
            width: 294px;
        }
        .auto-style7 {
            width: 294px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Station Id"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" Text="Station Name"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label4" runat="server" Text="State"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label5" runat="server" Text="City"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label6" runat="server" Text="Block"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="DropDownList3" runat="server">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label7" runat="server" Text="ContactNo"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label8" runat="server" Text="EmailId"></asp:Label>
                </td>
                <td class="auto-style7"><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label9" runat="server" Text="Ti_Name"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label11" runat="server" Text="Ti_Mobile_No"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label10" runat="server">TiPhotograph</asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label12" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="Button2" runat="server" Text="Edit" />
                </td>
                <td class="auto-style7">
                    <asp:Button ID="Button3" runat="server" Text="Delete" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Address">
                    <ItemTemplate>
                   <b> StationId=   <%#Eval("StationId") %><br />StationName=<%#Eval("StationName") %><br />Address=<%#Eval("Address") %><br />State=<%#Eval("StateName") %><br />City=<%#Eval("CityName") %><br />Block=<%#Eval("BlockName") %><br />ContactNo=<%#Eval("ContactNo") %></b>

                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ti_Information">
                    <ItemTemplate>
                      <b>  TiName=<%#Eval("TiName") %><br />TiMobileNo=<%#Eval("TiMobileNo") %></b>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ti_Photo">
                    <ItemTemplate>
                         <img src='/Tipic/<%#Eval("TiPhotograph") %>'  width="60" height="60"/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Edit/Delete">
                <ItemTemplate>
                    <asp:Button runat="server" ID="Display" Text="Display" CommandArgument='<%#Eval("StationId") %>' />
                </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
