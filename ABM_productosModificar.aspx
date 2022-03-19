<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="ABM_productosModificar.aspx.vb" Inherits="trabajo_final_carrera.ABM_productosModificar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex justify-content-center">
                <h1 class="m-3 pb-3 text-center">Productos</h1>
            </div>
        </div>
    </div>

    <div class="pb-3">
        <ul class="nav nav-tabs">
            <li class="nav-item">
                <a class="nav-link" href="ABM_productosCargar.aspx">Cargar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_productosEliminar.aspx">Eliminar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link active">Modificar</a>
            </li>
        </ul>
    </div>

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex">
                <h4 class="pb-3">Datos producto</h4>
            </div>
        </div>
    </div>

    <form id="formProductosModificar" runat="server">
        <div>
            <div class="input-group mb-3">
                <span class="input-group-text">Producto</span>
                <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                <span class="input-group-text">Precio</span>
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                <span class="input-group-text">Foto</span>
                <asp:FileUpload ID="fuFoto" runat="server" CssClass="btn-secondary m-auto p-1" />
            </div>
            <div class="input-group mb-3">
                <span class="input-group-text">Categoria</span>
                <asp:TextBox ID="txtCategoria" runat="server" CssClass="form-control"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                <span class="input-group-text">Fecha</span>
                <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
            </div>
        </div>
        <div align="center">
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-success m-3" />
        </div>


    </form>


</asp:Content>
