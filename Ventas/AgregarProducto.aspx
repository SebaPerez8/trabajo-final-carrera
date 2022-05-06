<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AgregarProducto.aspx.vb" Inherits="trabajo_final_carrera.AgregarProducto" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Agregar Producto</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>

<body>
    <form id="formAgregarProducto" runat="server" class="mt-3">

        <div class="container-fluid">
            <label class="form-label row justify-content-center">Producto</label>
            <div class="row justify-content-center">
                <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control" MaxLength="13" Width="300px"></asp:TextBox>
            </div>
            <div align="center" class="mb-5">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info m-3 pl-5 pr-5" />
            </div>
        </div>

        <div align="center">

            <asp:GridView ID="grillaProductos" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_producto" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True" CellSpacing="4" HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                    <asp:BoundField DataField="ID_producto" HeaderText="ID_producto" ReadOnly="True" SortExpression="ID_producto" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
                    <asp:BoundField DataField="FechaAlta" HeaderText="FechaAlta" SortExpression="FechaAlta" />
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



            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CADENA %>" SelectCommand="SELECT [ID_producto], [Nombre], [Precio], [FechaAlta] FROM [Productos] WHERE ([Nombre] LIKE '%' + @Nombre + '%') ORDER BY [ID_producto]">
                <SelectParameters>
                    <asp:ControlParameter ControlID="txtProducto" DefaultValue="%%" Name="Nombre" PropertyName="Text" Type="String" />
                </SelectParameters>
                
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>


<%--<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Codigo de Producto" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ButtonType="Link" ShowSelectButton="True" />
                    <asp:BoundField DataField="Codigo de Producto" HeaderText="Codigo de Producto" ReadOnly="True" SortExpression="Codigo de Producto" />
                    <asp:BoundField DataField="Nombre del Producto" HeaderText="Nombre del Producto" SortExpression="Nombre del Producto" />
                    <asp:BoundField DataField="Nombre de Categoria" HeaderText="Nombre de Categoria" SortExpression="Nombre de Categoria" />
                    <asp:BoundField DataField="Precio del Producto" HeaderText="Precio del Producto" SortExpression="Precio del Producto" />
                    <asp:BoundField DataField="Fecha de Alta" HeaderText="Fecha de Alta" SortExpression="Fecha de Alta" />
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



            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CADENA %>" SelectCommand="Select p.ID_producto as [Codigo de Producto], 
                                p.Nombre as [Nombre del Producto],
                                c.Nombre as [Nombre de Categoria],
                                p.Precio as [Precio del Producto],
                                p.FechaAlta as [Fecha de Alta]
                                from Productos p
                                inner join Categorias c on p.Id_Categoria=c.ID_Categoria
                                order by p.Id_Categoria"></asp:SqlDataSource>--%>