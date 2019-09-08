<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Bank.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lwelcome" runat="server" text="Welcome " Font-Size="Large"></asp:Label>
             <asp:Label ID="welcome" runat="server" text="amigo" Font-Size="Large"></asp:Label>
            <br /><br />
        </div>
        <div>
            <asp:Label ID="laddq" runat="server" Text="Quesion"></asp:Label><br />
            <asp:TextBox ID="question" runat="server"></asp:TextBox>
            <br />
            <asp:Button id="add" Text="Add" runat="server" OnClick="Adder"/><br /><br />

            <asp:Label ID="ldelq" runat="server" Text="Enter id of quesion to delete"></asp:Label><br />
            <asp:textbox ID="dquestion" runat="server"></asp:textbox><br />
            <asp:Button id="delete" Text="Delete" runat="server" OnClick="Deleter"/>
            <br /><br /><br /><br />
            <asp:Button runat="server" OnClick="logouter" Text="Logout" ID="logout"/>
        </div>
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Banks %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Banks %>" SelectCommand="SELECT * FROM [Questions]"></asp:SqlDataSource>
    </form>
</body>
</html>
