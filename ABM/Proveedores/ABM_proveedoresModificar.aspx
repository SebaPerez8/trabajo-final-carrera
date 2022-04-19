<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="ABM_proveedoresModificar.aspx.vb" Inherits="trabajo_final_carrera.ABM_proveedoresModificar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex justify-content-center">
                <h1 class="m-3 pb-3 text-center">Proveedores</h1>
            </div>
        </div>
    </div>

    <div class="pb-3">
        <ul class="nav nav-tabs">
            <li class="nav-item">
                <a class="nav-link" href="ABM_proveedoresListar.aspx">Listar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_proveedoresCargar.aspx">Cargar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_proveedoresEliminar.aspx">Eliminar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link active">Modificar</a>
            </li>
        </ul>
    </div>

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex">
                <h4 class="pb-3">Datos proveedor</h4>
            </div>
        </div>
    </div>

    <form id="formProveedoresModificar" runat="server">


        <div class="m-0 row justify-content-center">
            <span class="input-group-text">CUIT/CUIL</span>
            <asp:TextBox ID="txtCUIL" runat="server" CssClass="form-control w-50" MaxLength="13"></asp:TextBox>
        </div>
        <div align="center" class="mb-5">
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info m-3" />
        </div>
        <div class="input-group mb-3 w-50">
            <span class="input-group-text">Razón social</span>
            <asp:TextBox ID="txtRazonSocial" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="lblRazon" runat="server"></asp:Label>
        </div>
        <div class="input-group mb-3 w-50">
            <span class="input-group-text">Direccion</span>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="lblDireccion" runat="server"></asp:Label>
        </div>
        <div class="input-group mb-3 w-50">
            <span class="input-group-text">Correo electrónico</span>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
            <asp:Label ID="lblCorreo" runat="server"></asp:Label>
        </div>
        <div class="input-group mb-3 w-50">
            <span class="input-group-text">Contacto principal</span>
            <asp:TextBox ID="txtContacto" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="lblContacto" runat="server"></asp:Label>
        </div>
        <div class="input-group mb-3 w-50">
            <span class="input-group-text">Teléfono</span>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
            <asp:Label ID="lblTelefono" runat="server"></asp:Label>
        </div>
        <div class="input-group mb-3 w-50">
            <span class="input-group-text">Nombre Fantasia</span>
            <asp:TextBox ID="txtNombreFantasia" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
            <asp:Label ID="lblNombreFantasia" runat="server"></asp:Label>
        </div>


        <div align="center">
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-success m-3" />
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>

    </form>


</asp:Content>
