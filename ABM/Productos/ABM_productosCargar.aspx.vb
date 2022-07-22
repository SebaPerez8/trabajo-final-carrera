
Public Class productos
    Inherits System.Web.UI.Page
    Dim Producto As New Clase_Productos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LimpiarMensajes()
    End Sub



    Protected Sub btnCargar_Click1(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim ResultadoMensaje As Integer = 0
        Dim Control1 As Boolean = True
        Dim Control2 As Boolean = False
        Dim Existen As Boolean = True

        'COntrol Obligatorios:

        If ControldeBlancosObligatorio(Control1) Then
            If Existen = ControldeBlancos(Control2) Then
                ResultadoMensaje = MsgBox("Existen campos incompletos, ¿Desea Continuar?", MsgBoxStyle.YesNo, "AVISO")
                If ResultadoMensaje = 1 OrElse ResultadoMensaje = 6 Then
                    'guarda sin importar q exista campos nulos.
                    Producto.Precio_Producto = Convert.ToDecimal(Val(txtPrecio.Text))
                    Producto.Nombre_Producto = txtProducto.Text
                    Producto.Categoria = dplCategoria.SelectedValue

                    If txtFecha.Text = "" Then
                        Producto.FechaAlta = DateTime.Now().ToShortDateString
                        txtFecha.Text = Producto.FechaAlta
                    End If
                    Producto.FechaAlta = txtFecha.Text
                    Producto.Codigo_Producto = Val(txtCodigo.Text)
                    'Producto.foto
                    Try
                        If Not Producto.ControlExistencia(Val(txtCodigo.Text)) Then
                            Producto.Grabar()
                            MsgBox("Se grabo con exito el Producto", MsgBoxStyle.Information, "AVISO")
                            LimpiarFromProducto()
                        Else
                            MsgBox("Ese producto ya existe en la base de Datos", MsgBoxStyle.Exclamation, "AVISO")
                            txtCodigo.Focus()
                        End If
                    Catch ex As Exception
                        MsgBox("Hubo un problema, No se pudo grabar el Producto", MsgBoxStyle.Exclamation, "AVISO")
                    End Try




                Else
                    'aviso de campos nulos
                    AvisoBlancos()
                End If
            Else
                'no tiene campos nulos en el cargar
                Producto.Precio_Producto = Val(txtPrecio.Text)
                Producto.Nombre_Producto = txtProducto.Text
                Producto.Categoria = dplCategoria.SelectedValue
                If txtFecha.Text = "" Then
                    Producto.FechaAlta = DateTime.Now().ToShortDateString
                    txtFecha.Text = Producto.FechaAlta
                End If
                Producto.FechaAlta = txtFecha.Text
                Producto.Codigo_Producto = Val(txtCodigo.Text)
                'Producto.foto
                Try
                    If Not Producto.ControlExistencia(Val(txtCodigo.Text)) Then
                        Producto.Grabar()
                        MsgBox("Se grabo con exito el Producto", MsgBoxStyle.Information, "AVISO")
                        LimpiarFromProducto()
                    Else
                        MsgBox("Ese producto ya existe en la base de Datos", MsgBoxStyle.Exclamation, "AVISO")
                        txtCodigo.Focus()
                    End If
                Catch ex As Exception
                    MsgBox("Hubo un problema, No se pudo grabar el Producto", MsgBoxStyle.Exclamation, "AVISO")
                End Try
            End If
        Else
            lblMensaje.Text = "Existen campos Obligatorios incompletos"
        End If
    End Sub
    Public Sub AvisoBlancos()
        If txtFecha.Text = "" OrElse IsDBNull(txtFecha) OrElse txtFecha.Text = " " Then

            lblFecha.Text = "Este campo esta Incompleto"
        End If
        If txtPrecio.Text = "" OrElse IsDBNull(txtPrecio) OrElse txtPrecio.Text = " " Then

            lblPrecio.Text = "Este campo esta Incompleto"
        End If

        If IsDBNull(fuFoto) Then

            lblFoto.Text = "Este campo esta Incompleto"
        End If
        'faltaria controlar el campo foto, mas adelante.


    End Sub
    Public Sub LimpiarFromProducto()
        txtPrecio.Text = ""
        txtProducto.Text = ""
        txtCodigo.Text = ""
        txtFecha.Text = ""
    End Sub

    Public Function ControldeBlancos(todoOK As Boolean) As Boolean



        If txtFecha.Text = "" OrElse IsDBNull(txtFecha) Then
            todoOK = True
            'lblFecha.Text = "Debe completar este campo"
        End If
        If txtPrecio.Text = "" OrElse IsDBNull(txtPrecio) Then
            todoOK = True
            'lblPrecio.Text = "Debe completar este campo"
        End If
        If IsDBNull(fuFoto) Then
            todoOK = True
        End If
        Return todoOK
    End Function

    Public Sub LimpiarMensajes()
        lblMensaje.Text = ""
        lblProductos.Text = ""
        lblPrecio.Text = ""
        lblNombre.Text = ""
        lblFecha.Text = ""
    End Sub


    Public Function ControldeBlancosObligatorio(todoOK As Boolean) As Boolean


        If txtCodigo.Text = "" OrElse IsDBNull(txtCodigo) Then
            todoOK = False
            txtCodigo.CssClass = txtCodigo.CssClass + " is-invalid"
            lblProductos.Text = "Debe completar este campo"
        End If
        If txtProducto.Text = "" OrElse IsDBNull(txtProducto) Then
            todoOK = False
            txtProducto.CssClass = txtProducto.CssClass + " is-invalid"
            lblNombre.Text = "Debe completar este campo"
        End If

        Return todoOK
    End Function
End Class