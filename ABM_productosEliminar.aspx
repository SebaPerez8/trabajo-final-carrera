<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="ABM_productosEliminar.aspx.vb" Inherits="trabajo_final_carrera.ABM_productosEliminar" %>

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
                <a class="nav-link active">Eliminar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_productosModificar.aspx">Modificar</a>
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

    <form id="formProductosEliminar" runat="server">
        <div>
            <div class="input-group mb-3">
                <span class="input-group-text">Producto</span>
                <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
            </div>
        </div>
        <div align="center">
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger m-3" />
        </div>


    </form>




</asp:Content>
