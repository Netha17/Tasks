<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="Crud.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            margin:0px;
            padding:0px;
        }
        #main{
            display:flex;
            width:100vw;
            height:100vh;
        }
        #left{
            background-color:darkmagenta;
            width:40%;
            height:100vh;
        }
        #right{
             background-color:cyan;
            width:60%;
            height:100vh;
        }
        input{
            height:20px;
            width:200px;
        }
        select{
            height:25px;
            width:205px;
        }
        table{
            margin-top:150px;
        }
        #left{

        }
        h1{
            color:white;
            margin-top:50px;
            margin-left:70px;
            font-size:40px;
        }
        button{
            margin-top:300px;
            margin-left:200px;
        }
        a{
            text-decoration:none;
        }

        
    </style>
    <script>

    </script>
</head>
<body>
    
        <div id="main">
            
            <div id="left">
                <div><h1>Add item</h1></div>
                
                <button><a href="Homepage.aspx">Cancel</a></button>
            </div>
            <div id="right">
                <center>
                  <form id="form1" runat="server" onsubmit="return validation()">
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

                </center>


            </div>
        </div>
    
</body>
</html>
