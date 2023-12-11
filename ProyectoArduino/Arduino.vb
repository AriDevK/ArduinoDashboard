Imports System.IO.Ports

Module Arduino

    ' Obtiene los puertos seriales disponibles en el sistema
    Friend Function GetSerialPorts() As List(Of String)
        Dim result As New List(Of String)
        For Each port As String In My.Computer.Ports.SerialPortNames
            result.Add(port)
        Next
        Return result
    End Function

    ' Prueba el puerto serial seleccionado enviando un mensaje
    Friend Sub TestPort(portName As String)
        Dim port As New IO.Ports.SerialPort
        Try
            port.PortName = portName
            port.BaudRate = 9600
            port.Open()
            port.WriteLine("TEST")
            port.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Recibe datos del puerto serial seleccionado
    Friend Function ReceiveData(portName As String) As String
        Dim port As New IO.Ports.SerialPort
        Dim result As String = ""
        Try
            port.StopBits = 1
            port.DataBits = "8"
            port.PortName = portName
            port.BaudRate = 9600
            port.Open()
            result = port.ReadLine()
            port.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

End Module
