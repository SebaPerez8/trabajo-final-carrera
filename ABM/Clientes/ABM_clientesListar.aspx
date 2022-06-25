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
            <asp:Button ID="btnListar" runat="server" Text="Listar" CssClass="btn btn-warning m-5 pl-5 pr-5" />
        </div>

        <div class="container my-5">
            <h4>Listado de clientes</h4>


            <asp:GridView ID="grillaClientes" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True">
                <Columns>
                    <asp:BoundField DataField="Documento" HeaderText="Documento" SortExpression="Documento" />
                    <asp:BoundField DataField="Nombre y Apellido" HeaderText="Nombre y Apellido" SortExpression="Nombre y Apellido" />
                    <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                    <asp:BoundField DataField="Celular" HeaderText="Celular" SortExpression="Celular" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                </Columns>
            </asp:GridView>



            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CADENA %>" SelectCommand="select c.DNI as [Documento], C.Nombre as [Nombre y Apellido], C.Direccion as [Direccion], c.Telefono as [Celular],c.Mail as [Email] from Clientes C"></asp:SqlDataSource>



        </div>

    </form>

</asp:Content>
