<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="AC_06.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        To insert a book record please provide following information
        <br />
        Book Nmae<asp:TextBox ID="bookname" runat="server"></asp:TextBox>
         <br />
        Author Name<asp:TextBox ID="authorname" runat="server"></asp:TextBox>
         <br />
         Category<asp:TextBox ID="category" runat="server"></asp:TextBox>
         <br />
         Status <asp:TextBox ID="status" runat="server"></asp:TextBox>
            <asp:Button ID="insert" runat="server" Text="insert" OnClick="insert_Click" />
        <br />
        To modify a book record please provide following information
        <br />
        ID of book need to be modified<asp:TextBox ID="Id" runat="server"></asp:TextBox>
         <br />
        new BookName<asp:TextBox ID="Mname" runat="server"></asp:TextBox>
         <br />
         new Author Name<asp:TextBox ID="Mauthor" runat="server"></asp:TextBox>
         <br />
          new Category<asp:TextBox ID="Mcategory" runat="server"></asp:TextBox>
             <br />
          new Status<asp:TextBox ID="Mstatus" runat="server"></asp:TextBox>
            <asp:Button ID="modify" runat="server" Text="Modify" />
        <br />
        To Delete a book record please provide following information
        <br />
        ID of book need to be deleted<asp:TextBox ID="delid" runat="server"></asp:TextBox>
        <asp:Button ID="deletebyid" runat="server" Text="Delete by Id" />
         <br />
            <br />
        OR
        <br />
        Name of book need to be deleted<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="deletebyname" runat="server" Text="Delete by Name" />
         <br />
    </form>
</body>
</html>
