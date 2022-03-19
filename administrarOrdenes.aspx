<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="administrarOrdenes.aspx.vb" Inherits="trabajo_final_carrera.administrarOrdenes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex justify-content-center">
                <h1 class="m-3 pb-3 text-center">Servicio Técnico</h1>
            </div>
        </div>
    </div>

    <form id="formAdminOrdenes" runat="server">

        <div class="input-group mb-3 mt-5">
            <span class="input-group-text">N° de orden</span>
            <asp:TextBox ID="txtOrden" runat="server" CssClass="form-control"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
            <span class="input-group-text">Cliente</span>
            <asp:DropDownList ID="cmbClientes" runat="server" CssClass="form-control"></asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
        </div>
        <div align="center">
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-secondary m-4 pr-5 pl-5" />
        </div>

       

    </form>


























</asp:Content>
