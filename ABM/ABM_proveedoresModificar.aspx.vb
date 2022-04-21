Public Class ABM_proveedoresModificar
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
                        txtNombreFantasia.Text = (Proveedores.NombreFantasia).ToString
                    Else
                        MsgBox("Hubo un problema al traer la informacion del Proveedor", MsgBoxStyle.Exclamation, "AVISO")

                    End If

                Else

                    MsgBox("Ese Proveedor no existe ", MsgBoxStyle.Exclamation, "AVISO")
                    txtCUIL.Text = ""
                    txtCUIL.Focus()
                End If
            Else
                MsgBox("Es necesario completar el campo de CUIT/CUIL", MsgBoxStyle.Exclamation, "AVISO")

            End If

        Catch ex As Exception
            MsgBox("Hubo un problema, No se pudo Buscar el Proveedor", MsgBoxStyle.Exclamation, "AVISO")


        End Try
    End Sub

    Public Sub LimpiarFromProducto()
        txtCorreo.Text = ""
        txtRazonSocial.Text = ""
        txtCUIL.Text = ""
        ' txtFecha.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtContacto.Text = ""
        txtNombreFantasia.Text = ""
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim ResultadoMensaje As Integer = 0
        Dim Control1 As Boolean = True
        Dim Control2 As Boolean = False
        Dim Existen As Boolean = True



        If Existen = ControldeBlancos(Control2) Then

            ResultadoMensaje = MsgBox("Existen campos incompletos, ¿Desea Continuar?", MsgBoxStyle.YesNo, "AVISO")
            If ResultadoMensaje = 1 OrElse ResultadoMensaje = 6 Then
                Try
                    Proveedores.CUIT = Val(txtCUIL.Text)
                    Proveedores.RazonSocial = txtRazonSocial.Text
                    Proveedores.Telefono = Val(txtTelefono.Text)
                    Proveedores.Mail = txtCorreo.Text
                    Proveedores.Direccion = txtDireccion.Text

                    Proveedores.NombreFantasia = txtNombreFantasia.Text
                    Proveedores.ContactoPrinciapl = txtContacto.Text

                    'ponemos otro mensaje, desea guardar la modificacion?

                    Proveedores.Modificar()
                    MsgBox("Se modifico con exito el Proveedor", MsgBoxStyle.Exclamation, "AVISO")
                    LimpiarFormulario()
                Catch ex As Exception
                    MsgBox("Hubo un problema, No se pudo modificar el Proveedor", MsgBoxStyle.Information, "AVISO")
                End Try



            Else
                AvisoBlancos()
            End If
        Else

            Try
                Proveedores.CUIT = Val(txtCUIL.Text)
                Proveedores.RazonSocial = txtRazonSocial.Text
                Proveedores.Telefono = Val(txtTelefono.Text)
                Proveedores.Mail = txtCorreo.Text
                Proveedores.Direccion = txtDireccion.Text
                Proveedores.NombreFantasia = txtNombreFantasia.Text
                Proveedores.ContactoPrinciapl = txtContacto.Text

                Proveedores.Modificar()
                MsgBox("Se modifico con exito el Proveedor", MsgBoxStyle.Exclamation, "AVISO")
                LimpiarFormulario()
            Catch ex As Exception
                MsgBox("Hubo un problema, No se pudo modificar el Proveedor", MsgBoxStyle.Information, "AVISO")
            End Try

        End If



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
        If txtNombreFantasia.Text = "" OrElse IsDBNull(txtNombreFantasia) OrElse txtNombreFantasia.Text = " " Then
            todoOK = True

        End If
        Return todoOK
    End Function

    Public Sub AvisoBlancos()

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

        lblDireccion.Text = ""

        lblRazon.Text = ""
        lblTelefono.Text = ""
        lblNombreFantasia.Text = ""
    End Sub
    Public Sub LimpiarFormulario()
        txtCorreo.Text = ""
        txtRazonSocial.Text = ""
        txtCUIL.Text = ""

        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtContacto.Text = ""
        txtNombreFantasia.Text = ""
    End Sub

End Class