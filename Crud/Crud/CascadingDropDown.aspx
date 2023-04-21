<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CascadingDropDown.aspx.cs" Inherits="Crud.CascadingDropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddCountry" runat="server"  OnSelectedIndexChanged="ddCountry_SelectedIndexChanged1" AutoPostBack="true" EnableViewState="False" ViewStateMode="Disabled"></asp:DropDownList>

            <asp:DropDownList ID="ddState" runat="server" OnSelectedIndexChanged="ddState_SelectedIndexChanged"></asp:DropDownList>
            
            <asp:Button ID="Button1" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
