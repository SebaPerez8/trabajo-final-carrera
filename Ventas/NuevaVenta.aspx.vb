Public Class Ventas
    Inherits System.Web.UI.Page
    Dim Venta As New Clase_Ventas
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.txtDNI.Text = Session("DNI")
        Me.txtNombre.Text = Session("NombreCliente")

        Me.txtProducto.Text = Session("Nombre")
        Me.txtCodigo.Text = Session("ID_producto")
        Me.txtPrecioUnitario.Text = Session("Precio")

        If Not (Session("Nombre") Is Nothing) Then
            txtProducto.Text = TryCast(Session("Nombre"), String)
            If Not (Session("Stock") Is Nothing) Then
                txtStock.Text = TryCast(Session("Stock"), String)
                If txtStock.Text = "&nbsp;" Then
                    txtStock.Text = "Sin Datos"
                End If
            Else
                MsgBox("No se encontro el Stock del producto " + txtNombre.Text + " .", MsgBoxStyle.Information, "AVISO")
            End If
        End If

        If Not (Session("Precio") Is Nothing) Then
            txtPrecioUnitario.Text = TryCast(Session("Precio"), String)
        End If
        If Not (Session("ID_producto") Is Nothing) Then
            txtCodigo.Text = TryCast(Session("ID_producto"), String)
        End If




    End Sub

    Protected Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click

        Response.Redirect("AgregarProducto.aspx")

    End Sub

    Protected Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Response.Redirect("~/ABM/Clientes/ABM_clientesCargar.aspx")
    End Sub

    Protected Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Response.Redirect("AgregarCliente.aspx")
    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not (txtStock.Text = "Sin Datos") Then
            If (Val(txtStock.Text) > 0) Then
                If Session("dt") Is Nothing Then
                    Dim dt As DataTable = filldata()
                    Dim Row1 As DataRow
                    Row1 = dt.NewRow()
                    Row1("Codigo Producto") = Convert.ToString(txtCodigo.Text)
                    Row1("Producto") = Convert.ToString(txtProducto.Text)
                    Row1("Cantidad") = Convert.ToString(txtCantidad.Text)
                    Row1("Precio Unitario") = Convert.ToString(txtPrecioUnitario.Text)
                    Row1("Precio Total") = Convert.ToString(txtMontoTotalProducto.Text)
                    dt.Rows.Add(Row1)
                    GrillaVentas.DataSource = dt
                    GrillaVentas.DataBind()
                    Session("dt") = dt
                Else
                    Dim dt As DataTable = TryCast(Session("dt"), DataTable)
                    Dim Row1 As DataRow
                    Row1 = dt.NewRow()
                    Row1("Codigo Producto") = Convert.ToString(txtCodigo.Text)
                    Row1("Producto") = Convert.ToString(txtProducto.Text)
                    Row1("Cantidad") = Convert.ToString(txtCantidad.Text)
                    Row1("Precio Unitario") = Convert.ToString(txtPrecioUnitario.Text)
                    Row1("Precio Total") = Convert.ToString(txtMontoTotalProducto.Text)
                    dt.Rows.Add(Row1)
                    GrillaVentas.DataSource = dt
                    GrillaVentas.DataBind()
                    Session("dt") = dt
                End If
            Else
                MsgBox("El producto no tiene Stock", MsgBoxStyle.Exclamation, "AVISO")
            End If
        Else
            MsgBox("No se puede agregar el Producto", MsgBoxStyle.Exclamation, "AVISO")
        End If

    End Sub

    Public Function filldata() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("Codigo Producto", GetType(String))
        dt.Columns.Add("Producto", GetType(String))
        dt.Columns.Add("Cantidad", GetType(String))
        dt.Columns.Add("Precio Unitario", GetType(String))
        dt.Columns.Add("Precio Total", GetType(String))
        Return dt
    End Function

    Protected Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If Not (txtPrecioUnitario.Text Is Nothing) Then
            If Not (txtStock.Text = "Sin Datos") Then
                If (Val(txtStock.Text) >= Val(txtCantidad.Text)) Then
                    txtMontoTotalProducto.Text = Val(txtPrecioUnitario.Text) * Val(txtCantidad.Text)
                Else
                    MsgBox("No se puede agregar una cantidad mayor a el stock disponible", MsgBoxStyle.Information, "AVISO")

                End If

            Else
                txtMontoTotalProducto.Text = "No se puede calcular el Monto"
            End If
        End If

    End Sub

    Protected Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim ResultadoMensaje As Integer = 0
        Dim Control1 As Boolean = True
        Dim dt As DataTable = TryCast(Session("dt"), DataTable)
        If (GrillaVentas.Rows.Count > 0) Then
            If ControldeBlancosObligatorio(Control1) Then

                'Venta.ID_Cliente = TryCast(Session("ID_Cliente"), String)
                'Venta.ID_Medio_Pago = (cbMedioPago.SelectedValue)
                'Venta.Monto = Val(txtMontoTotal.Text)
                'Venta.Cuotas = Val(txtCuotas.text)
                'Venta.Estado_Pedido = "Entregado"

                ResultadoMensaje = MsgBox("Esta por confirmar la venta, ¿Desea Continuar?", MsgBoxStyle.YesNo, "AVISO")
                If ResultadoMensaje = 1 OrElse ResultadoMensaje = 6 Then
                    Try



                        Venta.Grabar(dt)
                        MsgBox("Se realizo con Exito la carga de la Venta", MsgBoxStyle.Exclamation, "AVISO")
                        LimpiarCampos()
                    Catch ex As Exception
                        MsgBox("Hubo un problema, No se pudo cargar la venta", MsgBoxStyle.Information, "AVISO")
                    End Try
                End If
            Else
                MsgBox("Existen campos obligatorios incompletos, por favor completar", MsgBoxStyle.Information, "AVISO")
            End If
        Else
            MsgBox("No existen productos en el carrito para realizar la operacion", MsgBoxStyle.Information, "AVISO")
        End If


    End Sub

    Public Sub LimpiarCampos()

        'VARIABLES SESSION
        Session("ID_Cliente") = Nothing
        Session("Nombre") = Nothing
        Session("Precio") = Nothing
        Session("Stock") = Nothing
        Session("ID_producto") = Nothing
        Session("dt") = Nothing
        'VARIABLES INPUT
        txtDNI.Text = ""
        txtNombre.Text = ""
        'cbMedioPago.SelectedValue = 1
        'txtCuotas.text = 1
        txtStock.Text = ""
        txtProducto.Text = ""
        txtCodigo.Text = ""
        txtCantidad.Text = ""
        txtMontoTotalProducto.Text = ""
        txtPrecioUnitario.Text = ""
        txtMontoTotalVenta.Text = ""

    End Sub

    Public Function ControldeBlancosObligatorio(todoOK As Boolean) As Boolean
        'Los campos obligatorios son--> El cliente
        'falta incluir el cliente.

        If txtCodigo.Text = "" OrElse IsDBNull(txtCodigo) Then
            todoOK = False
            txtCodigo.CssClass = txtCodigo.CssClass + " is-invalid"

        End If
        If txtProducto.Text = "" OrElse IsDBNull(txtProducto) Then
            todoOK = False
            txtProducto.CssClass = txtProducto.CssClass + " is-invalid"

        End If

        Return todoOK
    End Function

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        LimpiarCampos()

    End Sub
End Class