Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lstLog.Items.Add("¡Programa iniciado correctamente!")
    End Sub

    Sub crearRed()
        Try
            Dim comando As String = ""
            comando = "netsh wlan set hostednetwork mode=allow ssid=" & Me.txtSsid.Text & " key=" & Me.txtKey.Text
            Shell("cmd.exe /c" & comando) 'Se ejecuta el comando
            Me.lstLog.Items.Add("Se creo la red correctamente...")
        Catch ex As Exception
            Me.lstLog.Items.Add("Error: " & ex.Message)
        End Try

    End Sub

    Sub iniciarRed()
        Try
            Dim comando As String = ""
            comando = "netsh wlan start hostednetwork"
            Shell("cmd.exe /c" & comando)
            Me.lstLog.Items.Add("Se inicio la red correctamente...")
        Catch ex As Exception
            Me.lstLog.Items.Add("Error: " & ex.Message)
        End Try
    End Sub
    Sub borrarRed()
        Try
            Dim comando As String = ""
            comando = "netsh wlan stop hostednetwork"
            Shell("cmd /c" & comando)
            Me.lstLog.Items.Add("Red AdHoc apagada")
        Catch ex As Exception
            Me.lstLog.Items.Add("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnCrearRed_Click(sender As Object, e As EventArgs) Handles btnCrearRed.Click
        If Me.txtKey.TextLength >= 8 And Me.txtSsid.Text <> "" Then
            crearRed()
            iniciarRed()
            MsgBox("¡Red Creada correctamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red AdHoc - Hunter")
        Else
            MsgBox("La Contraseña debe de ser mínimo de 8 a 63 caracteres", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Red AdHoc - Hunter")
            Me.lstLog.Items.Add("La Contraseña debe de ser mínimo de 8 a 63 caracteres...")
            Me.lstLog.Items.Add("Cambie la contraseña")
            Me.txtKey.Focus()
        End If

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        borrarRed()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class
