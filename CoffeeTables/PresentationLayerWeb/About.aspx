﻿<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="PresentationLayerWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- STATS PAGE -->
    <div class="box">
        <div class="heading">Stats</div>
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
            <div class="data">
                Dnevni promet: <i>7856.85</i>
            </div>
            <div class="data">
                Jucerasnji promet: <i>4856.85</i>
            </div>
            <div class="data">
                Razlika: <i>3000</i>
            </div>
            <br><br>
            <div class="data">
                Dnevni br. musterija: <i>20</i>
            </div>
            <div class="data">
                Jucerasnji br. musterija: <i>5</i>
            </div>
            <div class="data">
                Razlika: <i>15</i>
            </div>
            <br><br><br>
            <hr>
            <div class="data">
                Broj musterija stola: <i>4</i>
            </div>
            <div class="data">
                Trenutni racun: <i>421.65</i>
            </div>
            <div class="data">
                Promet stola: <i>2651.95</i>
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
