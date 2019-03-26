<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        

        <br />
        <br />
        Address ID&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
         <br />
        <br />
         FirstName&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
         <br />
        <br />
         LastName&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
         <br />
        <br />
         Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
         <br />
        <br />
         PhoneNo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
         <br />
        <br />
         Country&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        

    &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Insert_Click" Text="InsertAddress" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Delete_Click" Text="DeleteAddress" />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Update_Click" Text="UpdateAddress" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Search_Click" Text="Search Address" />
        <br />
        

    </form>
</body>
</html>
