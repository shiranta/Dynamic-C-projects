<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HelloWebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.
    org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 100px;
        }
        .auto-style2 {
            height: 144px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="font-family:Arial; height: 269px; width: 447px;">
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Get message from Service" OnClick="Button1_Click" />


                </td>
            </tr>
            
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                </td>
            </tr>

        </table>
    </form>
</body>
</html>
