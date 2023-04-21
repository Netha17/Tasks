<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cdd.aspx.cs" Inherits="Crud.cdd"  StylesheetTheme="Skin1"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddCountry" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddCountry_SelectedIndexChanged"></asp:DropDownList>
            <asp:DropDownList ID="ddState" runat="server" OnSelectedIndexChanged="ddState_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:DropDownList ID="ddCity" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
