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
        <div>
            <div class="input-group mb-3">
                <span class="input-group-text">Razón social</span>
                <asp:TextBox ID="txtRazonSocial" runat="server" CssClass="form-control"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                <span class="input-group-text">CUIT/CUIL</span>
                <asp:TextBox ID="txtCUIL" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="input-group mb-3">
                <span class="input-group-text">Localidad/Ciudad</span>
                <asp:TextBox ID="txtLocalidad" runat="server" CssClass="form-control"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                <span class="input-group-text">Correo electrónico</span>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
            </div>
            <div class="input-group mb-3">
                <span class="input-group-text">Contacto principal</span>
                <asp:TextBox ID="txtContacto" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                <span class="input-group-text">Teléfono</span>
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
            </div>
        </div>
        <div align="center">
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-success m-3" />
        </div>   

    </form>


</asp:Content>
