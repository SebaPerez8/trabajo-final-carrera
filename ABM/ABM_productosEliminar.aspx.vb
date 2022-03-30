Public Class ABM_productosEliminar
    Inherits System.Web.UI.Page
    Dim Producto As New Clase_Productos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim valor As Boolean = False
            lblMensajeEliminar.Text = ""
            If valor <> Producto.BuscarProducto(Val(txtCodigoProducto.Text)) Then
                txtCategoria.Text = Producto.Categoria.ToString()
                txtProducto.Text = Producto.Nombre_Producto
                txtPrecio.Text = Producto.Precio_Producto
                txtFecha.Text = Producto.FechaAlta.ToString()
            Else
                lblMensajeEliminar.Text = "No existe ese Producto"
                txtCodigoProducto.Focus()
                txtCodigoProducto.Text = ""
            End If

        Catch ex As Exception
            lblMensajeEliminar.Text = "Hubo un problema al buscar el Producto"
        End Try
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try


            Producto.Codigo_Producto = txtCodigoProducto.Text
            Producto.Eliminar()
            lblMensajeFinal.Text = "Se elimino correctamente el producto"
            Me.LimpiarCajas()
        Catch ex As Exception
            lblMensajeFinal.Text = "No se pudo eliminar  el producto"
        End Try
    End Sub

    Public Sub LimpiarCajas()

        txtProducto.Text = ""
        txtCodigoProducto.Text = ""
        txtPrecio.Text = ""
        txtFecha.Text = ""
        txtCategoria.Text = ""
    End Sub
End Class