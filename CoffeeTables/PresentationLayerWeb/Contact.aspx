<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PresentationLayerWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- STATS PAGE -->
    <div class="box">
        <div class="heading" id="heading" runat="server">Sto br 1.</div>
        <div class="tables">
            <div class="table tb5" runat="server" id="t5">
                <div><a id="A5" href="#" runat="server" onserverclick="table_ServerClick5">5</a></div>
            </div>
            <div class="table tb4" runat="server" id="t4">
                <div><a id="A4" href="#" runat="server" onserverclick="table_ServerClick4">4</a></div>
            </div>
            <div class="table tb3" runat="server" id="t3">
                <div><a id="A3" href="#" runat="server" onserverclick="table_ServerClick3">3</a></div>
            </div>
            <div class="table tb2" runat="server" id="t2">
                <div><a id="A2" href="#" runat="server" onserverclick="table_ServerClick2">2</a></div>
            </div>
            <div class="table tb1" runat="server" id="t1">
                <div><a id="A1" href="#" runat="server" onserverclick="table_ServerClick1">1</a></div>
            </div>
        </div>
        <br>
        <hr>

        <div runat="server" class="stats">
            <div runat="server" id="priceLbl">Cena: <i id="totalSUM" runat="server">Izaberite sto!</i></div>
            <br>
            <div runat="server" class="checkoutBtn">
                <a href="#" runat="server" onserverclick="checkoutBill">Naplati</a>
            </div>    
            <br>
            <div runat="server" class="checkoutConfirm" id="checkoutConfirm">
            </div>
        </div>
    </div>
</asp:Content>
