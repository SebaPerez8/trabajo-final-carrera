<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="Stock.aspx.vb" Inherits="trabajo_final_carrera.Stock" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex justify-content-center">
                <h1 class="m-3 pb-3 text-center">Compras</h1>
            </div>
        </div>
    </div>

    <div class="pb-3">
        <ul class="nav nav-tabs">
            <li class="nav-item">
                <a class="nav-link active">Stock</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="Proveedores.aspx">Proveedores</a>
            </li>
        </ul>
    </div>

    <form id="formStock" runat="server" class="row g-3">


        <div class="col-md-5 position-relative m-1">
            <label class="form-label">Seleccionar Producto</label>
            <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
        </div>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info pl-3 pr-3 ml-3 mr-3 mt-4 mb-1" />

        <div class="row g-3 mt-3 ml-1">
            <div class="col-md-5 position-relative m-1">
                <label class="form-label">Categoria</label>
                <asp:TextBox ID="txtCategoria" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col-md-3 position-relative m-1">
                <label class="form-label">Precio</label>
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col-md-3 position-relative m-1">
                <label class="form-label">Stock</label>
                <asp:TextBox ID="txtStock" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
        </div>

        <div class="col-md-3 position-relative m-1">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar cambios" CssClass="btn btn-success pl-3 pr-3 mt-4 mb-1 " />
        </div>

        <div class="mx-auto">

            <asp:Button ID="btnListar" runat="server" Text="Listar" CssClass="btn btn-info pl-3 pr-3 mt-4 mb-1 " />

        </div>

        <div class="col-md-3 position-relative m-1">
            <asp:GridView ID="grillaStock" runat="server"></asp:GridView>
        </div>

    </form>


</asp:Content>
