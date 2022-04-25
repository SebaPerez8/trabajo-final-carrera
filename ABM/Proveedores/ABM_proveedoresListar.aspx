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
            <asp:Button ID="btnListar" runat="server" Text="Listar" CssClass="btn btn-warning m-5 pl-5 pr-5" />
        </div>

        <div class="container my-5">
            <h4>Listado de proveedores</h4>


            <asp:GridView ID="grillaProveedores" runat="server" AutoGenerateColumns="False" DataKeyNames="Razon Social,CUIT/CUIL" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Razon Social" HeaderText="Razon Social" ReadOnly="True" SortExpression="Razon Social" />
                    <asp:BoundField DataField="CUIT/CUIL" HeaderText="CUIT/CUIL" ReadOnly="True" SortExpression="CUIT/CUIL" />
                    <asp:BoundField DataField="Nombre Fantasia" HeaderText="Nombre Fantasia" SortExpression="Nombre Fantasia" />
                    <asp:BoundField DataField="Direccion de la Empresa" HeaderText="Direccion de la Empresa" SortExpression="Direccion de la Empresa" />
                    <asp:BoundField DataField="Contacto" HeaderText="Contacto" SortExpression="Contacto" />
                    <asp:BoundField DataField="Correo Electronico" HeaderText="Correo Electronico" SortExpression="Correo Electronico" />
                    <asp:BoundField DataField="Fecha Alta" HeaderText="Fecha Alta" SortExpression="Fecha Alta" />
                </Columns>
            </asp:GridView>



            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CADENA %>" SelectCommand="select p.Razon_Social as [Razon Social], p.CUIT as [CUIT/CUIL],p.Nombre_Fantasia as [Nombre Fantasia],p.Direccion as [Direccion de la Empresa], p.Telefono as [Contacto],p.Mail as [Correo Electronico],p.FechaAlta as [Fecha Alta] from Proveedores p order by FechaAlta"></asp:SqlDataSource>



        </div>

    </form>

</asp:Content>
