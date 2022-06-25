<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="Reparacion.aspx.vb" Inherits="trabajo_final_carrera.Reparacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex justify-content-center">
                <h1 class="m-3 pb-3 text-center">Servicio Técnico</h1>
            </div>
        </div>
    </div>

     <div class="pb-3">
        <ul class="nav nav-tabs">
            <li class="nav-item">
                <a class="nav-link" href="AdministrarOrdenes.aspx">Entrada</a>
            </li>
            <li class="nav-item">
                <a class="nav-link active">Reparacion</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="Salida.aspx">Salida</a>
            </li>
        </ul>
    </div>

    <form id="formReparacion" runat="server" class="row g-3">

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">N° de orden</label>
            <asp:TextBox ID="txtOrden" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="lblOrden" runat="server" ForeColor="#AA0610"></asp:Label>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Nombre Cliente</label>
            <asp:TextBox ID="txtCliente" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="lblCliente" runat="server" ForeColor="#AA0610"></asp:Label>
        </div>

        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info ml-3 mt-4 mb-1" />




    </form>

</asp:Content>
