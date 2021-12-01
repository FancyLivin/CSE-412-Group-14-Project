<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuyerPreference.aspx.cs" Inherits="project.BuyerPreference" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Please select your preference"></asp:Label>
            <br />
            <br />
            Max Price:
            <asp:TextBox ID="maxPriceTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Min Price:
            <asp:TextBox ID="minPriceTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Beds Preference:
            <asp:TextBox ID="bedPrefTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Bath Preference:
            <asp:TextBox ID="bathPrefTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Location Preference:
            <asp:TextBox ID="locPrefTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Style Preference:&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>ranch</asp:ListItem>
                <asp:ListItem>mcmansion</asp:ListItem>
                <asp:ListItem>contemporary</asp:ListItem>
                <asp:ListItem>craftsman</asp:ListItem>
                <asp:ListItem>colonial</asp:ListItem>
                <asp:ListItem>farmhouse</asp:ListItem>
                <asp:ListItem Selected="True">--select--</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="submitButton2" runat="server" Text="submit" OnClick="submitButton2_Click" />
            <br />
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
