<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SeleccionarProducto.aspx.vb" Inherits="trabajo_final_carrera.SeleccionarProducto" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Seleccionar Producto</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>

<body>
   <form id="formSelectProducto" runat="server" class="mt-3">
       
          <div class="container-fluid">
            <asp:Button ID="btnVolver" runat="server" Text="<< Volver" CssClass="btn btn-danger ml-3 mt-4 mb-1"/>
            <label class="form-label row justify-content-center">Producto</label>
            <div class="row justify-content-center">
                <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control" MaxLength="13" Width="300px"></asp:TextBox>
            </div>
            <div align="center" class="mb-5">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info m-3 pl-5 pr-5" />
            </div>
        </div>

       <div align="center">

           <asp:GridView ID="grillaProductos" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID_producto" DataSourceID="SqlDataSource" ForeColor="#333333" GridLines="None">
               <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
               <Columns>
                   <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                   <asp:BoundField DataField="ID_producto" HeaderText="ID_producto" ReadOnly="True" SortExpression="ID_producto" />
                   <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                   <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
                   <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
                   <asp:BoundField DataField="Categoria" HeaderText="Categoria" SortExpression="Categoria" />
               </Columns>
               <EditRowStyle BackColor="#999999" />
               <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
               <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
               <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
               <SortedAscendingCellStyle BackColor="#E9E7E2" />
               <SortedAscendingHeaderStyle BackColor="#506C8C" />
               <SortedDescendingCellStyle BackColor="#FFFDF8" />
               <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
           </asp:GridView>

           <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:CADENA %>" SelectCommand="SELECT p.[ID_producto], p.[Nombre], p.[Precio], sp.Cantidad, c.Nombre AS &quot;Categoria&quot;
FROM [Productos] p
INNER JOIN [Stock_Producto] sp ON p.ID_producto = sp.ID_producto
INNER JOIN [Categorias] c ON p.ID_Categoria = c.ID_Categoria
WHERE (p.[Nombre] LIKE '%' + @Nombre + '%')">
               <SelectParameters>
                   <asp:ControlParameter ControlID="txtProducto" DefaultValue="%%" Name="Nombre" PropertyName="Text" />
               </SelectParameters>
           </asp:SqlDataSource>

        </div>

    </form>
</body>
</html>
