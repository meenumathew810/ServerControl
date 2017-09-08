<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalendarServerControl.aspx.cs" Inherits="ServerControlDemo.CalendarServerControl" %>

<%@ Register assembly="ClassLibrary1" namespace="ClassLibrary1" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/images.png" Height="30px" Width="29px" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
