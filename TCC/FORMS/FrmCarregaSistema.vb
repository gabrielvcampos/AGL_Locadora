Public Class FrmCarregaSistema

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Increment(2)
        If Timer1.Value = 1 Then
            lbl_Carregando.Text = "Carregando Sistema"
        End If
        If Timer1.Value = 20 Then
            lbl_Carregando.Text = "Carregando o banco de dados"
        End If
        If Timer1.Value = 40 Then
            lbl_Carregando.Text = "Carregando padrões do windows"
        End If
        If Timer1.Value = 60 Then
            lbl_Carregando.Text = "Carregando configurações de proprietario"
        End If
        If Timer1.Value = 80 Then
            lbl_Carregando.Text = "Carregando informações de usuário"
        End If
        If Timer1.Value = 100 Then
            lbl_Carregando.Text = "Carregando Layout do sistema"
        End If
        If Timer1.Value = 120 Then
            frmLogin.Show()
            Me.Close()
        End If
    End Sub
End Class