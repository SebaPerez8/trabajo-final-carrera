<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="ABM_proveedoresListar.aspx.vb" Inherits="trabajo_final_carrera.ABM_proveedoresListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex justify-content-center">
                <h1 class="m-3 pb-3 text-center">Proveedores</h1>
            </div>
        </div>
    </div>
    
     <div class="pb-3">
        <ul class="nav nav-tabs">
            <li class="nav-item">
                <a class="nav-link active">Listar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_proveedoresCargar.aspx">Cargar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_proveedoresEliminar.aspx">Eliminar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_proveedoresModificar.aspx">Modificar</a>
            </li>
        </ul>
    </div>

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex">
                <h4 class="pb-3">Datos proveedor</h4>
            </div>
        </div>
    </div>

    <form id="formProveedoresListar" runat="server">
       
        <div align="center">
            <asp:Button ID="btnListar" runat="server" Text="Listar" CssClass="btn btn-warning m-5" />
        </div>

        <div class="container my-5">
            <h4>Listado de proveedores</h4>


            <asp:GridView ID="grillaProveedores" runat="server"></asp:GridView>



        </div>

    </form>

</asp:Content>
