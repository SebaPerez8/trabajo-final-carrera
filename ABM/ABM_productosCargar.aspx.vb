
Public Class productos
    Inherits System.Web.UI.Page
    Dim Producto As New Clase_Productos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'txtFecha.text= datetime.now

        LimpiarMensajes()
    End Sub



    Protected Sub btnCargar_Click1(sender As Object, e As EventArgs) Handles btnCargar.Click

        Dim Control As Boolean = True
        If ControldeBlancos(Control) Then
            Producto.Precio_Producto = Val(txtPrecio.Text)
            Producto.Nombre_Producto = txtProducto.Text
            Producto.Categoria = dplCategoria.SelectedValue
            Producto.FechaAlta = txtFecha.Text
            Producto.Codigo_Producto = Val(txtCodigo.Text)
            Try
                If Not Producto.ControlExistencia(Val(txtCodigo.Text)) Then
                    Producto.Grabar()
                    lblMensaje.Text = "Se grabo con exito el producto"
                    LimpiarFromProducto()
                Else
                    lblMensaje.Text = "Ese producto ya existe en la base de Datos"
                    txtCodigo.Focus()
                End If


            Catch ex As Exception
                lblMensaje.Text = "Hubo un problema,  No se pudo grabar el Producto"

            End Try
        Else
            lblMensaje.Text = "Existen campos incompletos"
        End If


    End Sub

    Public Sub LimpiarFromProducto()
        txtPrecio.Text = ""
        txtProducto.Text = ""
        txtCodigo.Text = ""
        txtFecha.Text = ""
    End Sub

    Public Function ControldeBlancos(todoOK As Boolean) As Boolean


        If txtCodigo.Text = "" OrElse IsDBNull(txtCodigo) Then
            todoOK = False
            lblProductos.Text = "Debe completar este campo"
        End If
        If txtProducto.Text = "" OrElse IsDBNull(txtProducto) Then
            todoOK = False
            lblNombre.Text = "Debe completar este campo"
        End If
        If txtFecha.Text = "" OrElse IsDBNull(txtFecha) Then
            todoOK = False
            lblFecha.Text = "Debe completar este campo"
        End If
        If txtPrecio.Text = "" OrElse IsDBNull(txtPrecio) Then
            todoOK = False
            lblPrecio.Text = "Debe completar este campo"
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
End Class