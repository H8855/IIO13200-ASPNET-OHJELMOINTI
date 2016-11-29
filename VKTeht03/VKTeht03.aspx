<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VKTeht03.aspx.cs" Inherits="VKTeht03" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="http://w3schools.com/lib/w3.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblDateToday" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="lblDateChosen" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="lblDateDifference" runat="server" Text="Label"></asp:Label><br />
        <asp:Button ID="btnYearDeductOne" runat="server" Text="< vuosi" OnClick="btnYearDeductOne_Click" />
        <asp:Button ID="btnYearAddOne" runat="server" Text="vuosi >" OnClick="btnYearAddOne_Click" /><br />
        <asp:Calendar ID="cldrDateChoose" runat="server" OnSelectionChanged="cldrDateChoose_SelectionChanged"></asp:Calendar>
    </div>
    </form>
</body>
</html>
