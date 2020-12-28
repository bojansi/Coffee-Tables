<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentationLayerWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main class="login">
        <!-- Waiter selection PAGE -->
        <ul runat="server" id="waiterss">
            <li id="L0">
                <a id="A0" href="#" runat="server" onserverclick="login_ServerClick1"></a>
            </li>
            <li id="L1">
                 <a id="A1" href="#" runat="server" onserverclick="login_ServerClick2"></a>
            </li>
        
        </ul>
    </main>
</asp:Content>
