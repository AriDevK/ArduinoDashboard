Module Database

    Friend ReadOnly databaseName = "arduino"
    Private connectionString = "server=localhost;user id=root;password=;database=arduino"

    ' Crea la base de datos y la tabla si no existen
    Friend Sub PrepareDatabase()
        Dim connection As New MySql.Data.MySqlClient.MySqlConnection
        Try
            connection.ConnectionString = "server=localhost;user id=root;password="
            connection.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand
            command.Connection = connection
            command.CommandText = "CREATE DATABASE IF NOT EXISTS arduino"
            command.ExecuteNonQuery()
            command.CommandText = "USE arduino"
            command.ExecuteNonQuery()
            command.CommandText = "CREATE TABLE IF NOT EXISTS data (id INT NOT NULL AUTO_INCREMENT, data VARCHAR(255), date DATETIME, PRIMARY KEY (id))"
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Prueba la conexion con la base de datos
    Friend Function TestConnection() As Boolean
        Dim connection As New MySql.Data.MySqlClient.MySqlConnection
        Dim result As Boolean = False
        Try
            connection.ConnectionString = "server=localhost;user id=root;password="
            connection.Open()
            result = True
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
        Return result
    End Function

    ' Guarda los datos en la base de datos
    Friend Sub SaveData(data As String)
        Dim connection As New MySql.Data.MySqlClient.MySqlConnection
        Try
            connection.ConnectionString = connectionString
            connection.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand
            command.Connection = connection
            command.CommandText = "INSERT INTO data (data, date) VALUES ("& data &", NOW())"
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Obtiene los datos de la base de datos
    Friend Function GetData() As DataTable
        Dim connection As New MySql.Data.MySqlClient.MySqlConnection
        Dim result As New DataTable
        Try
            connection.ConnectionString = connectionString
            connection.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand
            command.Connection = connection
            command.CommandText = "SELECT data AS Line, COUNT(*) AS Total FROM data WHERE date >= DATE_SUB(NOW(), INTERVAL 12 HOUR) GROUP BY Data"
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            adapter.Fill(result)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
        Return result
    End Function

    Friend Function GetFullData() As DataTable
        Dim connection As New MySql.Data.MySqlClient.MySqlConnection
        Dim result As New DataTable
        Try
            connection.ConnectionString = connectionString
            connection.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand
            command.Connection = connection
            command.CommandText = "SELECT * FROM data WHERE date >= DATE_SUB(NOW(), INTERVAL 12 HOUR) ORDER BY Id DESC"
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            adapter.Fill(result)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
        Return result
    End Function

End Module
