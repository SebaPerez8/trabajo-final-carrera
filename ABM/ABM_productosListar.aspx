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
            <asp:Button ID="btnListar" runat="server" Text="Listar" CssClass="btn btn-warning m-5" />
        </div>

        <div class="container my-5">
            <h4>Listado de productos</h4>


            <asp:GridView ID="grillaProductos" runat="server"></asp:GridView>



        </div>

    </form>



</asp:Content>
