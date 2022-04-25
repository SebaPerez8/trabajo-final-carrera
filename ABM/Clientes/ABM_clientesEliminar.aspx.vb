Public Class ABM_clientes_eliminar2
    Inherits System.Web.UI.Page
    Dim Clientes As New Clase_Clientes
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Control1 As Boolean = True
        Try
            If ControldeBlancosObligatorios(Control1) Then
                If Clientes.BuscarProducto(Val(txtDNI.Text)) Then
                    If Clientes.BuscarProducto(Val(txtDNI.Text)) Then
                        'txtDNI.Text = Clientes.DNI.ToString()
                        txtDireccion.Text = (Clientes.Direccion).ToString
                        txtNombre.Text = Clientes.Nombre_Cliente
                        txtTelefono.Text = Clientes.Telefono.ToString()
                        txtCorreo.Text = Clientes.Mail.ToString()
                        ' fuFoto=Producto
                    Else
                        MsgBox("Hubo un problema al traer la informacion del Cliente", MsgBoxStyle.Exclamation, "AVISO")

                    End If
                Else
                    MsgBox("Ese Cliente no existe ", MsgBoxStyle.Exclamation, "AVISO")
                    txtDNI.Text = ""
                    txtDNI.Focus()
                End If

            Else
                MsgBox("Es necesario completar el campo DNI", MsgBoxStyle.Exclamation, "AVISO")

            End If

        Catch ex As Exception

            MsgBox("Hubo un problema, No se pudo Buscar el Cliente", MsgBoxStyle.Exclamation, "AVISO")

        End Try
    End Sub
    Public Function ControldeBlancosObligatorios(todoOK As Boolean) As Boolean


        If txtDNI.Text = "" OrElse IsDBNull(txtDNI) Then
            todoOK = False

        End If


        Return todoOK
    End Function
    Public Sub LimpiarCajas()

        txtNombre.Text = ""
        txtDNI.Text = ""
        txtDireccion.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim ResultadoMensaje As Integer = 0

        ResultadoMensaje = MsgBox("Esta por eliminar un Cliente, ¿Desea Continuar?", MsgBoxStyle.YesNo, "AVISO")
        If ResultadoMensaje = 1 OrElse ResultadoMensaje = 6 Then
            Try
                Clientes.Eliminar(Val(txtDNI.Text))
                MsgBox("Se elimino con exito el Cliente", MsgBoxStyle.Exclamation, "AVISO")
                LimpiarCajas()
            Catch ex As Exception
                MsgBox("Hubo un problema, No se pudo eliminar el Cliente", MsgBoxStyle.Information, "AVISO")
            End Try
        End If
    End Sub
End Class