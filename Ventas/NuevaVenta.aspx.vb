Public Class Ventas
    Inherits System.Web.UI.Page
    Dim Venta As New Clase_Ventas
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Me.txtDNI.Text = Session("DNI")
        Me.txtNombre.Text = Session("NombreCliente")

        Me.txtProducto.Text = Session("Nombre")
        Me.txtCodigo.Text = Session("ID_producto")
        Me.txtPrecioUnitario.Text = Session("Precio")

#Region "Cliente"


        If Not (Session("NombreCliente") Is Nothing) Then
            txtNombre.Text = TryCast(Session("NombreCliente"), String)
        End If
        If Not (Session("DNI") Is Nothing) Then
            txtDNI.Text = TryCast(Session("DNI"), String)
        End If
        If Not (Session("MedioPago") Is Nothing) Then
            cbFormaPago.SelectedIndex = Convert.ToInt32(TryCast(Session("MedioPago"), String))
        End If
#End Region

#Region "Producto"
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


        If Not (Session("MontoTotal") Is Nothing) Then
            TxtMostrarTotal.Text = Convert.ToString(TryCast(Session("MontoTotal"), String))
        End If

#End Region

        cbFormaPago.SelectedIndex = 1
        Session("MedioPago") = Convert.ToString(cbFormaPago.SelectedIndex)
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

        If Not (txtPrecioUnitario.Text Is Nothing) Then
            If Not (txtStock.Text = "Sin Datos") Then
                If (Val(txtStock.Text) >= Val(txtCantidad.Text)) Then
                    txtMontoTotal.Text = Convert.ToDouble(Convert.ToDouble(Val(txtPrecioUnitario.Text)) * Convert.ToDouble(Val(txtCantidad.Text)))
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
                                Row1("Precio Total") = Convert.ToString(txtMontoTotal.Text)
                                dt.Rows.Add(Row1)
                                GrillaVentas.DataSource = dt
                                GrillaVentas.DataBind()
                                Session("dt") = dt
                                Session("MontoTotal") = SumarMonto(dt)
                                If Not (Session("MontoTotal") Is Nothing) Then
                                    TxtMostrarTotal.Text = TryCast(Session("MontoTotal"), String)
                                End If
                            Else
                                Dim dt As DataTable = TryCast(Session("dt"), DataTable)
                                Dim Row1 As DataRow
                                Row1 = dt.NewRow()
                                Row1("Codigo Producto") = Convert.ToString(txtCodigo.Text)
                                Row1("Producto") = Convert.ToString(txtProducto.Text)
                                Row1("Cantidad") = Convert.ToString(txtCantidad.Text)
                                Row1("Precio Unitario") = Convert.ToString(txtPrecioUnitario.Text)
                                Row1("Precio Total") = Convert.ToString(txtMontoTotal.Text)
                                dt.Rows.Add(Row1)
                                GrillaVentas.DataSource = dt
                                GrillaVentas.DataBind()
                                Session("dt") = dt
                                Session("MontoTotal") = SumarMonto(dt)
                                If Not (Session("MontoTotal") Is Nothing) Then
                                    TxtMostrarTotal.Text = TryCast(Session("MontoTotal"), String)
                                End If
                            End If
                            LimpiarInputAgregar()
                        Else
                            MsgBox("El producto no tiene Stock", MsgBoxStyle.Exclamation, "AVISO")
                        End If
                    Else
                        MsgBox("No se puede agregar el Producto", MsgBoxStyle.Exclamation, "AVISO")
                    End If
                Else
                    MsgBox("No se puede agregar una cantidad mayor a el stock disponible", MsgBoxStyle.Information, "AVISO")

                End If
            Else
                txtMontoTotal.Text = "No se puede calcular el Monto"
            End If
        End If
    End Sub
    Public Function SumarMonto(DT As DataTable) As String
        Dim ValorAnterior As Decimal = 0
        For Each row As DataRow In DT.Rows
            ValorAnterior += Convert.ToDecimal(row("Precio Total"))

        Next
        Return Convert.ToString(ValorAnterior)
    End Function
    Public Function filldata() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("Codigo Producto", GetType(String))
        dt.Columns.Add("Producto", GetType(String))
        dt.Columns.Add("Cantidad", GetType(String))
        dt.Columns.Add("Precio Unitario", GetType(String))
        dt.Columns.Add("Precio Total", GetType(String))
        Return dt
    End Function


    Protected Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim ResultadoMensaje As Integer = 0
        Dim Control1 As Boolean = True
        Dim dt As DataTable = TryCast(Session("dt"), DataTable)
        If (GrillaVentas.Rows.Count > 0) Then
            If Not (Session("MedioPago") = "0") AndAlso Not (Session("MedioPago") Is Nothing) Then

                If ControldeBlancosObligatorio(Control1) Then

                    Venta.ID_Cliente = Convert.ToInt32(TryCast(Session("ID_Cliente"), String))
                    Venta.Monto = Convert.ToDecimal(TryCast(Session("MontoTotal"), String))
                    Venta.Cuotas = 1
                    'Venta.Cuotas=Convert.ToInt32(TryCast(Session("Cuotas"), String))
                    Venta.ID_Medio_Pago = Session("MedioPago")
                    Venta.Estado_Pedido = "Entregado"


                    ResultadoMensaje = MsgBox("Esta por confirmar la venta, ¿Desea Continuar?", MsgBoxStyle.YesNo, "AVISO")
                    If ResultadoMensaje = 1 OrElse ResultadoMensaje = 6 Then
                        Try

                            Venta.GrabarVentas(dt)
                            MsgBox("Se realizo con Exito la carga de la Venta", MsgBoxStyle.Information, "AVISO")
                            LimpiarCampos()
                        Catch ex As Exception
                            MsgBox("Hubo un problema, No se pudo cargar la venta", MsgBoxStyle.Exclamation, "AVISO")
                        End Try
                    End If
                Else
                    MsgBox("Existen campos obligatorios incompletos, por favor completar", MsgBoxStyle.Information, "AVISO")
                End If
            Else
                MsgBox("No selecciono un Medio de Pago para concretar la venta", MsgBoxStyle.Information, "AVISO")
            End If

        Else

            MsgBox("No existen productos en el carrito para realizar la operacion", MsgBoxStyle.Information, "AVISO")
        End If
    End Sub
    Public Sub LimpiarInputAgregar()

        'Input en el Agregar Producto
        txtStock.Text = ""
        txtProducto.Text = ""
        txtCodigo.Text = ""
        txtCantidad.Text = ""
        txtMontoTotal.Text = ""
        txtPrecioUnitario.Text = ""
    End Sub
    Public Sub LimpiarCampos()

