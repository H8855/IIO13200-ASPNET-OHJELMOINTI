<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowFeedback.aspx.cs" Inherits="ShowFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="srcPalautteet" runat="server" ConnectionString="<%$ ConnectionStrings:Palautteet %>" SelectCommand="SELECT * FROM palaute" ></asp:SqlDataSource>
        <asp:GridView ID="gvPalautteet" runat="server" DataSourceID="srcPalautteet"></asp:GridView>
    </div>
    </form>
</body>
</html>
