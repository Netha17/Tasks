<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Timer.ascx.cs" Inherits="Crud.Timer" %>

<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

<asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>

<asp:Label ID="Label1" runat="server" Text="Label" BackColor="Red" BorderColor="Yellow" BorderStyle="Solid" BorderWidth="10px" Font-Bold="True" ForeColor="White" Width="100px"></asp:Label>