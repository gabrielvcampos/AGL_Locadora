Imports System
Imports System.Net
Imports System.Net.Mail
Public Class FrmEnviaEmail

    Dim objcontrole As New ClsComando

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Try
            Dim cliente As New SmtpClient
            Dim emailorigem As New MailAddress("equipe05@live.com".Trim.ToString)
            Dim emaildestino As New MailAddress(txtPara.Text.Trim.ToString)
            Dim mensagem As New MailMessage
            Dim creds As New System.Net.NetworkCredential
            'Configura host smtp para envio de e-mail
            cliente.Host = "smtp.live.com".Trim.ToString
            cliente.Port = 25
            'Atribui credenciais para envio do e-mail no host 
            mensagem.From = emailorigem
            creds.UserName = "equipe05@live.com".Trim.ToString
            creds.Password = "aggl2013".Trim.ToString
            cliente.EnableSsl = True
            cliente.Credentials = creds
            'Monta e-mail
            mensagem.To.Add(emaildestino)
            mensagem.Subject = txtAssunto.Text.Trim.ToString
            mensagem.Body = txtMensagem.Text.Trim.ToString
            mensagem.IsBodyHtml = True
           
            cliente.Send(mensagem)
            MsgBox("Email enviado com sucesso")
            objcontrole.Limpar_tela(Me)
            Me.Close()
        Catch ex As Exception
            MsgBox("Não foi possível enviar o email.Mais detalhes:" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Erro ao enviar")

        End Try
    End Sub

    Private Sub btnFechar_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class