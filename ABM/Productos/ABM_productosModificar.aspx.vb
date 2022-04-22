Public Class ABM_productosModificar
    Inherits System.Web.UI.Page
    Dim Producto As New Clase_Productos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try


            Dim Control1 As Boolean = True
            If ControldeBlancosObligatorios(Control1) Then
                If Producto.BuscarProducto(Val(txtCodigoProducto.Text)) Then
                    If Producto.BuscarProducto(Val(txtCodigoProducto.Text)) Then
                        dplCategoria.SelectedValue = Producto.Categoria.ToString()
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
    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim ResultadoMensaje As Integer = 0
        Dim Control1 As Boolean = True
        Dim Control2 As Boolean = False
        Dim Existen As Boolean = True


        If Existen = ControldeBlancos(Control2) Then
            ResultadoMensaje = MsgBox("Existen campos incompletos, ¿Desea Continuar?", MsgBoxStyle.YesNo, "AVISO")
            If ResultadoMensaje = 1 OrElse ResultadoMensaje = 6 Then
                'guarda sin importar q exista campos nulos.

                Try
                    Producto.Precio_Producto = Val(txtPrecio.Text)
                    Producto.Nombre_Producto = txtProducto.Text
                    Producto.Categoria = dplCategoria.SelectedValue
                    Producto.FechaAlta = txtFecha.Text
                    Producto.Codigo_Producto = Val(txtCodigoProducto.Text)
                    'Producto.foto

                    Producto.Modificar()
                    MsgBox("Se modifico con exito el Producto", MsgBoxStyle.Information, "AVISO")
                    LimpiarCajas()
                Catch ex As Exception
                    MsgBox("Hubo un problema, No se pudo modificar el Producto", MsgBoxStyle.Exclamation, "AVISO")
                End Try

            Else
                'aviso de campos nulos
                AvisoBlancos()
            End If
        Else

            Try
                Producto.Precio_Producto = Val(txtPrecio.Text)
                Producto.Nombre_Producto = txtProducto.Text
                Producto.Categoria = dplCategoria.SelectedValue
                Producto.FechaAlta = txtFecha.Text
                Producto.Codigo_Producto = Val(txtCodigoProducto.Text)
                'Producto.foto

                Producto.Modificar()
                MsgBox("Se modifico con exito el Producto", MsgBoxStyle.Information, "AVISO")
                LimpiarCajas()
            Catch ex As Exception
                MsgBox("Hubo un problema, No se pudo modificar el Producto", MsgBoxStyle.Exclamation, "AVISO")
            End Try
        End If
    End Sub
    Public Sub AvisoBlancos()
        If txtFecha.Text = "" OrElse IsDBNull(txtFecha) OrElse txtFecha.Text = " " Then

            lblFechaAlta.Text = "Este campo esta Incompleto"
        End If
        If txtPrecio.Text = "" OrElse IsDBNull(txtPrecio) OrElse txtPrecio.Text = " " Then

            lblPrecio.Text = "Este campo esta Incompleto"
        End If
        If txtProducto.Text = "" OrElse IsDBNull(txtProducto) OrElse txtProducto.Text = " " Then

            lblNombre.Text = "Este campo esta Incompleto"
        End If

        If IsDBNull(fuFoto) Then

            lblPrecio.Text = "Este campo esta Incompleto"
        End If


    End Sub
    Public Sub LimpiarFromProducto()
        txtPrecio.Text = ""
        txtProducto.Text = ""

        txtFecha.Text = ""
    End Sub



    Public Sub LimpiarMensajes()
        lblMensaje.Text = ""
        lblNombre.Text = ""
        lblPrecio.Text = ""
        lblNombre.Text = ""
        lblFechaAlta.Text = ""
    End Sub


    Public Function ControldeBlancosObligatorio(todoOK As Boolean) As Boolean

        If txtProducto.Text = "" OrElse IsDBNull(txtProducto) Then
            todoOK = False
            lblNombre.Text = "Debe completar este campo"
        End If

        Return todoOK
    End Function

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