#Region "Cliente"
        Session("ID_Cliente") = Nothing
        Session("DNI") = Nothing
        Session("NombreCliente") = Nothing
        Session("MedioPago") = Nothing
        txtDNI.Text = ""
        txtNombre.Text = ""

#End Region

#Region "Producto"
        Session("Nombre") = Nothing
        Session("Precio") = Nothing
        Session("Stock") = Nothing
        Session("ID_producto") = Nothing
        Session("Cuotas") = Nothing
        txtStock.Text = ""
        txtProducto.Text = ""
        txtCodigo.Text = ""
        txtCantidad.Text = ""
        txtMontoTotal.Text = ""
        txtPrecioUnitario.Text = ""


        'txtCuotas.text = 1



        Session("MontoTotal") = Nothing
        GrillaVentas.DataSource = Session("dt")
        TxtMostrarTotal.Text = ""


        Dim dt As DataTable = TryCast(Session("dt"), DataTable)
        Dim Row1 As DataRow
        Row1 = dt.NewRow()
        dt.Rows.Clear()
        GrillaVentas.DataSource = dt
        GrillaVentas.DataBind()
        Session("dt") = dt
#End Region

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

        If (Session("ID_Cliente") Is Nothing) Then
            todoOK = False
            txtDNI.CssClass = txtDNI.CssClass + " is-invalid"
            txtNombre.CssClass = txtNombre.CssClass + " is-invalid"
        End If
        Return todoOK
    End Function


    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        LimpiarCampos()
    End Sub
    Protected Sub cbFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFormaPago.SelectedIndexChanged
        Session("MedioPago") = Convert.ToString(cbFormaPago.SelectedIndex)
    End Sub

    Protected Sub cbFormaPago_TextChanged(sender As Object, e As EventArgs) Handles cbFormaPago.TextChanged
        Session("MedioPago") = Convert.ToString(cbFormaPago.SelectedIndex)

    End Sub
End Class