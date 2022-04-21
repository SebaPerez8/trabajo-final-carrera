Public Class ABM_clientesCargar
    Inherits System.Web.UI.Page
    Dim Cliente As New Clase_Clientes
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim Control1 As Boolean = True
            If ControldeBlancosObligatorio1(Control1) Then
                If Cliente.ControlExistencia(Val(txtDNI.Text)) Then
                    If Cliente.BuscarProducto(txtDNI.Text) Then
                        txtNombre.Text = Cliente.Nombre_Cliente
                        txtDireccion.Text = Cliente.Direccion
                        txtCorreo.Text = Cliente.Mail
                        txtTelefono.Text = (Cliente.Telefono)

                    Else
                        MsgBox("Hubo un problema al traer la informacion del Cliente", MsgBoxStyle.Exclamation, "AVISO")

                    End If

                Else

                    MsgBox("Ese Cliente no existe ", MsgBoxStyle.Exclamation, "AVISO")
                    txtDNI.Text = ""
                    txtDNI.Focus()
                End If
            Else
                MsgBox("Es necesario completar el campo de DNI", MsgBoxStyle.Exclamation, "AVISO")

            End If

        Catch ex As Exception
            MsgBox("Hubo un problema, No se pudo Buscar el Cliente", MsgBoxStyle.Exclamation, "AVISO")


        End Try
    End Sub

    Public Function ControldeBlancosObligatorio1(todoOK As Boolean) As Boolean


        If txtDNI.Text = "" OrElse IsDBNull(txtDNI) Then
            todoOK = False

        End If


        Return todoOK
    End Function
    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim ResultadoMensaje As Integer = 0
        Dim Control1 As Boolean = True
        Dim Control2 As Boolean = False
        Dim Existen As Boolean = True

        'COntrol Obligatorios:

        If ControldeBlancosObligatorio(Control1) Then
            If Existen = ControldeBlancos(Control2) Then
                ResultadoMensaje = MsgBox("Existen campos incompletos, ¿Desea Continuar?", MsgBoxStyle.YesNo, "AVISO")
                If ResultadoMensaje = 1 OrElse ResultadoMensaje = 6 Then
                    Cliente.Nombre_Cliente = txtNombre.Text

                    Cliente.DNI = Val(txtDNI.Text)
                    Cliente.Direccion = txtDireccion.Text
                    Cliente.Telefono = Val(txtTelefono.Text)
                    Cliente.Mail = txtCorreo.Text
                    Cliente.FechaAlta = DateTime.Now()
                    Try

                        Cliente.Modificar()
                        MsgBox("Se Modifico con exito el Cliente", MsgBoxStyle.Information, "AVISO")
                        LimpiarFromProducto()

                    Catch ex As Exception
                        MsgBox("Hubo un problema, No se pudo Modificar el Cliente", MsgBoxStyle.Exclamation, "AVISO")
                    End Try




                Else
                    'aviso de campos nulos
                    AvisoBlancos()
                End If
            Else
                Cliente.Nombre_Cliente = txtNombre.Text
                Cliente.DNI = Val(txtDNI.Text)
                Cliente.Direccion = txtDireccion.Text
                Cliente.Telefono = Val(txtTelefono.Text)
                Cliente.Mail = txtCorreo.Text
                Try

                    Cliente.Modificar()
                    MsgBox("Se Modifico con exito el Cliente", MsgBoxStyle.Information, "AVISO")
                    LimpiarFromProducto()

                Catch ex As Exception
                    MsgBox("Hubo un problema, No se pudo Modificar el Cliente", MsgBoxStyle.Exclamation, "AVISO")
                End Try

            End If






        Else
            lblMensaje.Text = "Existen campos Obligatorios incompletos"
        End If
    End Sub

    Public Function ControldeBlancosObligatorio(todoOK As Boolean) As Boolean


        If txtNombre.Text = "" OrElse IsDBNull(txtNombre) Then
            todoOK = False
            lblNombre.Text = "Debe completar este campo"
        End If

        Return todoOK
    End Function
    Public Function ControldeBlancos(todoOK As Boolean) As Boolean



        If txtCorreo.Text = "" OrElse IsDBNull(txtCorreo) Then
            todoOK = True
            'lblFecha.Text = "Debe completar este campo"
        End If
        If txtDireccion.Text = "" OrElse IsDBNull(txtDireccion) Then
            todoOK = True
            'lblPrecio.Text = "Debe completar este campo"
        End If
        If txtTelefono.Text = "" OrElse IsDBNull(txtTelefono) Then
            todoOK = True
            'lblPrecio.Text = "Debe completar este campo"
        End If
        Return todoOK
    End Function
    Public Sub AvisoBlancos()
        If txtCorreo.Text = "" OrElse IsDBNull(txtCorreo) OrElse txtCorreo.Text = " " Then

            lblCorreo.Text = "Este campo esta Incompleto"
        End If
        If txtDireccion.Text = "" OrElse IsDBNull(txtDireccion) OrElse txtDireccion.Text = " " Then

            lblDireccion.Text = "Este campo esta Incompleto"
        End If
        If txtTelefono.Text = "" OrElse IsDBNull(txtTelefono) OrElse txtTelefono.Text = " " Then

            lblTelefono.Text = "Este campo esta Incompleto"
        End If


    End Sub
    Public Sub LimpiarFromProducto()
        txtDNI.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtCorreo.Text = ""
        txtDireccion.Text = ""
    End Sub
End Class