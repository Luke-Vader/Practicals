<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 253px;
        }
        .auto-style4 {
            height: 23px;
            width: 253px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">Employee Number</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" Width="206px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" Width="206px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Age</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox3" runat="server" Width="206px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Department</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Width="206px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="search_button" runat="server" Text="SEARCH" />
                    </td>
                    <td>
                        <asp:Button ID="add_button" runat="server" OnClick="Button1_Click" Text="ADD" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:SqlDataSource ID="Employee" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [employee_details]"></asp:SqlDataSource>
    </form>
</body>
</html>
