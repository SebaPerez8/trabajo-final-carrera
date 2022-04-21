Public Class ABM_productosModificar
    Inherits System.Web.UI.Page
    Dim Producto As New Clase_Productos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If txtCodigoProducto.Text = "" OrElse IsDBNull(txtCodigoProducto) Then
                lblMensajeModificar.Text = "Debe ingresar un Codigo"
            Else
                Dim valor As Boolean = False
                lblMensajeModificar.Text = ""
                If valor <> Producto.BuscarProducto(Val(txtCodigoProducto.Text)) Then
                    dplCategoria.SelectedValue = Producto.Categoria
                    txtProducto.Text = Producto.Nombre_Producto
                    txtPrecio.Text = Producto.Precio_Producto
                    txtFecha.Text = Producto.FechaAlta.ToString()
                Else
                    lblMensajeModificar.Text = "No existe ese Producto"
                    txtCodigoProducto.Focus()
                    txtCodigoProducto.Text = ""
                End If
            End If


        Catch ex As Exception
            lblMensajeModificar.Text = "Hubo un problema al buscar el Producto"
        End Try

    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim Control As Boolean = True
            If ControldeBlancos(Control) Then

                Producto.Nombre_Producto = txtProducto.Text
                Producto.FechaAlta = txtFecha.Text
                Producto.Precio_Producto = Val(txtPrecio.Text)
                Producto.Categoria = dplCategoria.SelectedValue
                Producto.Codigo_Producto = txtCodigoProducto.Text
                Producto.Modificar()
                lblMensajeFinal.Text = "Se modifico correctamente el producto"
                Me.LimpiarCajas()
            Else
                lblMensajeFinal.Text = "Hay Campos incompletos, porfavor completar"
            End If
        Catch ex As Exception
            lblMensajeFinal.Text = "No se pudo modificar  el producto"
        End Try
    End Sub

    Public Sub LimpiarCajas()

        txtProducto.Text = ""
        txtCodigoProducto.Text = ""
        txtPrecio.Text = ""
        txtFecha.Text = ""
        dplCategoria.SelectedIndex = 1
    End Sub

    Public Function ControldeBlancos(todoOK As Boolean) As Boolean

        If txtProducto.Text = "" OrElse IsDBNull(txtProducto) Then
            todoOK = False
            lblNombre.Text = "Debe completar este campo"
        End If
        If txtFecha.Text = "" OrElse IsDBNull(txtFecha) Then
            todoOK = False
            lblFechaAlta.Text = "Debe completar este campo"
        End If
        If txtPrecio.Text = "" OrElse IsDBNull(txtPrecio) Then
            todoOK = False
            lblPrecio.Text = "Debe completar este campo"
        End If

        Return todoOK
    End Function
End Class