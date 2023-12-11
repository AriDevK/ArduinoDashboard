<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.GridViewTable = New System.Windows.Forms.DataGridView()
        Me.ChartData = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ButtonExport = New System.Windows.Forms.Button()
        Me.ClockReload = New System.Windows.Forms.Timer(Me.components)
        Me.GridViewTableFull = New System.Windows.Forms.DataGridView()
        Me.ButtonExportFull = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonTestDatabase = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboSerialPorts = New System.Windows.Forms.ComboBox()
        Me.ButtonTestSerial = New System.Windows.Forms.Button()
        Me.TextBoxDatabase = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GridViewTable,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ChartData,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridViewTableFull,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel2.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.Panel4.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.SuspendLayout
        '
        'GridViewTable
        '
        Me.GridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridViewTable.Location = New System.Drawing.Point(0, 0)
        Me.GridViewTable.Name = "GridViewTable"
        Me.GridViewTable.Size = New System.Drawing.Size(331, 183)
        Me.GridViewTable.TabIndex = 1
        '
        'ChartData
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartData.ChartAreas.Add(ChartArea2)
        Me.ChartData.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.ChartData.Legends.Add(Legend2)
        Me.ChartData.Location = New System.Drawing.Point(13, 128)
        Me.ChartData.Name = "ChartData"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.ChartData.Series.Add(Series2)
        Me.ChartData.Size = New System.Drawing.Size(649, 341)
        Me.ChartData.TabIndex = 2
        Me.ChartData.Text = "Chart1"
        '
        'ButtonExport
        '
        Me.ButtonExport.BackColor = System.Drawing.Color.SeaGreen
        Me.ButtonExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonExport.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonExport.ForeColor = System.Drawing.Color.White
        Me.ButtonExport.Location = New System.Drawing.Point(0, 183)
        Me.ButtonExport.Name = "ButtonExport"
        Me.ButtonExport.Size = New System.Drawing.Size(331, 32)
        Me.ButtonExport.TabIndex = 6
        Me.ButtonExport.Text = "Exportar a excel"
        Me.ButtonExport.UseVisualStyleBackColor = false
        '
        'ClockReload
        '
        Me.ClockReload.Enabled = true
        Me.ClockReload.Interval = 200
        '
        'GridViewTableFull
        '
        Me.GridViewTableFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewTableFull.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridViewTableFull.Location = New System.Drawing.Point(0, 0)
        Me.GridViewTableFull.Name = "GridViewTableFull"
        Me.GridViewTableFull.Size = New System.Drawing.Size(332, 215)
        Me.GridViewTableFull.TabIndex = 7
        '
        'ButtonExportFull
        '
        Me.ButtonExportFull.BackColor = System.Drawing.Color.SeaGreen
        Me.ButtonExportFull.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonExportFull.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonExportFull.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonExportFull.ForeColor = System.Drawing.Color.White
        Me.ButtonExportFull.Location = New System.Drawing.Point(0, 183)
        Me.ButtonExportFull.Name = "ButtonExportFull"
        Me.ButtonExportFull.Size = New System.Drawing.Size(332, 32)
        Me.ButtonExportFull.TabIndex = 8
        Me.ButtonExportFull.Text = "Exportar a excel"
        Me.ButtonExportFull.UseVisualStyleBackColor = false
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(675, 783)
        Me.Panel2.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 562)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(675, 221)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GridViewTable)
        Me.Panel3.Controls.Add(Me.ButtonExport)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(331, 215)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ButtonExportFull)
        Me.Panel4.Controls.Add(Me.GridViewTableFull)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(340, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(332, 215)
        Me.Panel4.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(78, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(274, 46)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Dashboard de ...."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoArduino.My.Resources.Resources.dashboard
        Me.PictureBox1.Location = New System.Drawing.Point(11, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = false
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 80)
        Me.Panel1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxDatabase)
        Me.GroupBox1.Controls.Add(Me.ButtonTestSerial)
        Me.GroupBox1.Controls.Add(Me.ComboSerialPorts)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ButtonTestDatabase)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Configuración"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(13, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base de datos:"
        '
        'ButtonTestDatabase
        '
        Me.ButtonTestDatabase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTestDatabase.Location = New System.Drawing.Point(177, 48)
        Me.ButtonTestDatabase.Name = "ButtonTestDatabase"
        Me.ButtonTestDatabase.Size = New System.Drawing.Size(132, 23)
        Me.ButtonTestDatabase.TabIndex = 2
        Me.ButtonTestDatabase.Text = "Probar conexión"
        Me.ButtonTestDatabase.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(344, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Puerto serial:"
        '
        'ComboSerialPorts
        '
        Me.ComboSerialPorts.FormattingEnabled = true
        Me.ComboSerialPorts.Location = New System.Drawing.Point(347, 50)
        Me.ComboSerialPorts.Name = "ComboSerialPorts"
        Me.ComboSerialPorts.Size = New System.Drawing.Size(155, 21)
        Me.ComboSerialPorts.TabIndex = 4
        '
        'ButtonTestSerial
        '
        Me.ButtonTestSerial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTestSerial.Location = New System.Drawing.Point(508, 50)
        Me.ButtonTestSerial.Name = "ButtonTestSerial"
        Me.ButtonTestSerial.Size = New System.Drawing.Size(132, 23)
        Me.ButtonTestSerial.TabIndex = 5
        Me.ButtonTestSerial.Text = "Probar serial"
        Me.ButtonTestSerial.UseVisualStyleBackColor = true
        '
        'TextBoxDatabase
        '
        Me.TextBoxDatabase.Location = New System.Drawing.Point(16, 48)
        Me.TextBoxDatabase.Name = "TextBoxDatabase"
        Me.TextBoxDatabase.ReadOnly = true
        Me.TextBoxDatabase.Size = New System.Drawing.Size(155, 20)
        Me.TextBoxDatabase.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.Controls.Add(Me.ChartData, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 80)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.89178!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.10822!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(675, 482)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 783)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Dashboard [Pantalla Principal]"
        CType(Me.GridViewTable,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ChartData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridViewTableFull,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel2.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel4.ResumeLayout(false)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GridViewTable As DataGridView
    Friend WithEvents ChartData As DataVisualization.Charting.Chart
    Friend WithEvents ButtonExport As Button
    Friend WithEvents ClockReload As Timer
    Friend WithEvents GridViewTableFull As DataGridView
    Friend WithEvents ButtonExportFull As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxDatabase As TextBox
    Friend WithEvents ButtonTestSerial As Button
    Friend WithEvents ComboSerialPorts As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonTestDatabase As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
