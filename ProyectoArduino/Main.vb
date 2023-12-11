Imports System.Windows.Forms.DataVisualization.Charting

Public Class Main

    Private isSerialOn = False
    Private isDatabaseOn = False

    ' Carga los datos iniciales de la ventana principal
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboSerialPorts.DataSource = Arduino.GetSerialPorts()
        ComboSerialPorts.SelectedIndex = 0
        isSerialOn = True
        TextBoxDatabase.Text = Database.databaseName
    End Sub

    ' Cierra la aplicacion cuando se cierra la ventana principal
    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub


    ' Prueba la conexion con la base de datos
    Private Sub ButtonTestDatabase_Click(sender As Object, e As EventArgs) Handles ButtonTestDatabase.Click
        Dim isConnected = Database.TestConnection()

        If isConnected Then
            MsgBox("Conexion realizada correctamente con base de datos")
            Database.PrepareDatabase()
            isDatabaseOn = True
        Else
            MsgBox("No se pudo realizar la conexion con la base de datos")
        End If
    End Sub


    ' Prueba la conexion con el puerto serial
    Private Sub ButtonTestSerial_Click(sender As Object, e As EventArgs) Handles ButtonTestSerial.Click
        Dim port = ComboSerialPorts.Text
        Arduino.TestPort(port)
        MsgBox("Revise si el buzzer emitio sonido")
    End Sub

    ' Recarga los datos de la base de datos y los muestra en la tabla y en el grafico
    Private Sub ClockReload_Tick(sender As Object, e As EventArgs) Handles ClockReload.Tick

        If isSerialOn And isDatabaseOn Then
            Dim serialData = Arduino.ReceiveData(ComboSerialPorts.Text).Replace(vbCr, "")
            If serialData <> "" Then
                Database.SaveData(serialData)
            End If
        End If

        If isDatabaseOn Then
            Dim data = Database.GetData()
            GridViewTable.DataSource = data
            For Each column As DataGridViewColumn In GridViewTable.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            Dim fullData = Database.GetFullData()
            GridViewTableFull.DataSource = fullData
            For Each column As DataGridViewColumn In GridViewTableFull.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            ChartData.Series(0).Points.Clear()
            For Each row As DataRow In data.Rows
                ChartData.Series(0).Points.AddXY(row("Line"), row("Total"))
            Next
        End If
    End Sub

    ' Exporta los datos de la base de datos a un archivo CSV (Excel) escribiendo cada fila en el archivo
    Private Sub ButtonExport_Click(sender As Object, e As EventArgs) Handles ButtonExport.Click
        Dim data = Database.GetData()
        Dim file As New SaveFileDialog
        file.Filter = "Archivo CSV|*.csv"
        file.Title = "Exportar datos"
        file.ShowDialog()
        If file.FileName <> "" Then
            Dim writer As New IO.StreamWriter(file.FileName)
            writer.WriteLine("id,data,date")
            For Each row As DataRow In data.Rows
                writer.WriteLine(row("Line") & "," & row("Total"))
            Next
            writer.Close()
        End If
    End Sub

    Private Sub ButtonExportFull_Click(sender As Object, e As EventArgs) Handles ButtonExportFull.Click
        Dim data = Database.GetFullData()
        Dim file As New SaveFileDialog
        file.Filter = "Archivo CSV|*.csv"
        file.Title = "Exportar datos"
        file.ShowDialog()
        If file.FileName <> "" Then
            Dim writer As New IO.StreamWriter(file.FileName)
            writer.WriteLine("id,data,date")
            For Each row As DataRow In data.Rows
                writer.WriteLine(row("id") & "," & row("data") & "," & row("date"))
            Next
            writer.Close()
        End If
    End Sub
End Class
