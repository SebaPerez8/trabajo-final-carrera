<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="ABM_proveedoresEliminar.aspx.vb" Inherits="trabajo_final_carrera.ABM_proveedoresEliminar" %>

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
                <a class="nav-link active">Eliminar</a>
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

    <form id="formProveedoresEliminar" runat="server">

        <div>
            <div class="m-0 row justify-content-center">
                <span class="input-group-text">CUIT/CUIL</span>
                <asp:TextBox ID="txtCUIL" runat="server" CssClass="form-control w-50" MaxLength="13"></asp:TextBox>
            </div>
            <div align="center" class="mb-5">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info m-3" />
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Razón social</span>
                <asp:TextBox ID="txtRazonSocial" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Direccion</span>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Correo electrónico</span>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" TextMode="Email" ReadOnly="True"></asp:TextBox>
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Contacto principal</span>
                <asp:TextBox ID="txtContacto" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Teléfono</span>
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TextMode="Phone" ReadOnly="True"></asp:TextBox>
            </div>
        </div>

        <div align="center">
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger m-3" />
        </div>

    </form>


</asp:Content>