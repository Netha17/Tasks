<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Mobile.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Parking.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <form>
        <center>
        <div id="signup">
            <h3>Create an account to continue</h3>
            <div>
                <input type="text" placeholder="FirstName" required autocomplete autofocus />

            </div>
            <div>
                <input type="text" placeholder="Surname" required autocomplete autofocus />
            </div>
            <div>
                <input type="email" placeholder="Email" required />
            </div>
            <div>
                <input type="password" placeholder="Password" required />
            </div>
            <div>
                <input type="submit" value="Create Acccount"  />
            </div>
        </div>
       </center>
    </form>








</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
