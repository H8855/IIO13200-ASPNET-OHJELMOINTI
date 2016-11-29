<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GetDemox.aspx.cs" Inherits="GetDemox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:GridView ID="gvAsiakkaat" runat="server"></asp:GridView>
    <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
</asp:Content>

