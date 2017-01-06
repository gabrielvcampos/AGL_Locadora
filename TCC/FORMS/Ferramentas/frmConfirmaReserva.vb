Public Class frmConfirmaReserva

    Private Sub btnReserva_Click(sender As System.Object, e As System.EventArgs) Handles btnReserva.Click
        FrmEnviaEmail.Show()
        FrmEnviaEmail.txtPara.Text = Me.txtEmail.Text
        FrmEnviaEmail.txtAssunto.Text = "ID: " & IDReserva & " - Confirmação de reserva de veículo"

    End Sub
End Class