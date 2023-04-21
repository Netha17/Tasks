<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Mobile.Master" AutoEventWireup="true" CodeBehind="Connect.aspx.cs" Inherits="Parking.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <div id="contact">
        <div id="con-form">
            <h1>CONTACT FORM</h1>
            <form>
                <table cellspacing="10">
                    <tr>
                        <td><input type="text" placeholder="Name*" required/></td>
                        <td><input type="text" placeholder="Subject*" required/></td>
                    </tr>
                    <tr>
                        <td><input type="text" placeholder="Phone Number*" required/></td>
                        <td><input type="text" placeholder="Email*" required/></td>
                    </tr>
                    <tr>
                        <td colspan="2"><textarea placeholder="Message" rows="5" cols="50" required></textarea></td>
                        
                    </tr>
                </table>

            </form>
        </div>
        <div id="con-info">
            <h1>CONTACT-INFO</h1>
            <p>140 Horizon Circle, New York, california 98109</p>
            <p>8(800)785 6472</p>
            <p>support@justpark.com</p>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
