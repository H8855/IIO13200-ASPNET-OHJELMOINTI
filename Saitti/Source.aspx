<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Source.aspx.cs" Inherits="Source" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tiedonvälitys-demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Source-sivu</h1>
        <p>
            Lähetettävä viesti: <asp:TextBox ID="txtMessage" runat="server" />
            <!-- tässä lista josta voi valita sopivan lauseen -->
            <asp:DropDownList ID="ddlMessages" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <!-- Tapa 1 -->
            <asp:Button ID="btnQueryString" runat="server" Text="Käytä QueryString" OnClick="btnQueryString_Click" />            
            <br />
            <!-- Tapa 2 -->
            <asp:Button ID="btnHttpPost" runat="server" Text="Käytä HTTPPost" PostBackUrl="~/Tapa2.aspx" />
            <br />
            <!-- Tapa 3 -->
            <asp:Button ID="btnSession" runat="server" Text="Käytä Session" OnClick="btnSession_Click" />
            <br />
            <!-- Tapa 4 -->
            <asp:Button ID="btnCookie" runat="server" Text="Käytä Evästettä" OnClick="btnCookie_Click" />
            <br />
            <!-- Tapa 5 -->
            <asp:Button ID="btnProperty" runat="server" Text="Käytä Public Propertyä" OnClick="btnProperty_Click" />
            <br />
        </p>
    </div>
    </form>
</body>
</html>
