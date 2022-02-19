<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="productos.aspx.vb" Inherits="trabajo_final_carrera.productos" %>
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
    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex">
                <h4 class="pb-3">Datos producto</h4>
            </div>
        </div>
    </div>

    <form id="formProductos" runat="server">
        <div>
            <div class="input-group mb-3">
                <span class="input-group-text">Producto</span>
                <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                <span class="input-group-text">Precio</span>
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                <span class="input-group-text">Foto</span>
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="btn-secondary m-auto p-1"/>
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
            <asp:Button ID="btnCargar" runat="server" Text="Cargar" CssClass="btn btn-primary m-3" />
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-success m-3" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger m-3" />
        </div>

        <div class="container my-5">
            <h4>Listado de productos</h4>


            <asp:GridView ID="grillaProductos" runat="server"></asp:GridView>



        </div>

    </form>
</asp:Content>
