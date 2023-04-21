<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Crud.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtusername" runat="server" ></asp:TextBox>
            
            <asp:Button  id="btnSubmit" runat="server" Text="Submit" PostBackUrl="~/Postbackurl.aspx"></asp:Button>

        </div>
    </form>
</body>
</html>
