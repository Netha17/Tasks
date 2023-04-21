<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Crud.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            padding:0px;
            margin:0px;
        }
        #main{
            display:flex;
            width:100vw;
            height:100vh;
        }
        #left{
            width:40%;
            background-color:blueviolet;
            
        }
        #right{
            width:60%;
            background-color:cyan;
        }
        h1{
            color:white;
            margin:auto
        }
    </style>
</head>
<body>
    
        <div id="main">
            <div id="left">
               <center> <h1>Edit item</h1></center>
            </div>

            <div id="right">
                <form id="form2" runat="server"  >
                      <table align="center"  width="400px" cellspacing="2" cellpadding="10">
                          <tr>
                              <td>
                                  
                                   <asp:TextBox ID="name" runat="server" placeholder="Name*"></asp:TextBox> 


                              </td>
                          </tr>
                             <tr>
                              <td>
                                  <asp:TextBox ID="mbl" runat="server" placeholder="Mobile Number"></asp:TextBox>
                              </td>
                          </tr>
                          <tr>
                              <td>
                                   <asp:TextBox ID="fee" runat="server" placeholder="Fee"></asp:TextBox>
                              </td>
                          </tr>
       
                          <tr>
                              <td><asp:Button ID="btnInsertRecord" runat="server" Text="Save Changes" OnClientClick="vaildate();" OnClick="btnInsertRecord_Click" /></td>
                          </tr>
                      </table>
                  
                  </form>

                            
            </div>
            
            
        </div>
    
</body>
</html>
