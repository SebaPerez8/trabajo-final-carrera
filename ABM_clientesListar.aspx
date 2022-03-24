<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="ABM_clientesListar.aspx.vb" Inherits="trabajo_final_carrera.ABM_clientesListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex justify-content-center">
                <h1 class="m-3 pb-3 text-center">Clientes</h1>
            </div>
        </div>
    </div>

    <div class="pb-3">
        <ul class="nav nav-tabs">
             <li class="nav-item">
                <a class="nav-link active">Listar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_clientesCargar.aspx">Cargar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_clientesEliminar.aspx">Eliminar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ABM_clientesModificar.aspx">Modificar</a>
            </li>
        </ul>
    </div>

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex">
                <h4 class="pb-3">Datos cliente</h4>
            </div>
        </div>
    </div>


    <form id="formClientesListar" runat="server">
           
        <div align="center">
            <asp:Button ID="btnListar" runat="server" Text="Listar" CssClass="btn btn-warning m-5" />
        </div>

        <div class="container my-5">
            <h4>Listado de clientes</h4>


            <asp:GridView ID="grillaClientes" runat="server"></asp:GridView>



        </div>

    </form>

</asp:Content>
