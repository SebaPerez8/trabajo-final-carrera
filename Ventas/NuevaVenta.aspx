<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="NuevaVenta.aspx.vb" Inherits="trabajo_final_carrera.Ventas" %>

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



    <form id="formVentas" runat="server" class="row g-3">

        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-12 d-flex">
                    <h4 class="pb-3">Informacion de Venta</h4>
                </div>
            </div>
        </div>

        <div class="col-md-4 position-relative m-1">

            <label class="form-label">Producto</label>
            <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control"></asp:TextBox>

            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-success m-3" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnQuitar" runat="server" Text="Quitar" CssClass="btn btn-danger m-3 " />

            <div>
                <br />
                <label class="form-label">Precio Total</label>
                <br />
                <div class="input-group">
                    <span class="input-group-text">$</span>
                    <asp:TextBox ID="txtPrecioTotal" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
        </div>

        <asp:ListBox ID="lstProductos" runat="server" Width="450px" CssClass="form-control m-3">
            <asp:ListItem></asp:ListItem>

        </asp:ListBox>

        <div class="position-relative m-3">
            <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar Venta" CssClass="btn btn-dark m-3" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnImprimir" runat="server" Text="Imprimir Comprobante" CssClass="btn btn-warning m-3" ForeColor="Black" />
        </div>
        <br />

        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-12 d-flex">
                    <h4 class="pb-3">Informacion de Cliente</h4>
                </div>
            </div>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label" for="txtNombre">Nombre</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>

        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">DNI</label>
            <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" MaxLength="8"></asp:TextBox>

        </div>

        <div class="m-3">
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Cliente" CssClass="btn btn-info m-3" />
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Correo electrónico</label>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" TextMode="Email" placeholder="correo@emaill.com"></asp:TextBox>

        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Teléfono</label>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TextMode="Phone" MaxLength="10"></asp:TextBox>


        </div>

    </form>


</asp:Content>
