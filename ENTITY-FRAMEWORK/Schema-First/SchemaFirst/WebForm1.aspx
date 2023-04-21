<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SchemaFirst.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="EntityDataSource1" AutoGenerateColumns="False" DataKeyNames="cid" >
                <Columns>
                    <asp:BoundField DataField="cid" HeaderText="Id" ReadOnly="True" SortExpression="cid"></asp:BoundField>
                    <asp:BoundField DataField="cname" HeaderText="Country" SortExpression="cname"></asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:EntityDataSource ID="EntityDataSource1" runat="server" DefaultContainerName="PracticeEntities" ConnectionString="name=PracticeEntities" EnableFlattening="False" EntitySetName="countries"></asp:EntityDataSource>
        </div>
    </form>
</body>
</html>
