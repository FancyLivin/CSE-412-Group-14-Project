<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMyProperties.aspx.cs" Inherits="CSE412_Group_Project_WebApp.ViewMyProperties" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Owned Properties"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Type the property ID of the property you wish to delete here:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="manage" runat="server" OnClick="manage_Click" Text="Delete!" />
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
