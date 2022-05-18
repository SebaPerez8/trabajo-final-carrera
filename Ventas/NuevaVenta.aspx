﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="NuevaVenta.aspx.vb" Inherits="trabajo_final_carrera.Ventas" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

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
                <a class="nav-link active">Nueva Venta</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ListaVentas.aspx">Listado de Ventas</a>
            </li>
        </ul>
    </div>

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex">
                <h4 class="pb-3">Informacion de Venta</h4>
            </div>
        </div>
    </div>

    <form id="formVentas" runat="server" class="row g-3">

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Id Venta</label>
            <asp:TextBox ID="txtIdVenta" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Fecha</label>
            <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">DNI</label>
            <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" MaxLength="8" ReadOnly="True"></asp:TextBox>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label" for="txtNombre">Nombre</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
        </div>
        <asp:Button ID="btnNuevoCliente" runat="server" Text="Nuevo Cliente" CssClass="btn btn-info ml-3 mt-4 mb-1" />
        <asp:Button ID="btnBuscarCliente" runat="server" Text="Buscar Cliente" CssClass="btn btn-info ml-3 mt-4 mb-1" />
        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Método de pago</label>
            <asp:DropDownList ID="dplMetodo" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>


        <div class="container-fluid m-3 mt-5">
            <div class="row">
                <div class="col-sm-12 d-flex">
                    <h4 class="pb-3">Detalle del Producto</h4>
                </div>
            </div>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Producto</label>
            <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Codigo</label>
            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
        </div>
        <asp:Button ID="btnBuscarProducto" runat="server" Text="Buscar Producto" CssClass="btn btn-info ml-3 mt-4 mb-1" />

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Precio unitario</label>
            <asp:TextBox ID="txtPrecioUnitario" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Cantidad</label>
            <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Monto Total</label>
            <asp:TextBox ID="txtMontoTotal" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
        </div>


        <div class="container-fluid m-3 mt-5">
            <asp:GridView ID="GrillaVentas" runat="server">
                <Columns>
                    <asp:BoundField HeaderText="Id Venta" />
                    <asp:BoundField HeaderText="Producto" />
                    <asp:BoundField HeaderText="Cantidad" />
                    <asp:BoundField HeaderText="Precio unitario" />
                    <asp:BoundField HeaderText="Precio Total" />
                </Columns>
            </asp:GridView>
        </div>




        <div class="container-fluid m-3 mt-5">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-success m-3" />

            <asp:Button ID="btnQuitar" runat="server" Text="Quitar" CssClass="btn btn-danger m-3 " />
            <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar Venta" CssClass="btn btn-dark m-3" />

            <asp:Button ID="btnImprimir" runat="server" Text="Imprimir Comprobante" CssClass="btn btn-warning m-3" ForeColor="Black" />
        </div>
    </form>


</asp:Content>
