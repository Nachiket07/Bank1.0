<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Bank.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <div style="position:fixed;top:42%; right:40%;">
        <form id="log" runat="server">
            
             <table>
                <tr>
                    <td><asp:label ID="lphone" runat="server" Text="Phone No"></asp:label></td>
                    <td><asp:TextBox ID="Phone" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lpwd" runat="server" Text="Password"></asp:Label></td>
                    <td><asp:TextBox ID="pwd" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button id="sign" runat="server" Text="Login" OnClick="validate"/></td>
                    <td><asp:Button id="sign1" runat="server" Text="Register" OnClick="redirectR"/></td>
                    <td><asp:Button id="admsign" runat="server" Text="Admin Login" OnClick="redirectA"/></td>
                </tr>
                    <asp:label id="invalid" Text="Invalid ID or Password" Visible="false" runat="server" ForeColor="Red"></asp:label>
                </table>
            
        </form>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Banks %>" SelectCommand="SELECT * FROM [User]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Banks %>" SelectCommand="SELECT * FROM [Admin]"></asp:SqlDataSource>
</body>
</html>
