Imports System.Data.SqlClient
Public Class Clase_Productos


#Region "Conectores Base"
    Dim CONECTOR As New SqlConnection(ConfigurationManager.ConnectionStrings("CADENA").ConnectionString)
    Dim COMANDO As New SqlCommand
    Dim SQL As String = ""
#End Region


#Region "Propiedades"
    Private _ID_Producto As Integer
    Private _Nombre As String
    Private _id_Categoria As Integer
    Private _Precio As Decimal
    Private _FechaAlta As Date


    'Private _Image As Image


    Public Property Codigo_Producto() As Integer
        Get
            Return _ID_Producto
        End Get
        Set(ByVal Value As Integer)
            _ID_Producto = Value
        End Set
    End Property

    Public Property Nombre_Producto() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal Value As String)
            _Nombre = Value
        End Set
    End Property
    Public Property Categoria() As Integer
        Get
            Return _id_Categoria
        End Get
        Set(ByVal Value As Integer)
            _id_Categoria = Value
        End Set
    End Property

    Public Property Precio_Producto() As Decimal
        Get
            Return _Precio
        End Get
        Set(ByVal Value As Decimal)
            _Precio = Value
        End Set
    End Property
    Public Property FechaAlta() As Date
        Get
            Return _FechaAlta
        End Get
        Set(ByVal Value As Date)
            _FechaAlta = Value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Sub Grabar()
        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text
        Try


            SQL = "INSERT INTO Productos (ID_producto,Nombre,Id_Categoria,Precio,FechaAlta) VALUES ( @ID_producto,@Nombre, @Id_Categoria , @Precio ,@FechaAlta )"
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()

            COMANDO.Parameters.AddWithValue("@ID_producto", _ID_Producto)
            COMANDO.Parameters.AddWithValue("@Nombre", _Nombre)
            COMANDO.Parameters.AddWithValue("@Id_Categoria", _id_Categoria)
            COMANDO.Parameters.AddWithValue("@Precio", _Precio)
            COMANDO.Parameters.AddWithValue("@FechaAlta", _FechaAlta)
            COMANDO.ExecuteNonQuery()

        Catch ex As Exception
            ex.Message("Error al insertar el Producto").ToString()
        End Try

        CONECTOR.Close()
    End Sub

    Public Function ControlExistencia(CodigoProd As Integer)

        Dim valor As Boolean = False

        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text

        Try
            SQL = "Select * from Productos where ID_producto= @CodPro"
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()
            COMANDO.Parameters.AddWithValue("@CodPro", CodigoProd)

            Dim DR As SqlDataReader = COMANDO.ExecuteReader()

            If DR.HasRows = True Then
                DR.Read()


                valor = True
            End If
            DR.Close()
        Catch ex As Exception
            ex.Message("Error al buscar el Producto").ToString()
        End Try

        CONECTOR.Close()

        Return valor
    End Function

    Public Sub Modificar()
        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text
        Try

            SQL = "UPDATE Productos  SET  Nombre=@Nombre, Precio=@Precio , Id_Categoria=@Id_Categoria where ID_producto= @CodPro "
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()


            COMANDO.Parameters.AddWithValue("@Nombre", _Nombre)
            COMANDO.Parameters.AddWithValue("@Id_Categoria", _id_Categoria)
            COMANDO.Parameters.AddWithValue("@Precio", _Precio)
            COMANDO.Parameters.AddWithValue("@CodPro", _ID_Producto)

            COMANDO.ExecuteNonQuery()

        Catch ex As Exception
            ex.Message("Error al modificar el Producto").ToString()
        End Try

        CONECTOR.Close()
    End Sub

    Public Function BuscarProducto(CodigoProd As Integer)
        Dim encontro As Boolean = False
        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text

        Try
            SQL = "Select * from Productos where ID_producto= @CodPro"
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()
            COMANDO.Parameters.AddWithValue("@CodPro", CodigoProd)

            Dim DR As SqlDataReader = COMANDO.ExecuteReader()

            If DR.HasRows = True Then
                encontro = True
                DR.Read()
                _Nombre = DR("Nombre")
                _id_Categoria = DR("Id_Categoria")
                _Precio = DR("Precio")
                _FechaAlta = DR("FechaAlta")


            End If
            DR.Close()
        Catch ex As Exception
            ex.Message("Error al buscar el Producto").ToString()
        End Try

        CONECTOR.Close()
        Return encontro
    End Function


    Public Sub Eliminar()
        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text
        Try

            SQL = "Delete from Productos where ID_producto= @CodPro "
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()



            COMANDO.Parameters.AddWithValue("@CodPro", _ID_Producto)

            COMANDO.ExecuteNonQuery()

        Catch ex As Exception
            ex.Message("Error al eliminar el Producto").ToString()
        End Try

        CONECTOR.Close()
    End Sub
#End Region
End Class
