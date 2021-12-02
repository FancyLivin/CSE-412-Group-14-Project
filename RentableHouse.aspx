<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentableHouse.aspx.cs" Inherits="CSE412_Group_Project_WebApp.RentableHouse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Avaliable Houses For Rent"></asp:Label>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
