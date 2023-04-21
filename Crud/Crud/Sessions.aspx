<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sessions.aspx.cs" Inherits="Crud.Sessions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             User Name:-<asp:TextBox ID="tbUserName" runat="server" AutoPostBack="True" OnTextChanged="tbUserName_TextChanged"></asp:TextBox>  
        <br />  
        <br />  
        Password:-<asp:TextBox ID="tbpwd" runat="server"></asp:TextBox>  
        <br />  
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />  
        </div>
    </form>
</body>
</html>
