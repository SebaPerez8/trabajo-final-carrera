<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="Ventas.aspx.vb" Inherits="trabajo_final_carrera.Ventas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex justify-content-center">
                <h1 class="m-3 pb-3 text-center">Ventas</h1>
            </div>
        </div>
    </div>


    <form id="formVentas" runat="server">

        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-12 d-flex">
                    <h4 class="pb-3">Informacion de Venta</h4>
                </div>
            </div>
        </div>

        <div>
            <div class="input-group mb-3 w-50">
                <span class="input-group-text" for="txtNombre">Producto</span>
                <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <div>
                $ <asp:Label ID="lblProducto" runat="server" Text="Precio" BorderStyle="Solid" BorderColor="Black" Width="200px"></asp:Label>
            </div>
            <br />
            <div class="input-group mb-3 w-50">
                <span class="input-group-text">Cantidad</span>
                <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                $ <asp:Label ID="lblPrecioTotal" runat="server" Text="Total"  BorderStyle="Solid" BorderColor="Black" Width="200px"></asp:Label>
            </div>
        </div>

         <div class="container-fluid">
            <div class="row">
                <div class="col-sm-12 d-flex">
                    <h4 class="pb-3">Informacion de Cliente</h4>
                </div>
            </div>
        </div>


    </form>


</asp:Content>
