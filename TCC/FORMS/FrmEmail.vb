Imports System
Imports System.Net
Imports System.Net.Mail
Public Class FrmEmail
    Dim cliente As New SmtpClient
    Dim objcontrole As New ClsControle

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Try
            Dim emailorigem As New MailAddress("Equipe05@live.com".Trim.ToString)
            Dim emaildestino As New MailAddress(txtPara.Text.Trim.ToString)
            Dim mensagem As New MailMessage
            mensagem.To.Add(emaildestino)
            mensagem.From = emailorigem
            mensagem.Subject = txtAssunto.Text.Trim.ToString
            mensagem.Body = txtMensagem.Text.Trim.ToString
            mensagem.IsBodyHtml = True
            cliente.Host = "smtp.live.com".Trim.ToString
            cliente.Port = 587
            Dim creds As New System.Net.NetworkCredential
            creds.UserName = "Equipe05".Trim.ToString
            creds.Password = "aggl2013".Trim.ToString
            cliente.EnableSsl = True
            cliente.Credentials = creds
            cliente.Send(mensagem)
            MsgBox("Email enviado com sucesso")
            objcontrole.Limpar_tela(Me)
            Me.Close()
        Catch ex As Exception
            MsgBox("Não foi possível enviar o email.Mais detalhes:" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Erro ao enviar")

        End Try
    End Sub
End Class