<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="clientes.aspx.vb" Inherits="trabajo_final_carrera.clientes" %>

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
    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 d-flex">
                <h4 class="m-3 pb-3">Datos cliente</h4>
            </div>
        </div>
    </div>
    <div>
        <div class="input-group mb-3">
            <span class="input-group-text">Nombre</span>
            <input type="text" class="form-control" aria-label="Username" aria-describedby="basic-addon1">
            <span class="input-group-text">DNI</span>
            <input type="text" class="form-control" aria-label="Username" aria-describedby="basic-addon1">
        </div>
        <div class="input-group mb-3">
            <span class="input-group-text">Dirección</span>
            <input type="text" class="form-control" aria-label="Username" aria-describedby="basic-addon1">
            <span class="input-group-text">e-mail</span>
            <input type="email" class="form-control" aria-label="Username" aria-describedby="basic-addon1">
        </div>
        <div class="input-group mb-3">
            <span class="input-group-text">Teléfono</span>
            <input type="text" class="form-control" aria-label="Username" aria-describedby="basic-addon1">
        </div>
    </div>
    <div align="center">
        <button type="button" class="btn btn-primary m-3">Listar</button>
        <button type="button" class="btn btn-secondary m-3">Cargar</button>
        <button type="button" class="btn btn-success m-3">Modificar</button>
        <button type="button" class="btn btn-danger m-3">Eliminar</button>
    </div>

    <div class="container my-5">
        <h4>Listado de clientes</h4>

        <div class="table-responsive">
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Nombre</th>
                        <th>DNI</th>
                        <th>Dirección</th>
                        <th>Teléfono</th>
                        <th>e-mail</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td>Juan Perez</td>
                        <td>31654789</td>
                        <td>San Martin 488</td>
                        <td>3518969258</td>
                        <td>juancito@gmail.com</td>
                    </tr>
                    <tr>
                        <td>2</td>
                        <td>Juan Perez</td>
                        <td>31654789</td>
                        <td>San Martin 488</td>
                        <td>3518969258</td>
                        <td>juancito@gmail.com</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>

</asp:Content>
