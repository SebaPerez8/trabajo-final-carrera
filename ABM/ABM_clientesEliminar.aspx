<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="ABM_clientesEliminar.aspx.vb" Inherits="trabajo_final_carrera.ABM_clientes_eliminar2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>





<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex justify-content-center">
                <h1 class="m-3 pb-3 text-center">Clientes</h1>
            </div>
        </div>
    </div>

    <div class="pb-3">
        <ul class="nav nav-tabs">
            <li class="nav-item">
                <a class="nav-link" href="ABM_clientesListar.aspx">Listar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_clientesCargar.aspx">Cargar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link active">Eliminar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_clientesModificar.aspx">Modificar</a>
            </li>
        </ul>
    </div>

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex">
                <h4 class="pb-3">Datos cliente</h4>
            </div>
        </div>
    </div>


    <form id="formClientesEliminar" runat="server">

        <div>
            <div class="m-0 row justify-content-center">
                <span class="input-group-text">DNI</span>
                <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div align="center" class="mb-5">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info m-3" />
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text" for="txtNombre">Nombre</span>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Dirección</span>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Correo electrónico</span>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Teléfono</span>
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
            </div>
        </div>


        <div align="center">
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger m-3" />
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>

    </form>



</asp:Content>
