<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="ABM_proveedoresCargar.aspx.vb" Inherits="trabajo_final_carrera.proveedores" %>

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
                <a class="nav-link active">Cargar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_proveedoresEliminar.aspx">Eliminar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_proveedoresModificar.aspx">Modificar</a>
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
    <br />
    <br />

    <form id="formProveedoresCargar" runat="server">


        <div class="input-group mb-3 w-50">
            <span class="input-group-text">Razón social</span>
            <asp:TextBox ID="txtRazonSocial" runat="server" CssClass="form-control" ></asp:TextBox>
            <asp:Label ID="lblRazon" runat="server" ForeColor="#CC0000"></asp:Label>
        </div>

        <div class="input-group mb-3 w-50">
            <span class="input-group-text">CUIT/CUIL</span>
            <asp:TextBox ID="txtCUIL" runat="server" CssClass="form-control" MaxLength="13"></asp:TextBox>
            <asp:Label ID="lblCUIT" runat="server"></asp:Label>
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
            <span class="input-group-text">Fecha de alta</span>
            <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
            <asp:Label ID="lblFecha" runat="server"></asp:Label>
        </div>
        <div class="input-group mb-3 w-50">
            <span class="input-group-text">Contacto Principal</span>
            <asp:TextBox ID="txtContacto" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="lblContacto" runat="server"></asp:Label>
        </div>
        <div class="input-group mb-3 w-50">
            <span class="input-group-text">Teléfono</span>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TextMode="Phone" MaxLength="13"></asp:TextBox>
            <asp:Label ID="lblTelefono" runat="server"></asp:Label>
        </div>
        <div class="input-group mb-3 w-50">
            <span class="input-group-text">Nombre Fantasia</span>
            <asp:TextBox ID="txtNombreFantasia" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
            <asp:Label ID="lblNombreFantasia" runat="server"></asp:Label>
        </div>


        <div align="center">
            <asp:Button ID="btnCargar" runat="server" Text="Cargar" CssClass="btn btn-primary m-3" />
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>


    </form>
</asp:Content>
