<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StoreImages.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Id" />
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" Height="100px"
                           ImageUrl='<%#"data:Image/png;base64," + Convert.ToBase64String((byte[]) Eval("Data")) %>' /> 

                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            

        </asp:GridView>
    </form>
</body>
</html>
