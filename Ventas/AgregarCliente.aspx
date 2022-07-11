﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AgregarCliente.aspx.vb" Inherits="trabajo_final_carrera.AgregarCliente" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Agregar Cliente</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>

<body>
    <form id="formAgregarCliente" runat="server" class="mt-3">

        <div class="container-fluid">
            <asp:Button ID="btnVolver" runat="server" Text="<< Volver" CssClass="btn btn-danger ml-3 mt-4 mb-1"/>
            <label class="form-label row justify-content-center">Nombre Cliente</label>
            <div class="row justify-content-center">
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" MaxLength="13" Width="300px"></asp:TextBox>
            </div>
            <div align="center" class="mb-5">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info m-3 pl-5 pr-5" />
            </div>
        </div>

        <div align="center">

            <asp:GridView ID="grillaProductos" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True" CellSpacing="4" HorizontalAlign="Center" DataKeyNames="ID_Cliente">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                     <asp:CommandField ButtonType="Button" ShowSelectButton="true"/>
                    <asp:BoundField DataField="ID_Cliente" HeaderText="ID_Cliente" SortExpression="ID_Cliente" InsertVisible="False" ReadOnly="True" />
                    <asp:BoundField DataField="DNI" HeaderText="DNI" SortExpression="DNI" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>



            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CADENA %>" SelectCommand="SELECT ID_Cliente,[DNI], [Nombre] FROM [Clientes] WHERE ([Nombre] LIKE '%' + @Nombre + '%')">
                <SelectParameters>
                    <asp:ControlParameter ControlID="txtNombre" DefaultValue="%%" Name="Nombre" PropertyName="Text" Type="String" />
                </SelectParameters>
                
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
