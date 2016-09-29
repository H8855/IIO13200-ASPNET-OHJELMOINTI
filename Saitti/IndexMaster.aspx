﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IndexMaster.aspx.cs" Inherits="Index" MasterPageFile="~/MasterPage.master" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>IIO13200 .NET Ohjelmointi</title>
    <link href="CSS/demo.css" rel="stylesheet" type="text/css" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
        <div>
            <h1>IIO13200. NET Ohjelmointi</h1>
            <h2>1.kontaktikerta</h2>
            <p>Oma sivu.</p>
            <h3>Perus-HTML -kontrolleja</h3>
            <a href="Testi.html">Testi-HTML -sivu</a>
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Hello.aspx">Hello</asp:LinkButton>
            <p>
                Esimerkki ASP.NET DataKontrollista
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ShowPhotos.aspx">Show Photos</asp:HyperLink>
            </p>
            <p>
                Esimerkki kuinka koodissa rakennetaan HTML:ää
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ShowCustomers.aspx">Show WineCustomers</asp:HyperLink>
            </p>
        </div>
</asp:Content>


