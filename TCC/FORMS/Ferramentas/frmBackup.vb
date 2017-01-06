Public Class frmBackup
    Dim objcontrole As New clnValidaControles
    Dim cn As New conexaosql
    Dim comandoexecutado As String
    Dim cnn As String = ("Server=ZAPW10093\SQLEXPRESS;Database=DB_Locadora;Trusted_Connection=True;")

    Private Sub frmBackup_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frmBackup_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If objcontrole.ValidaSeUsuarioTemAcesso() = True Then
            Me.Close()
        Else
            Call ExibeBanco()
        End If
        lbhold.Text = ""
    End Sub
    Public Sub ExibeBanco()
        Dim conexaoSQLServer As String = ("server=.;uid=sa;pwd=123456")
        'Dim conexaoSQLServer As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Master"
        Dim databases() As String = cn.ObtemBancoDeDadosSQLSever(conexaoSQLServer)
        Dim listaDB As String

        For Each listaDB In databases
            lstBDSQLServer.Items.Add(listaDB)
        Next
        lstBDSQLServer.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If lstBDSQLServer.SelectedIndex <> 0 Then
            MessageBox.Show("Selecione a base de dados!", "Base de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim conexaoSQLServer As String = ("server=.;uid=sa;pwd=123456")
        ' Dim conexaoSQLServer As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Master"
        Call DefineComando("BACKUP")
        Try
            cn.BackupDatabase(conexaoSQLServer, lstBDSQLServer.SelectedItem, "d:\DBTESTE.bak")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If lstBDSQLServer.SelectedIndex <> 0 Then
            MessageBox.Show("Selecione a base de dados!", "Base de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Dim conexaoSQLServer As String = ("server=.;uid=sa;pwd=123456")
        Dim conexaoSQLServer As String = "Data Source=(local);Initial Catalog=master;Persist Security Info=True;User ID=sa; Password=123456"
        Call DefineComando("RESTORE")
        Try
            cn.RestauraDatabase(conexaoSQLServer, lstBDSQLServer.SelectedItem, "d:\DBTESTE.bak")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Me.ProgressBar1.Increment(12)
      
        If ProgressBar1.Value = 100 Then

            RichTextBox1.Text = " O " & comandoexecutado & " DA BASE " & lstBDSQLServer.SelectedItem & " FOI CONCLUIDO!"
            RichTextBox1.Text.ToUpper()
            RichTextBox1.BackColor = Color.OliveDrab
            lbhold.Text = ""
            Timer1.Stop()
        End If
    End Sub
    Function DefineComando(ByVal comando As String)
        If comando = "RESTORE" Then
            comandoexecutado = "RESTORE"
        ElseIf comando = "BACKUP" Then
            comandoexecutado = "BACKUP"
        End If
        Return comandoexecutado
    End Function

    Private Sub lstBDSQLServer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lstBDSQLServer.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
        If e.KeyCode = Keys.F1 Then
            If lstBDSQLServer.SelectedIndex <> 0 Then
                MessageBox.Show("Selecione a base de dados!", "Base de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim conexaoSQLServer As String = ("server=.;uid=sa;pwd=123456")
            ' Dim conexaoSQLServer As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Master"
            Call DefineComando("BACKUP")
            Try
                cn.BackupDatabase(conexaoSQLServer, lstBDSQLServer.SelectedItem, "d:\DBTESTE.bak")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            lbhold.Text = "AGUARDE..."
        End If
        If e.KeyCode = Keys.F2 Then
            If lstBDSQLServer.SelectedIndex <> 0 Then
                MessageBox.Show("Selecione a base de dados!", "Base de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            'Dim conexaoSQLServer As String = ("server=.;uid=sa;pwd=123456")
            Dim conexaoSQLServer As String = "Server=ZAPW10093\SQLEXPRESS;Database=DB_Locadora;Trusted_Connection=True;"
            Call DefineComando("RESTORE")
            Try
                cn.RestauraDatabase(conexaoSQLServer, lstBDSQLServer.SelectedItem, "d:\DBTESTE.bak")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            lbhold.Text = "AGUARDE..."
        End If
    End Sub
End Class