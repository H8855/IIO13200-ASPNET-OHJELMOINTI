<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPage.aspx.cs" Inherits="MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:XmlDataSource ID="xdsTheatres" runat="server" XPath="TheatreAreas/TheatreArea"></asp:XmlDataSource>
    <asp:XmlDataSource ID="XdsShows" runat="server" XPath="Schedule/Shows/Show"></asp:XmlDataSource>
    <div>
        <table>
            <tr>
                <td>
                    <asp:ListBox ID="lbTheatres" runat="server" AutoPostBack="true" Height="500px" OnSelectedIndexChanged="lbTheatres_SelectedIndexChanged" ></asp:ListBox>
                </td>
                <td>
                    <asp:Repeater ID="rptMovies" runat="server">
                        <ItemTemplate>
                            <img src="<%# Container.DataItem %>" alt="Kuva puuttuu" />
                        </ItemTemplate>
                    </asp:Repeater>
                </td>
            </tr>
        </table>
        <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
