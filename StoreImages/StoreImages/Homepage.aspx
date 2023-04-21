<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="StoreImages.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" /><br />
            <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />
        </div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Id" DataField="id" />
                    <asp:ImageField HeaderText="Image" DataImageUrlField="path" ControlStyle-Height="120" ControlStyle-Width="140"></asp:ImageField>
                    <asp:TemplateField HeaderText="Image">
                        <ItemTemplate>
                            <img src="<%#Eval("path") %>" style="width:100px; height:100px;" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        
        </div>
    </form>
</body>
</html>
