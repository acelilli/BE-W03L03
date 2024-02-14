<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CineEsercizio._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Cinema Multisala</h1>
            <p class="lead">Inserisci la tua prenotazione:</p>
            <!--form + Bottone per la prenotazione

                 <p><a class="btn btn-primary btn-md">Learn more &raquo;</a></p>
                -->
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="Nord">
                <h2 id="SalaNordTitle">Sala Nord</h2>
                <p>Prenotazioni attive per Il Ragazzo e l'Airone:</p>
                <asp:Button ID="Button1" runat="server" Text="Mostra le prenotazioni" CssClass="btn btn-dark" onClick="Sala1_Click" style="background-color: #663d71;"/>

                <p id="SalaNord">
                    <!-- Posti Sala Nord o titoli di film boh-->
                </p>
                
            </section>
            <section class="col-md-4" aria-labelledby="Est">
                <h2 id="SalaEstTitle">Sala Est</h2>
                <p>Prenotazioni attive per Barbie:</p>
                <asp:Button ID="Button2" runat="server" Text="Mostra le prenotazioni" CssClass="btn btn-dark" onClick="Sala2_Click" style="background-color: #663d71;"/>
                <p id="SalaEst">
                    <!-- Posti Sala Est o titoli di film boh-->
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="Sud">
                <h2 id="SalaSudTitle">Sala Sud</h2>
                <p>Prenotazioni attive per Mean Girls:</p>
                <asp:Button ID="Button3" runat="server" Text="Mostra le prenotazioni" CssClass="btn btn-dark" onClick="Sala3_Click" style="background-color: #663d71;"/>
                <p id="SalaSud">
                    <!-- Posti Sala Est o titoli di film boh-->
                </p>
            </section>
        </div>
    </main>

</asp:Content>
