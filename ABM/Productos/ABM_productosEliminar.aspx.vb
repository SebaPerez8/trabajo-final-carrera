Public Class ABM_productosEliminar
    Inherits System.Web.UI.Page
    Dim Producto As New Clase_Productos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Control1 As Boolean = True
        Try
            If ControldeBlancosObligatorios(Control1) Then
                If Producto.BuscarProducto(Val(txtCodigoProducto.Text)) Then
                    If Producto.BuscarProducto(Val(txtCodigoProducto.Text)) Then
                        txtCategoria.Text = Producto.Categoria.ToString()
                        txtProducto.Text = (Producto.Nombre_Producto).ToString
                        txtPrecio.Text = Producto.Precio_Producto
                        txtFecha.Text = Producto.FechaAlta.ToString()
                        ' fuFoto=Producto
                    Else
                        MsgBox("Hubo un problema al traer la informacion del Producto", MsgBoxStyle.Exclamation, "AVISO")

                    End If
                Else
                    MsgBox("Ese Producto no existe ", MsgBoxStyle.Exclamation, "AVISO")
                    txtCodigoProducto.Text = ""
                    txtCodigoProducto.Focus()
                End If

            Else
                MsgBox("Es necesario completar el campo Codigo", MsgBoxStyle.Exclamation, "AVISO")

            End If

        Catch ex As Exception

            MsgBox("Hubo un problema, No se pudo Buscar el Producto", MsgBoxStyle.Exclamation, "AVISO")

        End Try

    End Sub

    Public Function ControldeBlancosObligatorios(todoOK As Boolean) As Boolean


        If txtCodigoProducto.Text = "" OrElse IsDBNull(txtCodigoProducto) Then
            todoOK = False

        End If


        Return todoOK
    End Function
    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim ResultadoMensaje As Integer = 0

        ResultadoMensaje = MsgBox("Esta por eliminar un Producto, ¿Desea Continuar?", MsgBoxStyle.YesNo, "AVISO")
        If ResultadoMensaje = 1 OrElse ResultadoMensaje = 6 Then
            Try



                Producto.Eliminar(Val(txtCodigoProducto.Text))
                MsgBox("Se elimino con exito el Producto", MsgBoxStyle.Exclamation, "AVISO")
                LimpiarCajas()
            Catch ex As Exception
                MsgBox("Hubo un problema, No se pudo eliminar el Producto", MsgBoxStyle.Information, "AVISO")
            End Try
        End If
    End Sub

    Public Sub LimpiarCajas()

        txtProducto.Text = ""
        txtCodigoProducto.Text = ""
        txtPrecio.Text = ""
        txtFecha.Text = ""
        txtCategoria.Text = ""
    End Sub
End Class