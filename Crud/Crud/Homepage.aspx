<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Crud.Homepage" %>

<%@ Register Src="~/Timer.ascx" TagPrefix="uc1" TagName="Timer" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            margin:0px;
            padding:0px;
        }
        #top{
            padding-top:7px;
            padding-left:40px;
            padding-bottom:4px;
            
            height:60px;
            background-color:darkviolet;
            margin-bottom:0px;
            
        
        }
        p{
            color:white;
            font-size:22px;
            font-family:'Arial';
            padding:0px;
            margin:0px;
            
        }
        a{
            text-decoration:none;
            font-size:18px;
        }
        button{
            padding:5px 20px 2px  20px;
            margin-left:50px;
            margin-top:10px;
        }
        .active{
            background-color:cyan;
            
        }
        #btnDelete{
            padding:5px 20px 3px  20px;
            margin-left:10px;
            margin-top:10px;
            font-size:18px;
            border-radius:3px;
            
        }
       

   #btnDelete{
      border:1px solid black;
      cursor:pointer;
   }

   table{
       margin-top:20px;
       text-align:center;

   }
   tr,th{
       height:50px;
       border-bottom:1px solid black;
       
   }
   th:hover{
       background-color:white;
       color:black;
   }
   tr:hover{
       background-color:darkblue;
       color:white;
   }
  #buttons_list{
       background-color:cyan;
       padding-bottom:15px;
       display:flex;
       
   }
    #btnEdit:hover{
        cursor:pointer;

    }
  #btnEdit:hover{
      background-color:green;
      color:white;
  }
  #btnDelete:hover,button:hover,a:hover{
      background-color:blue;
      color:white;
      border:none;
      font-family:Arial;
      border-radius:5px;
  }
  #timer{
      margin-left:850px;
      margin-top:9px;
  }
   
    </style>
</head>
<body>
    <div id="top">
       <p> Basic CRUD UI</p>
    </div>
    <span></span>    
    
  
    <form id="form1" runat="server">
        <div id="buttons_list">
            <button><a href="Insert.aspx">Insert</a></button>
             
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click1"/>
            <div id="timer">
                <uc1:Timer runat="server" id="Timer1" />
            </div>
            
        </div>

    
        <asp:GridView ID="GridView1"   runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" GridLines="None" CellPadding="4" Width="100% "    >
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        <asp:CheckBox ID="CbHeader" runat="server"    AutoPostBack="true" Text="Select All" OnCheckedChanged="CbHeader_CheckedChanged"/>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CbEmpty" runat="server"   OnCheckedChanged="CbEmpty_CheckedChanged" />
                    </ItemTemplate>
                </asp:TemplateField>
          <asp:BoundField   DataField="sid" HeaderText="ID"/>
          <asp:BoundField DataField="sname" HeaderText="Name" /> 
          <asp:BoundField DataField="mobile_no" HeaderText="Mobile"  />
          <asp:BoundField DataField="fee" HeaderText="Fee"  /> 
          <asp:TemplateField> <ItemTemplate> <asp:Button ID="btnEdit" runat="server" Width="60" Text="Edit" CommandName="EditButton" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" /> </ItemTemplate></asp:TemplateField>

     </Columns>

 </asp:GridView>
        
    </form>
   
</body>
</html>
