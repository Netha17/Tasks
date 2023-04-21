<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Mobile.Master" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="Parking.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">

    <div id="dashboard">
        <div id="bp">Book Parking</div>
        <div id="bookFields">
            <table>
                <tr><td><input type="text" placeholder="Vehicle Owner Name" required /></td></tr>
                <tr><td><input type="text" placeholder="Vehicle Number" required /></td></tr>
                <tr><td><select size="1" required width="100px" height="50px"><option>Car type</option> <option>Car</option><option>Bike</option><option>Truck</option></select></td></tr>
                <tr><td><input type="text" placeholder="Phone number" required /></td></tr>
                <tr><td><input type="text" placeholder="Location" required /></td></tr>
                <tr><td><input type="date" /></td></tr>
                <tr><td><input type="submit" value="Book Now" /></td></tr>
            </table>
        </div>

    </div>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
