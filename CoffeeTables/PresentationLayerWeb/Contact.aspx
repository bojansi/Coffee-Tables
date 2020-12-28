<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PresentationLayerWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- STATS PAGE -->
    <div class="box">
        <div class="heading">Sto br 1.</div>
        <div class="tables">
            <div class="table" id="t1">
                <div>5</div>
            </div>
            <div class="table" id="t2">
                <div>4</div>
            </div>
            <div class="table" id="t3">
                <div>3</div>
            </div>
            <div class="table" id="t4">
                <div>2</div>
            </div>
            <div class="table" id="t5">
                <div>1</div>
            </div>
        </div>
        <br>
        <hr>

        <div class="stats">
            <div id="priceLbl">Cena: <i>654.95</i></div>
            <br>
            <div class="checkoutBtn">
                <a href="#">Checkout</a>
                <a href="#">Confirm</a>
            </div>    
            <br>
            <div class="checkoutConfirm">
                Racun je placen!
            </div>
        </div>
    </div>
</asp:Content>
