<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="Login1.aspx.cs" Inherits="Authentication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table{margin:auto;

        }
        table td{
            padding:5px;
        }
        a{
            text-decoration:none;
            font-weight:bold;
               

        }
        a:hover{
            text-decoration:blink;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <caption>Login</caption>
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
                        <asp:Label ID="Label1" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Log in" OnClick="btnSubmit_Click" />
                    </td>

                </tr>
                
                    
                
            </table>
            <div>
                <center>If you don't have username and password, please do register <a href="Anonymous/Signup1.aspx">here</a></center>
            </div>
        </div>
    </form>
</body>
</html>
