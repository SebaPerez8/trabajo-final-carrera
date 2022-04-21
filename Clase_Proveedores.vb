Imports System.Data.SqlClient

Public Class Clase_Proveedores



#Region "Conectores Base"
    Dim CONECTOR As New SqlConnection(ConfigurationManager.ConnectionStrings("CADENA").ConnectionString)
    Dim COMANDO As New SqlCommand
    Dim SQL As String = ""
#End Region



#Region "Propiedades"
    Private _RazonSocial As String
    Private _CUIT As Int64
    Private _Direccion As String
    Private _Telefono As Int64
    Private _ContactoPrincipal As String
    Private _Mail As String
    Private _FechaAlta As Date
    Private _NombreFantasia As String

    Public Property CUIT() As Int64
        Get
            Return _CUIT
        End Get
        Set(ByVal Value As Int64)
            _CUIT = Value
        End Set
    End Property
    Public Property RazonSocial() As String
        Get
            Return _RazonSocial
        End Get
        Set(ByVal Value As String)
            _RazonSocial = Value
        End Set
    End Property
    Public Property NombreFantasia() As String
        Get
            Return _NombreFantasia
        End Get
        Set(ByVal Value As String)
            _NombreFantasia = Value
        End Set
    End Property
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal Value As String)
            _Direccion = Value
        End Set
    End Property
    Public Property Telefono() As Int64
        Get
            Return _Telefono
        End Get
        Set(ByVal Value As Int64)
            _Telefono = Value
        End Set
    End Property
    Public Property ContactoPrinciapl() As String
        Get
            Return _ContactoPrincipal
        End Get
        Set(ByVal Value As String)
            _ContactoPrincipal = Value
        End Set
    End Property
    Public Property Mail() As String
        Get
            Return _Mail
        End Get
        Set(ByVal Value As String)
            _Mail = Value
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

            '                                     (Razon_Social,CUIT-CUIL,Direccion,Telefono,Mail,FechaAlta,Nombre_Fantasia)
            SQL = "INSERT INTO Proveedores VALUES (@Razon_Social,@CUIT,IsNull(@Direccion,''),IsNull(@Telefono,0),IsNull(@Mail,''),ISNULL(@FechaAlta,GETDATE()),ISNULL(@Nombre_Fantasia,''),ISNULL(@Contacto_Principal,''))"
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()

            COMANDO.Parameters.AddWithValue("@Razon_Social", _RazonSocial)
            COMANDO.Parameters.AddWithValue("@CUIT", _CUIT)

            COMANDO.Parameters.AddWithValue("@Direccion", _Direccion)
            COMANDO.Parameters.AddWithValue("@Telefono", _Telefono)
            COMANDO.Parameters.AddWithValue("@Mail", _Mail)
            COMANDO.Parameters.AddWithValue("@FechaAlta", _FechaAlta)
            COMANDO.Parameters.AddWithValue("@Nombre_Fantasia", _NombreFantasia)
            COMANDO.Parameters.AddWithValue("@Contacto_Principal", _ContactoPrincipal)
            COMANDO.ExecuteNonQuery()

        Catch ex As Exception
            ex.Message("Error al insertar el Proveedor").ToString()
        End Try

        CONECTOR.Close()
    End Sub

    Public Function ControlExistencia(CUIT As Integer)

        Dim valor As Boolean = False

        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text

        Try

            SQL = "Select * from Proveedores where CUIT=@CUIT"
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()
            COMANDO.Parameters.AddWithValue("@CUIT", CUIT)


            Dim DR As SqlDataReader = COMANDO.ExecuteReader()

            If DR.HasRows = True Then
                DR.Read()


                valor = True
            End If
            DR.Close()
        Catch ex As Exception
            ex.Message("Error al buscar el Proveedor").ToString()
        End Try

        CONECTOR.Close()

        Return valor
    End Function

    Public Sub Modificar()
        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text
        Try

            SQL = "UPDATE Proveedores  SET  Direccion=@Direccion, Telefono=@Telefono, Mail=@Mail,Nombre_Fantasia=@Nombre_Fantasia,Razon_Social=@Razon,Contacto_Principal=@Contacto  where CUIT=@CUIT"
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()


            COMANDO.Parameters.AddWithValue("@Nombre_Fantasia", _NombreFantasia)
            COMANDO.Parameters.AddWithValue("@Direccion", _Direccion)
            COMANDO.Parameters.AddWithValue("@Telefono", _Telefono)
            COMANDO.Parameters.AddWithValue("@Mail", _Mail)
            COMANDO.Parameters.AddWithValue("@Razon", _RazonSocial)
            COMANDO.Parameters.AddWithValue("@Contacto", _ContactoPrincipal)
            COMANDO.Parameters.AddWithValue("@CUIT", _CUIT)


            COMANDO.ExecuteNonQuery()

        Catch ex As Exception
            ex.Message("Error al modificar el Proveedor").ToString()
        End Try

        CONECTOR.Close()
    End Sub


    Public Function BuscarProducto(CUIT As Integer)
        'Public Function BuscarProducto(CUIT As String)
        Dim encontro As Boolean = False
        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text

        Try

            SQL = "Select * from Proveedores where CUIT=@CUIT"
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()
            COMANDO.Parameters.AddWithValue("@CUIT", CUIT)


            Dim DR As SqlDataReader = COMANDO.ExecuteReader()

            If DR.HasRows = True Then
                encontro = True
                DR.Read()
                If (IsDBNull(DR("Nombre_Fantasia"))) Then _ContactoPrincipal = "" Else _NombreFantasia = DR("Nombre_Fantasia")
                If (IsDBNull(DR("Mail"))) Then _Mail = "" Else _Mail = DR("Mail")
                If (IsDBNull(DR("Telefono"))) Then _Telefono = "" Else _Telefono = DR("Telefono")
                If (IsDBNull(DR("FechaAlta"))) Then _FechaAlta = "" Else _FechaAlta = DR("FechaAlta")
                If (IsDBNull(DR("Direccion"))) Then _Direccion = "" Else _Direccion = DR("Direccion")
                If (IsDBNull(DR("Razon_Social"))) Then _RazonSocial = "" Else _RazonSocial = DR("Razon_Social")
                If (IsDBNull(DR("Contacto_Principal"))) Then _ContactoPrincipal = "" Else _ContactoPrincipal = DR("Contacto_Principal")

            End If
            DR.Close()
        Catch ex As Exception
            ex.Message("Error al buscar el Proveedor").ToString()
        End Try

        CONECTOR.Close()
        Return encontro
    End Function

    Public Sub Eliminar(CUIT As Integer)
        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text
        Try

            SQL = "Delete from Proveedores where CUIT=@CUIT"
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()

            COMANDO.Parameters.AddWithValue("@CUIT", CUIT)

            COMANDO.ExecuteNonQuery()

        Catch ex As Exception
            ex.Message("Error al eliminar el Proveedor").ToString()
        End Try

        CONECTOR.Close()
    End Sub
#End Region
End Class
