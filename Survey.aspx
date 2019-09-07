<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Survey.aspx.cs" Inherits="Bank.Survey" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="wel" Text="Welcome " Font-Size="Larger" runat="server"></asp:Label>
            <asp:Label ID="Name" Font-Size="larger" runat="server" text="amigo"></asp:Label><br/>
        
        </div>
        <div>
            <br /><br />
            <asp:Label id="Q1" Text="Does change in Ruling party affects the economy? What do you think!!" runat="server" ></asp:Label><br />
            <asp:RadioButtonList id="a" runat="server" value="-1">
                <asp:ListItem Value="1">Yes</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
            <br />

            <asp:Label id="Q2" Text="Is encroachment on pavements leads to accidents." runat="server" ></asp:Label><br />
            <asp:RadioButtonList id="b" runat="server"  DataValueField="-1">
                <asp:ListItem Value="1">Yes</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
            <br />

            <asp:Label id="Q3" Text="From motor vehicle act 2019 , will the traffic system of India benefited." runat="server" ></asp:Label><br />
            <asp:RadioButtonList id="c" runat="server" value="-1">
                <asp:ListItem Value="1">Yes</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
            <br />

            <asp:Label id="Q4" Text="Do you inform about things which are illegal in your place around to police. If yes this makes you active citizen of country?" runat="server" ></asp:Label><br />
            <asp:RadioButtonList id="d" runat="server" value="-1">
                <asp:ListItem Value="1">Yes</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button id="submit" runat="server" OnClick="submitClick" Text="submit"/>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Banks %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
    </form>
</body>
</html>
