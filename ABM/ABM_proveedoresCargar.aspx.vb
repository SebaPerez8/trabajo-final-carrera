Public Class proveedores
    Inherits System.Web.UI.Page
    Dim Proveedores As New Clase_Proveedores
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LimpiarMensajes()

    End Sub

    'faltaria poner limpiar labeeeles

    Protected Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim ResultadoMensaje As Integer = 0
        Dim Control1 As Boolean = True
        Dim Control2 As Boolean = False
        Dim Existen As Boolean = True

        If ControldeBlancosObligatorios(Control1) Then

            If existen = ControldeBlancos(Control2) Then

                ResultadoMensaje = MsgBox("Existen campos incompletos, ¿Desea Continuar?", MsgBoxStyle.YesNo, "AVISO")
                If ResultadoMensaje = 1 OrElse ResultadoMensaje = 6 Then
                    Proveedores.CUIT = Val(txtCUIL.Text)
                    Proveedores.RazonSocial = txtRazonSocial.Text
                    Proveedores.Telefono = Val(txtTelefono.Text)
                    Proveedores.Mail = txtCorreo.Text
                    Proveedores.Direccion = txtDireccion.Text
                    Proveedores.FechaAlta = txtFecha.Text
                    Proveedores.NombreFantasia = txtNombreFantasia.Text
                    Proveedores.ContactoPrinciapl = txtContacto.Text

                    Try
                        If Not Proveedores.ControlExistencia(Val(txtCUIL.Text)) Then
                            Proveedores.Grabar()
                            MsgBox("Se grabo con exito el Proveedor")

                            LimpiarFromProducto()
                        Else

                            MsgBox("Ya existe un Proveedor con esa CUIT")
                            txtRazonSocial.Focus()
                        End If


                    Catch ex As Exception
                        MsgBox("Hubo un problema, No se pudo grabar el Proveedor")


                    End Try
                Else
                    AvisoBlancos()

                End If
            Else
                Proveedores.CUIT = Val(txtCUIL.Text)
                Proveedores.RazonSocial = txtRazonSocial.Text
                Proveedores.Telefono = Val(txtTelefono.Text)
                Proveedores.Mail = txtCorreo.Text
                Proveedores.Direccion = txtDireccion.Text
                Proveedores.FechaAlta = txtFecha.Text
                Proveedores.NombreFantasia = txtNombreFantasia.Text
                Proveedores.ContactoPrinciapl = txtContacto.Text

                Try
                    If Not Proveedores.ControlExistencia(Val(txtCUIL.Text)) Then
                        Proveedores.Grabar()
                        MsgBox("Se grabo con exito el Proveedor", MsgBoxStyle.Exclamation, "AVISO")

                        LimpiarFromProducto()
                    Else

                        MsgBox("Ya existe un Proveedor con ese CUIT", MsgBoxStyle.Exclamation, "AVISO")
                    End If


                Catch ex As Exception
                    MsgBox("Hubo un problema, No se pudo grabar el Proveedor", MsgBoxStyle.Information, "AVISO")

                End Try

            End If


        Else
            lblMensaje.Text = "Existen campos Obligatorios incompletos"
        End If
    End Sub

    Public Sub LimpiarFromProducto()
        txtCorreo.Text = ""
        txtRazonSocial.Text = ""
        txtCUIL.Text = ""
        txtFecha.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtContacto.text = ""
        txtNombreFantasia.text = ""
    End Sub

    Public Function ControldeBlancosObligatorios(todoOK As Boolean) As Boolean


        If txtCUIL.Text = "" OrElse IsDBNull(txtCUIL) Then
            todoOK = False
            lblCUIT.Text = "Debe completar este campo"
        End If
        If txtRazonSocial.Text = "" OrElse IsDBNull(txtRazonSocial) Then
            todoOK = False
            lblRazon.Text = "Debe completar este campo"
        End If

        Return todoOK
    End Function

    Public Function ControldeBlancos(todoOK As Boolean) As Boolean

        If txtFecha.Text = "" OrElse IsDBNull(txtFecha) OrElse txtFecha.Text = " " Then
            todoOK = True

        End If
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
        If txtNombreFantasia.Text = "" OrElse IsDBNull(txtNombreFantasia) OrElse txtNombreFantasia.Text = " " Then
            todoOK = True

        End If
        Return todoOK
    End Function

    Public Sub AvisoBlancos()
        If txtFecha.Text = "" OrElse IsDBNull(txtFecha) OrElse txtFecha.Text = " " Then

            lblFecha.Text = "Este campo esta Incompleto"
        End If
        If txtCorreo.Text = "" OrElse IsDBNull(txtCorreo) OrElse txtCorreo.Text = " " Then

            lblCorreo.Text = "Este campo esta Incompleto"
        End If

        If txtTelefono.Text = "" OrElse IsDBNull(txtTelefono) OrElse txtTelefono.Text = " " Then

            lblTelefono.Text = "Este campo esta Incompleto"
        End If
        If txtDireccion.Text = "" OrElse IsDBNull(txtDireccion) OrElse txtDireccion.Text = " " Then

            lblDireccion.Text = "Este campo esta Incompleto"
        End If
        If txtContacto.Text = "" OrElse IsDBNull(txtContacto) OrElse txtContacto.Text = " " Then

            lblContacto.Text = "Este campo esta Incompleto"
        End If

    End Sub

    Public Sub LimpiarMensajes()
        lblMensaje.Text = ""
        lblContacto.Text = ""
        lblCorreo.Text = ""
        lblCUIT.Text = ""
        lblDireccion.Text = ""
        lblFecha.Text = ""
        lblRazon.Text = ""
        lblTelefono.Text = ""
        lblNombreFantasia.Text= ""
    End Sub
End Class