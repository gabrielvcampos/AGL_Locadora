
Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnEntrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Autentica()
    End Sub

    Private Sub txtSenha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call Autentica()
        End If
    End Sub
    Public Sub Autentica()
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand
        Dim strResultado(3) As String
        Dim mr As SqlDataReader
        Dim usuario, senha As String

        usuario = txtUsuario.Text
        senha = txtSenha.Text

        Try
            cn = New SqlConnection("Server=ZAPW10093\SQLEXPRESS;Database=DB_Locadora;Trusted_Connection=True;")
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                '.CommandText = "select * from Login where cod_func='" & txtusuario.Text & "' and senha ='" & TXTSENHA.Text & "'"

                If txtUsuario.Text = Nothing Or txtSenha.Text = Nothing Then
                    MessageBox.Show("Login ou senha inválido(a). Tente novamente", "Erro de login!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'txtSenha.Text = ""
                    txtSenha.Clear()
                    Exit Sub
                Else
                    .CommandText = "select * from login where cod_func='" & txtUsuario.Text & "'"
                End If
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader   ' somente leitura
            mr.Read()
            strResultado(1) = mr!cod_func
            strResultado(2) = mr!senha_func
            strResultado(3) = CStr(mr!tipo_login)

            If strResultado(1) = CInt(usuario) And strResultado(2) = senha Then
                If strResultado(3) = "1" Then
                 
                    frmIndex.MenuStrip1.Enabled = True
                    frmIndex.MenuToolStripMenuItem.Enabled = True
                    frmIndex.ContasToolStripMenuItem.Enabled = True
                    frmIndex.AjudaToolStripMenuItem.Enabled = True
                    frmIndex.EmailToolStripMenuItem.Enabled = True
                    For Each controle As Control In frmIndex.Controls
                        If TypeOf controle Is Button Then
                            controle.Enabled = True
                        End If

                    Next
                    frmIndex.Show()
                    Me.Close()

                ElseIf strResultado(3) = "2" Then
                    frmIndex.MenuToolStripMenuItem.Enabled = True
                    frmIndex.ContasToolStripMenuItem.Enabled = False
                    frmIndex.AjudaToolStripMenuItem.Enabled = True
                    frmIndex.EmailToolStripMenuItem.Enabled = True
                    frmIndex.Button1.Enabled = True
                    frmIndex.Button4.Enabled = True
                    frmIndex.Button5.Enabled = True
                    frmIndex.btnCarro.Enabled = True
                    frmIndex.Show()
                    Me.Close()
                End If
                CodUsuario = strResultado(1)
            Else
                MessageBox.Show("Login ou senha inválido(a). Tente novamente", "Erro de login!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtSenha.Clear()
            End If
        Catch ex As SqlClient.SqlException
            Throw ex
        Finally
            cmd.Dispose()
        End Try
    End Sub

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call Autentica()
        End If

    End Sub


    Private Sub btnSair_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutentica.Click
        Call Autentica()
    End Sub

    Private Sub txtSenha_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Autentica()
        End If
    End Sub

    Private Sub btnSair_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub


End Class