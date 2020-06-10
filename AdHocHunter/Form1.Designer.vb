<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lstLog = New System.Windows.Forms.ListBox()
        Me.btnCrearRed = New System.Windows.Forms.Button()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSsid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBorrar)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.lstLog)
        Me.GroupBox1.Controls.Add(Me.btnCrearRed)
        Me.GroupBox1.Controls.Add(Me.txtKey)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSsid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 309)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(300, 52)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(94, 38)
        Me.btnBorrar.TabIndex = 10
        Me.btnBorrar.Text = "Borrar Red"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(48, 91)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(151, 13)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Mostrar datos de la red AdHoc"
        '
        'lstLog
        '
        Me.lstLog.BackColor = System.Drawing.Color.Black
        Me.lstLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLog.ForeColor = System.Drawing.Color.Yellow
        Me.lstLog.FormattingEnabled = True
        Me.lstLog.ItemHeight = 15
        Me.lstLog.Location = New System.Drawing.Point(19, 112)
        Me.lstLog.Name = "lstLog"
        Me.lstLog.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstLog.Size = New System.Drawing.Size(429, 184)
        Me.lstLog.TabIndex = 8
        '
        'btnCrearRed
        '
        Me.btnCrearRed.Location = New System.Drawing.Point(200, 52)
        Me.btnCrearRed.Name = "btnCrearRed"
        Me.btnCrearRed.Size = New System.Drawing.Size(94, 38)
        Me.btnCrearRed.TabIndex = 6
        Me.btnCrearRed.Text = "Crear Red"
        Me.btnCrearRed.UseVisualStyleBackColor = True
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(54, 62)
        Me.txtKey.MaxLength = 63
        Me.txtKey.Name = "txtKey"
        Me.txtKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtKey.Size = New System.Drawing.Size(140, 20)
        Me.txtKey.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "KEY:"
        '
        'txtSsid
        '
        Me.txtSsid.Location = New System.Drawing.Point(54, 26)
        Me.txtSsid.Name = "txtSsid"
        Me.txtSsid.Size = New System.Drawing.Size(394, 20)
        Me.txtSsid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SSID:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 321)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                               .:: Red AdHoc - Hunter ::."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSsid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCrearRed As System.Windows.Forms.Button
    Friend WithEvents lstLog As System.Windows.Forms.ListBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnBorrar As System.Windows.Forms.Button

End Class
