
Imports System.Data.SqlClient
Public Class Clase_Ventas

#Region "Conectores Base"
    Dim CONECTOR As New SqlConnection(ConfigurationManager.ConnectionStrings("CADENA").ConnectionString)
    Dim COMANDO As New SqlCommand
    Dim SQL As String = ""
#End Region

#Region "Propiedades"
    'DEFINICIONES PARA VENTAS
    Private _ID_Detalle As Integer
    Private _ID_Cliente As String
    Private _ID_Medio_Pago As Integer
    Private _Monto As Decimal
    Private _Cuotas As Integer
    Private _Estado_Pedido As String
    'DEFINICIONES PARA DETALLE DE PEDIDO
    Private _CodigoProducto As Integer
    Private _PrecioUnitario As Decimal
    Private _Cantidad As Integer

    'PROPIEDADES PARA VENTAS
    Public Property ID_Detalle() As Integer
        Get
            Return _ID_Detalle
        End Get
        Set(ByVal Value As Integer)
            _ID_Detalle = Value
        End Set
    End Property
    Public Property ID_Cliente() As String
        Get
            Return _ID_Cliente
        End Get
        Set(ByVal Value As String)
            _ID_Cliente = Value
        End Set
    End Property
    Public Property ID_Medio_Pago() As Integer
        Get
            Return _ID_Medio_Pago
        End Get
        Set(ByVal Value As Integer)
            _ID_Medio_Pago = Value
        End Set
    End Property
    Public Property Monto() As Decimal
        Get
            Return _Monto
        End Get
        Set(ByVal Value As Decimal)
            _Monto = Value
        End Set
    End Property
    Public Property Cuotas() As Integer
        Get
            Return _Cuotas
        End Get
        Set(ByVal Value As Integer)
            _Cuotas = Value
        End Set
    End Property
    Public Property Estado_Pedido() As String
        Get
            Return _Estado_Pedido
        End Get
        Set(ByVal Value As String)
            _Estado_Pedido = Value
        End Set
    End Property

    'PROPIEDADES PARA DETALLE DE PEDIDO
    Public Property CodigoProducto() As Integer
        Get
            Return _CodigoProducto
        End Get
        Set(ByVal Value As Integer)
            _CodigoProducto = Value
        End Set
    End Property
    Public Property PrecioUnitario() As Decimal
        Get
            Return _PrecioUnitario
        End Get
        Set(ByVal Value As Decimal)
            _PrecioUnitario = Value
        End Set
    End Property
    Public Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal Value As Integer)
            _Cantidad = Value
        End Set
    End Property
#End Region

#Region "Metodos"

    Public Sub TraerDetalle()

        Try
            'no me termina de cerrar, q si se vende 15 productos, haga 15 envios. (pero garantizamos q se haga todo junto)
            COMANDO.CommandText = "dbo.SP_Traer_Ultimo_Detalle"

            Dim DR As SqlDataReader = COMANDO.ExecuteReader()

            If DR.HasRows = True Then
                DR.Read()
                _ID_Detalle = Convert.ToInt32(DR("ID_Detalle"))
            End If
            DR.Close()
        Catch ex As Exception
            ex.Message("Error al buscar el ultimo Detalle").ToString()
        End Try

    End Sub
    Public Sub GrabarDetalle(dt As DataTable)

        Try
            TraerDetalle()

            'no me termina de cerrar, q si se vende 15 productos, haga 15 envios. (pero garantizamos q se haga todo junto)
            COMANDO.CommandText = "dbo.SP_InsertarDetalleVenta"

            For Each row As DataRow In dt.Rows
                COMANDO.Parameters.Clear()

                If Not ((row("Cantidad") = 0) And row("Producto") = "Eliminado") Then

                    COMANDO.Parameters.AddWithValue("@ID_Detalle", _ID_Detalle)
                    COMANDO.Parameters.AddWithValue("@Cod_Producto", Convert.ToInt32(row("Codigo Producto")))
                    COMANDO.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(row("Cantidad")))
                    COMANDO.Parameters.AddWithValue("@Precio_Unitario", Convert.ToDecimal(row("Precio Unitario")))

                    COMANDO.ExecuteNonQuery()
                    COMANDO.Parameters.Clear()

                End If

            Next

        Catch ex As Exception
            ex.Message("Error al insertar el Detalle venta").ToString()
        End Try

    End Sub

    Public Sub GrabarVentas(dt As DataTable)

        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure

        Try
            GrabarDetalle(dt)

            'no me termina de cerrar, q si se vende 15 productos, haga 15 envios. (pero garantizamos q se haga todo junto)


            COMANDO.CommandText = "dbo.SP_InsertarVenta"

            COMANDO.Parameters.Clear()

                COMANDO.Parameters.AddWithValue("@ID_Cliente", _ID_Cliente)
                COMANDO.Parameters.AddWithValue("@Monto", _Monto)
                COMANDO.Parameters.AddWithValue("@ID_MedioPago", _ID_Medio_Pago)
            COMANDO.Parameters.AddWithValue("@Cuotas", _Cuotas)
            COMANDO.Parameters.AddWithValue("@Estado_Pedido", _Estado_Pedido)
                COMANDO.Parameters.AddWithValue("@ID_Detalle", _ID_Detalle)

            COMANDO.ExecuteNonQuery()

        Catch ex As Exception
            ex.Message("Error al insertar la venta").ToString()
        End Try

        CONECTOR.Close()
    End Sub
#End Region
End Class
