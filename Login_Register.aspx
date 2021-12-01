<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Register.aspx.cs" Inherits="CSE412_Group_Project_WebApp.App_Start.Login_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Height="30px" OnClick="Button1_Click" Text="Login" />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register" />
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
