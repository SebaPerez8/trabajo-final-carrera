<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="NuevaOrden.aspx.vb" Inherits="trabajo_final_carrera.NuevaOrden" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<%-- REVISAR CASO DE SI HAY MAS DE UN EQUIPO EN LA ORDEN --%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex justify-content-center">
                <h1 class="m-3 pb-3 text-center">Sevicio Técnico</h1>
            </div>
        </div>
    </div>


    <form id="formNuevaOrden" runat="server" class="row g-3">

        <div class="container-fluid m-3 mt-5">
            <div class="row">
                <div class="col-sm-12 d-flex">
                    <h4 class="pb-3">Cliente</h4>
                </div>
            </div>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">DNI</label>
            <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" MaxLength="8" ReadOnly="True"></asp:TextBox>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Nombre</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
        </div>

        <asp:Button ID="btnBuscarCliente" runat="server" Text="Buscar Cliente" CssClass="btn btn-info ml-3 mt-4 mb-1" />

        <div class="container-fluid m-3 mt-5">
            <div class="row">
                <div class="col-sm-12 d-flex">
                    <h4 class="pb-3">Detalle del Equipo</h4>
                </div>
            </div>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Equipo</label>
            <asp:TextBox ID="txtEquipo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">N° de Orden</label>
            <asp:TextBox ID="txtOrden" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Descripcion General</label>
            <asp:TextBox ID="txtDescGeneral" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>

        <div class="col-md-4 position-relative m-1">
            <label class="form-label">Desperfecto Declarado</label>
            <asp:TextBox ID="txtDespDeclarado" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>

        <div class="container-fluid m-3 mt-5">


            <asp:Button ID="btnImprimir" runat="server" Text="Imprimir Constancia" CssClass="btn btn-dark m-3 " />
            <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar Nueva Orden" CssClass="btn btn-success m-3" />


        </div>

    </form>

</asp:Content>
