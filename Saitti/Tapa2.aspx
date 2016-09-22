<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tapa2.aspx.cs" Inherits="Tapa2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tapa 2: HTTPPost</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Tapa 2: HTTPPost -tapa</h1>
        <p>
            Kutsuvalta sivulta luetaan viesti: 
            <%=Request.Form["txtMessage"] %>
            <br />
        </p>
    </div>
    </form>
</body>
</html>
