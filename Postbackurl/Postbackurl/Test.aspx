<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Postbackurl.Test"   %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title> 
    
    <link href="App_Themes/Theme1/StyleSheet1.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button SkinID="btn" runat="server" ID="btn2" />
            <asp:Button ID="Button1" runat="server" Text="Submit" PostBackUrl="~/Demo.aspx" ForeColor="White" BackColor="Blue" BorderColor="#CCFF33" Width="70px"  />
            <p>This is a themes page</p>
        </div>
    </form>
</body>
</html>
