Public Class frmObsAluguel

    Private Sub frmObsAluguel_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmObsAluguel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtobscarro.Focus()
        txtobscarro.Text = ObsCarro
    End Sub

    Private Sub txtobscarro_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtobscarro.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtobscarro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtobscarro.TextChanged

    End Sub
End Class