<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="AC_06.user" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="userview" runat="server" Text="view the available books" OnClick="userview_Click" />
        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:Label ID="Label1" runat="server" Text="Available Books"></asp:Label>
        <br />
        OR Book Id<asp:TextBox ID="bid" runat="server"></asp:TextBox>
        <asp:Button ID="viewbyid" runat="server" Text="search" OnClick="viewbyid_Click" />
        <br />
        OR Book category<asp:TextBox ID="cat" runat="server"></asp:TextBox>
        <asp:Button ID="getbycat" runat="server" Text="search " OnClick="getbycat_Click" />
        <br />
        <br />
    </form>
</body>
</html>
