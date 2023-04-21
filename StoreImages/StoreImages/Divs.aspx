<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Divs.aspx.cs" Inherits="StoreImages.Divs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
  

        #left{
            width:50%;
            background-color:cyan;
            float:right;
        }
        #right{
            width:50%;
            background-color:green;
            float:right;

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main">
            <div id="left">
                Left division
            </div>
                <div id="right">
                Left division
            </div>
        </div>
    </form>
</body>
</html>
