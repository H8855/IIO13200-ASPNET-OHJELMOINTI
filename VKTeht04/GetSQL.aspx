<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GetSQL.aspx.cs" Inherits="GetSQL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:SqlDataSource ID="srcAsiakkaat" runat="server" ConnectionString="<%$ ConnectionStrings:Asiakkaat %>" SelectCommand="SELECT [astunnus], [asnimi], [yhteyshlo], [postitmp] FROM [asiakas]"></asp:SqlDataSource>
    <asp:GridView ID="gvAsiakkaat" DataSourceID="srcAsiakkaat" runat="server"></asp:GridView>
</asp:Content>

