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
                <a class="nav-link" href="ABM_productosListar.aspx">Listar</a>
            </li>
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
            <div class="m-0 row justify-content-center">
                <span class="input-group-text">Codigo de Producto</span>
                <asp:TextBox ID="txtCodigoProducto" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div align="center" class="mb-5">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info m-3" />
                <br />
                <asp:Label ID="lblMensajeModificar" runat="server"></asp:Label>
            </div>

            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Producto</span>
                <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Label ID="lblNombre" runat="server" Text="Label"></asp:Label>
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Precio</span>
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Label ID="lblPrecio" runat="server" Text="Label"></asp:Label>
            </div>

            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Foto</span>
                <asp:FileUpload ID="fuFoto" runat="server" CssClass="btn-secondary p-1" />
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Categoria</span>
                <asp:DropDownList ID="dplCategoria" runat="server" CssClass="form-control" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="ID_Categoria"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CADENA %>" SelectCommand="SELECT [ID_Categoria], [Nombre] FROM [Categorias] ORDER BY [Nombre]"></asp:SqlDataSource>
            </div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Fecha</span>
                <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" TextMode="DateTime"></asp:TextBox>
                <asp:Label ID="lblFechaAlta" runat="server"></asp:Label>
            </div>
        </div>

        <div align="center">
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-success m-3" />
            <br />
            <asp:Label ID="lblMensajeFinal" runat="server"></asp:Label>
        </div>


    </form>


</asp:Content>
