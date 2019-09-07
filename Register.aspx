<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Bank.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Banks %>" SelectCommand="SELECT * FROM [User]"></asp:SqlDataSource>
    <div style="">
    <form id="form1" runat="server">
            <table>
                <tr>
                    <td><asp:Label ID="lname" runat="server" Text="Name"></asp:Label></td>
                    <td><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lphone" runat="server" Text="Phone No."></asp:Label></td>
                    <td><asp:TextBox ID="phone" runat="server"></asp:TextBox></td>    
                </tr>
                <tr>
                    <td><asp:Label ID="lemail" runat="server" Text="Email"></asp:Label></td>
                    <td><asp:TextBox ID="email" runat="server"></asp:TextBox></td>    
                </tr>
                <tr>
                    <td><asp:Label ID="lpwd" runat="server" Text="Password"></asp:Label></td>
                    <td><asp:TextBox ID="password" runat="server"></asp:TextBox></td>    
                </tr>
                <tr>
                    <td><asp:Button id="SignUp" runat="server" Text="Register" OnClick="register"/></td>
                </tr>
                <tr>
                    <td><asp:Label ID="rejected" runat="server" Visible="false" Text="Phone No already registered." ForeColor="red"></asp:Label></td>
                </tr>
            </table>
        </form>
    </div>
</body>
</html>
