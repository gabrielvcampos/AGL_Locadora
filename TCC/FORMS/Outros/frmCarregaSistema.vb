Public Class frmCarregaSistema
   
    Private Sub Timer_Splash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Splash.Tick
        pgb_Splash.Increment(2)

       
        If pgb_Splash.Value = 10 Then
            lbl_Carregando.Text = "Carregando o banco de dados do sistema."
        End If
        If pgb_Splash.Value = 20 Then
            lbl_Carregando.Text = "Carregando o banco de dados do sistema.."
        End If
        If pgb_Splash.Value = 35 Then
            lbl_Carregando.Text = "Carregando o banco de dados do sistema..."
        End If
        If pgb_Splash.Value = 45 Then
            lbl_Carregando.Text = "Carregando o banco de dados do sistema..."
        End If
        If pgb_Splash.Value = 50 Then
            lbl_Carregando.Text = "Carregando configurações de proprietário."
        End If
        If pgb_Splash.Value = 45 Then
            lbl_Carregando.Text = "Carregando configurações de proprietário.."
        End If
        If pgb_Splash.Value = 50 Then
            lbl_Carregando.Text = "Carregando configurações de proprietário..."
        End If
        If pgb_Splash.Value = 55 Then
            lbl_Carregando.Text = "Carregando informações de usuário do sistema."
        End If
        If pgb_Splash.Value = 60 Then
            lbl_Carregando.Text = "Carregando informações de usuário do sistema.."
        End If
        If pgb_Splash.Value = 65 Then
            lbl_Carregando.Text = "Carregando informações de usuário do sistema..."
        End If
        If pgb_Splash.Value = 70 Then
            lbl_Carregando.Text = "Carregando configurações Layout do sistema."
        End If
        If pgb_Splash.Value = 80 Then
            lbl_Carregando.Text = "Carregando configurações de Layout do sistema.."
        End If
        If pgb_Splash.Value = 95 Then
            lbl_Carregando.Text = "Carregando configurações Layout do sistema..."
        End If
        If pgb_Splash.Value = 100 Then
            frmLogin.Show()
            Timer_Splash.Stop()
            Me.Hide()
        End If
       
    End Sub

    Private Sub frmCarregaSistema_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer_Splash.Start()

    End Sub
End Class