Public Class clientes
    Inherits System.Web.UI.Page
    Dim Cliente As New Clase_Clientes
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
                    Cliente.Nombre_Cliente = txtNombre.Text

                    Cliente.DNI = Val(txtDNI.Text)
                    Cliente.Direccion = txtDireccion.Text
                    Cliente.Telefono = Val(txtTelefono.Text)
                    Cliente.Mail = txtCorreo.Text
                    Cliente.FechaAlta = DateTime.Now()
                    Try
                        If Not Cliente.ControlExistencia(Val(txtDNI.Text)) Then
                            Cliente.Grabar()
                            MsgBox("Se grabo con exito el Cliente", MsgBoxStyle.Information, "AVISO")
                            LimpiarFromProducto()
                        Else
                            MsgBox("Ese Documento ya existe en la base de Datos", MsgBoxStyle.Exclamation, "AVISO")
                            txtDNI.Focus()
                        End If
                    Catch ex As Exception
                        MsgBox("Hubo un problema, No se pudo grabar el Cliente", MsgBoxStyle.Exclamation, "AVISO")
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
                    If Not Cliente.ControlExistencia(Val(txtDNI.Text)) Then
                        Cliente.Grabar()
                        MsgBox("Se grabo con exito el Cliente", MsgBoxStyle.Information, "AVISO")
                        LimpiarFromProducto()
                    Else
                        MsgBox("Ese Documento ya existe en la base de Datos", MsgBoxStyle.Exclamation, "AVISO")
                        txtDNI.Focus()
                    End If
                Catch ex As Exception
                    MsgBox("Hubo un problema, No se pudo grabar el Cliente", MsgBoxStyle.Exclamation, "AVISO")
                End Try
            End If






        Else
            lblMensaje.Text = "Existen campos Obligatorios incompletos"
        End If
    End Sub
    Public Sub LimpiarFromProducto()
        txtDNI.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtCorreo.Text = ""
        txtDireccion.Text = ""
    End Sub
    Public Function ControldeBlancosObligatorio(todoOK As Boolean) As Boolean


        If txtDNI.Text = "" OrElse IsDBNull(txtDNI) Then
            todoOK = False
            lblDNI.Text = "Debe completar este campo"
        End If
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
End Class