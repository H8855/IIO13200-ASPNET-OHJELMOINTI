<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPage.aspx.cs" Inherits="MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnKaikkiAsiakkaat" runat="server" Text="Hae kaikki asiakkaat" OnClick="btnKaikkiAsiakkaat_Click" />
        <asp:DropDownList ID="ddlMaat" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlMaat_SelectedIndexChanged"></asp:DropDownList>
        <asp:Button ID="btnMaasta" runat="server" Text="Hae asiakkaat valitusta maasta" OnClick="btnMaasta_Click" />
        <asp:Button ID="btnAsiakkaatMaittain" runat="server" Text="Hae asiakkaat maittain." />
        <asp:Panel ID=" pnlLuoAsiakas" runat="server" Visible="false" ></asp:Panel>
        <asp:GridView ID="gvAsiakkaat" runat="server"></asp:GridView>        
    </div>
    </form>
</body>
</html>
