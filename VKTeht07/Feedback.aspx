<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblDate" runat="server" Text="Pvm:"></asp:Label><br />
        <asp:TextBox ID="txbDate" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvDate" ControlToValidate="txbDate" runat="server" ErrorMessage="Päivä vaaditaan"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblName" runat="server" Text="Nimi:"></asp:Label><br />
        <asp:TextBox ID="txbName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvName" ControlToValidate="txbName" runat="server" ErrorMessage="Nimi vaaditaan"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblCourse" runat="server" Text="Kurssi:"></asp:Label><br />
        <asp:TextBox ID="txbCourse" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txbDate" runat="server" ErrorMessage="Päivä vaaditaan"></asp:RequiredFieldValidator>
        <br />
    </div>
    </form>
</body>
</html>
