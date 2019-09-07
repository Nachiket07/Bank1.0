<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Bank.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
            .hide
            {
                display:none;
            }
        </style>
        <script>
            function setq() {
                var divId = document.getElementById("income").selectedIndex;
                document.getElementById("opt1").style.display = "none";
                document.getElementById("opt2").style.display = "none";
                document.getElementById("opt3").style.display = "none";
                document.getElementById("opt4").style.display = "none";
                if (divId != 0)
                {
                    
                    document.getElementById("opt" + divId).style.display = "inline";
                    document.getElementById("logout").style.display = "inline";
                    document.getElementById("selectedincome").value = divId;
                    //document.write(divId);
                }
                else {
                    document.getElementById("logout").style.display = "none";
                }
            }
        </script>
    <title>
    </title>
</head>
<body>
    <form id="form1" runat="server">
    <div runat="server" id="opt0">
        
            <asp:Label ID="wel" Text="Welcome " Font-Size="Larger" runat="server"></asp:Label>
            <asp:Label ID="Name" Font-Size="larger" runat="server" value="amigo"></asp:Label><br/>
            <asp:DropDownList runat="server" ID="income" OnSelectedIndexChanged="income_SelectedIndexChanged">
                <asp:ListItem value="None">Please Select</asp:ListItem>
                <asp:ListItem Value="opt1">0-3L</asp:ListItem>
                <asp:ListItem Value="opt2">3L-10L</asp:ListItem>
                <asp:ListItem Value="opt3">7L-15L</asp:ListItem>
                <asp:ListItem Value="opt4">More than 15L</asp:ListItem>
            </asp:DropDownList>
            <br />
            <button type="button" onclick="setq()">Submit</button><br/><br />
            <!--<asp:Button runat="server" ID="submit" Text="submit" OnClientClick="setq()"/>-->
            <asp:Label runat="server" ID="selsom" Visible="false" ForeColor="Red" Text="Please select income."></asp:Label>
        
    </div>
    
    
    <div class="hide" id="opt1" runat="server">
        <asp:Label runat="server" ID="q11" Text="Q1. First Question of opt1"></asp:Label><br />
        <asp:RadioButton runat="server" GroupName="q11" Text="one" value="1"/><br />
        <asp:RadioButton runat="server" GroupName="q11" Text="two" value="2" /><br /><br />
        <br/>
        <asp:Label runat="server" ID="q12" Text="Q2. Second Question of opt1"></asp:Label><br />
        <asp:RadioButton runat="server" GroupName="q12" Text="None" value="3"/><br />
        <asp:RadioButton runat="server" GroupName="q12" Text="All" value="4" />
    </div>
    
    <div class="hide" id="opt2" runat="server">
        <asp:Label runat="server" ID="q21" Text="Q1. First Question of opt2"></asp:Label><br />
        <asp:RadioButton runat="server" GroupName="q21" Text="one" value="5"/><br />
        <asp:RadioButton runat="server" GroupName="q21" Text="two" value="6" /><br /><br />
        <br/>
        <asp:Label runat="server" ID="q22" Text="Q2. Second Question of opt2"></asp:Label><br />
        <asp:RadioButton runat="server" GroupName="q22" Text="None" value="7"/><br />
        <asp:RadioButton runat="server" GroupName="q22" Text="All" value="8" />
    </div>

    <div class="hide" id="opt3" runat="server">
        <asp:Label runat="server" ID="q31" Text="Q1. First Question of opt3"></asp:Label><br />
        <asp:RadioButton runat="server" GroupName="q31" Text="one" value="9"/><br />
        <asp:RadioButton runat="server" GroupName="q31" Text="two" value="10" /><br /><br />
        <br/>
        <asp:Label runat="server" ID="q32" Text="Q2. Second Question of opt3"></asp:Label><br />
        <asp:RadioButton runat="server" GroupName="q32" Text="None" value="11"/><br />
        <asp:RadioButton runat="server" GroupName="q32" Text="All" value="12" />
    </div>

    <div class="hide" id="opt4" runat="server">
        <asp:Label runat="server" ID="q41" Text="Q1. First Question of opt4"></asp:Label><br />
        <asp:RadioButton runat="server" GroupName="q41" Text="one" value="13"/><br />
        <asp:RadioButton runat="server" GroupName="q41" Text="two" value="14" /><br /><br />
        <br/>
        <asp:Label runat="server" ID="q42" Text="Q2. Second Question of opt4"></asp:Label><br />
        <asp:RadioButton runat="server" GroupName="q42" Text="None" value="14"/><br />
        <asp:RadioButton runat="server" GroupName="q42" Text="All" value="15" />
    </div><br/>
    <asp:Button class="hide" runat="server" ID="logout" OnClick="submitLogout" Text="Submit"/>
    <asp:HiddenField id="selectedincome" runat="server" Value="0"/>
    </form>
</body>
</html>
