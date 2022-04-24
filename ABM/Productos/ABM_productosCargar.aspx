<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="ABM_productosCargar.aspx.vb" Inherits="trabajo_final_carrera.productos" %>

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
                <a class="nav-link active">Cargar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_productosEliminar.aspx">Eliminar</a>
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
    <br />
    <br />
    <form id="formProductosCargar" runat="server" class="row g-3">


        <div class="col-md-4 position-relative m-1">
            <label for="txtCodigo" class="form-label">Codigo de Producto</label>
            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" placeholder="0000000001"></asp:TextBox>
            <asp:Label ID="lblProductos" runat="server"></asp:Label>
        </div>
        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Producto</label>
            <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control" placeholder="Memoria USB Kingtone 16GB"></asp:TextBox>
            <asp:Label ID="lblNombre" runat="server"></asp:Label>
        </div>
        <div class="col-md-3 position-relative m-1">
            <label class="form-label">Precio</label>
            <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" placeholder="1000"></asp:TextBox>
            <asp:Label ID="lblPrecio" runat="server"></asp:Label>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Foto</label>
            <asp:FileUpload ID="fuFoto" runat="server" CssClass="btn-secondary p-1" />
            <asp:Label ID="lblfoto" runat="server"></asp:Label>
        </div>
        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Categoria</label>
            <asp:DropDownList ID="dplCategoria" runat="server" CssClass="form-control" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="ID_Categoria"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CADENA %>" SelectCommand="SELECT [Nombre], [ID_Categoria] FROM [Categorias] ORDER BY [Nombre]"></asp:SqlDataSource>
        </div>
        <div class="col-md-3 position-relative m-1">
            <label class="form-label">Fecha</label>
            <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
            <asp:Label ID="lblFecha" runat="server"></asp:Label>
        </div>



        <div class="col-12 m-3" align="center">
            <asp:Button ID="btnCargar" runat="server" Text="Cargar" CssClass="btn btn-success m-3 pl-5 pr-5" />
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>


    </form>

</asp:Content>
