<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VKTeht06Details.aspx.cs" Inherits="VKTeht06Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:XmlDataSource ID="srcRecords" runat="server" DataFile="~/App_Data/LevykauppaX.xml"></asp:XmlDataSource>
        <asp:XmlDataSource ID="srcSongs" runat="server" DataFile="~/App_Data/LevykauppaX.xml"></asp:XmlDataSource>
    <div>
        <asp:DataList ID="dlRecords" runat="server" DataSourceID="srcRecords">
            <ItemTemplate>
                <table>
                    <tr>
                        <td>
                            <img src="Images/<%# Eval("ISBN") %>.jpg" alt="Kuva puuttuu" /><br />
                            <b><%# Eval("Artist") %>: <%# Eval("Title") %></b><br /><br />
                            <b>ISBN:</b><%# Eval("ISBN") %></a><br />
                            <b>Hinta:</b> <%# Eval("Price") %><br />
                            <b>Levyn biisit:</b><br />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>

        <asp:DataList ID="dlSongs" runat="server" DataSourceID="srcSongs">
            <ItemTemplate>
                <%# Eval("name") %>
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
