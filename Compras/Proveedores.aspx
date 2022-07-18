<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="Proveedores.aspx.vb" Inherits="trabajo_final_carrera.Proveedores1" %>

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
                <a class="nav-link" href="Stock.aspx">Stock</a>
            </li>
            <li class="nav-item">
                <a class="nav-link active">Proveedores</a>
            </li>
        </ul>
    </div>

    <form id="formProveedoresCompras" runat="server" class="row g-3">

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Seleccionar Proveedor</label>
            <asp:TextBox ID="txtProveedor" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
        </div>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info pl-3 pr-3 ml-3 mr-3 mt-4 mb-1" />


        <div class="col-md-3 position-relative m-1">
            <label class="form-label">Recibo de Compra</label>
            <asp:TextBox ID="txtRecibo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar cambios" CssClass="btn btn-success pl-3 pr-3 ml-3 mr-3 mt-4 mb-1" />


    </form>

</asp:Content>
