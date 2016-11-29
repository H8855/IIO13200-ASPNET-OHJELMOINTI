<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VKTeht02.aspx.cs" Inherits="VKTeht02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                <asp:DropDownList ID="ddlRows" runat="server"></asp:DropDownList> riviä <br />
                <asp:DropDownList ID="ddlType" runat="server">
                    <asp:ListItem Text="Suomi-Lotto" Value="Suomi"></asp:ListItem>
                    <asp:ListItem Text="Viking-Lotto" Value="Viking"></asp:ListItem>
                </asp:DropDownList><br />
                <asp:Button ID="btnDraw" runat="server" Text="Arvo" OnClick="btnDraw_Click" />
            </td>
            <td>

            </td>
        </tr>
    </table>
    </div>
        <div runat="server" id="divRows">
            Arvotut rivit.
        </div>
    </form>
</body>
</html>
