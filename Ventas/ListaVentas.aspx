<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="ListaVentas.aspx.vb" Inherits="trabajo_final_carrera.ListaVentas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex justify-content-center">
                <h1 class="m-3 pb-3 text-center">Ventas</h1>
            </div>
        </div>
    </div>

    <div class="pb-3">
        <ul class="nav nav-tabs">
            <li class="nav-item">
                <a class="nav-link" href="NuevaVenta.aspx">Nueva Venta</a>
            </li>
            <li class="nav-item">
                <a class="nav-link active">Listado de Ventas</a>
            </li>
        </ul>
    </div>



    <form id="formVentasListar" runat="server">

        <div align="center">
            <asp:Button ID="btnListar" runat="server" Text="Listar" CssClass="btn btn-warning m-5 pl-5 pr-5" />
        </div>

        <div class="container my-5">
            <h4>Listado de ventas</h4>


            <asp:GridView ID="grillaVentas" runat="server"></asp:GridView>


        </div>

    </form>

</asp:Content>
