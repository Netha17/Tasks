<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Mobile.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Parking.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
  <form align="center">
    <table id="login" width="500px"   align="center"  cellpadding="4" cellspacing="10">
        <caption><h2>Welcome back! Let's get you signed in</h2></caption>
        <tr align="center">
            
            <td><input type="email"  placeholder="Email"  required/></td>
        </tr   >
        <tr  align="center">
            
            <td><input type="password" placeholder="Password" required /></td>
        </tr>
        <tr>
            <td> <input type="submit" value="Sign in" /></td>     
          <td><input type="reset" value="Reset" style="width:50%"/></td> 
        </tr>
        
           

        
       
    </table>
    
  </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
