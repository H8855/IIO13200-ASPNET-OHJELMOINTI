<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VKTeht06.aspx.cs" Inherits="VKTeht06" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .recordpic{
            width: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:XmlDataSource ID="srcRecords" runat="server" DataFile="~/App_Data/LevykauppaX.xml" XPath="//record"></asp:XmlDataSource>
    <div>
        <asp:DataList ID="dlRecords" runat="server" DataSourceID="srcRecords">
            <ItemTemplate>
                <table>
                    <tr>
                        <td class="recordpic">
                            <img src="Images/<%# Eval("ISBN") %>.jpg" alt="Kuva puuttuu" />
                        </td>
                        <td>
                            <b><%# Eval("Artist") %>: <%# Eval("Title") %></b><br /><br />
                            <b>ISBN:</b><a href='<%# "/VKTeht06Details.aspx?record=" + Eval("ISBN") %>'><%# Eval("ISBN") %></a><br />
                            <b>Hinta:</b> <%# Eval("Price") %><br />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
