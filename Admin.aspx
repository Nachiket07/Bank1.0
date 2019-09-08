<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Bank.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lwelcome" runat="server" text="Welcome  " Font-Size="Medium"></asp:Label>
            <asp:Label ID="welcome" runat="server" Text="Amigo" Font-Size="Medium"></asp:Label>
            <br /><br />
        </div>
        <div>
            <asp:Label ID="ladd" runat="server" Text="Add Question"></asp:Label><br /><br />
            <asp:Button ID="add" runat="server" Text="Add" />

            
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Banks %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
    </form>
</body>
</html>
