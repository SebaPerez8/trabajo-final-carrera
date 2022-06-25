<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="ABM_clientesModificar.aspx.vb" Inherits="trabajo_final_carrera.ABM_clientesCargar" %>

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
                <a class="nav-link" href="ABM_clientesEliminar.aspx">Eliminar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link active">Modificar</a>
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


    <form id="formClientesModificar" runat="server" class="row g-3">

        <div class="container-fluid">
            <label class="form-label row justify-content-center">DNI</label>
            <div class="row justify-content-center">
                <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" MaxLength="8" Width="300px"></asp:TextBox>
            </div>
            <div align="center" class="mb-5">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info m-3 pl-5 pr-5" />
            </div>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label" for="txtNombre">Nombre</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="lblNombre" runat="server" ForeColor="#AA0610"></asp:Label>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Dirección</label>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="lblDireccion" runat="server" ForeColor="#AA0610"></asp:Label>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Correo electrónico</label>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" TextMode="Email" placeholder="correo@email.com"></asp:TextBox>
            <asp:Label ID="lblCorreo" runat="server" ForeColor="#AA0610"></asp:Label>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Teléfono</label>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TextMode="Phone" MaxLength="10"></asp:TextBox>
            <asp:Label ID="lblTelefono" runat="server" ForeColor="#AA0610"></asp:Label>
        </div>


        <div class="col-12 m-3" align="center">
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-primary m-3 pl-5 pr-5" />
            <br />
            <asp:Label ID="lblMensaje" runat="server" Font-Size="Large" ForeColor="#AA0610"></asp:Label>
        </div>


    </form>


</asp:Content>
