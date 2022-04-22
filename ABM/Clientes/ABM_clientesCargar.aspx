<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="ABM_clientesCargar.aspx.vb" Inherits="trabajo_final_carrera.clientes" %>

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
                <a class="nav-link active">Cargar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_clientesEliminar.aspx">Eliminar</a>
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
    <br />
    <br />

    <form id="formClientesCargar" runat="server">
        <div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text" for="txtNombre">Nombre</span>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="José Pérez"></asp:TextBox>
                <asp:Label ID="lblNombre" runat="server"></asp:Label>
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">DNI</span>
                <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" placeholder="17749563"></asp:TextBox>
                <asp:Label ID="lblDNI" runat="server"></asp:Label>
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Dirección</span>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" placeholder="Alem 952"></asp:TextBox>
                <asp:Label ID="lblDireccion" runat="server"></asp:Label>
            </div>
             <div class="input-group mb-3 w-50">
                 <span class="input-group-text">Correo electrónico</span>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" TextMode="Email" placeholder="correo@emaill.com"></asp:TextBox>
                 <asp:Label ID="lblCorreo" runat="server"></asp:Label>
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Teléfono</span>
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TextMode="Phone" placeholder="2976999028"></asp:TextBox>
                <asp:Label ID="lblTelefono" runat="server"></asp:Label>
                <br />
            </div>
        </div>


        <div align="center">
            <asp:Button ID="btnCargar" runat="server" Text="Cargar" CssClass="btn btn-primary m-3" />
            <br />
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>


    </form>

</asp:Content>
