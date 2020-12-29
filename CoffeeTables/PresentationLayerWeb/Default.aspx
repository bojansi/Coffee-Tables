<%@ Page Title="Waiter Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentationLayerWeb._Default" %>

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
            <li id="L2">
                 <a id="A2" href="#" runat="server" onserverclick="login_ServerClick3"></a>
            </li>
            <li id="L3">
                 <a id="A3" href="#" runat="server" onserverclick="login_ServerClick4"></a>
            </li>
            <li id="L4">
                 <a id="A4" href="#" runat="server" onserverclick="login_ServerClick5"></a>
            </li>
        </ul>
    </main>
</asp:Content>
