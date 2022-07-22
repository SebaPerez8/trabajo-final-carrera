<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SeleccionarProveedor.aspx.vb" Inherits="trabajo_final_carrera.SeleccionarProveedor" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Seleccionar Proveedor</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>

<body>
    <form id="formSelectProveedor" runat="server" class="mt-3">
       
           <div class="container-fluid">
            <asp:Button ID="btnVolver" runat="server" Text="<< Volver" CssClass="btn btn-danger ml-3 mt-4 mb-1"/>
            <label class="form-label row justify-content-center">Proveedor</label>
            <div class="row justify-content-center">
                <asp:TextBox ID="txtProveedor" runat="server" CssClass="form-control" MaxLength="13" Width="300px"></asp:TextBox>
            </div>
            <div align="center" class="mb-5">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info m-3 pl-5 pr-5" />
            </div>
        </div>

         <div align="center">

             <asp:GridView ID="grillaProveedores" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Razon_Social,CUIT" DataSourceID="SqlDataSource" ForeColor="#333333" GridLines="None">
                 <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                 <Columns>
                     <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                     <asp:BoundField DataField="Razon_Social" HeaderText="Razon Social" ReadOnly="True" SortExpression="Razon_Social" />
                     <asp:BoundField DataField="CUIT" HeaderText="CUIT" ReadOnly="True" SortExpression="CUIT" />
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

             <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:CADENA %>" SelectCommand="SELECT [Razon_Social], [CUIT] FROM [Proveedores] WHERE ([Razon_Social] LIKE '%' + @Razon_Social + '%')">
                 <SelectParameters>
                     <asp:ControlParameter ControlID="txtProveedor" DefaultValue="%%" Name="Razon_Social" PropertyName="Text" Type="String" />
                 </SelectParameters>
             </asp:SqlDataSource>

        </div>

    </form>
</body>
</html>
