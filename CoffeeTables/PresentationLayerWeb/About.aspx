<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="PresentationLayerWeb.About" %>

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
        <div class="stats">
            <div class="data">
                Dnevni promet: <i runat="server" id="todayValue"></i>
            </div>
            <div class="data">
                Ukupni promet: <i runat="server" id="allValue"></i>
            </div>
           
            <br><br>
            <div class="data">
                Dnevni br. musterija: <i runat="server" id="todayValueCount"></i>
            </div>
            <div class="data">
                Ukupni br. musterija: <i runat="server" id="allValueCount"></i>
            </div>
            <br><br><br>
            <hr>
            <div class="data">
                Broj musterija stola: <i runat="server" id="tableCountValue"></i>
            </div>
            <div class="data">
                Dnevni promet stola: <i runat="server" id="tableSumTodayValue"></i>
            </div>
            <div class="data">
                Ukupni promet stola: <i runat="server" id="tableSumAllValue"></i>
            </div>
            <br><br><br>
            <hr>
            <div class="data1">
                Zauzet <span id="red">&nbsp &nbsp &nbsp &nbsp &nbsp</span>
            </div>
            <div class="data1">
                Slobodan <span id="green">&nbsp &nbsp &nbsp &nbsp &nbsp</span>
            </div>
            <div class="data1">
                Selektovan <span id="blue">&nbsp &nbsp &nbsp &nbsp &nbsp</span>
            </div>
            
        </div>
        
    

    </div>
</asp:Content>
