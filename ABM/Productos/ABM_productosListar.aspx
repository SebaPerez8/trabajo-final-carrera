<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="ABM_productosListar.aspx.vb" Inherits="trabajo_final_carrera.ABM_productosListar" %>

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
                <a class="nav-link active" href="ABM_productosModificar.aspx">Listar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_productosCargar.aspx">Cargar</a>
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

    <form id="formProductosListar" runat="server">

        <div align="center">
            <asp:Button ID="btnListar" runat="server" Text="Listar" CssClass="btn btn-warning m-5 pl-5 pr-5" />
        </div>

        <div class="container my-5">
            <h4>Listado de productos</h4>


            <asp:GridView ID="grillaProductos" runat="server" AutoGenerateColumns="False" DataKeyNames="Codigo de Producto" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True">
                <Columns>
                    <asp:BoundField DataField="Codigo de Producto" HeaderText="Codigo de Producto" ReadOnly="True" SortExpression="Codigo de Producto" />
                    <asp:BoundField DataField="Nombre del Producto" HeaderText="Nombre del Producto" SortExpression="Nombre del Producto" />
                    <asp:BoundField DataField="Nombre de Categoria" HeaderText="Nombre de Categoria" SortExpression="Nombre de Categoria" />
                    <asp:BoundField DataField="Precio del Producto" HeaderText="Precio del Producto" SortExpression="Precio del Producto" />
                    <asp:BoundField DataField="Fecha de Alta" HeaderText="Fecha de Alta" SortExpression="Fecha de Alta" />
                </Columns>
            </asp:GridView>



            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CADENA %>" SelectCommand="Select p.ID_producto as [Codigo de Producto], 
                                p.Nombre as [Nombre del Producto],
                                c.Nombre as [Nombre de Categoria],
                                p.Precio as [Precio del Producto],
                                p.FechaAlta as [Fecha de Alta]
                                from Productos p
                                inner join Categorias c on p.Id_Categoria=c.ID_Categoria
                                order by p.Id_Categoria"></asp:SqlDataSource>



        </div>

    </form>



</asp:Content>
