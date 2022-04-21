Public Class ABM_proveedoresEliminar
    Inherits System.Web.UI.Page
    Dim Proveedores As New Clase_Proveedores
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim Control1 As Boolean = True
            If ControldeBlancosObligatorios(Control1) Then
                If Proveedores.ControlExistencia(Val(txtCUIL.Text)) Then
                    If Proveedores.BuscarProducto(txtCUIL.Text) Then
                        txtRazonSocial.Text = Proveedores.RazonSocial
                        txtDireccion.Text = Proveedores.Direccion
                        txtCorreo.Text = Proveedores.Mail
                        txtContacto.Text = Proveedores.ContactoPrinciapl
                        txtTelefono.Text = (Proveedores.Telefono)

                    Else
                        MsgBox("Hubo un problema al traer la informacion del Proveedor", MsgBoxStyle.Exclamation, "AVISO")

                    End If

                Else
                    MsgBox("Ese Proveedor no existe ", MsgBoxStyle.Information, "AVISO")
                    txtCUIL.Text = ""
                    txtCUIL.Focus()
                End If
            Else
                MsgBox("Es necesario completar el campo de CUIT/CUIL", MsgBoxStyle.Information, "AVISO")

            End If



        Catch ex As Exception
            MsgBox("Hubo un problema, No se pudo Buscar el Proveedor", MsgBoxStyle.Information, "AVISO")


        End Try
    End Sub


    Public Function ControldeBlancosObligatorios(todoOK As Boolean) As Boolean


        If txtCUIL.Text = "" OrElse IsDBNull(txtCUIL) Then
            todoOK = False

        End If


        Return todoOK
    End Function

    Public Function ControldeBlancos(todoOK As Boolean) As Boolean


        If txtCorreo.Text = "" OrElse IsDBNull(txtCorreo) OrElse txtCorreo.Text = " " Then
            todoOK = True

        End If

        If txtTelefono.Text = "" OrElse IsDBNull(txtTelefono) OrElse txtTelefono.Text = " " Then
            todoOK = True

        End If
        If txtDireccion.Text = "" OrElse IsDBNull(txtDireccion) OrElse txtDireccion.Text = " " Then
            todoOK = True

        End If
        If txtContacto.Text = "" OrElse IsDBNull(txtContacto) OrElse txtContacto.Text = " " Then
            todoOK = True

        End If

        Return todoOK
    End Function



    Public Sub LimpiarFormulario()
        txtCorreo.Text = ""
        txtRazonSocial.Text = ""
        txtCUIL.Text = ""

        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtContacto.Text = ""

    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim ResultadoMensaje As Integer = 0

        ResultadoMensaje = MsgBox("Esta por eliminar un Proveedor, ¿Desea Continuar?", MsgBoxStyle.YesNo, "AVISO")
        If ResultadoMensaje = 1 OrElse ResultadoMensaje = 6 Then
            Try



                Proveedores.Eliminar(Val(txtCUIL.Text))
                MsgBox("Se elimino con exito el Proveedor", MsgBoxStyle.Exclamation, "AVISO")
                LimpiarFormulario()
            Catch ex As Exception
                MsgBox("Hubo un problema, No se pudo eliminar el Proveedor", MsgBoxStyle.Information, "AVISO")
            End Try
        End If

    End Sub
End Class