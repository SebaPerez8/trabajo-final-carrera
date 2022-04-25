Imports System.Data.SqlClient
Public Class Clase_Clientes

#Region "Conectores Base"
    Dim CONECTOR As New SqlConnection(ConfigurationManager.ConnectionStrings("CADENA").ConnectionString)
    Dim COMANDO As New SqlCommand
    Dim SQL As String = ""
#End Region

#Region "Propiedades"
    Private _DNI As Integer
    Private _Nombre As String
    Private _Direccion As String
    Private _Telefono As Integer
    Private _Mail As String
    Private _FechaAlta As Date



    Public Property DNI() As Integer
        Get
            Return _DNI
        End Get
        Set(ByVal Value As Integer)
            _DNI = Value
        End Set
    End Property

    Public Property Nombre_Cliente() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal Value As String)
            _Nombre = Value
        End Set
    End Property
    Public Property Telefono() As Integer
        Get
            Return _Telefono
        End Get
        Set(ByVal Value As Integer)
            _Telefono = Value
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
    Public Property FechaAlta() As Date
        Get
            Return _FechaAlta
        End Get
        Set(ByVal Value As Date)
            _FechaAlta = Value
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

#End Region

#Region "Metodos"
    Public Sub Grabar()
        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text
        Try


            SQL = "INSERT INTO Clientes (DNI,Nombre,Direccion,Telefono,Mail,FechaAlta) VALUES (@DNI,@Nombre,IsNUll(@Direccion,''),IsNull(@Telefono,0),IsNUll(@Mail,''),ISNULL(@FechaAlta,GETDATE()))"
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()

            COMANDO.Parameters.AddWithValue("@DNI", _DNI)
            COMANDO.Parameters.AddWithValue("@Nombre", _Nombre)
            COMANDO.Parameters.AddWithValue("@Direccion", _Direccion)
            COMANDO.Parameters.AddWithValue("@Telefono", _Telefono)
            COMANDO.Parameters.AddWithValue("@Mail", _Mail)
            COMANDO.Parameters.AddWithValue("@FechaAlta", _FechaAlta)
            COMANDO.ExecuteNonQuery()

        Catch ex As Exception
            ex.Message("Error al insertar el Cliente").ToString()
        End Try

        CONECTOR.Close()
    End Sub

    Public Function ControlExistencia(DOCUMENTO As Integer)

        Dim valor As Boolean = False

        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text

        Try
            SQL = "Select * from Clientes where DNI= @DNI"
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()
            COMANDO.Parameters.AddWithValue("@DNI", DOCUMENTO)

            Dim DR As SqlDataReader = COMANDO.ExecuteReader()

            If DR.HasRows = True Then
                DR.Read()


                valor = True
            End If
            DR.Close()
        Catch ex As Exception
            ex.Message("Error al buscar el Cliente").ToString()
        End Try

        CONECTOR.Close()

        Return valor
    End Function

    Public Sub Modificar()
        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text
        Try

            SQL = "UPDATE Clientes  SET  Nombre=@Nombre, Direccion=@Direccion, Telefono=@Telefono, Mail=@Mail where DNI= @DNI "
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()


            COMANDO.Parameters.AddWithValue("@Nombre", _Nombre)
            COMANDO.Parameters.AddWithValue("@DNI", _DNI)
            COMANDO.Parameters.AddWithValue("@Direccion", _Direccion)
            COMANDO.Parameters.AddWithValue("@Telefono", _Telefono)
            COMANDO.Parameters.AddWithValue("@Mail", _Mail)


            COMANDO.ExecuteNonQuery()

        Catch ex As Exception
            ex.Message("Error al modificar el Cliente").ToString()
        End Try

        CONECTOR.Close()
    End Sub

    Public Function BuscarProducto(Documento As Integer)
        Dim encontro As Boolean = False
        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text

        Try
            SQL = "Select * from Clientes where DNI= @DNI"
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()
            COMANDO.Parameters.AddWithValue("@DNI", Documento)

            Dim DR As SqlDataReader = COMANDO.ExecuteReader()

            If DR.HasRows = True Then
                encontro = True
                DR.Read()
                If (IsDBNull(DR("Nombre"))) Then _Nombre = "" Else _Nombre = DR("Nombre")
                If (IsDBNull(DR("Direccion"))) Then _Direccion = "" Else _Direccion = DR("Direccion")
                If (IsDBNull(DR("Telefono"))) Then _Telefono = "" Else _Telefono = DR("Telefono")
                If (IsDBNull(DR("Mail"))) Then _Mail = "" Else _Mail = DR("Mail")
                If (IsDBNull(DR("DNI"))) Then _DNI = "" Else _DNI = DR("DNI")
                If (IsDBNull(DR("FechaAlta"))) Then _FechaAlta = "" Else _FechaAlta = DR("FechaAlta")
            End If
            DR.Close()
        Catch ex As Exception
            ex.Message("Error al buscar el Cliente").ToString()
        End Try

        CONECTOR.Close()
        Return encontro
    End Function


    Public Sub Eliminar(DNI As Integer)
        CONECTOR.Open()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text
        Try

            SQL = "Delete from Clientes where DNI= @DNI "
            COMANDO.CommandText = SQL
            COMANDO.Parameters.Clear()



            COMANDO.Parameters.AddWithValue("@DNI", DNI)

            COMANDO.ExecuteNonQuery()

        Catch ex As Exception
            ex.Message("Error al eliminar el Cliente").ToString()
        End Try

        CONECTOR.Close()
    End Sub
#End Region
End Class
