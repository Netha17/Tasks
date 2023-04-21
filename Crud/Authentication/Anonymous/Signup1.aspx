<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup1.aspx.cs" Inherits="Authentication.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        caption{
            font-size:30px;
            font-family:Arial;
            font-weight:bold;
            margin-bottom:30px;
        }
        table td{
            padding:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <table style="margin:auto">
              <caption>Sign up</caption>
               <tr>
                   <td>
                       <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="txtEmail" TextMode="Email" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       <asp:Label ID="lblMobile" runat="server" Text="Mobile Number"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       <asp:Label ID="lblPassword" runat="server"   Text="Password"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_SubmitClick" />
                   </td>
                   <td style="text-align:left">
                       <input id="Reset1" type="reset" value="Reset" />
                   </td>
               </tr>
           </table>
        </div>
    </form>
</body>
</html>
