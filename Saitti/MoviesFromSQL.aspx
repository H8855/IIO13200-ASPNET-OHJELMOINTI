<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MoviesFromSQL.aspx.cs" Inherits="MoviesFromSQL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Elokuvat SQL</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <!-- DataSource SQL-serveriltä -->
    <asp:SqlDataSource ID="srcMovies" runat="server" ConnectionString="<%$ ConnectionStrings:Muuvit %>" SelectCommand="SELECT [title], [director], [year], [url] FROM [Movies] ORDER BY [title]"></asp:SqlDataSource>
    <!-- GV esittää dataa -->
    <div>
        <h2 class="w3-container w3-indigo">Elokuvat SQL-serveriltä GridView:ssä</h2>
        <asp:GridView ID="gvMovies" DataSourceID="srcMovies" runat="server"></asp:GridView>
    </div>
    <!-- data HTML:ssä -->
    <h2 class="w3-container w3-indigo">Elokuvat XML-tiedostosta HTML-taulussa</h2>
    <asp:Repeater ID="Repeater1" DataSourceID="srcMovies" runat="server">
        <ItemTemplate>
            <p><%# Eval("title") %> by <%# Eval("director") %> </p>
            <img src="<%# Eval("url") %>" alt="Kuva puuttuu" width="200" />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

