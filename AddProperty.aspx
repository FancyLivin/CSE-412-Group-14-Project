<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProperty.aspx.cs" Inherits="CSE412_Group_Project_WebApp.AddProperty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Please enter your house information"></asp:Label>
            <br />
            <br />
            Price/Rent Per Month:
            <asp:TextBox ID="priceTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Rent Time(Years, if applicable):
            <asp:TextBox ID="rentTimeTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Year of Property Build: <asp:TextBox ID="yearTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Square Feet: <asp:TextBox ID="sqftTextBox" runat="server" Width="166px"></asp:TextBox>
            <br />
            <br />
            Num
            Beds:
            <asp:TextBox ID="bedsTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Num
            Baths: <asp:TextBox ID="bathsTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Address: <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            City: <asp:TextBox ID="cityTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Country: <asp:TextBox ID="countryTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Style:&nbsp;
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
            <asp:Button ID="SaleButton" runat="server" Text="Post for Sale" OnClick="SaleButton_Click" />
            <br />
            <br />
            <asp:Button ID="RentButton" runat="server" Text="Post for Rent" OnClick="RentButton_Click" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
